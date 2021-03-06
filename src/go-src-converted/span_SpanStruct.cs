//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:01:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using path = go.path_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal
{
    public static partial class span_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct span
        {
            // Constructors
            public span(NilType _)
            {
                this.URI = default;
                this.Start = default;
                this.End = default;
            }

            public span(URI URI = default, point Start = default, point End = default)
            {
                this.URI = URI;
                this.Start = Start;
                this.End = End;
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
            return new span(value.URI, value.Start, value.End);
        }
    }
}}}}}