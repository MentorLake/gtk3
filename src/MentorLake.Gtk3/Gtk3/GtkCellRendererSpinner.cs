namespace MentorLake.Gtk3.Gtk3;

public class GtkCellRendererSpinnerHandle : GtkCellRendererHandle
{
	public static GtkCellRendererSpinnerHandle New()
	{
		return GtkCellRendererSpinnerExterns.gtk_cell_renderer_spinner_new();
	}

}

public static class GtkCellRendererSpinnerHandleExtensions
{
}

internal class GtkCellRendererSpinnerExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellRendererSpinnerHandle gtk_cell_renderer_spinner_new();

}
