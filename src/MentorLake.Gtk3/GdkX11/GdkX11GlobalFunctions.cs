namespace MentorLake.GdkX11;

public class GdkX11GlobalFunctions
{
/// <summary>
/// <para>
/// Converts from a #GdkAtom to the X atom for the default GDK display
/// with the same string value.
/// </para>
/// </summary>

/// <param name="atom">
/// A #GdkAtom
/// </param>
/// <return>
/// the X atom corresponding to @atom.
/// </return>

	public static MentorLake.xlib.Atom X11AtomToXatom(MentorLake.Gdk.GdkAtom atom)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_atom_to_xatom(atom);
	}

/// <summary>
/// <para>
/// Converts from a #GdkAtom to the X atom for a #GdkDisplay
/// with the same string value. The special value %GDK_NONE
/// is converted to %None.
/// </para>
/// </summary>

/// <param name="display">
/// A #GdkDisplay
/// </param>
/// <param name="atom">
/// A #GdkAtom, or %GDK_NONE
/// </param>
/// <return>
/// the X atom corresponding to @atom, or %None
/// </return>

	public static MentorLake.xlib.Atom X11AtomToXatomForDisplay(MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.Gdk.GdkAtom atom)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_atom_to_xatom_for_display(display, atom);
	}

/// <summary>
/// <para>
/// Returns the device ID as seen by XInput2.
/// </para>
/// <para>
/// > If gdk_disable_multidevice() has been called, this function
/// > will respectively return 2/3 for the core pointer and keyboard,
/// > (matching the IDs for the Virtual Core Pointer and Keyboard in
/// > XInput 2), but calling this function on any slave devices (i.e.
/// > those managed via XInput 1.x), will return 0.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// the XInput2 device ID.
/// </return>

	public static int X11DeviceGetId(MentorLake.GdkX11.GdkX11DeviceCoreHandle device)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_device_get_id(device);
	}

/// <summary>
/// <para>
/// Returns the #GdkDevice that wraps the given device ID.
/// </para>
/// </summary>

/// <param name="device_manager">
/// a #GdkDeviceManager
/// </param>
/// <param name="device_id">
/// a device ID, as understood by the XInput2 protocol
/// </param>
/// <return>
/// The #GdkDevice wrapping the device ID,
///          or %NULL if the given ID doesn’t currently represent a device.
/// </return>

	public static MentorLake.GdkX11.GdkX11DeviceCoreHandle X11DeviceManagerLookup(MentorLake.GdkX11.GdkX11DeviceManagerCoreHandle device_manager, int device_id)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_device_manager_lookup(device_manager, device_id);
	}

/// <summary>
/// <para>
/// Frees the data returned from gdk_x11_display_string_to_compound_text().
/// </para>
/// </summary>

/// <param name="ctext">
/// The pointer stored in @ctext from a call to
///   gdk_x11_display_string_to_compound_text().
/// </param>

	public static void X11FreeCompoundText(byte ctext)
	{
		GdkX11GlobalFunctionsExterns.gdk_x11_free_compound_text(ctext);
	}

/// <summary>
/// <para>
/// Frees the array of strings created by
/// gdk_x11_display_text_property_to_text_list().
/// </para>
/// </summary>

/// <param name="list">
/// the value stored in the @list parameter by
///   a call to gdk_x11_display_text_property_to_text_list().
/// </param>

	public static void X11FreeTextList(string list)
	{
		GdkX11GlobalFunctionsExterns.gdk_x11_free_text_list(list);
	}

/// <summary>
/// <para>
/// Gets the root window of the default screen
/// (see gdk_x11_get_default_screen()).
/// </para>
/// </summary>

/// <return>
/// an Xlib Window.
/// </return>

	public static MentorLake.xlib.Window X11GetDefaultRootXwindow()
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_default_root_xwindow();
	}

/// <summary>
/// <para>
/// Gets the default GTK+ screen number.
/// </para>
/// </summary>

/// <return>
/// returns the screen number specified by
///   the --display command line option or the DISPLAY environment
///   variable when gdk_init() calls XOpenDisplay().
/// </return>

	public static int X11GetDefaultScreen()
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_default_screen();
	}

/// <summary>
/// <para>
/// Gets the default GTK+ display.
/// </para>
/// </summary>

/// <return>
/// the Xlib Display* for
/// the display specified in the `--display` command
/// line option or the `DISPLAY` environment variable.
/// </return>

	public static MentorLake.xlib.DisplayHandle X11GetDefaultXdisplay()
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_default_xdisplay();
	}

