//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IfMsgHdr
        {
            // Constructors
            public IfMsgHdr(NilType _)
            {
                this.Msglen = default;
                this.Version = default;
                this.Type = default;
                this.Addrs = default;
                this.Flags = default;
                this.Index = default;
                this.Addrlen = default;
                this._ = default;
            }

            public IfMsgHdr(ushort Msglen = default, byte Version = default, byte Type = default, int Addrs = default, int Flags = default, ushort Index = default, byte Addrlen = default, array<byte> _ = default)
            {
                this.Msglen = Msglen;
                this.Version = Version;
                this.Type = Type;
                this.Addrs = Addrs;
                this.Flags = Flags;
                this.Index = Index;
                this.Addrlen = Addrlen;
                this._ = _;
            }

            // Enable comparisons between nil and IfMsgHdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IfMsgHdr value, NilType nil) => value.Equals(default(IfMsgHdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IfMsgHdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IfMsgHdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IfMsgHdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IfMsgHdr(NilType nil) => default(IfMsgHdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IfMsgHdr IfMsgHdr_cast(dynamic value)
        {
            return new IfMsgHdr(value.Msglen, value.Version, value.Type, value.Addrs, value.Flags, value.Index, value.Addrlen, value._);
        }
    }
}}}}}}