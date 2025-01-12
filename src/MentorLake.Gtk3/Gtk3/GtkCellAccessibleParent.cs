namespace MentorLake.Gtk3.Gtk3;

public interface GtkCellAccessibleParentHandle
{
}

internal class GtkCellAccessibleParentHandleImpl : BaseSafeHandle, GtkCellAccessibleParentHandle
{
}

public static class GtkCellAccessibleParentHandleExtensions
{
	public static T Activate<T>(this T parent, GtkCellAccessibleHandle cell) where T : GtkCellAccessibleParentHandle
	{
		GtkCellAccessibleParentExterns.gtk_cell_accessible_parent_activate(parent, cell);
		return parent;
	}

	public static T Edit<T>(this T parent, GtkCellAccessibleHandle cell) where T : GtkCellAccessibleParentHandle
	{
		GtkCellAccessibleParentExterns.gtk_cell_accessible_parent_edit(parent, cell);
		return parent;
	}

	public static T ExpandCollapse<T>(this T parent, GtkCellAccessibleHandle cell) where T : GtkCellAccessibleParentHandle
	{
		GtkCellAccessibleParentExterns.gtk_cell_accessible_parent_expand_collapse(parent, cell);
		return parent;
	}

	public static T GetCellArea<T>(this T parent, GtkCellAccessibleHandle cell, out GdkRectangle cell_rect) where T : GtkCellAccessibleParentHandle
	{
		GtkCellAccessibleParentExterns.gtk_cell_accessible_parent_get_cell_area(parent, cell, out cell_rect);
		return parent;
	}

	public static T GetCellExtents<T>(this T parent, GtkCellAccessibleHandle cell, out int x, out int y, out int width, out int height, AtkCoordType coord_type) where T : GtkCellAccessibleParentHandle
	{
		GtkCellAccessibleParentExterns.gtk_cell_accessible_parent_get_cell_extents(parent, cell, out x, out y, out width, out height, coord_type);
		return parent;
	}

	public static T GetCellPosition<T>(this T parent, GtkCellAccessibleHandle cell, out int row, out int column) where T : GtkCellAccessibleParentHandle
	{
		GtkCellAccessibleParentExterns.gtk_cell_accessible_parent_get_cell_position(parent, cell, out row, out column);
		return parent;
	}

	public static int GetChildIndex(this GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell)
	{
		return GtkCellAccessibleParentExterns.gtk_cell_accessible_parent_get_child_index(parent, cell);
	}

	public static IntPtr GetColumnHeaderCells(this GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell)
	{
		return GtkCellAccessibleParentExterns.gtk_cell_accessible_parent_get_column_header_cells(parent, cell);
	}

	public static GtkCellRendererState GetRendererState(this GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell)
	{
		return GtkCellAccessibleParentExterns.gtk_cell_accessible_parent_get_renderer_state(parent, cell);
	}

	public static IntPtr GetRowHeaderCells(this GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell)
	{
		return GtkCellAccessibleParentExterns.gtk_cell_accessible_parent_get_row_header_cells(parent, cell);
	}

	public static bool GrabFocus(this GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell)
	{
		return GtkCellAccessibleParentExterns.gtk_cell_accessible_parent_grab_focus(parent, cell);
	}

	public static T UpdateRelationset<T>(this T parent, GtkCellAccessibleHandle cell, AtkRelationSetHandle relationset) where T : GtkCellAccessibleParentHandle
	{
		GtkCellAccessibleParentExterns.gtk_cell_accessible_parent_update_relationset(parent, cell, relationset);
		return parent;
	}

}

internal class GtkCellAccessibleParentExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_accessible_parent_activate(GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_accessible_parent_edit(GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_accessible_parent_expand_collapse(GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_accessible_parent_get_cell_area(GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell, out GdkRectangle cell_rect);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_accessible_parent_get_cell_extents(GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell, out int x, out int y, out int width, out int height, AtkCoordType coord_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_accessible_parent_get_cell_position(GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell, out int row, out int column);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_cell_accessible_parent_get_child_index(GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_cell_accessible_parent_get_column_header_cells(GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellRendererState gtk_cell_accessible_parent_get_renderer_state(GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_cell_accessible_parent_get_row_header_cells(GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_accessible_parent_grab_focus(GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_accessible_parent_update_relationset(GtkCellAccessibleParentHandle parent, GtkCellAccessibleHandle cell, AtkRelationSetHandle relationset);

}
