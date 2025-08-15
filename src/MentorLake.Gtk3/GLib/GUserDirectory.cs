namespace MentorLake.GLib;

/// <summary>
/// <para>
/// These are logical ids for special directories which are defined
/// depending on the platform used. You should use g_get_user_special_dir()
/// to retrieve the full path associated to the logical id.
/// </para>
/// <para>
/// The #GUserDirectory enumeration can be extended at later date. Not
/// every platform has a directory for every logical id in this
/// enumeration.
/// </para>
/// </summary>

[Flags]
public enum GUserDirectory
{
/// <summary>
/// <para>
/// the user&apos;s Desktop directory
/// </para>
/// </summary>

	G_USER_DIRECTORY_DESKTOP = 0,
/// <summary>
/// <para>
/// the user&apos;s Documents directory
/// </para>
/// </summary>

	G_USER_DIRECTORY_DOCUMENTS = 1,
/// <summary>
/// <para>
/// the user&apos;s Downloads directory
/// </para>
/// </summary>

	G_USER_DIRECTORY_DOWNLOAD = 2,
/// <summary>
/// <para>
/// the user&apos;s Music directory
/// </para>
/// </summary>

	G_USER_DIRECTORY_MUSIC = 3,
/// <summary>
/// <para>
/// the user&apos;s Pictures directory
/// </para>
/// </summary>

	G_USER_DIRECTORY_PICTURES = 4,
/// <summary>
/// <para>
/// the user&apos;s shared directory
/// </para>
/// </summary>

	G_USER_DIRECTORY_PUBLIC_SHARE = 5,
/// <summary>
/// <para>
/// the user&apos;s Templates directory
/// </para>
/// </summary>

	G_USER_DIRECTORY_TEMPLATES = 6,
/// <summary>
/// <para>
/// the user&apos;s Movies directory
/// </para>
/// </summary>

	G_USER_DIRECTORY_VIDEOS = 7,
/// <summary>
/// <para>
/// the number of enum values
/// </para>
/// </summary>

	G_USER_N_DIRECTORIES = 8
}
