//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:58:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class regexp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct runeSlice
        {
            // Value of the runeSlice struct
            private readonly slice<int> m_value;

            public runeSlice(slice<int> value) => m_value = value;

            // Enable implicit conversions between slice<int> and runeSlice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator runeSlice(slice<int> value) => new runeSlice(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<int>(runeSlice value) => value.m_value;
            
            // Enable comparisons between nil and runeSlice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(runeSlice value, NilType nil) => value.Equals(default(runeSlice));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(runeSlice value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, runeSlice value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, runeSlice value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator runeSlice(NilType nil) => default(runeSlice);
        }
    }
}
