namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Error codes returned by regular expressions functions.
/// </para>
/// </summary>

[Flags]
public enum GRegexError
{
/// <summary>
/// <para>
/// Compilation of the regular expression failed.
/// </para>
/// </summary>

	G_REGEX_ERROR_COMPILE = 0,
/// <summary>
/// <para>
/// Optimization of the regular expression failed.
/// </para>
/// </summary>

	G_REGEX_ERROR_OPTIMIZE = 1,
/// <summary>
/// <para>
/// Replacement failed due to an ill-formed replacement
///     string.
/// </para>
/// </summary>

	G_REGEX_ERROR_REPLACE = 2,
/// <summary>
/// <para>
/// The match process failed.
/// </para>
/// </summary>

	G_REGEX_ERROR_MATCH = 3,
/// <summary>
/// <para>
/// Internal error of the regular expression engine.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_INTERNAL = 4,
/// <summary>
/// <para>
/// &quot;\\&quot; at end of pattern. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_STRAY_BACKSLASH = 101,
/// <summary>
/// <para>
/// &quot;\\c&quot; at end of pattern. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_MISSING_CONTROL_CHAR = 102,
/// <summary>
/// <para>
/// Unrecognized character follows &quot;\\&quot;.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_UNRECOGNIZED_ESCAPE = 103,
/// <summary>
/// <para>
/// Numbers out of order in &quot;{}&quot;
///     quantifier. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_QUANTIFIERS_OUT_OF_ORDER = 104,
/// <summary>
/// <para>
/// Number too big in &quot;{}&quot; quantifier.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_QUANTIFIER_TOO_BIG = 105,
/// <summary>
/// <para>
/// Missing terminating &quot;]&quot; for
///     character class. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_UNTERMINATED_CHARACTER_CLASS = 106,
/// <summary>
/// <para>
/// Invalid escape sequence
///     in character class. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_INVALID_ESCAPE_IN_CHARACTER_CLASS = 107,
/// <summary>
/// <para>
/// Range out of order in character class.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_RANGE_OUT_OF_ORDER = 108,
/// <summary>
/// <para>
/// Nothing to repeat. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_NOTHING_TO_REPEAT = 109,
/// <summary>
/// <para>
/// Unrecognized character after &quot;(?&quot;,
///     &quot;(?&amp;lt;&quot; or &quot;(?P&quot;. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_UNRECOGNIZED_CHARACTER = 112,
/// <summary>
/// <para>
/// POSIX named classes are
///     supported only within a class. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_POSIX_NAMED_CLASS_OUTSIDE_CLASS = 113,
/// <summary>
/// <para>
/// Missing terminating &quot;)&quot; or &quot;)&quot;
///     without opening &quot;(&quot;. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_UNMATCHED_PARENTHESIS = 114,
/// <summary>
/// <para>
/// Reference to non-existent
///     subpattern. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_INEXISTENT_SUBPATTERN_REFERENCE = 115,
/// <summary>
/// <para>
/// Missing terminating &quot;)&quot; after comment.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_UNTERMINATED_COMMENT = 118,
/// <summary>
/// <para>
/// Regular expression too large.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_EXPRESSION_TOO_LARGE = 120,
/// <summary>
/// <para>
/// Failed to get memory. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_MEMORY_ERROR = 121,
/// <summary>
/// <para>
/// Lookbehind assertion is not
///     fixed length. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_VARIABLE_LENGTH_LOOKBEHIND = 125,
/// <summary>
/// <para>
/// Malformed number or name after &quot;(?(&quot;.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_MALFORMED_CONDITION = 126,
/// <summary>
/// <para>
/// Conditional group contains
///     more than two branches. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_TOO_MANY_CONDITIONAL_BRANCHES = 127,
/// <summary>
/// <para>
/// Assertion expected after &quot;(?(&quot;.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_ASSERTION_EXPECTED = 128,
/// <summary>
/// <para>
/// Unknown POSIX class name.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_UNKNOWN_POSIX_CLASS_NAME = 130,
/// <summary>
/// <para>
/// POSIX collating
///     elements are not supported. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_POSIX_COLLATING_ELEMENTS_NOT_SUPPORTED = 131,
/// <summary>
/// <para>
/// Character value in &quot;\\x{...}&quot; sequence
///     is too large. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_HEX_CODE_TOO_LARGE = 134,
/// <summary>
/// <para>
/// Invalid condition &quot;(?(0)&quot;. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_INVALID_CONDITION = 135,
/// <summary>
/// <para>
/// \\C not allowed in
///     lookbehind assertion. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_SINGLE_BYTE_MATCH_IN_LOOKBEHIND = 136,
/// <summary>
/// <para>
/// Recursive call could loop indefinitely.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_INFINITE_LOOP = 140,
/// <summary>
/// <para>
/// Missing terminator
///     in subpattern name. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_MISSING_SUBPATTERN_NAME_TERMINATOR = 142,
/// <summary>
/// <para>
/// Two named subpatterns have
///     the same name. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_DUPLICATE_SUBPATTERN_NAME = 143,
/// <summary>
/// <para>
/// Malformed &quot;\\P&quot; or &quot;\\p&quot; sequence.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_MALFORMED_PROPERTY = 146,
/// <summary>
/// <para>
/// Unknown property name after &quot;\\P&quot; or
///     &quot;\\p&quot;. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_UNKNOWN_PROPERTY = 147,
/// <summary>
/// <para>
/// Subpattern name is too long
///     (maximum 32 characters). Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_SUBPATTERN_NAME_TOO_LONG = 148,
/// <summary>
/// <para>
/// Too many named subpatterns (maximum
///     10,000). Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_TOO_MANY_SUBPATTERNS = 149,
/// <summary>
/// <para>
/// Octal value is greater than &quot;\\377&quot;.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_INVALID_OCTAL_VALUE = 151,
/// <summary>
/// <para>
/// &quot;DEFINE&quot; group contains more
///     than one branch. Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_TOO_MANY_BRANCHES_IN_DEFINE = 154,
/// <summary>
/// <para>
/// Repeating a &quot;DEFINE&quot; group is not allowed.
///     This error is never raised. Since: 2.16 Deprecated: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_DEFINE_REPETION = 155,
/// <summary>
/// <para>
/// Inconsistent newline options.
///     Since 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_INCONSISTENT_NEWLINE_OPTIONS = 156,
/// <summary>
/// <para>
/// &quot;\\g&quot; is not followed by a braced,
///      angle-bracketed, or quoted name or number, or by a plain number. Since: 2.16
/// </para>
/// </summary>

