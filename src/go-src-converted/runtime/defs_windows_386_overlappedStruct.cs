//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct overlapped
        {
            // Constructors
            public overlapped(NilType _)
            {
                this.@internal = default;
                this.internalhigh = default;
                this.anon0 = default;
                this.hevent = default;
            }

            public overlapped(uint @internal = default, uint internalhigh = default, array<byte> anon0 = default, ref ptr<byte> hevent = default)
            {
                this.@internal = @internal;
                this.internalhigh = internalhigh;
                this.anon0 = anon0;
                this.hevent = hevent;
            }

            // Enable comparisons between nil and overlapped struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(overlapped value, NilType nil) => value.Equals(default(overlapped));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(overlapped value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, overlapped value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, overlapped value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator overlapped(NilType nil) => default(overlapped);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static overlapped overlapped_cast(dynamic value)
        {
            return new overlapped(value.@internal, value.internalhigh, value.anon0, ref value.hevent);
        }
    }
}