//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:33:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using @base = go.cmd.go.@internal.@base_package;
using get = go.cmd.go.@internal.get_package;
using imports = go.cmd.go.@internal.imports_package;
using load = go.cmd.go.@internal.load_package;
using modload = go.cmd.go.@internal.modload_package;
using mvs = go.cmd.go.@internal.mvs_package;
using par = go.cmd.go.@internal.par_package;
using search = go.cmd.go.@internal.search_package;
using work = go.cmd.go.@internal.work_package;
using module = go.golang.org.x.mod.module_package;
using semver = go.golang.org.x.mod.semver_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modget_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct upgrader
        {
            // Reqs.Required function promotion
            private delegate (module.Version, error) RequiredByVal(T value, module.Version m);
            private delegate (module.Version, error) RequiredByRef(ref T value, module.Version m);

            private static readonly RequiredByVal s_RequiredByVal;
            private static readonly RequiredByRef s_RequiredByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (module.Version, error) Required(module.Version m) => s_RequiredByRef?.Invoke(ref this, m) ?? s_RequiredByVal?.Invoke(this, m) ?? Reqs?.Required(m) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Reqs.Max function promotion
            private delegate (module.Version, error) MaxByVal(T value, @string v1, @string v2);
            private delegate (module.Version, error) MaxByRef(ref T value, @string v1, @string v2);

            private static readonly MaxByVal s_MaxByVal;
            private static readonly MaxByRef s_MaxByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (module.Version, error) Max(@string v1, @string v2) => s_MaxByRef?.Invoke(ref this, v1, v2) ?? s_MaxByVal?.Invoke(this, v1, v2) ?? Reqs?.Max(v1, v2) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Reqs.Upgrade function promotion
            private delegate (module.Version, error) UpgradeByVal(T value, module.Version m);
            private delegate (module.Version, error) UpgradeByRef(ref T value, module.Version m);

            private static readonly UpgradeByVal s_UpgradeByVal;
            private static readonly UpgradeByRef s_UpgradeByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (module.Version, error) Upgrade(module.Version m) => s_UpgradeByRef?.Invoke(ref this, m) ?? s_UpgradeByVal?.Invoke(this, m) ?? Reqs?.Upgrade(m) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Reqs.Previous function promotion
            private delegate (module.Version, error) PreviousByVal(T value, module.Version m);
            private delegate (module.Version, error) PreviousByRef(ref T value, module.Version m);

            private static readonly PreviousByVal s_PreviousByVal;
            private static readonly PreviousByRef s_PreviousByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (module.Version, error) Previous(module.Version m) => s_PreviousByRef?.Invoke(ref this, m) ?? s_PreviousByVal?.Invoke(this, m) ?? Reqs?.Previous(m) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static upgrader()
            {
                Type targetType = typeof(upgrader);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Required");

                if ((object)extensionMethod != null)
                {
                    s_RequiredByRef = extensionMethod.CreateStaticDelegate(typeof(RequiredByRef)) as RequiredByRef;

                    if ((object)s_RequiredByRef == null)
                        s_RequiredByVal = extensionMethod.CreateStaticDelegate(typeof(RequiredByVal)) as RequiredByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Max");

                if ((object)extensionMethod != null)
                {
                    s_MaxByRef = extensionMethod.CreateStaticDelegate(typeof(MaxByRef)) as MaxByRef;

                    if ((object)s_MaxByRef == null)
                        s_MaxByVal = extensionMethod.CreateStaticDelegate(typeof(MaxByVal)) as MaxByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Upgrade");

                if ((object)extensionMethod != null)
                {
                    s_UpgradeByRef = extensionMethod.CreateStaticDelegate(typeof(UpgradeByRef)) as UpgradeByRef;

                    if ((object)s_UpgradeByRef == null)
                        s_UpgradeByVal = extensionMethod.CreateStaticDelegate(typeof(UpgradeByVal)) as UpgradeByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Previous");

                if ((object)extensionMethod != null)
                {
                    s_PreviousByRef = extensionMethod.CreateStaticDelegate(typeof(PreviousByRef)) as PreviousByRef;

                    if ((object)s_PreviousByRef == null)
                        s_PreviousByVal = extensionMethod.CreateStaticDelegate(typeof(PreviousByVal)) as PreviousByVal;
                }
            }

            // Constructors
            public upgrader(NilType _)
            {
                this.Reqs = default;
                this.cmdline = default;
                this.upgrade = default;
            }

            public upgrader(mvs.Reqs Reqs = default, map<@string, ptr<query>> cmdline = default, map<@string, bool> upgrade = default)
            {
                this.Reqs = Reqs;
                this.cmdline = cmdline;
                this.upgrade = upgrade;
            }

            // Enable comparisons between nil and upgrader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(upgrader value, NilType nil) => value.Equals(default(upgrader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(upgrader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, upgrader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, upgrader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator upgrader(NilType nil) => default(upgrader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static upgrader upgrader_cast(dynamic value)
        {
            return new upgrader(value.Reqs, value.cmdline, value.upgrade);
        }
    }
}}}}