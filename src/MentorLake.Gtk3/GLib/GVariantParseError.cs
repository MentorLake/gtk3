namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Error codes returned by parsing text-format GVariants.
/// </para>
/// </summary>

[Flags]
public enum GVariantParseError
{
/// <summary>
/// <para>
/// generic error (unused)
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_FAILED = 0,
/// <summary>
/// <para>
/// a non-basic #GVariantType was given where a basic type was expected
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_BASIC_TYPE_EXPECTED = 1,
/// <summary>
/// <para>
/// cannot infer the #GVariantType
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_CANNOT_INFER_TYPE = 2,
/// <summary>
/// <para>
/// an indefinite #GVariantType was given where a definite type was expected
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_DEFINITE_TYPE_EXPECTED = 3,
/// <summary>
/// <para>
/// extra data after parsing finished
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_INPUT_NOT_AT_END = 4,
/// <summary>
/// <para>
/// invalid character in number or unicode escape
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_INVALID_CHARACTER = 5,
/// <summary>
/// <para>
/// not a valid #GVariant format string
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_INVALID_FORMAT_STRING = 6,
/// <summary>
/// <para>
/// not a valid object path
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_INVALID_OBJECT_PATH = 7,
/// <summary>
/// <para>
/// not a valid type signature
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_INVALID_SIGNATURE = 8,
/// <summary>
/// <para>
/// not a valid #GVariant type string
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_INVALID_TYPE_STRING = 9,
/// <summary>
/// <para>
/// could not find a common type for array entries
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_NO_COMMON_TYPE = 10,
/// <summary>
/// <para>
/// the numerical value is out of range of the given type
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_NUMBER_OUT_OF_RANGE = 11,
/// <summary>
/// <para>
/// the numerical value is out of range for any type
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_NUMBER_TOO_BIG = 12,
/// <summary>
/// <para>
/// cannot parse as variant of the specified type
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_TYPE_ERROR = 13,
/// <summary>
/// <para>
/// an unexpected token was encountered
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_UNEXPECTED_TOKEN = 14,
/// <summary>
/// <para>
/// an unknown keyword was encountered
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_UNKNOWN_KEYWORD = 15,
/// <summary>
/// <para>
/// unterminated string constant
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_UNTERMINATED_STRING_CONSTANT = 16,
/// <summary>
/// <para>
/// no value given
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_VALUE_EXPECTED = 17,
/// <summary>
/// <para>
/// variant was too deeply nested; #GVariant is only guaranteed to handle nesting up to 64 levels (Since: 2.64)
/// </para>
/// </summary>

	G_VARIANT_PARSE_ERROR_RECURSION = 18
}
