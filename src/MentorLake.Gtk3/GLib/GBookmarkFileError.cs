namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Error codes returned by bookmark file parsing.
/// </para>
/// </summary>

[Flags]
public enum GBookmarkFileError
{
/// <summary>
/// <para>
/// URI was ill-formed
/// </para>
/// </summary>

	G_BOOKMARK_FILE_ERROR_INVALID_URI = 0,
/// <summary>
/// <para>
/// a requested field was not found
/// </para>
/// </summary>

	G_BOOKMARK_FILE_ERROR_INVALID_VALUE = 1,
/// <summary>
/// <para>
/// a requested application did
///     not register a bookmark
/// </para>
/// </summary>

	G_BOOKMARK_FILE_ERROR_APP_NOT_REGISTERED = 2,
/// <summary>
/// <para>
/// a requested URI was not found
/// </para>
/// </summary>

	G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND = 3,
/// <summary>
/// <para>
/// document was ill formed
/// </para>
/// </summary>

	G_BOOKMARK_FILE_ERROR_READ = 4,
/// <summary>
/// <para>
/// the text being parsed was
///     in an unknown encoding
/// </para>
/// </summary>

	G_BOOKMARK_FILE_ERROR_UNKNOWN_ENCODING = 5,
/// <summary>
/// <para>
/// an error occurred while writing
/// </para>
/// </summary>

	G_BOOKMARK_FILE_ERROR_WRITE = 6,
/// <summary>
/// <para>
/// requested file was not found
/// </para>
/// </summary>

	G_BOOKMARK_FILE_ERROR_FILE_NOT_FOUND = 7
}
