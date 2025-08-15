namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags specifying compile-time options.
/// </para>
/// </summary>

[Flags]
public enum GRegexCompileFlags : uint
{
/// <summary>
/// <para>
/// No special options set. Since: 2.74
/// </para>
/// </summary>

	G_REGEX_DEFAULT = 0,
/// <summary>
/// <para>
/// Letters in the pattern match both upper- and
///     lowercase letters. This option can be changed within a pattern
///     by a &quot;(?i)&quot; option setting.
/// </para>
/// </summary>

	G_REGEX_CASELESS = 1,
/// <summary>
/// <para>
/// By default, GRegex treats the strings as consisting
///     of a single line of characters (even if it actually contains
///     newlines). The &quot;start of line&quot; metacharacter (&quot;^&quot;) matches only
///     at the start of the string, while the &quot;end of line&quot; metacharacter
///     (&quot;$&quot;) matches only at the end of the string, or before a terminating
///     newline (unless %G_REGEX_DOLLAR_ENDONLY is set). When
///     %G_REGEX_MULTILINE is set, the &quot;start of line&quot; and &quot;end of line&quot;
///     constructs match immediately following or immediately before any
///     newline in the string, respectively, as well as at the very start
///     and end. This can be changed within a pattern by a &quot;(?m)&quot; option
///     setting.
/// </para>
/// </summary>

	G_REGEX_MULTILINE = 2,
/// <summary>
/// <para>
/// A dot metacharacter (&quot;.&quot;) in the pattern matches all
///     characters, including newlines. Without it, newlines are excluded.
///     This option can be changed within a pattern by a (&quot;?s&quot;) option setting.
/// </para>
/// </summary>

	G_REGEX_DOTALL = 4,
/// <summary>
/// <para>
/// Whitespace data characters in the pattern are
///     totally ignored except when escaped or inside a character class.
///     Whitespace does not include the VT character (code 11). In addition,
///     characters between an unescaped &quot;#&quot; outside a character class and
///     the next newline character, inclusive, are also ignored. This can
///     be changed within a pattern by a &quot;(?x)&quot; option setting.
/// </para>
/// </summary>

	G_REGEX_EXTENDED = 8,
/// <summary>
/// <para>
/// The pattern is forced to be &quot;anchored&quot;, that is,
///     it is constrained to match only at the first matching point in the
///     string that is being searched. This effect can also be achieved by
///     appropriate constructs in the pattern itself such as the &quot;^&quot;
///     metacharacter.
/// </para>
/// </summary>

	G_REGEX_ANCHORED = 16,
/// <summary>
/// <para>
/// A dollar metacharacter (&quot;$&quot;) in the pattern
///     matches only at the end of the string. Without this option, a
///     dollar also matches immediately before the final character if
///     it is a newline (but not before any other newlines). This option
///     is ignored if %G_REGEX_MULTILINE is set.
/// </para>
/// </summary>

	G_REGEX_DOLLAR_ENDONLY = 32,
/// <summary>
/// <para>
/// Inverts the &quot;greediness&quot; of the quantifiers so that
///     they are not greedy by default, but become greedy if followed by &quot;?&quot;.
///     It can also be set by a &quot;(?U)&quot; option setting within the pattern.
/// </para>
/// </summary>

	G_REGEX_UNGREEDY = 512,
/// <summary>
/// <para>
/// Usually strings must be valid UTF-8 strings, using this
///     flag they are considered as a raw sequence of bytes.
/// </para>
/// </summary>

	G_REGEX_RAW = 2048,
/// <summary>
/// <para>
/// Disables the use of numbered capturing
///     parentheses in the pattern. Any opening parenthesis that is not
///     followed by &quot;?&quot; behaves as if it were followed by &quot;?:&quot; but named
///     parentheses can still be used for capturing (and they acquire numbers
///     in the usual way).
/// </para>
/// </summary>

	G_REGEX_NO_AUTO_CAPTURE = 4096,
/// <summary>
/// <para>
/// Since 2.74 and the port to pcre2, requests JIT
///     compilation, which, if the just-in-time compiler is available, further
///     processes a compiled pattern into machine code that executes much
///     faster. However, it comes at the cost of extra processing before the
///     match is performed, so it is most beneficial to use this when the same
///     compiled pattern is used for matching many times. Before 2.74 this
///     option used the built-in non-JIT optimizations in pcre1.
/// </para>
/// </summary>

	G_REGEX_OPTIMIZE = 8192,
/// <summary>
/// <para>
/// Limits an unanchored pattern to match before (or at) the
///     first newline. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_FIRSTLINE = 262144,
/// <summary>
/// <para>
/// Names used to identify capturing subpatterns need not
///     be unique. This can be helpful for certain types of pattern when it
///     is known that only one instance of the named subpattern can ever be
///     matched.
/// </para>
/// </summary>

	G_REGEX_DUPNAMES = 524288,
/// <summary>
/// <para>
/// Usually any newline character or character sequence is
///     recognized. If this option is set, the only recognized newline character
///     is &apos;\r&apos;.
/// </para>
/// </summary>

	G_REGEX_NEWLINE_CR = 1048576,
/// <summary>
/// <para>
/// Usually any newline character or character sequence is
///     recognized. If this option is set, the only recognized newline character
///     is &apos;\n&apos;.
/// </para>
/// </summary>

	G_REGEX_NEWLINE_LF = 2097152,
/// <summary>
/// <para>
/// Usually any newline character or character sequence is
///     recognized. If this option is set, the only recognized newline character
///     sequence is &apos;\r\n&apos;.
/// </para>
/// </summary>

	G_REGEX_NEWLINE_CRLF = 3145728,
/// <summary>
/// <para>
/// Usually any newline character or character sequence
///     is recognized. If this option is set, the only recognized newline character
///     sequences are &apos;\r&apos;, &apos;\n&apos;, and &apos;\r\n&apos;. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_NEWLINE_ANYCRLF = 5242880,
/// <summary>
/// <para>
/// Usually any newline character or character sequence
///     is recognised. If this option is set, then &quot;\R&quot; only recognizes the newline
///    characters &apos;\r&apos;, &apos;\n&apos; and &apos;\r\n&apos;. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_BSR_ANYCRLF = 8388608,
/// <summary>
/// <para>
/// Changes behaviour so that it is compatible with
///     JavaScript rather than PCRE. Since GLib 2.74 this is no longer supported,
///     as libpcre2 does not support it. Since: 2.34 Deprecated: 2.74
/// </para>
/// </summary>

	G_REGEX_JAVASCRIPT_COMPAT = 33554432
}
