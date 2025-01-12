namespace MentorLake.Gtk3.Gtk3;

public interface GtkCellLayoutHandle
{
}

internal class GtkCellLayoutHandleImpl : BaseSafeHandle, GtkCellLayoutHandle
{
}

public static class GtkCellLayoutHandleExtensions
{
	public static T AddAttribute<T>(this T cell_layout, GtkCellRendererHandle cell, string attribute, int column) where T : GtkCellLayoutHandle
	{
		GtkCellLayoutExterns.gtk_cell_layout_add_attribute(cell_layout, cell, attribute, column);
		return cell_layout;
	}

	public static T Clear<T>(this T cell_layout) where T : GtkCellLayoutHandle
	{
		GtkCellLayoutExterns.gtk_cell_layout_clear(cell_layout);
		return cell_layout;
	}

	public static T ClearAttributes<T>(this T cell_layout, GtkCellRendererHandle cell) where T : GtkCellLayoutHandle
	{
		GtkCellLayoutExterns.gtk_cell_layout_clear_attributes(cell_layout, cell);
		return cell_layout;
	}

	public static GtkCellAreaHandle GetArea(this GtkCellLayoutHandle cell_layout)
	{
		return GtkCellLayoutExterns.gtk_cell_layout_get_area(cell_layout);
	}

	public static GListHandle GetCells(this GtkCellLayoutHandle cell_layout)
	{
		return GtkCellLayoutExterns.gtk_cell_layout_get_cells(cell_layout);
	}

	public static T PackEnd<T>(this T cell_layout, GtkCellRendererHandle cell, bool expand) where T : GtkCellLayoutHandle
	{
		GtkCellLayoutExterns.gtk_cell_layout_pack_end(cell_layout, cell, expand);
		return cell_layout;
	}

	public static T PackStart<T>(this T cell_layout, GtkCellRendererHandle cell, bool expand) where T : GtkCellLayoutHandle
	{
		GtkCellLayoutExterns.gtk_cell_layout_pack_start(cell_layout, cell, expand);
		return cell_layout;
	}

	public static T Reorder<T>(this T cell_layout, GtkCellRendererHandle cell, int position) where T : GtkCellLayoutHandle
	{
		GtkCellLayoutExterns.gtk_cell_layout_reorder(cell_layout, cell, position);
		return cell_layout;
	}

	public static T SetAttributes<T>(this T cell_layout, GtkCellRendererHandle cell, IntPtr @__arglist) where T : GtkCellLayoutHandle
	{
		GtkCellLayoutExterns.gtk_cell_layout_set_attributes(cell_layout, cell, @__arglist);
		return cell_layout;
	}

	public static T SetCellDataFunc<T>(this T cell_layout, GtkCellRendererHandle cell, GtkCellLayoutDataFunc func, IntPtr func_data, GDestroyNotify destroy) where T : GtkCellLayoutHandle
	{
		GtkCellLayoutExterns.gtk_cell_layout_set_cell_data_func(cell_layout, cell, func, func_data, destroy);
		return cell_layout;
	}

}

internal class GtkCellLayoutExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_layout_add_attribute(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, string attribute, int column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_layout_clear(GtkCellLayoutHandle cell_layout);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_layout_clear_attributes(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellAreaHandle gtk_cell_layout_get_area(GtkCellLayoutHandle cell_layout);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_cell_layout_get_cells(GtkCellLayoutHandle cell_layout);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_layout_pack_end(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, bool expand);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_layout_pack_start(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, bool expand);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_layout_reorder(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_layout_set_attributes(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_layout_set_cell_data_func(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, GtkCellLayoutDataFunc func, IntPtr func_data, GDestroyNotify destroy);

}
