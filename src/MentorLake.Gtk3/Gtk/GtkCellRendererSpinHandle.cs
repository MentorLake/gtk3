namespace MentorLake.Gtk;

public class GtkCellRendererSpinHandle : GtkCellRendererTextHandle
{
	public static MentorLake.Gtk.GtkCellRendererSpinHandle New()
	{
		return GtkCellRendererSpinHandleExterns.gtk_cell_renderer_spin_new();
	}

}

public static class GtkCellRendererSpinHandleExtensions
{
}

internal class GtkCellRendererSpinHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererSpinHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererSpinHandle gtk_cell_renderer_spin_new();

}
