namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkRecentChooser is an interface that can be implemented by widgets
/// displaying the list of recently used files.  In GTK+, the main objects
/// that implement this interface are #GtkRecentChooserWidget,
/// #GtkRecentChooserDialog and #GtkRecentChooserMenu.
/// </para>
/// <para>
/// Recently used files are supported since GTK+ 2.10.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Adds @filter to the list of #GtkRecentFilter objects held by @chooser.
/// </para>
/// <para>
/// If no previous filter objects were defined, this function will call
/// gtk_recent_chooser_set_filter().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="filter">
/// a #GtkRecentFilter
/// </param>

	public static T AddFilter<T>(this T chooser, MentorLake.Gtk.GtkRecentFilterHandle filter) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_add_filter(chooser, filter);
		return chooser;
	}

/// <summary>
/// <para>
/// Gets the #GtkRecentInfo currently selected by @chooser.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// a #GtkRecentInfo.  Use gtk_recent_info_unref() when
///   when you have finished using it.
/// </return>

	public static MentorLake.Gtk.GtkRecentInfoHandle GetCurrentItem(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_current_item(chooser);
	}

/// <summary>
/// <para>
/// Gets the URI currently selected by @chooser.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// a newly allocated string holding a URI.
/// </return>

	public static string GetCurrentUri(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_current_uri(chooser);
	}

/// <summary>
/// <para>
/// Gets the #GtkRecentFilter object currently used by @chooser to affect
/// the display of the recently used resources.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// a #GtkRecentFilter object.
/// </return>

	public static MentorLake.Gtk.GtkRecentFilterHandle GetFilter(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_filter(chooser);
	}

/// <summary>
/// <para>
/// Gets the list of recently used resources in form of #GtkRecentInfo objects.
/// </para>
/// <para>
/// The return value of this function is affected by the “sort-type” and
/// “limit” properties of @chooser.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// A newly allocated
///   list of #GtkRecentInfo objects.  You should
///   use gtk_recent_info_unref() on every item of the list, and then free
///   the list itself using g_list_free().
/// </return>

	public static MentorLake.GLib.GListHandle GetItems(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_items(chooser);
	}

/// <summary>
/// <para>
/// Gets the number of items returned by gtk_recent_chooser_get_items()
/// and gtk_recent_chooser_get_uris().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// A positive integer, or -1 meaning that all items are
///   returned.
/// </return>

	public static int GetLimit(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_limit(chooser);
	}

/// <summary>
/// <para>
/// Gets whether only local resources should be shown in the recently used
/// resources selector.  See gtk_recent_chooser_set_local_only()
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// %TRUE if only local resources should be shown.
/// </return>

	public static bool GetLocalOnly(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_local_only(chooser);
	}

/// <summary>
/// <para>
/// Gets whether @chooser can select multiple items.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// %TRUE if @chooser can select more than one item.
/// </return>

	public static bool GetSelectMultiple(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_select_multiple(chooser);
	}

/// <summary>
/// <para>
/// Retrieves whether @chooser should show an icon near the resource.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// %TRUE if the icons should be displayed, %FALSE otherwise.
/// </return>

	public static bool GetShowIcons(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_show_icons(chooser);
	}

/// <summary>
/// <para>
/// Retrieves whether @chooser should show the recently used resources that
/// were not found.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// %TRUE if the resources not found should be displayed, and
///   %FALSE otheriwse.
/// </return>

	public static bool GetShowNotFound(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_show_not_found(chooser);
	}

/// <summary>
/// <para>
/// Returns whether @chooser should display recently used resources
/// registered as private.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// %TRUE if the recent chooser should show private items,
///   %FALSE otherwise.
/// </return>

	public static bool GetShowPrivate(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_show_private(chooser);
	}

/// <summary>
/// <para>
/// Gets whether @chooser should display tooltips containing the full path
/// of a recently user resource.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// %TRUE if the recent chooser should show tooltips,
///   %FALSE otherwise.
/// </return>

	public static bool GetShowTips(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_show_tips(chooser);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_recent_chooser_set_sort_type().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// the sorting order of the @chooser.
/// </return>

	public static MentorLake.Gtk.GtkRecentSortType GetSortType(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_sort_type(chooser);
	}

/// <summary>
/// <para>
/// Gets the URI of the recently used resources.
/// </para>
/// <para>
/// The return value of this function is affected by the “sort-type” and “limit”
/// properties of @chooser.
/// </para>
/// <para>
/// Since the returned array is %NULL terminated, @length may be %NULL.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="length">
/// return location for a the length of the
///     URI list, or %NULL
/// </param>
/// <return>
/// 
///     A newly allocated, %NULL-terminated array of strings. Use
///     g_strfreev() to free it.
/// </return>

	public static string[] GetUris(this MentorLake.Gtk.GtkRecentChooserHandle chooser, out UIntPtr length)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_get_uris(chooser, out length);
	}

/// <summary>
/// <para>
/// Gets the #GtkRecentFilter objects held by @chooser.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <return>
/// A singly linked list
///   of #GtkRecentFilter objects.  You
///   should just free the returned list using g_slist_free().
/// </return>

	public static MentorLake.GLib.GSListHandle ListFilters(this MentorLake.Gtk.GtkRecentChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		return GtkRecentChooserHandleExterns.gtk_recent_chooser_list_filters(chooser);
	}