/// <summary>
/// <para>
/// Used with gdk_window_set_background_pattern() to inherit background from
/// parent window. Useful for imitating transparency when compositing is not
/// available. Otherwise behaves like a transparent pattern.
/// </para>
/// </summary>


	public static MentorLake.cairo.cairo_pattern_tHandle X11GetParentRelativePattern()
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_parent_relative_pattern();
	}

/// <summary>
/// <para>
/// Routine to get the current X server time stamp.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow, used for communication
///          with the server.  The window must have
///          GDK_PROPERTY_CHANGE_MASK in its events mask or a hang will
///          result.
/// </param>
/// <return>
/// the time stamp.
/// </return>

	public static uint X11GetServerTime(MentorLake.GdkX11.GdkX11WindowHandle window)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_server_time(window);
	}

/// <summary>
/// <para>
/// Returns the X atom for GDK’s default display corresponding to @atom_name.
/// This function caches the result, so if called repeatedly it is much
/// faster than XInternAtom(), which is a round trip to the server each time.
/// </para>
/// </summary>

/// <param name="atom_name">
/// a string
/// </param>
/// <return>
/// a X atom for GDK’s default display.
/// </return>

	public static MentorLake.xlib.Atom X11GetXatomByName(string atom_name)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_xatom_by_name(atom_name);
	}

/// <summary>
/// <para>
/// Returns the X atom for a #GdkDisplay corresponding to @atom_name.
/// This function caches the result, so if called repeatedly it is much
/// faster than XInternAtom(), which is a round trip to the server each time.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="atom_name">
/// a string
/// </param>
/// <return>
/// a X atom for a #GdkDisplay
/// </return>

	public static MentorLake.xlib.Atom X11GetXatomByNameForDisplay(MentorLake.GdkX11.GdkX11DisplayHandle display, string atom_name)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_xatom_by_name_for_display(display, atom_name);
	}

/// <summary>
/// <para>
/// Returns the name of an X atom for GDK’s default display. This
/// function is meant mainly for debugging, so for convenience, unlike
/// XAtomName() and gdk_atom_name(), the result
/// doesn’t need to be freed. Also, this function will never return %NULL,
/// even if @xatom is invalid.
/// </para>
/// </summary>

/// <param name="xatom">
/// an X atom for GDK’s default display
/// </param>
/// <return>
/// name of the X atom; this string is owned by GTK+,
///   so it shouldn’t be modifed or freed.
/// </return>

	public static string X11GetXatomName(MentorLake.xlib.Atom xatom)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_xatom_name(xatom);
	}

/// <summary>
/// <para>
/// Returns the name of an X atom for its display. This
/// function is meant mainly for debugging, so for convenience, unlike
/// XAtomName() and gdk_atom_name(), the result doesn’t need to
/// be freed.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay where @xatom is defined
/// </param>
/// <param name="xatom">
/// an X atom
/// </param>
/// <return>
/// name of the X atom; this string is owned by GDK,
///   so it shouldn’t be modifed or freed.
/// </return>

	public static string X11GetXatomNameForDisplay(MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.xlib.Atom xatom)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_xatom_name_for_display(display, xatom);
	}

/// <summary>
/// <para>
/// Call gdk_x11_display_grab() on the default display.
/// To ungrab the server again, use gdk_x11_ungrab_server().
/// </para>
/// <para>
/// gdk_x11_grab_server()/gdk_x11_ungrab_server() calls can be nested.
/// </para>
/// </summary>


	public static void X11GrabServer()
	{
		GdkX11GlobalFunctionsExterns.gdk_x11_grab_server();
	}

/// <summary>
/// <para>
/// Find the #GdkDisplay corresponding to @xdisplay, if any exists.
/// </para>
/// </summary>

/// <param name="xdisplay">
/// a pointer to an X Display
/// </param>
/// <return>
/// the #GdkDisplay, if found, otherwise %NULL.
/// </return>

	public static MentorLake.GdkX11.GdkX11DisplayHandle X11LookupXdisplay(MentorLake.xlib.DisplayHandle xdisplay)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_lookup_xdisplay(xdisplay);
	}

/// <summary>
/// <para>
/// Registers interest in receiving extension events with type codes
/// between @event_base and `event_base + n_events - 1`.
/// The registered events must have the window field in the same place
/// as core X events (this is not the case for e.g. XKB extension events).
/// </para>
/// <para>
/// If an event type is registered, events of this type will go through
/// global and window-specific filters (see gdk_window_add_filter()).
/// Unregistered events will only go through global filters.
/// GDK may register the events of some X extensions on its own.
/// </para>
/// <para>
/// This function should only be needed in unusual circumstances, e.g.
/// when filtering XInput extension events on the root window.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="event_base">
/// first event type code to register
/// </param>
/// <param name="n_events">
/// number of event type codes to register
/// </param>

	public static void X11RegisterStandardEventType(MentorLake.GdkX11.GdkX11DisplayHandle display, int event_base, int n_events)
	{
		GdkX11GlobalFunctionsExterns.gdk_x11_register_standard_event_type(display, event_base, n_events);
	}

