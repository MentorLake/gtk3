namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The possible errors, used in the @v_error field
/// of #GTokenValue, when the token is a %G_TOKEN_ERROR.
/// </para>
/// </summary>

[Flags]
public enum GErrorType
{
/// <summary>
/// <para>
/// unknown error
/// </para>
/// </summary>

	G_ERR_UNKNOWN = 0,
/// <summary>
/// <para>
/// unexpected end of file
/// </para>
/// </summary>

	G_ERR_UNEXP_EOF = 1,
/// <summary>
/// <para>
/// unterminated string constant
/// </para>
/// </summary>

	G_ERR_UNEXP_EOF_IN_STRING = 2,
/// <summary>
/// <para>
/// unterminated comment
/// </para>
/// </summary>

	G_ERR_UNEXP_EOF_IN_COMMENT = 3,
/// <summary>
/// <para>
/// non-digit character in a number
/// </para>
/// </summary>

	G_ERR_NON_DIGIT_IN_CONST = 4,
/// <summary>
/// <para>
/// digit beyond radix in a number
/// </para>
/// </summary>

	G_ERR_DIGIT_RADIX = 5,
/// <summary>
/// <para>
/// non-decimal floating point number
/// </para>
/// </summary>

	G_ERR_FLOAT_RADIX = 6,
/// <summary>
/// <para>
/// malformed floating point number
/// </para>
/// </summary>

	G_ERR_FLOAT_MALFORMED = 7
}
