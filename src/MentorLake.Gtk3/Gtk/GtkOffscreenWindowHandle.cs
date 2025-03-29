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
		if (offscreen.IsInvalid || offscreen.IsClosed) throw new Exception("Invalid or closed handle (GtkOffscreenWindowHandle)");
		return GtkOffscreenWindowHandleExterns.gtk_offscreen_window_get_pixbuf(offscreen);
	}

	public static MentorLake.cairo.cairo_surface_tHandle GetSurface(this MentorLake.Gtk.GtkOffscreenWindowHandle offscreen)
	{
		if (offscreen.IsInvalid || offscreen.IsClosed) throw new Exception("Invalid or closed handle (GtkOffscreenWindowHandle)");
		return GtkOffscreenWindowHandleExterns.gtk_offscreen_window_get_surface(offscreen);
	}

}

internal class GtkOffscreenWindowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkOffscreenWindowHandle gtk_offscreen_window_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_offscreen_window_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOffscreenWindowHandle>))] MentorLake.Gtk.GtkOffscreenWindowHandle offscreen);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gtk_offscreen_window_get_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOffscreenWindowHandle>))] MentorLake.Gtk.GtkOffscreenWindowHandle offscreen);

}
