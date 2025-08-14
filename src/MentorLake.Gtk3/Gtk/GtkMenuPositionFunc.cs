namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A user function supplied when calling gtk_menu_popup() which
/// controls the positioning of the menu when it is displayed.  The
/// function sets the @x and @y parameters to the coordinates where the
/// menu is to be drawn.  To make the menu appear on a different
/// monitor than the mouse pointer, gtk_menu_set_monitor() must be
/// called.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu.
/// </param>
/// <param name="x">
/// address of the #gint representing the horizontal
///     position where the menu shall be drawn.
/// </param>
/// <param name="y">
/// address of the #gint representing the vertical position
///     where the menu shall be drawn.  This is an output parameter.
/// </param>
/// <param name="push_in">
/// This parameter controls how menus placed outside
///     the monitor are handled.  If this is set to %TRUE and part of
///     the menu is outside the monitor then GTK+ pushes the window
///     into the visible area, effectively modifying the popup
///     position.  Note that moving and possibly resizing the menu
///     around will alter the scroll position to keep the menu items
///     “in place”, i.e. at the same monitor position they would have
///     been without resizing.  In practice, this behavior is only
///     useful for combobox popups or option menus and cannot be used
///     to simply confine a menu to monitor boundaries.  In that case,
///     changing the scroll offset is not desirable.
/// </param>
/// <param name="user_data">
/// the data supplied by the user in the gtk_menu_popup()
///     @data parameter.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkMenuPositionFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, ref int x, ref int y, out bool push_in, IntPtr user_data);
