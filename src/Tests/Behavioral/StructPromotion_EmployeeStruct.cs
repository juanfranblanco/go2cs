//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 August 09 01:21:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial struct Employee : EmptyInterface
        {
            // Constructors
            public Employee(NilType _)
            {
                this.position = default;
            }

            public Employee(@string position)
            {
                this.position = position;
            }

            // Enable comparisons between nil and Employee struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Employee value, NilType nil) => value.Equals(default(Employee));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Employee value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Employee value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Employee value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Employee(NilType nil) => default(Employee);
        }

        [GeneratedCode("go2cs", "0.1.1.0")]
        public static Employee Employee_cast(dynamic value)
        {
            return new Employee(value.position);
        }
    }
}