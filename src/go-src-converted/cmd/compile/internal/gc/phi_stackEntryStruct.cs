//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:42:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ssa = go.cmd.compile.@internal.ssa_package;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using heap = go.container.heap_package;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct stackEntry
        {
            // Constructors
            public stackEntry(NilType _)
            {
                this.b = default;
                this.n = default;
                this.v = default;
            }

            public stackEntry(ref ptr<ssa.Block> b = default, int n = default, ref ptr<ssa.Value> v = default)
            {
                this.b = b;
                this.n = n;
                this.v = v;
            }

            // Enable comparisons between nil and stackEntry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stackEntry value, NilType nil) => value.Equals(default(stackEntry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stackEntry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stackEntry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stackEntry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stackEntry(NilType nil) => default(stackEntry);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stackEntry stackEntry_cast(dynamic value)
        {
            return new stackEntry(ref value.b, value.n, ref value.v);
        }
    }
}}}}