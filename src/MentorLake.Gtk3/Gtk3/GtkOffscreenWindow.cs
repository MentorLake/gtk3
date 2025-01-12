namespace MentorLake.Gtk3.Gtk3;

public class GtkOffscreenWindowHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkOffscreenWindowHandle New()
	{
		return GtkOffscreenWindowExterns.gtk_offscreen_window_new();
	}

}

public static class GtkOffscreenWindowHandleExtensions
{
	public static GdkPixbufHandle GetPixbuf(this GtkOffscreenWindowHandle offscreen)
	{
		return GtkOffscreenWindowExterns.gtk_offscreen_window_get_pixbuf(offscreen);
	}

	public static cairo_surface_tHandle GetSurface(this GtkOffscreenWindowHandle offscreen)
	{
		return GtkOffscreenWindowExterns.gtk_offscreen_window_get_surface(offscreen);
	}

}

internal class GtkOffscreenWindowExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkOffscreenWindowHandle gtk_offscreen_window_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_offscreen_window_get_pixbuf(GtkOffscreenWindowHandle offscreen);

	[DllImport(Libraries.Gtk3)]
	internal static extern cairo_surface_tHandle gtk_offscreen_window_get_surface(GtkOffscreenWindowHandle offscreen);

}
