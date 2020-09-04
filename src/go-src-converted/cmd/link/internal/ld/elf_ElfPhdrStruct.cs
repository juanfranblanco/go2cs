//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:03:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using sym = go.cmd.link.@internal.sym_package;
using sha1 = go.crypto.sha1_package;
using binary = go.encoding.binary_package;
using hex = go.encoding.hex_package;
using io = go.io_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ElfPhdr
        {
            // Constructors
            public ElfPhdr(NilType _)
            {
                this.type_ = default;
                this.flags = default;
                this.off = default;
                this.vaddr = default;
                this.paddr = default;
                this.filesz = default;
                this.memsz = default;
                this.align = default;
            }

            public ElfPhdr(uint type_ = default, uint flags = default, ulong off = default, ulong vaddr = default, ulong paddr = default, ulong filesz = default, ulong memsz = default, ulong align = default)
            {
                this.type_ = type_;
                this.flags = flags;
                this.off = off;
                this.vaddr = vaddr;
                this.paddr = paddr;
                this.filesz = filesz;
                this.memsz = memsz;
                this.align = align;
            }

            // Enable comparisons between nil and ElfPhdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ElfPhdr value, NilType nil) => value.Equals(default(ElfPhdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ElfPhdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ElfPhdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ElfPhdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ElfPhdr(NilType nil) => default(ElfPhdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ElfPhdr ElfPhdr_cast(dynamic value)
        {
            return new ElfPhdr(value.type_, value.flags, value.off, value.vaddr, value.paddr, value.filesz, value.memsz, value.align);
        }
    }
}}}}