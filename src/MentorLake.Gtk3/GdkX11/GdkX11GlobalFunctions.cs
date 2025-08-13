namespace MentorLake.GdkX11;

public class GdkX11GlobalFunctions
{
	public static MentorLake.xlib.Atom X11AtomToXatom(MentorLake.Gdk.GdkAtom atom)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_atom_to_xatom(atom);
	}

	public static MentorLake.xlib.Atom X11AtomToXatomForDisplay(MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.Gdk.GdkAtom atom)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_atom_to_xatom_for_display(display, atom);
	}

	public static int X11DeviceGetId(MentorLake.GdkX11.GdkX11DeviceCoreHandle device)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_device_get_id(device);
	}

	public static MentorLake.GdkX11.GdkX11DeviceCoreHandle X11DeviceManagerLookup(MentorLake.GdkX11.GdkX11DeviceManagerCoreHandle device_manager, int device_id)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_device_manager_lookup(device_manager, device_id);
	}

	public static void X11FreeCompoundText(byte ctext)
	{
		GdkX11GlobalFunctionsExterns.gdk_x11_free_compound_text(ctext);
	}

	public static void X11FreeTextList(string list)
	{
		GdkX11GlobalFunctionsExterns.gdk_x11_free_text_list(list);
	}

	public static MentorLake.xlib.Window X11GetDefaultRootXwindow()
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_default_root_xwindow();
	}

	public static int X11GetDefaultScreen()
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_default_screen();
	}

	public static MentorLake.xlib.DisplayHandle X11GetDefaultXdisplay()
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_default_xdisplay();
	}

	public static MentorLake.cairo.cairo_pattern_tHandle X11GetParentRelativePattern()
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_parent_relative_pattern();
	}

	public static uint X11GetServerTime(MentorLake.GdkX11.GdkX11WindowHandle window)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_server_time(window);
	}

	public static MentorLake.xlib.Atom X11GetXatomByName(string atom_name)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_xatom_by_name(atom_name);
	}

	public static MentorLake.xlib.Atom X11GetXatomByNameForDisplay(MentorLake.GdkX11.GdkX11DisplayHandle display, string atom_name)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_xatom_by_name_for_display(display, atom_name);
	}

	public static string X11GetXatomName(MentorLake.xlib.Atom xatom)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_xatom_name(xatom);
	}

	public static string X11GetXatomNameForDisplay(MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.xlib.Atom xatom)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_get_xatom_name_for_display(display, xatom);
	}

	public static void X11GrabServer()
	{
		GdkX11GlobalFunctionsExterns.gdk_x11_grab_server();
	}

	public static MentorLake.GdkX11.GdkX11DisplayHandle X11LookupXdisplay(MentorLake.xlib.DisplayHandle xdisplay)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_lookup_xdisplay(xdisplay);
	}

	public static void X11RegisterStandardEventType(MentorLake.GdkX11.GdkX11DisplayHandle display, int event_base, int n_events)
	{
		GdkX11GlobalFunctionsExterns.gdk_x11_register_standard_event_type(display, event_base, n_events);
	}

	public static void X11SetSmClientId(string sm_client_id)
	{
		GdkX11GlobalFunctionsExterns.gdk_x11_set_sm_client_id(sm_client_id);
	}

	public static void X11UngrabServer()
	{
		GdkX11GlobalFunctionsExterns.gdk_x11_ungrab_server();
	}

	public static MentorLake.Gdk.GdkAtom X11XatomToAtom(MentorLake.xlib.Atom xatom)
	{
		return GdkX11GlobalFunctionsExterns.gdk_x11_xatom_to_atom(xatom);
	}

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
