// Code generated by running "go generate" in golang.org/x/text. DO NOT EDIT.

// Copyright 2016 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package idna -- go2cs converted at 2020 October 09 04:57:01 UTC
// import "golang.org/x/net/idna" ==> using idna = go.golang.org.x.net.idna_package
// Original source: C:\Users\ritchie\go\src\golang.org\x\net\idna\punycode.go
// This file implements the Punycode algorithm from RFC 3492.

using math = go.math_package;
using strings = go.strings_package;
using utf8 = go.unicode.utf8_package;
using static go.builtin;

namespace go {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class idna_package
    {
        // These parameter values are specified in section 5.
        //
        // All computation is done with int32s, so that overflow behavior is identical
        // regardless of whether int is 32-bit or 64-bit.
        private static readonly int base = (int)36L;
        private static readonly int damp = (int)700L;
        private static readonly int initialBias = (int)72L;
        private static readonly int initialN = (int)128L;
        private static readonly int skew = (int)38L;
        private static readonly int tmax = (int)26L;
        private static readonly int tmin = (int)1L;


        private static error punyError(@string s)
        {
            return error.As(addr(new labelError(s,"A3"))!)!;
        }

        // decode decodes a string as specified in section 6.2.
        private static (@string, error) decode(@string encoded)
        {
            @string _p0 = default;
            error _p0 = default!;

            if (encoded == "")
            {
                return ("", error.As(null!)!);
            }

            long pos = 1L + strings.LastIndex(encoded, "-");
            if (pos == 1L)
            {
                return ("", error.As(punyError(encoded))!);
            }

            if (pos == len(encoded))
            {
                return (encoded[..len(encoded) - 1L], error.As(null!)!);
            }

            var output = make_slice<int>(0L, len(encoded));
            if (pos != 0L)
            {
                foreach (var (_, r) in encoded[..pos - 1L])
                {
                    output = append(output, r);
                }

            }

            var i = int32(0L);
            var n = initialN;
            var bias = initialBias;
            while (pos < len(encoded))
            {
                var oldI = i;
                var w = int32(1L);
                {
                    var k = base;

                    while (>>MARKER:FOREXPRESSION_LEVEL_2<<)
                    {
                        if (pos == len(encoded))
                        {
                            return ("", error.As(punyError(encoded))!);
                        k += base;
                        }

                        var (digit, ok) = decodeDigit(encoded[pos]);
                        if (!ok)
                        {
                            return ("", error.As(punyError(encoded))!);
                        }

                        pos++;
                        i += digit * w;
                        if (i < 0L)
                        {
                            return ("", error.As(punyError(encoded))!);
                        }

                        var t = k - bias;
                        if (t < tmin)
                        {
                            t = tmin;
                        }
                        else if (t > tmax)
                        {
                            t = tmax;
                        }

                        if (digit < t)
                        {
                            break;
                        }

                        w *= base - t;
                        if (w >= math.MaxInt32 / base)
                        {
                            return ("", error.As(punyError(encoded))!);
                        }

                    }

                }
                var x = int32(len(output) + 1L);
                bias = adapt(i - oldI, x, oldI == 0L);
                n += i / x;
                i %= x;
                if (n > utf8.MaxRune || len(output) >= 1024L)
                {
                    return ("", error.As(punyError(encoded))!);
                }

                output = append(output, 0L);
                copy(output[i + 1L..], output[i..]);
                output[i] = n;
                i++;

            }

            return (string(output), error.As(null!)!);

        }

        // encode encodes a string as specified in section 6.3 and prepends prefix to
        // the result.
        //
        // The "while h < length(input)" line in the specification becomes "for
        // remaining != 0" in the Go code, because len(s) in Go is in bytes, not runes.
        private static (@string, error) encode(@string prefix, @string s)
        {
            @string _p0 = default;
            error _p0 = default!;

            var output = make_slice<byte>(len(prefix), len(prefix) + 1L + 2L * len(s));
            copy(output, prefix);
            var delta = int32(0L);
            var n = initialN;
            var bias = initialBias;
            var b = int32(0L);
            var remaining = int32(0L);
            {
                var r__prev1 = r;

                foreach (var (_, __r) in s)
                {
                    r = __r;
                    if (r < 0x80UL)
                    {
                        b++;
                        output = append(output, byte(r));
                    }
                    else
                    {
                        remaining++;
                    }

                }

                r = r__prev1;
            }

            var h = b;
            if (b > 0L)
            {
                output = append(output, '-');
            }

            while (remaining != 0L)
            {
                var m = int32(0x7fffffffUL);
                {
                    var r__prev2 = r;

                    foreach (var (_, __r) in s)
                    {
                        r = __r;
                        if (m > r && r >= n)
                        {
                            m = r;
                        }

                    }

                    r = r__prev2;
                }

                delta += (m - n) * (h + 1L);
                if (delta < 0L)
                {
                    return ("", error.As(punyError(s))!);
                }

                n = m;
                {
                    var r__prev2 = r;

                    foreach (var (_, __r) in s)
                    {
                        r = __r;
                        if (r < n)
                        {
                            delta++;
                            if (delta < 0L)
                            {
                                return ("", error.As(punyError(s))!);
                            }

                            continue;

                        }

                        if (r > n)
                        {
                            continue;
                        }

                        var q = delta;
                        {
                            var k = base;

                            while (>>MARKER:FOREXPRESSION_LEVEL_3<<)
                            {
                                var t = k - bias;
                                if (t < tmin)
                                {
                                    t = tmin;
                                k += base;
                                }
                                else if (t > tmax)
                                {
                                    t = tmax;
                                }

                                if (q < t)
                                {
                                    break;
                                }

                                output = append(output, encodeDigit(t + (q - t) % (base - t)));
                                q = (q - t) / (base - t);

                            }

                        }
                        output = append(output, encodeDigit(q));
                        bias = adapt(delta, h + 1L, h == b);
                        delta = 0L;
                        h++;
                        remaining--;

                    }

                    r = r__prev2;
                }

                delta++;
                n++;

            }

            return (string(output), error.As(null!)!);

        }

        private static (int, bool) decodeDigit(byte x)
        {
            int digit = default;
            bool ok = default;


            if ('0' <= x && x <= '9') 
                return (int32(x - ('0' - 26L)), true);
            else if ('A' <= x && x <= 'Z') 
                return (int32(x - 'A'), true);
            else if ('a' <= x && x <= 'z') 
                return (int32(x - 'a'), true);
                        return (0L, false);

        }

        private static byte encodeDigit(int digit) => func((_, panic, __) =>
        {

            if (0L <= digit && digit < 26L) 
                return byte(digit + 'a');
            else if (26L <= digit && digit < 36L) 
                return byte(digit + ('0' - 26L));
                        panic("idna: internal error in punycode encoding");

        });

        // adapt is the bias adaptation function specified in section 6.1.
        private static int adapt(int delta, int numPoints, bool firstTime)
        {
            if (firstTime)
            {
                delta /= damp;
            }
            else
            {
                delta /= 2L;
            }

            delta += delta / numPoints;
            var k = int32(0L);
            while (delta > ((base - tmin) * tmax) / 2L)
            {
                delta /= base - tmin;
                k += base;
            }

            return k + (base - tmin + 1L) * delta / (delta + skew);

        }
    }
}}}}
