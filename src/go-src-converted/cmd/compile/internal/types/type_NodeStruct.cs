//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:53:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using obj = go.cmd.@internal.obj_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Node
        {
            // Constructors
            public Node(NilType _)
            {
                this._ = default;
            }

            public Node(long _ = default)
            {
                this._ = _;
            }

            // Enable comparisons between nil and Node struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Node value, NilType nil) => value.Equals(default(Node));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Node value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Node value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Node value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Node(NilType nil) => default(Node);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Node Node_cast(dynamic value)
        {
            return new Node(value._);
        }
    }
}}}}