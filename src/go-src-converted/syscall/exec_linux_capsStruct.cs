//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:26:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct caps
        {
            // Constructors
            public caps(NilType _)
            {
                this.hdr = default;
                this.data = default;
            }

            public caps(capHeader hdr = default, array<capData> data = default)
            {
                this.hdr = hdr;
                this.data = data;
            }

            // Enable comparisons between nil and caps struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(caps value, NilType nil) => value.Equals(default(caps));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(caps value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, caps value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, caps value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator caps(NilType nil) => default(caps);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static caps caps_cast(dynamic value)
        {
            return new caps(value.hdr, value.data);
        }
    }
}