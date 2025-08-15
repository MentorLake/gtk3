namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags specifying match-time options.
/// </para>
/// </summary>

[Flags]
public enum GRegexMatchFlags : uint
{
/// <summary>
/// <para>
/// No special options set. Since: 2.74
/// </para>
/// </summary>

	G_REGEX_MATCH_DEFAULT = 0,
/// <summary>
/// <para>
/// The pattern is forced to be &quot;anchored&quot;, that is,
///     it is constrained to match only at the first matching point in the
///     string that is being searched. This effect can also be achieved by
///     appropriate constructs in the pattern itself such as the &quot;^&quot;
///     metacharacter.
/// </para>
/// </summary>

	G_REGEX_MATCH_ANCHORED = 16,
/// <summary>
/// <para>
/// Specifies that first character of the string is
///     not the beginning of a line, so the circumflex metacharacter should
///     not match before it. Setting this without %G_REGEX_MULTILINE (at
///     compile time) causes circumflex never to match. This option affects
///     only the behaviour of the circumflex metacharacter, it does not
///     affect &quot;\A&quot;.
/// </para>
/// </summary>

	G_REGEX_MATCH_NOTBOL = 128,
/// <summary>
/// <para>
/// Specifies that the end of the subject string is
///     not the end of a line, so the dollar metacharacter should not match
///     it nor (except in multiline mode) a newline immediately before it.
///     Setting this without %G_REGEX_MULTILINE (at compile time) causes
///     dollar never to match. This option affects only the behaviour of
///     the dollar metacharacter, it does not affect &quot;\Z&quot; or &quot;\z&quot;.
/// </para>
/// </summary>

	G_REGEX_MATCH_NOTEOL = 256,
/// <summary>
/// <para>
/// An empty string is not considered to be a valid
///     match if this option is set. If there are alternatives in the pattern,
///     they are tried. If all the alternatives match the empty string, the
///     entire match fails. For example, if the pattern &quot;a?b?&quot; is applied to
///     a string not beginning with &quot;a&quot; or &quot;b&quot;, it matches the empty string
///     at the start of the string. With this flag set, this match is not
///     valid, so GRegex searches further into the string for occurrences
///     of &quot;a&quot; or &quot;b&quot;.
/// </para>
/// </summary>

	G_REGEX_MATCH_NOTEMPTY = 1024,
/// <summary>
/// <para>
/// Turns on the partial matching feature, for more
///     documentation on partial matching see g_match_info_is_partial_match().
/// </para>
/// </summary>

	G_REGEX_MATCH_PARTIAL = 32768,
/// <summary>
/// <para>
/// Overrides the newline definition set when
///     creating a new #GRegex, setting the &apos;\r&apos; character as line terminator.
/// </para>
/// </summary>

	G_REGEX_MATCH_NEWLINE_CR = 1048576,
/// <summary>
/// <para>
/// Overrides the newline definition set when
///     creating a new #GRegex, setting the &apos;\n&apos; character as line terminator.
/// </para>
/// </summary>

	G_REGEX_MATCH_NEWLINE_LF = 2097152,
/// <summary>
/// <para>
/// Overrides the newline definition set when
///     creating a new #GRegex, setting the &apos;\r\n&apos; characters sequence as line terminator.
/// </para>
/// </summary>

	G_REGEX_MATCH_NEWLINE_CRLF = 3145728,
/// <summary>
/// <para>
/// Overrides the newline definition set when
///     creating a new #GRegex, any Unicode newline sequence
///     is recognised as a newline. These are &apos;\r&apos;, &apos;\n&apos; and &apos;\rn&apos;, and the
///     single characters U+000B LINE TABULATION, U+000C FORM FEED (FF),
///     U+0085 NEXT LINE (NEL), U+2028 LINE SEPARATOR and
///     U+2029 PARAGRAPH SEPARATOR.
/// </para>
/// </summary>

	G_REGEX_MATCH_NEWLINE_ANY = 4194304,
/// <summary>
/// <para>
/// Overrides the newline definition set when
///     creating a new #GRegex; any &apos;\r&apos;, &apos;\n&apos;, or &apos;\r\n&apos; character sequence
///     is recognized as a newline. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_MATCH_NEWLINE_ANYCRLF = 5242880,
/// <summary>
/// <para>
/// Overrides the newline definition for &quot;\R&quot; set when
///     creating a new #GRegex; only &apos;\r&apos;, &apos;\n&apos;, or &apos;\r\n&apos; character sequences
///     are recognized as a newline by &quot;\R&quot;. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_MATCH_BSR_ANYCRLF = 8388608,
/// <summary>
/// <para>
/// Overrides the newline definition for &quot;\R&quot; set when
///     creating a new #GRegex; any Unicode newline character or character sequence
///     are recognized as a newline by &quot;\R&quot;. These are &apos;\r&apos;, &apos;\n&apos; and &apos;\rn&apos;, and the
///     single characters U+000B LINE TABULATION, U+000C FORM FEED (FF),
///     U+0085 NEXT LINE (NEL), U+2028 LINE SEPARATOR and
///     U+2029 PARAGRAPH SEPARATOR. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_MATCH_BSR_ANY = 16777216,
/// <summary>
/// <para>
/// An alias for %G_REGEX_MATCH_PARTIAL. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_MATCH_PARTIAL_SOFT = 32768,
/// <summary>
/// <para>
/// Turns on the partial matching feature. In contrast to
///     to %G_REGEX_MATCH_PARTIAL_SOFT, this stops matching as soon as a partial match
///     is found, without continuing to search for a possible complete match. See
///     g_match_info_is_partial_match() for more information. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_MATCH_PARTIAL_HARD = 134217728,
/// <summary>
/// <para>
/// Like %G_REGEX_MATCH_NOTEMPTY, but only applied to
///     the start of the matched string. For anchored
///     patterns this can only happen for pattern containing &quot;\K&quot;. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_MATCH_NOTEMPTY_ATSTART = 268435456
}
