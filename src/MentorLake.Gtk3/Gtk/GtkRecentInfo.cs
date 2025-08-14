namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkRecentInfo-struct contains private data only, and should
/// be accessed using the provided API.
/// </para>
/// <para>
/// #GtkRecentInfo constains all the meta-data
/// associated with an entry in the recently used files list.
/// </para>
/// </summary>

public class GtkRecentInfoHandle : BaseSafeHandle
{
}


public static class GtkRecentInfoExtensions
{
/// <summary>
/// <para>
/// Creates a #GAppInfo for the specified #GtkRecentInfo
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <param name="app_name">
/// the name of the application that should
///   be mapped to a #GAppInfo; if %NULL is used then the default
///   application for the MIME type is used
/// </param>
/// <return>
/// the newly created #GAppInfo, or %NULL.
///   In case of error, @error will be set either with a
///   %GTK_RECENT_MANAGER_ERROR or a %G_IO_ERROR
/// </return>

	public static MentorLake.Gio.GAppInfoHandle CreateAppInfo(this MentorLake.Gtk.GtkRecentInfoHandle info, string app_name)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		var externCallResult = GtkRecentInfoExterns.gtk_recent_info_create_app_info(info, app_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks whether the resource pointed by @info still exists.
/// At the moment this check is done only on resources pointing
/// to local files.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// %TRUE if the resource exists
/// </return>

	public static bool Exists(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_exists(info);
	}

/// <summary>
/// <para>
/// Gets the timestamp (seconds from system’s Epoch) when the resource
/// was added to the recently used resources list.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// the number of seconds elapsed from system’s Epoch when
///   the resource was added to the list, or -1 on failure.
/// </return>

	public static long GetAdded(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_added(info);
	}

/// <summary>
/// <para>
/// Gets the number of days elapsed since the last update
/// of the resource pointed by @info.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// a positive integer containing the number of days
///   elapsed since the time this resource was last modified
/// </return>

	public static int GetAge(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_age(info);
	}

/// <summary>
/// <para>
/// Gets the data regarding the application that has registered the resource
/// pointed by @info.
/// </para>
/// <para>
/// If the command line contains any escape characters defined inside the
/// storage specification, they will be expanded.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <param name="app_name">
/// the name of the application that has registered this item
/// </param>
/// <param name="app_exec">
/// return location for the string containing
///    the command line
/// </param>
/// <param name="count">
/// return location for the number of times this item was registered
/// </param>
/// <param name="time_">
/// return location for the timestamp this item was last registered
///    for this application
/// </param>
/// <return>
/// %TRUE if an application with @app_name has registered this
///   resource inside the recently used list, or %FALSE otherwise. The
///   @app_exec string is owned by the #GtkRecentInfo and should not be
///   modified or freed
/// </return>

	public static bool GetApplicationInfo(this MentorLake.Gtk.GtkRecentInfoHandle info, string app_name, out string app_exec, out uint count, out long time_)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_application_info(info, app_name, out app_exec, out count, out time_);
	}

/// <summary>
/// <para>
/// Retrieves the list of applications that have registered this resource.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <param name="length">
/// return location for the length of the returned list
/// </param>
/// <return>
/// 
///     a newly allocated %NULL-terminated array of strings.
///     Use g_strfreev() to free it.
/// </return>

	public static string[] GetApplications(this MentorLake.Gtk.GtkRecentInfoHandle info, out UIntPtr length)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_applications(info, out length);
	}

/// <summary>
/// <para>
/// Gets the (short) description of the resource.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// the description of the resource. The returned string
///   is owned by the recent manager, and should not be freed.
/// </return>

	public static string GetDescription(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_description(info);
	}

/// <summary>
/// <para>
/// Gets the name of the resource. If none has been defined, the basename
/// of the resource is obtained.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// the display name of the resource. The returned string
///   is owned by the recent manager, and should not be freed.
/// </return>

	public static string GetDisplayName(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_display_name(info);
	}

/// <summary>
/// <para>
/// Retrieves the icon associated to the resource MIME type.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// a #GIcon containing the icon, or %NULL.
///   Use g_object_unref() when finished using the icon
/// </return>

	public static MentorLake.Gio.GIconHandle GetGicon(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_gicon(info);
	}

/// <summary>
/// <para>
/// Returns all groups registered for the recently used item @info.
/// The array of returned group names will be %NULL terminated, so
/// length might optionally be %NULL.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <param name="length">
/// return location for the number of groups returned
/// </param>
/// <return>
/// 
///   a newly allocated %NULL terminated array of strings.
///   Use g_strfreev() to free it.
/// </return>

	public static string[] GetGroups(this MentorLake.Gtk.GtkRecentInfoHandle info, out UIntPtr length)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_groups(info, out length);
	}

/// <summary>
/// <para>
/// Retrieves the icon of size @size associated to the resource MIME type.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <param name="size">
/// the size of the icon in pixels
/// </param>
/// <return>
/// a #GdkPixbuf containing the icon,
///     or %NULL. Use g_object_unref() when finished using the icon.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetIcon(this MentorLake.Gtk.GtkRecentInfoHandle info, int size)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_icon(info, size);
	}

/// <summary>
/// <para>
/// Gets the MIME type of the resource.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// the MIME type of the resource. The returned string
///   is owned by the recent manager, and should not be freed.
/// </return>

	public static string GetMimeType(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_mime_type(info);
	}

/// <summary>
/// <para>
/// Gets the timestamp (seconds from system’s Epoch) when the meta-data
/// for the resource was last modified.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// the number of seconds elapsed from system’s Epoch when
///   the resource was last modified, or -1 on failure.
/// </return>

	public static long GetModified(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_modified(info);
	}

