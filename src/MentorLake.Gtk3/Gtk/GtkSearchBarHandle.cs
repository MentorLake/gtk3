namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkSearchBar is a container made to have a search entry (possibly
/// with additional connex widgets, such as drop-down menus, or buttons)
/// built-in. The search bar would appear when a search is started through
/// typing on the keyboard, or the application’s search mode is toggled on.
/// </para>
/// <para>
/// For keyboard presses to start a search, events will need to be
/// forwarded from the top-level window that contains the search bar.
/// See gtk_search_bar_handle_event() for example code. Common shortcuts
/// such as Ctrl+F should be handled as an application action, or through
/// the menu items.
/// </para>
/// <para>
/// You will also need to tell the search bar about which entry you
/// are using as your search entry using gtk_search_bar_connect_entry().
/// The following example shows you how to create a more complex search
/// entry.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkSearchBar has a single CSS node with name searchbar.
/// </para>
/// <para>
/// ## Creating a search bar
/// </para>
/// <para>
/// [A simple example](https://gitlab.gnome.org/GNOME/gtk/blob/gtk-3-24/examples/search-bar.c)
/// </para>
/// </summary>

public class GtkSearchBarHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a #GtkSearchBar. You will need to tell it about
/// which widget is going to be your text entry using
/// gtk_search_bar_connect_entry().
/// </para>
/// </summary>

/// <return>
/// a new #GtkSearchBar
/// </return>

	public static MentorLake.Gtk.GtkSearchBarHandle New()
	{
		return GtkSearchBarHandleExterns.gtk_search_bar_new();
	}

}

public static class GtkSearchBarHandleExtensions
{
/// <summary>
/// <para>
/// Connects the #GtkEntry widget passed as the one to be used in
/// this search bar. The entry should be a descendant of the search bar.
/// This is only required if the entry isn’t the direct child of the
/// search bar (as in our main example).
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkSearchBar
/// </param>
/// <param name="entry">
/// a #GtkEntry
/// </param>

	public static T ConnectEntry<T>(this T bar, MentorLake.Gtk.GtkEntryHandle entry) where T : GtkSearchBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkSearchBarHandle)");
		GtkSearchBarHandleExterns.gtk_search_bar_connect_entry(bar, entry);
		return bar;
	}

/// <summary>
/// <para>
/// Returns whether the search mode is on or off.
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkSearchBar
/// </param>
/// <return>
/// whether search mode is toggled on
/// </return>

	public static bool GetSearchMode(this MentorLake.Gtk.GtkSearchBarHandle bar)
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkSearchBarHandle)");
		return GtkSearchBarHandleExterns.gtk_search_bar_get_search_mode(bar);
	}

/// <summary>
/// <para>
/// Returns whether the close button is shown.
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkSearchBar
/// </param>
/// <return>
/// whether the close button is shown
/// </return>

	public static bool GetShowCloseButton(this MentorLake.Gtk.GtkSearchBarHandle bar)
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkSearchBarHandle)");
		return GtkSearchBarHandleExterns.gtk_search_bar_get_show_close_button(bar);
	}

/// <summary>
/// <para>
/// This function should be called when the top-level
/// window which contains the search bar received a key event.
/// </para>
/// <para>
/// If the key event is handled by the search bar, the bar will
/// be shown, the entry populated with the entered text and %GDK_EVENT_STOP
/// will be returned. The caller should ensure that events are
/// not propagated further.
/// </para>
/// <para>
/// If no entry has been connected to the search bar, using
/// gtk_search_bar_connect_entry(), this function will return
/// immediately with a warning.
/// </para>
/// <para>
/// ## Showing the search bar on key presses
/// </para>
/// <code>
/// static gboolean
/// static gboolean
/// on_key_press_event (GtkWidget *widget,
///                     GdkEvent  *event,
///                     gpointer   user_data)
/// {
///   GtkSearchBar *bar = GTK_SEARCH_BAR (user_data);
///   return gtk_search_bar_handle_event (bar, event);
/// }
/// 
/// static void
/// create_toplevel (void)
/// {
///   GtkWidget *window = gtk_window_new (GTK_WINDOW_TOPLEVEL);
///   GtkWindow *search_bar = gtk_search_bar_new ();
/// 
///  // Add more widgets to the window...
/// 
///   g_signal_connect (window,
///                    &quot;key-press-event&quot;,
///                     G_CALLBACK (on_key_press_event),
///                     search_bar);
/// }
/// </code>
/// </summary>

/// <param name="bar">
/// a #GtkSearchBar
/// </param>
/// <param name="@event">
/// a #GdkEvent containing key press events
/// </param>
/// <return>
/// %GDK_EVENT_STOP if the key press event resulted
///     in text being entered in the search entry (and revealing
///     the search bar if necessary), %GDK_EVENT_PROPAGATE otherwise.
/// </return>

	public static bool HandleEvent(this MentorLake.Gtk.GtkSearchBarHandle bar, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkSearchBarHandle)");
		return GtkSearchBarHandleExterns.gtk_search_bar_handle_event(bar, @event);
	}

/// <summary>
/// <para>
/// Switches the search mode on or off.
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkSearchBar
/// </param>
/// <param name="search_mode">
/// the new state of the search mode
/// </param>

	public static T SetSearchMode<T>(this T bar, bool search_mode) where T : GtkSearchBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkSearchBarHandle)");
		GtkSearchBarHandleExterns.gtk_search_bar_set_search_mode(bar, search_mode);
		return bar;
	}

/// <summary>
/// <para>
/// Shows or hides the close button. Applications that
/// already have a “search” toggle button should not show a close
/// button in their search bar, as it duplicates the role of the
/// toggle button.
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkSearchBar
/// </param>
/// <param name="visible">
/// whether the close button will be shown or not
/// </param>

	public static T SetShowCloseButton<T>(this T bar, bool visible) where T : GtkSearchBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkSearchBarHandle)");
		GtkSearchBarHandleExterns.gtk_search_bar_set_show_close_button(bar, visible);
		return bar;
	}

}

internal class GtkSearchBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))]
	internal static extern MentorLake.Gtk.GtkSearchBarHandle gtk_search_bar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_search_bar_connect_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))] MentorLake.Gtk.GtkSearchBarHandle bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_search_bar_get_search_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))] MentorLake.Gtk.GtkSearchBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_search_bar_get_show_close_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))] MentorLake.Gtk.GtkSearchBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_search_bar_handle_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))] MentorLake.Gtk.GtkSearchBarHandle bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_search_bar_set_search_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))] MentorLake.Gtk.GtkSearchBarHandle bar, bool search_mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_search_bar_set_show_close_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))] MentorLake.Gtk.GtkSearchBarHandle bar, bool visible);

}
