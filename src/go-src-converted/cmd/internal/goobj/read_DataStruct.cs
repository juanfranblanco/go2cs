//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using objabi = go.cmd.@internal.objabi_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class goobj_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Data
        {
            // Constructors
            public Data(NilType _)
            {
                this.Offset = default;
                this.Size = default;
            }

            public Data(long Offset = default, long Size = default)
            {
                this.Offset = Offset;
                this.Size = Size;
            }

            // Enable comparisons between nil and Data struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Data value, NilType nil) => value.Equals(default(Data));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Data value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Data value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Data value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Data(NilType nil) => default(Data);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Data Data_cast(dynamic value)
        {
            return new Data(value.Offset, value.Size);
        }
    }
}}}