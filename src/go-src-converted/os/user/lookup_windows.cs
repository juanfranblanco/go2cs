// Copyright 2012 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package user -- go2cs converted at 2020 October 09 05:07:38 UTC
// import "os/user" ==> using user = go.os.user_package
// Original source: C:\Go\src\os\user\lookup_windows.go
using fmt = go.fmt_package;
using windows = go.@internal.syscall.windows_package;
using registry = go.@internal.syscall.windows.registry_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go {
namespace os
{
    public static partial class user_package
    {
        private static (bool, error) isDomainJoined()
        {
            bool _p0 = default;
            error _p0 = default!;

            ptr<ushort> domain;
            ref uint status = ref heap(out ptr<uint> _addr_status);
            var err = syscall.NetGetJoinInformation(null, _addr_domain, _addr_status);
            if (err != null)
            {
                return (false, error.As(err)!);
            }
            syscall.NetApiBufferFree((byte.val)(@unsafe.Pointer(domain)));
            return (status == syscall.NetSetupDomainName, error.As(null!)!);

        }

        private static (@string, error) lookupFullNameDomain(@string domainAndUser)
        {
            @string _p0 = default;
            error _p0 = default!;

            return syscall.TranslateAccountName(domainAndUser, syscall.NameSamCompatible, syscall.NameDisplay, 50L);
        }

        private static (@string, error) lookupFullNameServer(@string servername, @string username) => func((defer, _, __) =>
        {
            @string _p0 = default;
            error _p0 = default!;

            var (s, e) = syscall.UTF16PtrFromString(servername);
            if (e != null)
            {
                return ("", error.As(e)!);
            }

            var (u, e) = syscall.UTF16PtrFromString(username);
            if (e != null)
            {
                return ("", error.As(e)!);
            }

            ptr<byte> p;
            e = syscall.NetUserGetInfo(s, u, 10L, _addr_p);
            if (e != null)
            {
                return ("", error.As(e)!);
            }

            defer(syscall.NetApiBufferFree(p));
            var i = (syscall.UserInfo10.val)(@unsafe.Pointer(p));
            return (windows.UTF16PtrToString(i.FullName), error.As(null!)!);

        });

        private static (@string, error) lookupFullName(@string domain, @string username, @string domainAndUser)
        {
            @string _p0 = default;
            error _p0 = default!;

            var (joined, err) = isDomainJoined();
            if (err == null && joined)
            {
                var (name, err) = lookupFullNameDomain(domainAndUser);
                if (err == null)
                {
                    return (name, error.As(null!)!);
                }

            }

            (name, err) = lookupFullNameServer(domain, username);
            if (err == null)
            {
                return (name, error.As(null!)!);
            } 
            // domain worked neither as a domain nor as a server
            // could be domain server unavailable
            // pretend username is fullname
            return (username, error.As(null!)!);

        }

        // getProfilesDirectory retrieves the path to the root directory
        // where user profiles are stored.
        private static (@string, error) getProfilesDirectory()
        {
            @string _p0 = default;
            error _p0 = default!;

            ref var n = ref heap(uint32(100L), out ptr<var> _addr_n);
            while (true)
            {
                var b = make_slice<ushort>(n);
                var e = windows.GetProfilesDirectory(_addr_b[0L], _addr_n);
                if (e == null)
                {
                    return (syscall.UTF16ToString(b), error.As(null!)!);
                }

                if (e != syscall.ERROR_INSUFFICIENT_BUFFER)
                {
                    return ("", error.As(e)!);
                }

                if (n <= uint32(len(b)))
                {
                    return ("", error.As(e)!);
                }

            }


        }

        // lookupUsernameAndDomain obtains the username and domain for usid.
        private static (@string, @string, error) lookupUsernameAndDomain(ptr<syscall.SID> _addr_usid)
        {
            @string username = default;
            @string domain = default;
            error e = default!;
            ref syscall.SID usid = ref _addr_usid.val;

            var (username, domain, t, e) = usid.LookupAccount("");
            if (e != null)
            {
                return ("", "", error.As(e)!);
            }

            if (t != syscall.SidTypeUser)
            {
                return ("", "", error.As(fmt.Errorf("user: should be user account type, not %d", t))!);
            }

            return (username, domain, error.As(null!)!);

        }

        // findHomeDirInRegistry finds the user home path based on the uid.
        private static (@string, error) findHomeDirInRegistry(@string uid) => func((defer, _, __) =>
        {
            @string dir = default;
            error e = default!;

            var (k, e) = registry.OpenKey(registry.LOCAL_MACHINE, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\ProfileList\\" + uid, registry.QUERY_VALUE);
            if (e != null)
            {
                return ("", error.As(e)!);
            }

            defer(k.Close());
            dir, _, e = k.GetStringValue("ProfileImagePath");
            if (e != null)
            {
                return ("", error.As(e)!);
            }

            return (dir, error.As(null!)!);

        });

        // lookupGroupName accepts the name of a group and retrieves the group SID.
        private static (@string, error) lookupGroupName(@string groupname)
        {
            @string _p0 = default;
            error _p0 = default!;

            var (sid, _, t, e) = syscall.LookupSID("", groupname);
            if (e != null)
            {
                return ("", error.As(e)!);
            } 
            // https://msdn.microsoft.com/en-us/library/cc245478.aspx#gt_0387e636-5654-4910-9519-1f8326cf5ec0
            // SidTypeAlias should also be treated as a group type next to SidTypeGroup
            // and SidTypeWellKnownGroup:
            // "alias object -> resource group: A group object..."
            //
            // Tests show that "Administrators" can be considered of type SidTypeAlias.
            if (t != syscall.SidTypeGroup && t != syscall.SidTypeWellKnownGroup && t != syscall.SidTypeAlias)
            {
                return ("", error.As(fmt.Errorf("lookupGroupName: should be group account type, not %d", t))!);
            }

            return sid.String();

        }

        // listGroupsForUsernameAndDomain accepts username and domain and retrieves
        // a SID list of the local groups where this user is a member.
        private static (slice<@string>, error) listGroupsForUsernameAndDomain(@string username, @string domain) => func((defer, _, __) =>
        {
            slice<@string> _p0 = default;
            error _p0 = default!;
 
            // Check if both the domain name and user should be used.
            @string query = default;
            var (joined, err) = isDomainJoined();
            if (err == null && joined && len(domain) != 0L)
            {
                query = domain + "\\" + username;
            }
            else
            {
                query = username;
            }

            var (q, err) = syscall.UTF16PtrFromString(query);
            if (err != null)
            {
                return (null, error.As(err)!);
            }

            ptr<byte> p0;
            ref uint entriesRead = ref heap(out ptr<uint> _addr_entriesRead);            ref uint totalEntries = ref heap(out ptr<uint> _addr_totalEntries); 
            // https://msdn.microsoft.com/en-us/library/windows/desktop/aa370655(v=vs.85).aspx
            // NetUserGetLocalGroups() would return a list of LocalGroupUserInfo0
            // elements which hold the names of local groups where the user participates.
            // The list does not follow any sorting order.
            //
            // If no groups can be found for this user, NetUserGetLocalGroups() should
            // always return the SID of a single group called "None", which
            // also happens to be the primary group for the local user.
 
            // https://msdn.microsoft.com/en-us/library/windows/desktop/aa370655(v=vs.85).aspx
            // NetUserGetLocalGroups() would return a list of LocalGroupUserInfo0
            // elements which hold the names of local groups where the user participates.
            // The list does not follow any sorting order.
            //
            // If no groups can be found for this user, NetUserGetLocalGroups() should
            // always return the SID of a single group called "None", which
            // also happens to be the primary group for the local user.
            err = windows.NetUserGetLocalGroups(null, q, 0L, windows.LG_INCLUDE_INDIRECT, _addr_p0, windows.MAX_PREFERRED_LENGTH, _addr_entriesRead, _addr_totalEntries);
            if (err != null)
            {
                return (null, error.As(err)!);
            }

            defer(syscall.NetApiBufferFree(p0));
            if (entriesRead == 0L)
            {
                return (null, error.As(fmt.Errorf("listGroupsForUsernameAndDomain: NetUserGetLocalGroups() returned an empty list for domain: %s, username: %s", domain, username))!);
            }

            ptr<array<windows.LocalGroupUserInfo0>> entries = new ptr<ptr<array<windows.LocalGroupUserInfo0>>>(@unsafe.Pointer(p0)).slice(-1, entriesRead, entriesRead);
            slice<@string> sids = default;
            foreach (var (_, entry) in entries)
            {
                if (entry.Name == null)
                {
                    continue;
                }

                var (sid, err) = lookupGroupName(windows.UTF16PtrToString(entry.Name));
                if (err != null)
                {
                    return (null, error.As(err)!);
                }

                sids = append(sids, sid);

            }
            return (sids, error.As(null!)!);

        });

        private static (ptr<User>, error) newUser(@string uid, @string gid, @string dir, @string username, @string domain)
        {
            ptr<User> _p0 = default!;
            error _p0 = default!;

            var domainAndUser = domain + "\\" + username;
            var (name, e) = lookupFullName(domain, username, domainAndUser);
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            }

            ptr<User> u = addr(new User(Uid:uid,Gid:gid,Username:domainAndUser,Name:name,HomeDir:dir,));
            return (_addr_u!, error.As(null!)!);

        }

        private static (ptr<User>, error) current() => func((defer, _, __) =>
        {
            ptr<User> _p0 = default!;
            error _p0 = default!;

            var (t, e) = syscall.OpenCurrentProcessToken();
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            }

            defer(t.Close());
            var (u, e) = t.GetTokenUser();
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            }

            var (pg, e) = t.GetTokenPrimaryGroup();
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            }

            var (uid, e) = u.User.Sid.String();
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            }

            var (gid, e) = pg.PrimaryGroup.String();
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            }

            var (dir, e) = t.GetUserProfileDirectory();
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            }

            var (username, domain, e) = lookupUsernameAndDomain(_addr_u.User.Sid);
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            }

            return _addr_newUser(uid, gid, dir, username, domain)!;

        });

        // lookupUserPrimaryGroup obtains the primary group SID for a user using this method:
        // https://support.microsoft.com/en-us/help/297951/how-to-use-the-primarygroupid-attribute-to-find-the-primary-group-for
        // The method follows this formula: domainRID + "-" + primaryGroupRID
        private static (@string, error) lookupUserPrimaryGroup(@string username, @string domain) => func((defer, _, __) =>
        {
            @string _p0 = default;
            error _p0 = default!;
 
            // get the domain RID
            var (sid, _, t, e) = syscall.LookupSID("", domain);
            if (e != null)
            {
                return ("", error.As(e)!);
            }

            if (t != syscall.SidTypeDomain)
            {
                return ("", error.As(fmt.Errorf("lookupUserPrimaryGroup: should be domain account type, not %d", t))!);
            }

            var (domainRID, e) = sid.String();
            if (e != null)
            {
                return ("", error.As(e)!);
            } 
            // If the user has joined a domain use the RID of the default primary group
            // called "Domain Users":
            // https://support.microsoft.com/en-us/help/243330/well-known-security-identifiers-in-windows-operating-systems
            // SID: S-1-5-21domain-513
            //
            // The correct way to obtain the primary group of a domain user is
            // probing the user primaryGroupID attribute in the server Active Directory:
            // https://msdn.microsoft.com/en-us/library/ms679375(v=vs.85).aspx
            //
            // Note that the primary group of domain users should not be modified
            // on Windows for performance reasons, even if it's possible to do that.
            // The .NET Developer's Guide to Directory Services Programming - Page 409
            // https://books.google.bg/books?id=kGApqjobEfsC&lpg=PA410&ots=p7oo-eOQL7&dq=primary%20group%20RID&hl=bg&pg=PA409#v=onepage&q&f=false
            var (joined, err) = isDomainJoined();
            if (err == null && joined)
            {
                return (domainRID + "-513", error.As(null!)!);
            } 
            // For non-domain users call NetUserGetInfo() with level 4, which
            // in this case would not have any network overhead.
            // The primary group should not change from RID 513 here either
            // but the group will be called "None" instead:
            // https://www.adampalmer.me/iodigitalsec/2013/08/10/windows-null-session-enumeration/
            // "Group 'None' (RID: 513)"
            var (u, e) = syscall.UTF16PtrFromString(username);
            if (e != null)
            {
                return ("", error.As(e)!);
            }

            var (d, e) = syscall.UTF16PtrFromString(domain);
            if (e != null)
            {
                return ("", error.As(e)!);
            }

            ptr<byte> p;
            e = syscall.NetUserGetInfo(d, u, 4L, _addr_p);
            if (e != null)
            {
                return ("", error.As(e)!);
            }

            defer(syscall.NetApiBufferFree(p));
            var i = (windows.UserInfo4.val)(@unsafe.Pointer(p));
            return (fmt.Sprintf("%s-%d", domainRID, i.PrimaryGroupID), error.As(null!)!);

        });

        private static (ptr<User>, error) newUserFromSid(ptr<syscall.SID> _addr_usid)
        {
            ptr<User> _p0 = default!;
            error _p0 = default!;
            ref syscall.SID usid = ref _addr_usid.val;

            var (username, domain, e) = lookupUsernameAndDomain(_addr_usid);
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            }

            var (gid, e) = lookupUserPrimaryGroup(username, domain);
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            }

            var (uid, e) = usid.String();
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            } 
            // If this user has logged in at least once their home path should be stored
            // in the registry under the specified SID. References:
            // https://social.technet.microsoft.com/wiki/contents/articles/13895.how-to-remove-a-corrupted-user-profile-from-the-registry.aspx
            // https://support.asperasoft.com/hc/en-us/articles/216127438-How-to-delete-Windows-user-profiles
            //
            // The registry is the most reliable way to find the home path as the user
            // might have decided to move it outside of the default location,
            // (e.g. C:\users). Reference:
            // https://answers.microsoft.com/en-us/windows/forum/windows_7-security/how-do-i-set-a-home-directory-outside-cusers-for-a/aed68262-1bf4-4a4d-93dc-7495193a440f
            var (dir, e) = findHomeDirInRegistry(uid);
            if (e != null)
            { 
                // If the home path does not exist in the registry, the user might
                // have not logged in yet; fall back to using getProfilesDirectory().
                // Find the username based on a SID and append that to the result of
                // getProfilesDirectory(). The domain is not relevant here.
                dir, e = getProfilesDirectory();
                if (e != null)
                {
                    return (_addr_null!, error.As(e)!);
                }

                dir += "\\" + username;

            }

            return _addr_newUser(uid, gid, dir, username, domain)!;

        }

        private static (ptr<User>, error) lookupUser(@string username)
        {
            ptr<User> _p0 = default!;
            error _p0 = default!;

            var (sid, _, t, e) = syscall.LookupSID("", username);
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            }

            if (t != syscall.SidTypeUser)
            {
                return (_addr_null!, error.As(fmt.Errorf("user: should be user account type, not %d", t))!);
            }

            return _addr_newUserFromSid(_addr_sid)!;

        }

        private static (ptr<User>, error) lookupUserId(@string uid)
        {
            ptr<User> _p0 = default!;
            error _p0 = default!;

            var (sid, e) = syscall.StringToSid(uid);
            if (e != null)
            {
                return (_addr_null!, error.As(e)!);
            }

            return _addr_newUserFromSid(_addr_sid)!;

        }

        private static (ptr<Group>, error) lookupGroup(@string groupname)
        {
            ptr<Group> _p0 = default!;
            error _p0 = default!;

            var (sid, err) = lookupGroupName(groupname);
            if (err != null)
            {
                return (_addr_null!, error.As(err)!);
            }

            return (addr(new Group(Name:groupname,Gid:sid)), error.As(null!)!);

        }

        private static (ptr<Group>, error) lookupGroupId(@string gid)
        {
            ptr<Group> _p0 = default!;
            error _p0 = default!;

            var (sid, err) = syscall.StringToSid(gid);
            if (err != null)
            {
                return (_addr_null!, error.As(err)!);
            }

            var (groupname, _, t, err) = sid.LookupAccount("");
            if (err != null)
            {
                return (_addr_null!, error.As(err)!);
            }

            if (t != syscall.SidTypeGroup && t != syscall.SidTypeWellKnownGroup && t != syscall.SidTypeAlias)
            {
                return (_addr_null!, error.As(fmt.Errorf("lookupGroupId: should be group account type, not %d", t))!);
            }

            return (addr(new Group(Name:groupname,Gid:gid)), error.As(null!)!);

        }

        private static (slice<@string>, error) listGroups(ptr<User> _addr_user)
        {
            slice<@string> _p0 = default;
            error _p0 = default!;
            ref User user = ref _addr_user.val;

            var (sid, err) = syscall.StringToSid(user.Uid);
            if (err != null)
            {
                return (null, error.As(err)!);
            }

            var (username, domain, err) = lookupUsernameAndDomain(_addr_sid);
            if (err != null)
            {
                return (null, error.As(err)!);
            }

            var (sids, err) = listGroupsForUsernameAndDomain(username, domain);
            if (err != null)
            {
                return (null, error.As(err)!);
            } 
            // Add the primary group of the user to the list if it is not already there.
            // This is done only to comply with the POSIX concept of a primary group.
            {
                var sid__prev1 = sid;

                foreach (var (_, __sid) in sids)
                {
                    sid = __sid;
                    if (sid == user.Gid)
                    {
                        return (sids, error.As(null!)!);
                    }

                }

                sid = sid__prev1;
            }

            return (append(sids, user.Gid), error.As(null!)!);

        }
    }
}}
