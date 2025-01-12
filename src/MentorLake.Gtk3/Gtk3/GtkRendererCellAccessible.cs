namespace MentorLake.Gtk3.Gtk3;

public class GtkRendererCellAccessibleHandle : GtkCellAccessibleHandle, AtkActionHandle, AtkComponentHandle, AtkTableCellHandle
{
	public static GtkRendererCellAccessibleHandle New(GtkCellRendererHandle renderer)
	{
		return GtkRendererCellAccessibleExterns.gtk_renderer_cell_accessible_new(renderer);
	}

}

public static class GtkRendererCellAccessibleHandleExtensions
{
}

internal class GtkRendererCellAccessibleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRendererCellAccessibleHandle gtk_renderer_cell_accessible_new(GtkCellRendererHandle renderer);

}
