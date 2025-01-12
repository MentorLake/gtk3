namespace MentorLake.Gtk3.Gdk3X11;

public class Gdk3X11GlobalFunctions
{
	[DllImport(Libraries.Gdk3X11)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	public static extern string gdk_x11_get_xatom_name(ulong xatom);

	[DllImport(Libraries.Gdk3X11)]
	public static extern GdkAtom gdk_x11_xatom_to_atom(ulong xatom);

	[DllImport(Libraries.Gdk3X11)]
	public static extern void gdk_x11_register_standard_event_type(GdkDisplayHandle display, int event_base, int n_events);

	[DllImport(Libraries.Gdk3X11)]
	public static extern void gdk_x11_free_text_list(ref string list);

	[DllImport(Libraries.Gdk3X11)]
	public static extern int gdk_x11_get_default_screen();

	[DllImport(Libraries.Gdk3X11)]
	public static extern cairo_pattern_tHandle gdk_x11_get_parent_relative_pattern();

	[DllImport(Libraries.Gdk3X11)]
	public static extern GdkDisplayHandle gdk_x11_lookup_xdisplay(IntPtr xdisplay);

	[DllImport(Libraries.Gdk3X11)]
	public static extern ulong gdk_x11_atom_to_xatom(GdkAtom atom);

	[DllImport(Libraries.Gdk3X11)]
	public static extern GdkAtom gdk_x11_xatom_to_atom_for_display(GdkDisplayHandle display, ulong xatom);

	[DllImport(Libraries.Gdk3X11)]
	public static extern ulong gdk_x11_get_xatom_by_name_for_display(GdkDisplayHandle display, string atom_name);

	[DllImport(Libraries.Gdk3X11)]
	public static extern ulong gdk_x11_get_xatom_by_name(string atom_name);

	[DllImport(Libraries.Gdk3X11)]
	public static extern void gdk_x11_ungrab_server();

	[DllImport(Libraries.Gdk3X11)]
	public static extern void gdk_x11_set_sm_client_id(string sm_client_id);

	[DllImport(Libraries.Gdk3X11)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	public static extern string gdk_x11_get_xatom_name_for_display(GdkDisplayHandle display, ulong xatom);

	[DllImport(Libraries.Gdk3X11)]
	public static extern int gdk_x11_device_get_id(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3X11)]
	public static extern ulong gdk_x11_atom_to_xatom_for_display(GdkDisplayHandle display, GdkAtom atom);

	[DllImport(Libraries.Gdk3X11)]
	public static extern void gdk_x11_grab_server();

	[DllImport(Libraries.Gdk3X11)]
	public static extern void gdk_x11_free_compound_text(string ctext);

	[DllImport(Libraries.Gdk3X11)]
	public static extern uint gdk_x11_get_server_time(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3X11)]
	public static extern IntPtr gdk_x11_get_default_xdisplay();

	[DllImport(Libraries.Gdk3X11)]
	public static extern IntPtr gdk_x11_get_default_root_xwindow();

	[DllImport(Libraries.Gdk3X11)]
	public static extern GdkDeviceHandle gdk_x11_device_manager_lookup(GdkDeviceManagerHandle device_manager, int device_id);

}
