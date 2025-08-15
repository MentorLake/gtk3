namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when an operation may create a file.
/// </para>
/// </summary>

[Flags]
public enum GFileCreateFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_FILE_CREATE_NONE = 0,
/// <summary>
/// <para>
/// Create a file that can only be
///    accessed by the current user.
/// </para>
/// </summary>

	G_FILE_CREATE_PRIVATE = 1,
/// <summary>
/// <para>
/// Replace the destination
///    as if it didn&apos;t exist before. Don&apos;t try to keep any old
///    permissions, replace instead of following links. This
///    is generally useful if you&apos;re doing a &quot;copy over&quot;
///    rather than a &quot;save new version of&quot; replace operation.
///    You can think of it as &quot;unlink destination&quot; before
///    writing to it, although the implementation may not
///    be exactly like that. This flag can only be used with
///    g_file_replace() and its variants, including g_file_replace_contents().
///    Since 2.20
/// </para>
/// </summary>

	G_FILE_CREATE_REPLACE_DESTINATION = 2
}
