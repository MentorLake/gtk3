namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// These flags serve two purposes.  First, the application can call gtk_places_sidebar_set_open_flags()
/// using these flags as a bitmask.  This tells the sidebar that the application is able to open
/// folders selected from the sidebar in various ways, for example, in new tabs or in new windows in
/// addition to the normal mode.
/// </para>
/// <para>
/// Second, when one of these values gets passed back to the application in the
/// #GtkPlacesSidebar::open-location signal, it means that the application should
/// open the selected location in the normal way, in a new tab, or in a new
/// window.  The sidebar takes care of determining the desired way to open the location,
/// based on the modifier keys that the user is pressing at the time the selection is made.
/// </para>
/// <para>
/// If the application never calls gtk_places_sidebar_set_open_flags(), then the sidebar will only
/// use #GTK_PLACES_OPEN_NORMAL in the #GtkPlacesSidebar::open-location signal.  This is the
/// default mode of operation.
/// </para>
/// </summary>

[Flags]
public enum GtkPlacesOpenFlags : uint
{
/// <summary>
/// <para>
/// This is the default mode that #GtkPlacesSidebar uses if no other flags
///  are specified.  It indicates that the calling application should open the selected location
///  in the normal way, for example, in the folder view beside the sidebar.
/// </para>
/// </summary>

	GTK_PLACES_OPEN_NORMAL = 1,
/// <summary>
/// <para>
/// When passed to gtk_places_sidebar_set_open_flags(), this indicates
///  that the application can open folders selected from the sidebar in new tabs.  This value
///  will be passed to the #GtkPlacesSidebar::open-location signal when the user selects
///  that a location be opened in a new tab instead of in the standard fashion.
/// </para>
/// </summary>

	GTK_PLACES_OPEN_NEW_TAB = 2,
/// <summary>
/// <para>
/// Similar to @GTK_PLACES_OPEN_NEW_TAB, but indicates that the application
///  can open folders in new windows.
/// </para>
/// </summary>

	GTK_PLACES_OPEN_NEW_WINDOW = 4
}
