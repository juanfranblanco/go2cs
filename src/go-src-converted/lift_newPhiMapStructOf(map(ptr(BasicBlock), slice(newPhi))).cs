//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:57:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct newPhiMap
        {
            // Value of the newPhiMap struct
            private readonly map<ptr<BasicBlock>, slice<newPhi>> m_value;

            public newPhiMap(map<ptr<BasicBlock>, slice<newPhi>> value) => m_value = value;

            // Enable implicit conversions between map<ptr<BasicBlock>, slice<newPhi>> and newPhiMap struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator newPhiMap(map<ptr<BasicBlock>, slice<newPhi>> value) => new newPhiMap(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<ptr<BasicBlock>, slice<newPhi>>(newPhiMap value) => value.m_value;
            
            // Enable comparisons between nil and newPhiMap struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(newPhiMap value, NilType nil) => value.Equals(default(newPhiMap));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(newPhiMap value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, newPhiMap value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, newPhiMap value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator newPhiMap(NilType nil) => default(newPhiMap);
        }
    }
}}}}}