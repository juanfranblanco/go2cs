//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:57:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct M
        {
            // Value of the M struct
            private readonly map<@string, long> m_value;

            public M(map<@string, long> value) => m_value = value;

            // Enable implicit conversions between map<@string, long> and M struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator M(map<@string, long> value) => new M(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<@string, long>(M value) => value.m_value;
            
            // Enable comparisons between nil and M struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(M value, NilType nil) => value.Equals(default(M));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(M value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, M value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, M value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator M(NilType nil) => default(M);
        }
    }
}