//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:01:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using keys = go.golang.org.x.tools.@internal.@event.keys_package;
using label = go.golang.org.x.tools.@internal.@event.label_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event {
namespace export
{
    public static partial class metric_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct HistogramFloat64
        {
            // Constructors
            public HistogramFloat64(NilType _)
            {
                this.Name = default;
                this.Description = default;
                this.Keys = default;
                this.Buckets = default;
            }

            public HistogramFloat64(@string Name = default, @string Description = default, slice<label.Key> Keys = default, slice<double> Buckets = default)
            {
                this.Name = Name;
                this.Description = Description;
                this.Keys = Keys;
                this.Buckets = Buckets;
            }

            // Enable comparisons between nil and HistogramFloat64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(HistogramFloat64 value, NilType nil) => value.Equals(default(HistogramFloat64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(HistogramFloat64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, HistogramFloat64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, HistogramFloat64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator HistogramFloat64(NilType nil) => default(HistogramFloat64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static HistogramFloat64 HistogramFloat64_cast(dynamic value)
        {
            return new HistogramFloat64(value.Name, value.Description, value.Keys, value.Buckets);
        }
    }
}}}}}}}