namespace MentorLake.Gtk;

public class GtkOffscreenWindowHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkOffscreenWindowHandle New()
	{
		return GtkOffscreenWindowHandleExterns.gtk_offscreen_window_new();
	}

}

public static class GtkOffscreenWindowHandleExtensions
{
	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.Gtk.GtkOffscreenWindowHandle offscreen)
	{
		if (offscreen.IsInvalid) throw new Exception("Invalid handle (GtkOffscreenWindowHandle)");
		return GtkOffscreenWindowHandleExterns.gtk_offscreen_window_get_pixbuf(offscreen);
	}

	public static MentorLake.cairo.cairo_surface_tHandle GetSurface(this MentorLake.Gtk.GtkOffscreenWindowHandle offscreen)
	{
		if (offscreen.IsInvalid) throw new Exception("Invalid handle (GtkOffscreenWindowHandle)");
		return GtkOffscreenWindowHandleExterns.gtk_offscreen_window_get_surface(offscreen);
	}

}

internal class GtkOffscreenWindowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkOffscreenWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkOffscreenWindowHandle gtk_offscreen_window_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_offscreen_window_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOffscreenWindowHandle>))] MentorLake.Gtk.GtkOffscreenWindowHandle offscreen);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gtk_offscreen_window_get_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOffscreenWindowHandle>))] MentorLake.Gtk.GtkOffscreenWindowHandle offscreen);

}
