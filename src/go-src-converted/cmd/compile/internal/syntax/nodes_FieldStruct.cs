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
        [PromotedStruct(typeof(node))]
        public partial struct Field
        {
            // node structure promotion - sourced from value copy
            private readonly ptr<node> m_nodeRef;

            private ref node node_val => ref m_nodeRef.Value;

            public ref src.Pos pos => ref m_nodeRef.Value.pos;

            // Constructors
            public Field(NilType _)
            {
                this.Name = default;
                this.Type = default;
                this.m_nodeRef = new ptr<node>(new node(nil));
            }

            public Field(ref ptr<Name> Name = default, Expr Type = default, node node = default)
            {
                this.Name = Name;
                this.Type = Type;
                this.m_nodeRef = new ptr<node>(node);
            }

            // Enable comparisons between nil and Field struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Field value, NilType nil) => value.Equals(default(Field));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Field value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Field value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Field value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Field(NilType nil) => default(Field);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Field Field_cast(dynamic value)
        {
            return new Field(ref value.Name, value.Type, value.node);
        }
    }
}}}}