//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:27:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sigset_t
        {
            // Constructors
            public sigset_t(NilType _)
            {
                this.X__val = default;
            }

            public sigset_t(array<ulong> X__val = default)
            {
                this.X__val = X__val;
            }

            // Enable comparisons between nil and sigset_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sigset_t value, NilType nil) => value.Equals(default(sigset_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sigset_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sigset_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sigset_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sigset_t(NilType nil) => default(sigset_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sigset_t sigset_t_cast(dynamic value)
        {
            return new sigset_t(value.X__val);
        }
    }
}