//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:28:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using os = go.os_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using time = go.time_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct UnixAddr
        {
            // Constructors
            public UnixAddr(NilType _)
            {
                this.Name = default;
                this.Net = default;
            }

            public UnixAddr(@string Name = default, @string Net = default)
            {
                this.Name = Name;
                this.Net = Net;
            }

            // Enable comparisons between nil and UnixAddr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnixAddr value, NilType nil) => value.Equals(default(UnixAddr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnixAddr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnixAddr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnixAddr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnixAddr(NilType nil) => default(UnixAddr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static UnixAddr UnixAddr_cast(dynamic value)
        {
            return new UnixAddr(value.Name, value.Net);
        }
    }
}