namespace MentorLake.Gtk;

public interface GtkRecentChooserHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkRecentChooserHandleImpl : BaseSafeHandle, GtkRecentChooserHandle
{
}

public static class GtkRecentChooserHandleExtensions
{
	public static T AddFilter<T>(this T chooser, MentorLake.Gtk.GtkRecentFilterHandle filter) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_add_filter(chooser, filter);
		return chooser;
	}

	public static MentorLake.Gtk.GtkRecentInfoHandle GetCurrentItem(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_current_item(chooser);
	}

	public static string GetCurrentUri(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_current_uri(chooser);
	}

	public static MentorLake.Gtk.GtkRecentFilterHandle GetFilter(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_filter(chooser);
	}

	public static MentorLake.GLib.GListHandle GetItems(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_items(chooser);
	}

	public static int GetLimit(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_limit(chooser);
	}

	public static bool GetLocalOnly(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_local_only(chooser);
	}

	public static bool GetSelectMultiple(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_select_multiple(chooser);
	}

	public static bool GetShowIcons(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_show_icons(chooser);
	}

	public static bool GetShowNotFound(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_show_not_found(chooser);
	}

	public static bool GetShowPrivate(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_show_private(chooser);
	}

	public static bool GetShowTips(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_show_tips(chooser);
	}

	public static MentorLake.Gtk.GtkRecentSortType GetSortType(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_sort_type(chooser);
	}

	public static string[] GetUris(this MentorLake.Gtk.GtkRecentChooserHandle chooser, out UIntPtr length)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_uris(chooser, out length);
	}

	public static MentorLake.GLib.GSListHandle ListFilters(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_list_filters(chooser);
	}

	public static T RemoveFilter<T>(this T chooser, MentorLake.Gtk.GtkRecentFilterHandle filter) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_remove_filter(chooser, filter);
		return chooser;
	}

	public static T SelectAll<T>(this T chooser) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_select_all(chooser);
		return chooser;
	}

	public static bool SelectUri(this MentorLake.Gtk.GtkRecentChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		var externCallResult = GtkRecentChooserHandleExterns.gtk_recent_chooser_select_uri(chooser, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool SetCurrentUri(this MentorLake.Gtk.GtkRecentChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		var externCallResult = GtkRecentChooserHandleExterns.gtk_recent_chooser_set_current_uri(chooser, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetFilter<T>(this T chooser, MentorLake.Gtk.GtkRecentFilterHandle filter) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_filter(chooser, filter);
		return chooser;
	}

	public static T SetLimit<T>(this T chooser, int limit) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_limit(chooser, limit);
		return chooser;
	}

	public static T SetLocalOnly<T>(this T chooser, bool local_only) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_local_only(chooser, local_only);
		return chooser;
	}

	public static T SetSelectMultiple<T>(this T chooser, bool select_multiple) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_select_multiple(chooser, select_multiple);
		return chooser;
	}

	public static T SetShowIcons<T>(this T chooser, bool show_icons) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_show_icons(chooser, show_icons);
		return chooser;
	}

	public static T SetShowNotFound<T>(this T chooser, bool show_not_found) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_show_not_found(chooser, show_not_found);
		return chooser;
	}

	public static T SetShowPrivate<T>(this T chooser, bool show_private) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_show_private(chooser, show_private);
		return chooser;
	}

	public static T SetShowTips<T>(this T chooser, bool show_tips) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_show_tips(chooser, show_tips);
		return chooser;
	}

	public static T SetSortFunc<T>(this T chooser, MentorLake.Gtk.GtkRecentSortFunc sort_func, IntPtr sort_data, MentorLake.GLib.GDestroyNotify data_destroy) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_sort_func(chooser, sort_func, sort_data, data_destroy);
		return chooser;
	}

	public static T SetSortType<T>(this T chooser, MentorLake.Gtk.GtkRecentSortType sort_type) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_sort_type(chooser, sort_type);
		return chooser;
	}

	public static T UnselectAll<T>(this T chooser) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_unselect_all(chooser);
		return chooser;
	}

	public static T UnselectUri<T>(this T chooser, string uri) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_unselect_uri(chooser, uri);
		return chooser;
	}

}

internal class GtkRecentChooserHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_add_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentInfoHandle gtk_recent_chooser_get_current_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_chooser_get_current_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentFilterHandle gtk_recent_chooser_get_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_recent_chooser_get_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_recent_chooser_get_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_chooser_get_local_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_chooser_get_select_multiple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_chooser_get_show_icons([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_chooser_get_show_not_found([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_chooser_get_show_private([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_chooser_get_show_tips([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentSortType gtk_recent_chooser_get_sort_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_recent_chooser_get_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, out UIntPtr length);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_recent_chooser_list_filters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_remove_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_chooser_select_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_chooser_set_current_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_set_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_set_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, int limit);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_set_local_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, bool local_only);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_set_select_multiple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, bool select_multiple);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_set_show_icons([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, bool show_icons);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_set_show_not_found([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, bool show_not_found);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_set_show_private([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, bool show_private);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_set_show_tips([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, bool show_tips);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_set_sort_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, MentorLake.Gtk.GtkRecentSortFunc sort_func, IntPtr sort_data, MentorLake.GLib.GDestroyNotify data_destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_set_sort_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, MentorLake.Gtk.GtkRecentSortType sort_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_unselect_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle chooser, string uri);

}
