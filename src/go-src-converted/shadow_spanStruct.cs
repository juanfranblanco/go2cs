//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:04:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ast = go.go.ast_package;
using token = go.go.token_package;
using types = go.go.types_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using inspect = go.golang.org.x.tools.go.analysis.passes.inspect_package;
using inspector = go.golang.org.x.tools.go.ast.inspector_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace passes
{
    public static partial class shadow_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct span
        {
            // Constructors
            public span(NilType _)
            {
                this.min = default;
                this.max = default;
            }

            public span(token.Pos min = default, token.Pos max = default)
            {
                this.min = min;
                this.max = max;
            }

            // Enable comparisons between nil and span struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(span value, NilType nil) => value.Equals(default(span));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(span value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, span value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, span value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator span(NilType nil) => default(span);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static span span_cast(dynamic value)
        {
            return new span(value.min, value.max);
        }
    }
}}}}}}}