//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:19:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sort = go.sort_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Named
        {
            // Constructors
            public Named(NilType _)
            {
                this.info = default;
                this.obj = default;
                this.orig = default;
                this.underlying = default;
                this.methods = default;
            }

            public Named(typeInfo info = default, ref ptr<TypeName> obj = default, Type orig = default, Type underlying = default, slice<ptr<Func>> methods = default)
            {
                this.info = info;
                this.obj = obj;
                this.orig = orig;
                this.underlying = underlying;
                this.methods = methods;
            }

            // Enable comparisons between nil and Named struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Named value, NilType nil) => value.Equals(default(Named));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Named value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Named value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Named value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Named(NilType nil) => default(Named);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Named Named_cast(dynamic value)
        {
            return new Named(value.info, ref value.obj, value.orig, value.underlying, value.methods);
        }
    }
}}