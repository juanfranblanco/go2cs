//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:46:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using modfile = go.golang.org.x.mod.modfile_package;
using module = go.golang.org.x.mod.module_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modload_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct modFileIndex
        {
            // Constructors
            public modFileIndex(NilType _)
            {
                this.data = default;
                this.dataNeedsFix = default;
                this.module = default;
                this.goVersion = default;
                this.require = default;
                this.replace = default;
                this.exclude = default;
            }

            public modFileIndex(slice<byte> data = default, bool dataNeedsFix = default, module.Version module = default, @string goVersion = default, map<module.Version, requireMeta> require = default, map<module.Version, module.Version> replace = default, map<module.Version, bool> exclude = default)
            {
                this.data = data;
                this.dataNeedsFix = dataNeedsFix;
                this.module = module;
                this.goVersion = goVersion;
                this.require = require;
                this.replace = replace;
                this.exclude = exclude;
            }

            // Enable comparisons between nil and modFileIndex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(modFileIndex value, NilType nil) => value.Equals(default(modFileIndex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(modFileIndex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, modFileIndex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, modFileIndex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator modFileIndex(NilType nil) => default(modFileIndex);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static modFileIndex modFileIndex_cast(dynamic value)
        {
            return new modFileIndex(value.data, value.dataNeedsFix, value.module, value.goVersion, value.require, value.replace, value.exclude);
        }
    }
}}}}