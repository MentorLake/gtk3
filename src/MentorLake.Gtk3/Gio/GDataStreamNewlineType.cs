namespace MentorLake.Gio;

/// <summary>
/// <para>
/// #GDataStreamNewlineType is used when checking for or setting the line endings for a given file.
/// </para>
/// </summary>

[Flags]
public enum GDataStreamNewlineType
{
/// <summary>
/// <para>
/// Selects "LF" line endings, common on most modern UNIX platforms.
/// </para>
/// </summary>

	G_DATA_STREAM_NEWLINE_TYPE_LF = 0,
/// <summary>
/// <para>
/// Selects "CR" line endings.
/// </para>
/// </summary>

	G_DATA_STREAM_NEWLINE_TYPE_CR = 1,
/// <summary>
/// <para>
/// Selects "CR, LF" line ending, common on Microsoft Windows.
/// </para>
/// </summary>

	G_DATA_STREAM_NEWLINE_TYPE_CR_LF = 2,
/// <summary>
/// <para>
/// Automatically try to handle any line ending type.
/// </para>
/// </summary>

	G_DATA_STREAM_NEWLINE_TYPE_ANY = 3
}