/// <summary>
/// <para>
/// Gets the value of the “private” flag. Resources in the recently used
/// list that have this flag set to %TRUE should only be displayed by the
/// applications that have registered them.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// %TRUE if the private flag was found, %FALSE otherwise
/// </return>

	public static bool GetPrivateHint(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_private_hint(info);
	}

/// <summary>
/// <para>
/// Computes a valid UTF-8 string that can be used as the
/// name of the item in a menu or list. For example, calling
/// this function on an item that refers to
/// “file:///foo/bar.txt” will yield “bar.txt”.
/// </para>
/// </summary>

/// <param name="info">
/// an #GtkRecentInfo
/// </param>
/// <return>
/// A newly-allocated string in UTF-8 encoding
///   free it with g_free()
/// </return>

	public static string GetShortName(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_short_name(info);
	}

/// <summary>
/// <para>
/// Gets the URI of the resource.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// the URI of the resource. The returned string is
///   owned by the recent manager, and should not be freed.
/// </return>

	public static string GetUri(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_uri(info);
	}

/// <summary>
/// <para>
/// Gets a displayable version of the resource’s URI. If the resource
/// is local, it returns a local path; if the resource is not local,
/// it returns the UTF-8 encoded content of gtk_recent_info_get_uri().
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// a newly allocated UTF-8 string containing the
///   resource’s URI or %NULL. Use g_free() when done using it.
/// </return>

	public static string GetUriDisplay(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_uri_display(info);
	}

/// <summary>
/// <para>
/// Gets the timestamp (seconds from system’s Epoch) when the meta-data
/// for the resource was last visited.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// the number of seconds elapsed from system’s Epoch when
///   the resource was last visited, or -1 on failure.
/// </return>

	public static long GetVisited(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_get_visited(info);
	}

/// <summary>
/// <para>
/// Checks whether an application registered this resource using @app_name.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <param name="app_name">
/// a string containing an application name
/// </param>
/// <return>
/// %TRUE if an application with name @app_name was found,
///   %FALSE otherwise
/// </return>

	public static bool HasApplication(this MentorLake.Gtk.GtkRecentInfoHandle info, string app_name)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_has_application(info, app_name);
	}

/// <summary>
/// <para>
/// Checks whether @group_name appears inside the groups
/// registered for the recently used item @info.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <param name="group_name">
/// name of a group
/// </param>
/// <return>
/// %TRUE if the group was found
/// </return>

	public static bool HasGroup(this MentorLake.Gtk.GtkRecentInfoHandle info, string group_name)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_has_group(info, group_name);
	}

/// <summary>
/// <para>
/// Checks whether the resource is local or not by looking at the
/// scheme of its URI.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// %TRUE if the resource is local
/// </return>

	public static bool IsLocal(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_is_local(info);
	}

/// <summary>
/// <para>
/// Gets the name of the last application that have registered the
/// recently used resource represented by @info.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// an application name. Use g_free() to free it.
/// </return>

	public static string LastApplication(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_last_application(info);
	}

/// <summary>
/// <para>
/// Checks whether two #GtkRecentInfo-struct point to the same
/// resource.
/// </para>
/// </summary>

/// <param name="info_a">
/// a #GtkRecentInfo
/// </param>
/// <param name="info_b">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// %TRUE if both #GtkRecentInfo-struct point to the same
///   resource, %FALSE otherwise
/// </return>

	public static bool Match(this MentorLake.Gtk.GtkRecentInfoHandle info_a, MentorLake.Gtk.GtkRecentInfoHandle info_b)
	{
		if (info_a.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_match(info_a, info_b);
	}

/// <summary>
/// <para>
/// Increases the reference count of @recent_info by one.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>
/// <return>
/// the recent info object with its reference count
///     increased by one
/// </return>

	public static MentorLake.Gtk.GtkRecentInfoHandle Ref(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		return GtkRecentInfoExterns.gtk_recent_info_ref(info);
	}

/// <summary>
/// <para>
/// Decreases the reference count of @info by one. If the reference
/// count reaches zero, @info is deallocated, and the memory freed.
/// </para>
/// </summary>

/// <param name="info">
/// a #GtkRecentInfo
/// </param>

	public static void Unref(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GtkRecentInfo)");
		GtkRecentInfoExterns.gtk_recent_info_unref(info);
	}


	public static GtkRecentInfo Dereference(this GtkRecentInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentInfo>(x.DangerousGetHandle());
}
internal class GtkRecentInfoExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle gtk_recent_info_create_app_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, string app_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_exists([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern long gtk_recent_info_get_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_recent_info_get_age([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_get_application_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, string app_name, out string app_exec, out uint count, out long time_);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_recent_info_get_applications([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, out UIntPtr length);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle gtk_recent_info_get_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_recent_info_get_groups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, out UIntPtr length);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_recent_info_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, int size);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern long gtk_recent_info_get_modified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_get_private_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_short_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_uri_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern long gtk_recent_info_get_visited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_has_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, string app_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_has_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, string group_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_is_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_last_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info_a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info_b);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentInfoHandle gtk_recent_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

}

/// <summary>
/// <para>
/// #GtkRecentInfo-struct contains private data only, and should
/// be accessed using the provided API.
/// </para>
/// <para>
/// #GtkRecentInfo constains all the meta-data
/// associated with an entry in the recently used files list.
/// </para>
/// </summary>

public struct GtkRecentInfo
{
}
