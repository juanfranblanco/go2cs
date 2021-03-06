// Copyright 2011 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package os -- go2cs converted at 2020 October 09 05:07:17 UTC
// import "os" ==> using os = go.os_package
// Original source: C:\Go\src\os\path_plan9.go

using static go.builtin;

namespace go
{
    public static partial class os_package
    {
        public static readonly char PathSeparator = (char)'/'; // OS-specific path separator
        public static readonly char PathListSeparator = (char)' '; // OS-specific path list separator

        // IsPathSeparator reports whether c is a directory separator character.
        public static bool IsPathSeparator(byte c)
        {
            return PathSeparator == c;
        }

        private static @string fixRootDirectory(@string p)
        {
            return p;
        }
    }
}
