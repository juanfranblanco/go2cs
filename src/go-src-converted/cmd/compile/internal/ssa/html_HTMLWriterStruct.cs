//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:53:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using html = go.html_package;
using io = go.io_package;
using os = go.os_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct HTMLWriter
        {
            // Constructors
            public HTMLWriter(NilType _)
            {
                this.Logger = default;
                this.w = default;
            }

            public HTMLWriter(Logger Logger = default, io.WriteCloser w = default)
            {
                this.Logger = Logger;
                this.w = w;
            }

            // Enable comparisons between nil and HTMLWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(HTMLWriter value, NilType nil) => value.Equals(default(HTMLWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(HTMLWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, HTMLWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, HTMLWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator HTMLWriter(NilType nil) => default(HTMLWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static HTMLWriter HTMLWriter_cast(dynamic value)
        {
            return new HTMLWriter(value.Logger, value.w);
        }
    }
}}}}