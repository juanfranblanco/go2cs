//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:47:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class testing_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct panicHandling
        {
            // Value of the panicHandling struct
            private readonly long m_value;

            public panicHandling(long value) => m_value = value;

            // Enable implicit conversions between long and panicHandling struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator panicHandling(long value) => new panicHandling(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(panicHandling value) => value.m_value;
            
            // Enable comparisons between nil and panicHandling struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(panicHandling value, NilType nil) => value.Equals(default(panicHandling));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(panicHandling value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, panicHandling value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, panicHandling value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator panicHandling(NilType nil) => default(panicHandling);
        }
    }
}