	G_REGEX_ERROR_MISSING_BACK_REFERENCE = 157,
/// <summary>
/// <para>
/// relative reference must not be zero. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_INVALID_RELATIVE_REFERENCE = 158,
/// <summary>
/// <para>
/// the backtracing
///     control verb used does not allow an argument. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_BACKTRACKING_CONTROL_VERB_ARGUMENT_FORBIDDEN = 159,
/// <summary>
/// <para>
/// unknown backtracing
///     control verb. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_UNKNOWN_BACKTRACKING_CONTROL_VERB = 160,
/// <summary>
/// <para>
/// number is too big in escape sequence. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_NUMBER_TOO_BIG = 161,
/// <summary>
/// <para>
/// Missing subpattern name. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_MISSING_SUBPATTERN_NAME = 162,
/// <summary>
/// <para>
/// Missing digit. Since 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_MISSING_DIGIT = 163,
/// <summary>
/// <para>
/// In JavaScript compatibility mode,
///     &quot;[&quot; is an invalid data character. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_INVALID_DATA_CHARACTER = 164,
/// <summary>
/// <para>
/// different names for subpatterns of the
///     same number are not allowed. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_EXTRA_SUBPATTERN_NAME = 165,
/// <summary>
/// <para>
/// the backtracing control
///     verb requires an argument. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_BACKTRACKING_CONTROL_VERB_ARGUMENT_REQUIRED = 166,
/// <summary>
/// <para>
/// &quot;\\c&quot; must be followed by an ASCII
///     character. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_INVALID_CONTROL_CHAR = 168,
/// <summary>
/// <para>
/// &quot;\\k&quot; is not followed by a braced, angle-bracketed, or
///     quoted name. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_MISSING_NAME = 169,
/// <summary>
/// <para>
/// &quot;\\N&quot; is not supported in a class. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_NOT_SUPPORTED_IN_CLASS = 171,
/// <summary>
/// <para>
/// too many forward references. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_TOO_MANY_FORWARD_REFERENCES = 172,
/// <summary>
/// <para>
/// the name is too long in &quot;(*MARK)&quot;, &quot;(*PRUNE)&quot;,
///     &quot;(*SKIP)&quot;, or &quot;(*THEN)&quot;. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_NAME_TOO_LONG = 175,
/// <summary>
/// <para>
/// the character value in the \\u sequence is
///     too large. Since: 2.34
/// </para>
/// </summary>

	G_REGEX_ERROR_CHARACTER_VALUE_TOO_LARGE = 176
}
