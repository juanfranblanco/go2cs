// Copyright 2016 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build darwin dragonfly freebsd netbsd openbsd

// Package route provides basic functions for the manipulation of
// packet routing facilities on BSD variants.
//
// The package supports any version of Darwin, any version of
// DragonFly BSD, FreeBSD 7 through 11, NetBSD 6 and above, and
// OpenBSD 5.6 and above.
// package route -- go2cs converted at 2020 August 29 10:12:34 UTC
// import "vendor/golang_org/x/net/route" ==> using route = go.vendor.golang_org.x.net.route_package
// Original source: C:\Go\src\vendor\golang_org\x\net\route\route.go
using errors = go.errors_package;
using os = go.os_package;
using syscall = go.syscall_package;
using static go.builtin;

namespace go {
namespace vendor {
namespace golang_org {
namespace x {
namespace net
{
    public static partial class route_package
    {
        private static var errUnsupportedMessage = errors.New("unsupported message");        private static var errMessageMismatch = errors.New("message mismatch");        private static var errMessageTooShort = errors.New("message too short");        private static var errInvalidMessage = errors.New("invalid message");        private static var errInvalidAddr = errors.New("invalid address");        private static var errShortBuffer = errors.New("short buffer");

        // A RouteMessage represents a message conveying an address prefix, a
        // nexthop address and an output interface.
        //
        // Unlike other messages, this message can be used to query adjacency
        // information for the given address prefix, to add a new route, and
        // to delete or modify the existing route from the routing information
        // base inside the kernel by writing and reading route messages on a
        // routing socket.
        //
        // For the manipulation of routing information, the route message must
        // contain appropriate fields that include:
        //
        //    Version       = <must be specified>
        //    Type          = <must be specified>
        //    Flags         = <must be specified>
        //    Index         = <must be specified if necessary>
        //    ID            = <must be specified>
        //    Seq           = <must be specified>
        //    Addrs         = <must be specified>
        //
        // The Type field specifies a type of manipulation, the Flags field
        // specifies a class of target information and the Addrs field
        // specifies target information like the following:
        //
        //    route.RouteMessage{
        //        Version: RTM_VERSION,
        //        Type: RTM_GET,
        //        Flags: RTF_UP | RTF_HOST,
        //        ID: uintptr(os.Getpid()),
        //        Seq: 1,
        //        Addrs: []route.Addrs{
        //            RTAX_DST: &route.Inet4Addr{ ... },
        //            RTAX_IFP: &route.LinkAddr{ ... },
        //            RTAX_BRD: &route.Inet4Addr{ ... },
        //        },
        //    }
        //
        // The values for the above fields depend on the implementation of
        // each operating system.
        //
        // The Err field on a response message contains an error value on the
        // requested operation. If non-nil, the requested operation is failed.
        public partial struct RouteMessage
        {
            public long Version; // message version
            public long Type; // message type
            public long Flags; // route flags
            public long Index; // interface index when atatched
            public System.UIntPtr ID; // sender's identifier; usually process ID
            public long Seq; // sequence number
            public error Err; // error on requested operation
            public slice<Addr> Addrs; // addresses

            public long extOff; // offset of header extension
            public slice<byte> raw; // raw message
        }

        // Marshal returns the binary encoding of m.
        private static (slice<byte>, error) Marshal(this ref RouteMessage m)
        {
            return m.marshal();
        }

        // A RIBType reprensents a type of routing information base.
        public partial struct RIBType // : long
        {
        }

        public static readonly RIBType RIBTypeRoute = syscall.NET_RT_DUMP;
        public static readonly RIBType RIBTypeInterface = syscall.NET_RT_IFLIST;

        // FetchRIB fetches a routing information base from the operating
        // system.
        //
        // The provided af must be an address family.
        //
        // The provided arg must be a RIBType-specific argument.
        // When RIBType is related to routes, arg might be a set of route
        // flags. When RIBType is related to network interfaces, arg might be
        // an interface index or a set of interface flags. In most cases, zero
        // means a wildcard.
        public static (slice<byte>, error) FetchRIB(long af, RIBType typ, long arg)
        {
            array<int> mib = new array<int>(new int[] { sysCTL_NET, sysAF_ROUTE, 0, int32(af), int32(typ), int32(arg) });
            var n = uintptr(0L);
            {
                var err__prev1 = err;

                var err = sysctl(mib[..], null, ref n, null, 0L);

                if (err != null)
                {
                    return (null, os.NewSyscallError("sysctl", err));
                }

                err = err__prev1;

            }
            if (n == 0L)
            {
                return (null, null);
            }
            var b = make_slice<byte>(n);
            {
                var err__prev1 = err;

                err = sysctl(mib[..], ref b[0L], ref n, null, 0L);

                if (err != null)
                {
                    return (null, os.NewSyscallError("sysctl", err));
                }

                err = err__prev1;

            }
            return (b[..n], null);
        }
    }
}}}}}