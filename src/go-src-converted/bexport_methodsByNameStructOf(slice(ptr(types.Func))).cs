//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace @internal
{
    public static partial class gcimporter_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct methodsByName
        {
            // Value of the methodsByName struct
            private readonly slice<ptr<types.Func>> m_value;

            public methodsByName(slice<ptr<types.Func>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<types.Func>> and methodsByName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator methodsByName(slice<ptr<types.Func>> value) => new methodsByName(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<types.Func>>(methodsByName value) => value.m_value;
            
            // Enable comparisons between nil and methodsByName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(methodsByName value, NilType nil) => value.Equals(default(methodsByName));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(methodsByName value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, methodsByName value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, methodsByName value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator methodsByName(NilType nil) => default(methodsByName);
        }
    }
}}}}}}
