//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:19:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct stdFunction
        {
            // Value of the stdFunction struct
            private readonly unsafe.Pointer m_value;

            public stdFunction(unsafe.Pointer value) => m_value = value;

            // Enable implicit conversions between unsafe.Pointer and stdFunction struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stdFunction(unsafe.Pointer value) => new stdFunction(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator unsafe.Pointer(stdFunction value) => value.m_value;
            
            // Enable comparisons between nil and stdFunction struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stdFunction value, NilType nil) => value.Equals(default(stdFunction));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stdFunction value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stdFunction value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stdFunction value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stdFunction(NilType nil) => default(stdFunction);
        }
    }
}