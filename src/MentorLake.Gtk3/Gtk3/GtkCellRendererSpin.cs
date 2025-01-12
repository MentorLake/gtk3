namespace MentorLake.Gtk3.Gtk3;

public class GtkCellRendererSpinHandle : GtkCellRendererTextHandle
{
	public static GtkCellRendererSpinHandle New()
	{
		return GtkCellRendererSpinExterns.gtk_cell_renderer_spin_new();
	}

}

public static class GtkCellRendererSpinHandleExtensions
{
}

internal class GtkCellRendererSpinExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellRendererSpinHandle gtk_cell_renderer_spin_new();

}
