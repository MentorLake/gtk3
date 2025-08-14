namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Application Information interface, for operating system portability.
/// </para>
/// </summary>

public class GAppInfoIfaceHandle : BaseSafeHandle
{
}


public static class GAppInfoIfaceExtensions
{

	public static GAppInfoIface Dereference(this GAppInfoIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GAppInfoIface>(x.DangerousGetHandle());
}
internal class GAppInfoIfaceExterns
{
}

/// <summary>
/// <para>
/// Application Information interface, for operating system portability.
/// </para>
/// </summary>

public struct GAppInfoIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Copies a [iface@Gio.AppInfo].
/// </para>
/// </summary>

public IntPtr dup;
	/// <summary>
/// <para>
/// Checks two [iface@Gio.AppInfo]s for equality.
/// </para>
/// </summary>

public IntPtr equal;
	/// <summary>
/// <para>
/// Gets a string identifier for a [iface@Gio.AppInfo].
/// </para>
/// </summary>

public IntPtr get_id;
	/// <summary>
/// <para>
/// Gets the name of the application for a [iface@Gio.AppInfo].
/// </para>
/// </summary>

public IntPtr get_name;
	/// <summary>
/// <para>
/// Gets a short description for the application described by
///   the [iface@Gio.AppInfo].
/// </para>
/// </summary>

public IntPtr get_description;
	/// <summary>
/// <para>
/// Gets the executable name for the [iface@Gio.AppInfo].
/// </para>
/// </summary>

public IntPtr get_executable;
	/// <summary>
/// <para>
/// Gets the [iface@Gio.Icon] for the [iface@Gio.AppInfo].
/// </para>
/// </summary>

public IntPtr get_icon;
	/// <summary>
/// <para>
/// Launches an application specified by the [iface@Gio.AppInfo].
/// </para>
/// </summary>

public IntPtr launch;
	/// <summary>
/// <para>
/// Indicates whether the application specified supports
///   launching URIs.
/// </para>
/// </summary>

public IntPtr supports_uris;
	/// <summary>
/// <para>
/// Indicates whether the application specified accepts
///   filename arguments.
/// </para>
/// </summary>

public IntPtr supports_files;
	/// <summary>
/// <para>
/// Launches an application with a list of URIs.
/// </para>
/// </summary>

public IntPtr launch_uris;
	/// <summary>
/// <para>
/// Returns whether an application should be shown (e.g. when
///   getting a list of installed applications).
///   [FreeDesktop.Org Startup Notification Specification](http://standards.freedesktop.org/startup-notification-spec/startup-notification-latest.txt).
/// </para>
/// </summary>

public IntPtr should_show;
	/// <summary>
/// <para>
/// Sets an application as default for a given content
///   type.
/// </para>
/// </summary>

public IntPtr set_as_default_for_type;
	/// <summary>
/// <para>
/// Sets an application as default for a given
///   file extension.
/// </para>
/// </summary>

public IntPtr set_as_default_for_extension;
	/// <summary>
/// <para>
/// Adds to the [iface@Gio.AppInfo] information about
///   supported file types.
/// </para>
/// </summary>

public IntPtr add_supports_type;
	/// <summary>
/// <para>
/// Checks for support for removing supported file
///   types from a [iface@Gio.AppInfo].
/// </para>
/// </summary>

public IntPtr can_remove_supports_type;
	/// <summary>
/// <para>
/// Removes a supported application type from a
///   [iface@Gio.AppInfo].
/// </para>
/// </summary>

public IntPtr remove_supports_type;
	/// <summary>
/// <para>
/// Checks if a [iface@Gio.AppInfo] can be deleted. (Since 2.20)
/// </para>
/// </summary>

public IntPtr can_delete;
	/// <summary>
/// <para>
/// Deletes a [iface@Gio.AppInfo]. (Since 2.20)
/// </para>
/// </summary>

public IntPtr do_delete;
	/// <summary>
/// <para>
/// Gets the commandline for the [iface@Gio.AppInfo].
///   (Since 2.20)
/// </para>
/// </summary>

public IntPtr get_commandline;
	/// <summary>
/// <para>
/// Gets the display name for the [iface@Gio.AppInfo].
///   (Since 2.24)
/// </para>
/// </summary>

public IntPtr get_display_name;
	/// <summary>
/// <para>
/// Sets the application as the last used. See
///   [method@Gio.AppInfo.set_as_last_used_for_type].
/// </para>
/// </summary>

public IntPtr set_as_last_used_for_type;
	/// <summary>
/// <para>
/// Retrieves the list of content types that @app_info
///   claims to support.
/// </para>
/// </summary>

public IntPtr get_supported_types;
	/// <summary>
/// <para>
/// Asynchronously launches an application with a list of
///   URIs. (Since: 2.60)
/// </para>
/// </summary>

public IntPtr launch_uris_async;
	/// <summary>
/// <para>
/// Finishes an operation started with @launch_uris_async.
///   (Since: 2.60)
/// </para>
/// </summary>

public IntPtr launch_uris_finish;
}
