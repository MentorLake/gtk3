namespace MentorLake.Gtk3.Gdk3X11;

public class GdkX11VisualHandle : GdkVisualHandle
{
}

public static class GdkX11VisualHandleExtensions
{
	public static GdkVisualHandle GetXvisual(this GdkX11VisualHandle visual)
	{
		return GdkX11VisualExterns.gdk_x11_visual_get_xvisual(visual);
	}

}

internal class GdkX11VisualExterns
{
	[DllImport(Libraries.Gdk3X11)]
	internal static extern GdkVisualHandle gdk_x11_visual_get_xvisual(GdkVisualHandle visual);

}
