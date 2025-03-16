namespace MentorLake.Gtk;

public class GtkCellRendererPixbufHandle : GtkCellRendererHandle
{
	public static MentorLake.Gtk.GtkCellRendererPixbufHandle New()
	{
		return GtkCellRendererPixbufHandleExterns.gtk_cell_renderer_pixbuf_new();
	}

}

public static class GtkCellRendererPixbufHandleExtensions
{
}

internal class GtkCellRendererPixbufHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCellRendererPixbufHandle gtk_cell_renderer_pixbuf_new();

}
