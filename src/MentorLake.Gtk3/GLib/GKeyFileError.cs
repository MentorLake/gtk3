namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Error codes returned by key file parsing.
/// </para>
/// </summary>

[Flags]
public enum GKeyFileError
{
/// <summary>
/// <para>
/// the text being parsed was in
///   an unknown encoding
/// </para>
/// </summary>

	G_KEY_FILE_ERROR_UNKNOWN_ENCODING = 0,
/// <summary>
/// <para>
/// document was ill-formed
/// </para>
/// </summary>

	G_KEY_FILE_ERROR_PARSE = 1,
/// <summary>
/// <para>
/// the file was not found
/// </para>
/// </summary>

	G_KEY_FILE_ERROR_NOT_FOUND = 2,
/// <summary>
/// <para>
/// a requested key was not found
/// </para>
/// </summary>

	G_KEY_FILE_ERROR_KEY_NOT_FOUND = 3,
/// <summary>
/// <para>
/// a requested group was not found
/// </para>
/// </summary>

	G_KEY_FILE_ERROR_GROUP_NOT_FOUND = 4,
/// <summary>
/// <para>
/// a value could not be parsed
/// </para>
/// </summary>

	G_KEY_FILE_ERROR_INVALID_VALUE = 5
}
