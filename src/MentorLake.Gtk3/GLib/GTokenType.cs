namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The possible types of token returned from each
/// g_scanner_get_next_token() call.
/// </para>
/// </summary>

[Flags]
public enum GTokenType
{
/// <summary>
/// <para>
/// the end of the file
/// </para>
/// </summary>

	G_TOKEN_EOF = 0,
/// <summary>
/// <para>
/// a '(' character
/// </para>
/// </summary>

	G_TOKEN_LEFT_PAREN = 40,
/// <summary>
/// <para>
/// a ')' character
/// </para>
/// </summary>

	G_TOKEN_RIGHT_PAREN = 41,
/// <summary>
/// <para>
/// a '{' character
/// </para>
/// </summary>

	G_TOKEN_LEFT_CURLY = 123,
/// <summary>
/// <para>
/// a '}' character
/// </para>
/// </summary>

	G_TOKEN_RIGHT_CURLY = 125,
/// <summary>
/// <para>
/// a '[' character
/// </para>
/// </summary>

	G_TOKEN_LEFT_BRACE = 91,
/// <summary>
/// <para>
/// a ']' character
/// </para>
/// </summary>

	G_TOKEN_RIGHT_BRACE = 93,
/// <summary>
/// <para>
/// a '=' character
/// </para>
/// </summary>

	G_TOKEN_EQUAL_SIGN = 61,
/// <summary>
/// <para>
/// a ',' character
/// </para>
/// </summary>

	G_TOKEN_COMMA = 44,
/// <summary>
/// <para>
/// not a token
/// </para>
/// </summary>

	G_TOKEN_NONE = 256,
/// <summary>
/// <para>
/// an error occurred
/// </para>
/// </summary>

	G_TOKEN_ERROR = 257,
/// <summary>
/// <para>
/// a character
/// </para>
/// </summary>

	G_TOKEN_CHAR = 258,
/// <summary>
/// <para>
/// a binary integer
/// </para>
/// </summary>

	G_TOKEN_BINARY = 259,
/// <summary>
/// <para>
/// an octal integer
/// </para>
/// </summary>

	G_TOKEN_OCTAL = 260,
/// <summary>
/// <para>
/// an integer
/// </para>
/// </summary>

	G_TOKEN_INT = 261,
/// <summary>
/// <para>
/// a hex integer
/// </para>
/// </summary>

	G_TOKEN_HEX = 262,
/// <summary>
/// <para>
/// a floating point number
/// </para>
/// </summary>

	G_TOKEN_FLOAT = 263,
/// <summary>
/// <para>
/// a string
/// </para>
/// </summary>

	G_TOKEN_STRING = 264,
/// <summary>
/// <para>
/// a symbol
/// </para>
/// </summary>

	G_TOKEN_SYMBOL = 265,
/// <summary>
/// <para>
/// an identifier
/// </para>
/// </summary>

	G_TOKEN_IDENTIFIER = 266,
/// <summary>
/// <para>
/// a null identifier
/// </para>
/// </summary>

	G_TOKEN_IDENTIFIER_NULL = 267,
/// <summary>
/// <para>
/// one line comment
/// </para>
/// </summary>

	G_TOKEN_COMMENT_SINGLE = 268,
/// <summary>
/// <para>
/// multi line comment
/// </para>
/// </summary>

	G_TOKEN_COMMENT_MULTI = 269
}
