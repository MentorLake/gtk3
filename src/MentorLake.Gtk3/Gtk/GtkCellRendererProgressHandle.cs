namespace MentorLake.Gtk;

public class GtkCellRendererProgressHandle : GtkCellRendererHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkCellRendererProgressHandle New()
	{
		return GtkCellRendererProgressHandleExterns.gtk_cell_renderer_progress_new();
	}

}

public static class GtkCellRendererProgressHandleExtensions
{
}

internal class GtkCellRendererProgressHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererProgressHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererProgressHandle gtk_cell_renderer_progress_new();

}
