//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errorspkg = go.errors_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using time = go.time_package;
using utf16 = go.unicode.utf16_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sysLinger
        {
            // Constructors
            public sysLinger(NilType _)
            {
                this.Onoff = default;
                this.Linger = default;
            }

            public sysLinger(ushort Onoff = default, ushort Linger = default)
            {
                this.Onoff = Onoff;
                this.Linger = Linger;
            }

            // Enable comparisons between nil and sysLinger struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sysLinger value, NilType nil) => value.Equals(default(sysLinger));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sysLinger value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sysLinger value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sysLinger value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sysLinger(NilType nil) => default(sysLinger);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sysLinger sysLinger_cast(dynamic value)
        {
            return new sysLinger(value.Onoff, value.Linger);
        }
    }
}}}}}}