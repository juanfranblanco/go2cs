//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using go;

namespace go {
namespace testing
{
    public static partial class iotest_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct truncateWriter
        {
            // Constructors
            public truncateWriter(NilType _)
            {
                this.w = default;
                this.n = default;
            }

            public truncateWriter(io.Writer w = default, long n = default)
            {
                this.w = w;
                this.n = n;
            }

            // Enable comparisons between nil and truncateWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(truncateWriter value, NilType nil) => value.Equals(default(truncateWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(truncateWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, truncateWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, truncateWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator truncateWriter(NilType nil) => default(truncateWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static truncateWriter truncateWriter_cast(dynamic value)
        {
            return new truncateWriter(value.w, value.n);
        }
    }
}}