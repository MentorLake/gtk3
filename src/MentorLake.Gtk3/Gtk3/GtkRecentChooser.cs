namespace MentorLake.Gtk3.Gtk3;

public interface GtkRecentChooserHandle
{
}

internal class GtkRecentChooserHandleImpl : BaseSafeHandle, GtkRecentChooserHandle
{
}

public static class GtkRecentChooserHandleExtensions
{
	public static T AddFilter<T>(this T chooser, GtkRecentFilterHandle filter) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_add_filter(chooser, filter);
		return chooser;
	}

	public static GtkRecentInfoHandle GetCurrentItem(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_current_item(chooser);
	}

	public static string GetCurrentUri(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_current_uri(chooser);
	}

	public static GtkRecentFilterHandle GetFilter(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_filter(chooser);
	}

	public static GListHandle GetItems(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_items(chooser);
	}

	public static int GetLimit(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_limit(chooser);
	}

	public static bool GetLocalOnly(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_local_only(chooser);
	}

	public static bool GetSelectMultiple(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_select_multiple(chooser);
	}

	public static bool GetShowIcons(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_show_icons(chooser);
	}

	public static bool GetShowNotFound(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_show_not_found(chooser);
	}

	public static bool GetShowPrivate(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_show_private(chooser);
	}

	public static bool GetShowTips(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_show_tips(chooser);
	}

	public static GtkRecentSortType GetSortType(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_sort_type(chooser);
	}

	public static IntPtr GetUris(this GtkRecentChooserHandle chooser, out UIntPtr length)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_get_uris(chooser, out length);
	}

	public static GSListHandle ListFilters(this GtkRecentChooserHandle chooser)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_list_filters(chooser);
	}

	public static T RemoveFilter<T>(this T chooser, GtkRecentFilterHandle filter) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_remove_filter(chooser, filter);
		return chooser;
	}

	public static T SelectAll<T>(this T chooser) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_select_all(chooser);
		return chooser;
	}

	public static bool SelectUri(this GtkRecentChooserHandle chooser, string uri, out GErrorHandle error)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_select_uri(chooser, uri, out error);
	}

	public static bool SetCurrentUri(this GtkRecentChooserHandle chooser, string uri, out GErrorHandle error)
	{
		return GtkRecentChooserExterns.gtk_recent_chooser_set_current_uri(chooser, uri, out error);
	}

	public static T SetFilter<T>(this T chooser, GtkRecentFilterHandle filter) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_set_filter(chooser, filter);
		return chooser;
	}

	public static T SetLimit<T>(this T chooser, int limit) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_set_limit(chooser, limit);
		return chooser;
	}

	public static T SetLocalOnly<T>(this T chooser, bool local_only) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_set_local_only(chooser, local_only);
		return chooser;
	}

	public static T SetSelectMultiple<T>(this T chooser, bool select_multiple) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_set_select_multiple(chooser, select_multiple);
		return chooser;
	}

	public static T SetShowIcons<T>(this T chooser, bool show_icons) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_set_show_icons(chooser, show_icons);
		return chooser;
	}

	public static T SetShowNotFound<T>(this T chooser, bool show_not_found) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_set_show_not_found(chooser, show_not_found);
		return chooser;
	}

	public static T SetShowPrivate<T>(this T chooser, bool show_private) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_set_show_private(chooser, show_private);
		return chooser;
	}

	public static T SetShowTips<T>(this T chooser, bool show_tips) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_set_show_tips(chooser, show_tips);
		return chooser;
	}

	public static T SetSortFunc<T>(this T chooser, GtkRecentSortFunc sort_func, IntPtr sort_data, GDestroyNotify data_destroy) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_set_sort_func(chooser, sort_func, sort_data, data_destroy);
		return chooser;
	}

	public static T SetSortType<T>(this T chooser, GtkRecentSortType sort_type) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_set_sort_type(chooser, sort_type);
		return chooser;
	}

	public static T UnselectAll<T>(this T chooser) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_unselect_all(chooser);
		return chooser;
	}

	public static T UnselectUri<T>(this T chooser, string uri) where T : GtkRecentChooserHandle
	{
		GtkRecentChooserExterns.gtk_recent_chooser_unselect_uri(chooser, uri);
		return chooser;
	}

}

internal class GtkRecentChooserExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_add_filter(GtkRecentChooserHandle chooser, GtkRecentFilterHandle filter);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentInfoHandle gtk_recent_chooser_get_current_item(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_recent_chooser_get_current_uri(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentFilterHandle gtk_recent_chooser_get_filter(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_recent_chooser_get_items(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_recent_chooser_get_limit(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_chooser_get_local_only(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_chooser_get_select_multiple(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_chooser_get_show_icons(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_chooser_get_show_not_found(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_chooser_get_show_private(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_chooser_get_show_tips(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentSortType gtk_recent_chooser_get_sort_type(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_recent_chooser_get_uris(GtkRecentChooserHandle chooser, out UIntPtr length);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_recent_chooser_list_filters(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_remove_filter(GtkRecentChooserHandle chooser, GtkRecentFilterHandle filter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_select_all(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_chooser_select_uri(GtkRecentChooserHandle chooser, string uri, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_chooser_set_current_uri(GtkRecentChooserHandle chooser, string uri, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_set_filter(GtkRecentChooserHandle chooser, GtkRecentFilterHandle filter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_set_limit(GtkRecentChooserHandle chooser, int limit);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_set_local_only(GtkRecentChooserHandle chooser, bool local_only);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_set_select_multiple(GtkRecentChooserHandle chooser, bool select_multiple);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_set_show_icons(GtkRecentChooserHandle chooser, bool show_icons);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_set_show_not_found(GtkRecentChooserHandle chooser, bool show_not_found);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_set_show_private(GtkRecentChooserHandle chooser, bool show_private);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_set_show_tips(GtkRecentChooserHandle chooser, bool show_tips);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_set_sort_func(GtkRecentChooserHandle chooser, GtkRecentSortFunc sort_func, IntPtr sort_data, GDestroyNotify data_destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_set_sort_type(GtkRecentChooserHandle chooser, GtkRecentSortType sort_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_unselect_all(GtkRecentChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_unselect_uri(GtkRecentChooserHandle chooser, string uri);

}
