namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Error codes for #GtkRecentManager operations
/// </para>
/// </summary>

[Flags]
public enum GtkRecentManagerError
{
/// <summary>
/// <para>
/// the URI specified does not exists in
///   the recently used resources list.
/// </para>
/// </summary>

	GTK_RECENT_MANAGER_ERROR_NOT_FOUND = 0,
/// <summary>
/// <para>
/// the URI specified is not valid.
/// </para>
/// </summary>

	GTK_RECENT_MANAGER_ERROR_INVALID_URI = 1,
/// <summary>
/// <para>
/// the supplied string is not
///   UTF-8 encoded.
/// </para>
/// </summary>

	GTK_RECENT_MANAGER_ERROR_INVALID_ENCODING = 2,
/// <summary>
/// <para>
/// no application has registered
///   the specified item.
/// </para>
/// </summary>

	GTK_RECENT_MANAGER_ERROR_NOT_REGISTERED = 3,
/// <summary>
/// <para>
/// failure while reading the recently used
///   resources file.
/// </para>
/// </summary>

	GTK_RECENT_MANAGER_ERROR_READ = 4,
/// <summary>
/// <para>
/// failure while writing the recently used
///   resources file.
/// </para>
/// </summary>

	GTK_RECENT_MANAGER_ERROR_WRITE = 5,
/// <summary>
/// <para>
/// unspecified error.
/// </para>
/// </summary>

	GTK_RECENT_MANAGER_ERROR_UNKNOWN = 6
}
