//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:26:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using src = go.cmd.@internal.src_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(expr))]
        public partial struct BasicLit
        {
            // expr structure promotion - sourced from value copy
            private readonly ptr<expr> m_exprRef;

            private ref expr expr_val => ref m_exprRef.Value;

            // Constructors
            public BasicLit(NilType _)
            {
                this.Value = default;
                this.Kind = default;
                this.m_exprRef = new ptr<expr>(new expr(nil));
            }

            public BasicLit(@string Value = default, LitKind Kind = default, expr expr = default)
            {
                this.Value = Value;
                this.Kind = Kind;
                this.m_exprRef = new ptr<expr>(expr);
            }

            // Enable comparisons between nil and BasicLit struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BasicLit value, NilType nil) => value.Equals(default(BasicLit));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BasicLit value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BasicLit value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BasicLit value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BasicLit(NilType nil) => default(BasicLit);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BasicLit BasicLit_cast(dynamic value)
        {
            return new BasicLit(value.Value, value.Kind, value.expr);
        }
    }
}}}}