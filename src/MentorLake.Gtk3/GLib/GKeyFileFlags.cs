namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags which influence the parsing.
/// </para>
/// </summary>

[Flags]
public enum GKeyFileFlags : uint
{
/// <summary>
/// <para>
/// No flags, default behaviour
/// </para>
/// </summary>

	G_KEY_FILE_NONE = 0,
/// <summary>
/// <para>
/// Use this flag if you plan to write the
///   (possibly modified) contents of the key file back to a file;
///   otherwise all comments will be lost when the key file is
///   written back.
/// </para>
/// </summary>

	G_KEY_FILE_KEEP_COMMENTS = 1,
/// <summary>
/// <para>
/// Use this flag if you plan to write the
///   (possibly modified) contents of the key file back to a file;
///   otherwise only the translations for the current language will be
///   written back.
/// </para>
/// </summary>

	G_KEY_FILE_KEEP_TRANSLATIONS = 2
}
