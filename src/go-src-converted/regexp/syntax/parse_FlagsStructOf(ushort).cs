//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:58:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace regexp
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Flags
        {
            // Value of the Flags struct
            private readonly ushort m_value;

            public Flags(ushort value) => m_value = value;

            // Enable implicit conversions between ushort and Flags struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Flags(ushort value) => new Flags(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ushort(Flags value) => value.m_value;
            
            // Enable comparisons between nil and Flags struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Flags value, NilType nil) => value.Equals(default(Flags));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Flags value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Flags value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Flags value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Flags(NilType nil) => default(Flags);
        }
    }
}}
