//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:18:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class build_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ImportMode
        {
            // Value of the ImportMode struct
            private readonly ulong m_value;

            public ImportMode(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and ImportMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ImportMode(ulong value) => new ImportMode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(ImportMode value) => value.m_value;
            
            // Enable comparisons between nil and ImportMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ImportMode value, NilType nil) => value.Equals(default(ImportMode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ImportMode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ImportMode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ImportMode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ImportMode(NilType nil) => default(ImportMode);
        }
    }
}}
