//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 05:02:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace text {
namespace unicode
{
    public static partial class norm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct streamSafe
        {
            // Value of the streamSafe struct
            private readonly byte m_value;

            public streamSafe(byte value) => m_value = value;

            // Enable implicit conversions between byte and streamSafe struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator streamSafe(byte value) => new streamSafe(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(streamSafe value) => value.m_value;
            
            // Enable comparisons between nil and streamSafe struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(streamSafe value, NilType nil) => value.Equals(default(streamSafe));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(streamSafe value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, streamSafe value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, streamSafe value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator streamSafe(NilType nil) => default(streamSafe);
        }
    }
}}}}}}