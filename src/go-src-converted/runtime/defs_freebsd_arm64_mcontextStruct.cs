//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mcontext
        {
            // Constructors
            public mcontext(NilType _)
            {
                this.mc_gpregs = default;
                this.mc_fpregs = default;
                this.mc_flags = default;
                this.mc_pad = default;
                this.mc_spare = default;
            }

            public mcontext(gpregs mc_gpregs = default, fpregs mc_fpregs = default, int mc_flags = default, int mc_pad = default, array<ulong> mc_spare = default)
            {
                this.mc_gpregs = mc_gpregs;
                this.mc_fpregs = mc_fpregs;
                this.mc_flags = mc_flags;
                this.mc_pad = mc_pad;
                this.mc_spare = mc_spare;
            }

            // Enable comparisons between nil and mcontext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mcontext value, NilType nil) => value.Equals(default(mcontext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mcontext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mcontext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mcontext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mcontext(NilType nil) => default(mcontext);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mcontext mcontext_cast(dynamic value)
        {
            return new mcontext(value.mc_gpregs, value.mc_fpregs, value.mc_flags, value.mc_pad, value.mc_spare);
        }
    }
}