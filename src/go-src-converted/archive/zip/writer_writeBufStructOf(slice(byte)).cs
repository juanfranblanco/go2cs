//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:08:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace archive
{
    public static partial class zip_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct writeBuf
        {
            // Value of the writeBuf struct
            private readonly slice<byte> m_value;

            public writeBuf(slice<byte> value) => m_value = value;

            // Enable implicit conversions between slice<byte> and writeBuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator writeBuf(slice<byte> value) => new writeBuf(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<byte>(writeBuf value) => value.m_value;
            
            // Enable comparisons between nil and writeBuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(writeBuf value, NilType nil) => value.Equals(default(writeBuf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(writeBuf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, writeBuf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, writeBuf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator writeBuf(NilType nil) => default(writeBuf);
        }
    }
}}
