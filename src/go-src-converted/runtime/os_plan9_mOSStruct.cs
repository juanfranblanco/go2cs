//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:47:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mOS
        {
            // Constructors
            public mOS(NilType _)
            {
                this.waitsemacount = default;
                this.notesig = default;
                this.errstr = default;
                this.ignoreHangup = default;
            }

            public mOS(uint waitsemacount = default, ref ptr<sbyte> notesig = default, ref ptr<byte> errstr = default, bool ignoreHangup = default)
            {
                this.waitsemacount = waitsemacount;
                this.notesig = notesig;
                this.errstr = errstr;
                this.ignoreHangup = ignoreHangup;
            }

            // Enable comparisons between nil and mOS struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mOS value, NilType nil) => value.Equals(default(mOS));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mOS value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mOS value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mOS value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mOS(NilType nil) => default(mOS);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mOS mOS_cast(dynamic value)
        {
            return new mOS(value.waitsemacount, ref value.notesig, ref value.errstr, value.ignoreHangup);
        }
    }
}