/// <summary>
/// <para>
/// Removes @filter from the list of #GtkRecentFilter objects held by @chooser.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="filter">
/// a #GtkRecentFilter
/// </param>

	public static T RemoveFilter<T>(this T chooser, MentorLake.Gtk.GtkRecentFilterHandle filter) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_remove_filter(chooser, filter);
		return chooser;
	}

/// <summary>
/// <para>
/// Selects all the items inside @chooser, if the @chooser supports
/// multiple selection.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>

	public static T SelectAll<T>(this T chooser) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_select_all(chooser);
		return chooser;
	}

/// <summary>
/// <para>
/// Selects @uri inside @chooser.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="uri">
/// a URI
/// </param>
/// <return>
/// %TRUE if @uri was found.
/// </return>

	public static bool SelectUri(this MentorLake.Gtk.GtkRecentChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		var externCallResult = GtkRecentChooserHandleExterns.gtk_recent_chooser_select_uri(chooser, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @uri as the current URI for @chooser.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="uri">
/// a URI
/// </param>
/// <return>
/// %TRUE if the URI was found.
/// </return>

	public static bool SetCurrentUri(this MentorLake.Gtk.GtkRecentChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		var externCallResult = GtkRecentChooserHandleExterns.gtk_recent_chooser_set_current_uri(chooser, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @filter as the current #GtkRecentFilter object used by @chooser
/// to affect the displayed recently used resources.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="filter">
/// a #GtkRecentFilter
/// </param>

	public static T SetFilter<T>(this T chooser, MentorLake.Gtk.GtkRecentFilterHandle filter) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_filter(chooser, filter);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets the number of items that should be returned by
/// gtk_recent_chooser_get_items() and gtk_recent_chooser_get_uris().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="limit">
/// a positive integer, or -1 for all items
/// </param>

	public static T SetLimit<T>(this T chooser, int limit) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_limit(chooser, limit);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets whether only local resources, that is resources using the file:// URI
/// scheme, should be shown in the recently used resources selector.  If
/// @local_only is %TRUE (the default) then the shown resources are guaranteed
/// to be accessible through the operating system native file system.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="local_only">
/// %TRUE if only local files can be shown
/// </param>

	public static T SetLocalOnly<T>(this T chooser, bool local_only) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_local_only(chooser, local_only);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets whether @chooser can select multiple items.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="select_multiple">
/// %TRUE if @chooser can select more than one item
/// </param>

	public static T SetSelectMultiple<T>(this T chooser, bool select_multiple) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_select_multiple(chooser, select_multiple);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets whether @chooser should show an icon near the resource when
/// displaying it.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="show_icons">
/// whether to show an icon near the resource
/// </param>

	public static T SetShowIcons<T>(this T chooser, bool show_icons) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_show_icons(chooser, show_icons);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets whether @chooser should display the recently used resources that
/// it didn’t find.  This only applies to local resources.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="show_not_found">
/// whether to show the local items we didn’t find
/// </param>

	public static T SetShowNotFound<T>(this T chooser, bool show_not_found) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_show_not_found(chooser, show_not_found);
		return chooser;
	}

/// <summary>
/// <para>
/// Whether to show recently used resources marked registered as private.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="show_private">
/// %TRUE to show private items, %FALSE otherwise
/// </param>

	public static T SetShowPrivate<T>(this T chooser, bool show_private) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_show_private(chooser, show_private);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets whether to show a tooltips containing the full path of each
/// recently used resource in a #GtkRecentChooser widget.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="show_tips">
/// %TRUE if tooltips should be shown
/// </param>

	public static T SetShowTips<T>(this T chooser, bool show_tips) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_show_tips(chooser, show_tips);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets the comparison function used when sorting to be @sort_func.  If
/// the @chooser has the sort type set to #GTK_RECENT_SORT_CUSTOM then
/// the chooser will sort using this function.
/// </para>
/// <para>
/// To the comparison function will be passed two #GtkRecentInfo structs and
/// @sort_data;  @sort_func should return a positive integer if the first
/// item comes before the second, zero if the two items are equal and
/// a negative integer if the first item comes after the second.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="sort_func">
/// the comparison function
/// </param>
/// <param name="sort_data">
/// user data to pass to @sort_func, or %NULL
/// </param>
/// <param name="data_destroy">
/// destroy notifier for @sort_data, or %NULL
/// </param>

	public static T SetSortFunc<T>(this T chooser, MentorLake.Gtk.GtkRecentSortFunc sort_func, IntPtr sort_data, MentorLake.GLib.GDestroyNotify data_destroy) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_sort_func(chooser, sort_func, sort_data, data_destroy);
		return chooser;
	}

/// <summary>
/// <para>
/// Changes the sorting order of the recently used resources list displayed by
/// @chooser.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="sort_type">
/// sort order that the chooser should use
/// </param>

	public static T SetSortType<T>(this T chooser, MentorLake.Gtk.GtkRecentSortType sort_type) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_set_sort_type(chooser, sort_type);
		return chooser;
	}

/// <summary>
/// <para>
/// Unselects all the items inside @chooser.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>

	public static T UnselectAll<T>(this T chooser) where T : GtkRecentChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserHandle)");
		GtkRecentChooserHandleExterns.gtk_recent_chooser_unselect_all(chooser);
		return chooser;
	}

/// <summary>
/// <para>
/// Unselects @uri inside @chooser.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkRecentChooser
/// </param>
/// <param name="uri">
/// a URI
/// </param>

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