/// <summary>
/// <para>
/// Sets the `SM_CLIENT_ID` property on the application’s leader window so that
/// the window manager can save the application’s state using the X11R6 ICCCM
/// session management protocol.
/// </para>
/// <para>
/// See the X Session Management Library documentation for more information on
/// session management and the Inter-Client Communication Conventions Manual
/// </para>
/// </summary>

/// <param name="sm_client_id">
/// the client id assigned by the session manager
///    when the connection was opened, or %NULL to remove the property.
/// </param>

	public static void X11SetSmClientId(string sm_client_id)
	{
		GdkX11GlobalFunctionsExterns.gdk_x11_set_sm_client_id(sm_client_id);
	}

/// <summary>
/// <para>
/// Ungrab the default display after it has been grabbed with
/// gdk_x11_grab_server().
/// </para>
/// </summary>


	public static void X11UngrabServer()
	{
		GdkX11GlobalFunctionsExterns.gdk_x11_ungrab_server();
	}

/// <summary>
/// <para>
/// Convert from an X atom for the default display to the corresponding
/// #GdkAtom.
/// </para>
/// </summary>

/// <param name="xatom">
/// an X atom for the default GDK display
/// </param>
/// <return>
/// the corresponding G#dkAtom.
/// </return>

	public static MentorLake.Gdk.GdkAtom X11XatomToAtom(MentorLake.xlib.Atom xatom)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_xatom_to_atom(xatom);
	}

/// <summary>
/// <para>
/// Convert from an X atom for a #GdkDisplay to the corresponding
/// #GdkAtom.
/// </para>
/// </summary>

/// <param name="display">
/// A #GdkDisplay
/// </param>
/// <param name="xatom">
/// an X atom
/// </param>
/// <return>
/// the corresponding #GdkAtom.
/// </return>

	public static MentorLake.Gdk.GdkAtom X11XatomToAtomForDisplay(MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.xlib.Atom xatom)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_xatom_to_atom_for_display(display, xatom);
	}

}

internal class GdkX11GlobalFunctionsExterns
{
	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.xlib.Atom gdk_x11_atom_to_xatom(MentorLake.Gdk.GdkAtom atom);

	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.xlib.Atom gdk_x11_atom_to_xatom_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.Gdk.GdkAtom atom);

	[DllImport(GdkX11Library.Name)]
	internal static extern int gdk_x11_device_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DeviceCoreHandle>))] MentorLake.GdkX11.GdkX11DeviceCoreHandle device);

	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DeviceCoreHandle>))]
	internal static extern MentorLake.GdkX11.GdkX11DeviceCoreHandle gdk_x11_device_manager_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DeviceManagerCoreHandle>))] MentorLake.GdkX11.GdkX11DeviceManagerCoreHandle device_manager, int device_id);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_free_compound_text(byte ctext);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_free_text_list(string list);

	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.xlib.Window gdk_x11_get_default_root_xwindow();

	[DllImport(GdkX11Library.Name)]
	internal static extern int gdk_x11_get_default_screen();

	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))]
	internal static extern MentorLake.xlib.DisplayHandle gdk_x11_get_default_xdisplay();

	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle gdk_x11_get_parent_relative_pattern();

	[DllImport(GdkX11Library.Name)]
	internal static extern uint gdk_x11_get_server_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11WindowHandle>))] MentorLake.GdkX11.GdkX11WindowHandle window);

	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.xlib.Atom gdk_x11_get_xatom_by_name(string atom_name);

	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.xlib.Atom gdk_x11_get_xatom_by_name_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, string atom_name);

	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_x11_get_xatom_name(MentorLake.xlib.Atom xatom);

	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_x11_get_xatom_name_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.xlib.Atom xatom);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_grab_server();

	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))]
	internal static extern MentorLake.GdkX11.GdkX11DisplayHandle gdk_x11_lookup_xdisplay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))] MentorLake.xlib.DisplayHandle xdisplay);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_register_standard_event_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, int event_base, int n_events);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_set_sm_client_id(string sm_client_id);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_ungrab_server();

	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gdk_x11_xatom_to_atom(MentorLake.xlib.Atom xatom);

	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gdk_x11_xatom_to_atom_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.xlib.Atom xatom);

}
