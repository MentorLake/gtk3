namespace MentorLake.Gtk3.Gtk3;

public class GtkCellAreaBoxHandle : GtkCellAreaHandle, GtkBuildableHandle, GtkCellLayoutHandle, GtkOrientableHandle
{
	public static GtkCellAreaBoxHandle New()
	{
		return GtkCellAreaBoxExterns.gtk_cell_area_box_new();
	}

}

public static class GtkCellAreaBoxHandleExtensions
{
	public static int GetSpacing(this GtkCellAreaBoxHandle box)
	{
		return GtkCellAreaBoxExterns.gtk_cell_area_box_get_spacing(box);
	}

	public static T PackEnd<T>(this T box, GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed) where T : GtkCellAreaBoxHandle
	{
		GtkCellAreaBoxExterns.gtk_cell_area_box_pack_end(box, renderer, expand, align, @fixed);
		return box;
	}

	public static T PackStart<T>(this T box, GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed) where T : GtkCellAreaBoxHandle
	{
		GtkCellAreaBoxExterns.gtk_cell_area_box_pack_start(box, renderer, expand, align, @fixed);
		return box;
	}

	public static T SetSpacing<T>(this T box, int spacing) where T : GtkCellAreaBoxHandle
	{
		GtkCellAreaBoxExterns.gtk_cell_area_box_set_spacing(box, spacing);
		return box;
	}

}

internal class GtkCellAreaBoxExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellAreaBoxHandle gtk_cell_area_box_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_cell_area_box_get_spacing(GtkCellAreaBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_box_pack_end(GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_box_pack_start(GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_box_set_spacing(GtkCellAreaBoxHandle box, int spacing);

}
