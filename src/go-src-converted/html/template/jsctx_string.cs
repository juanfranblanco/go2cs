// Code generated by "stringer -type jsCtx"; DO NOT EDIT.

// package template -- go2cs converted at 2020 October 08 03:43:09 UTC
// import "html/template" ==> using template = go.html.template_package
// Original source: C:\Go\src\html\template\jsctx_string.go
using strconv = go.strconv_package;
using static go.builtin;

namespace go {
namespace html
{
    public static partial class template_package
    {
        private static readonly @string _jsCtx_name = (@string)"jsCtxRegexpjsCtxDivOpjsCtxUnknown";



        private static array<byte> _jsCtx_index = new array<byte>(new byte[] { 0, 11, 21, 33 });

        private static @string String(this jsCtx i)
        {
            if (i >= jsCtx(len(_jsCtx_index) - 1L))
            {
                return "jsCtx(" + strconv.FormatInt(int64(i), 10L) + ")";
            }

            return _jsCtx_name[_jsCtx_index[i].._jsCtx_index[i + 1L]];

        }
    }
}}