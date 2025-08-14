namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Error codes returned by character set conversion routines.
/// </para>
/// </summary>

[Flags]
public enum GConvertError
{
/// <summary>
/// <para>
/// Conversion between the requested character
///     sets is not supported.
/// </para>
/// </summary>

	G_CONVERT_ERROR_NO_CONVERSION = 0,
/// <summary>
/// <para>
/// Invalid byte sequence in conversion input;
///    or the character sequence could not be represented in the target
///    character set.
/// </para>
/// </summary>

	G_CONVERT_ERROR_ILLEGAL_SEQUENCE = 1,
/// <summary>
/// <para>
/// Conversion failed for some reason.
/// </para>
/// </summary>

	G_CONVERT_ERROR_FAILED = 2,
/// <summary>
/// <para>
/// Partial character sequence at end of input.
/// </para>
/// </summary>

	G_CONVERT_ERROR_PARTIAL_INPUT = 3,
/// <summary>
/// <para>
/// URI is invalid.
/// </para>
/// </summary>

	G_CONVERT_ERROR_BAD_URI = 4,
/// <summary>
/// <para>
/// Pathname is not an absolute path.
/// </para>
/// </summary>

	G_CONVERT_ERROR_NOT_ABSOLUTE_PATH = 5,
/// <summary>
/// <para>
/// No memory available. Since: 2.40
/// </para>
/// </summary>

	G_CONVERT_ERROR_NO_MEMORY = 6,
/// <summary>
/// <para>
/// An embedded NUL character is present in
///     conversion output where a NUL-terminated string is expected.
///     Since: 2.56
/// </para>
/// </summary>

	G_CONVERT_ERROR_EMBEDDED_NUL = 7
}
