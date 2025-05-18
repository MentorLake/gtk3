namespace MentorLake.Gtk;

public class GtkCellRendererSpinnerHandle : GtkCellRendererHandle
{
	public static MentorLake.Gtk.GtkCellRendererSpinnerHandle New()
	{
		return GtkCellRendererSpinnerHandleExterns.gtk_cell_renderer_spinner_new();
	}

}

public static class GtkCellRendererSpinnerHandleExtensions
{
}

internal class GtkCellRendererSpinnerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererSpinnerHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererSpinnerHandle gtk_cell_renderer_spinner_new();

}
