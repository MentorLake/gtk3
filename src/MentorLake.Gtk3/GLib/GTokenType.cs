namespace MentorLake.GLib;

[Flags]
public enum GTokenType
{
	G_TOKEN_EOF = 0,
	G_TOKEN_LEFT_PAREN = 40,
	G_TOKEN_RIGHT_PAREN = 41,
	G_TOKEN_LEFT_CURLY = 123,
	G_TOKEN_RIGHT_CURLY = 125,
	G_TOKEN_LEFT_BRACE = 91,
	G_TOKEN_RIGHT_BRACE = 93,
	G_TOKEN_EQUAL_SIGN = 61,
	G_TOKEN_COMMA = 44,
	G_TOKEN_NONE = 256,
	G_TOKEN_ERROR = 257,
	G_TOKEN_CHAR = 258,
	G_TOKEN_BINARY = 259,
	G_TOKEN_OCTAL = 260,
	G_TOKEN_INT = 261,
	G_TOKEN_HEX = 262,
	G_TOKEN_FLOAT = 263,
	G_TOKEN_STRING = 264,
	G_TOKEN_SYMBOL = 265,
	G_TOKEN_IDENTIFIER = 266,
	G_TOKEN_IDENTIFIER_NULL = 267,
	G_TOKEN_COMMENT_SINGLE = 268,
	G_TOKEN_COMMENT_MULTI = 269
}
