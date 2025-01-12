namespace MentorLake.Gtk3.Gtk3;

public class GtkGridHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkGridHandle New()
	{
		return GtkGridExterns.gtk_grid_new();
	}

}

public static class GtkGridHandleExtensions
{
	public static T Attach<T>(this T grid, GtkWidgetHandle child, int left, int top, int width, int height) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_attach(grid, child, left, top, width, height);
		return grid;
	}

	public static T AttachNextTo<T>(this T grid, GtkWidgetHandle child, GtkWidgetHandle sibling, GtkPositionType side, int width, int height) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_attach_next_to(grid, child, sibling, side, width, height);
		return grid;
	}

	public static int GetBaselineRow(this GtkGridHandle grid)
	{
		return GtkGridExterns.gtk_grid_get_baseline_row(grid);
	}

	public static GtkWidgetHandle GetChildAt(this GtkGridHandle grid, int left, int top)
	{
		return GtkGridExterns.gtk_grid_get_child_at(grid, left, top);
	}

	public static bool GetColumnHomogeneous(this GtkGridHandle grid)
	{
		return GtkGridExterns.gtk_grid_get_column_homogeneous(grid);
	}

	public static uint GetColumnSpacing(this GtkGridHandle grid)
	{
		return GtkGridExterns.gtk_grid_get_column_spacing(grid);
	}

	public static GtkBaselinePosition GetRowBaselinePosition(this GtkGridHandle grid, int row)
	{
		return GtkGridExterns.gtk_grid_get_row_baseline_position(grid, row);
	}

	public static bool GetRowHomogeneous(this GtkGridHandle grid)
	{
		return GtkGridExterns.gtk_grid_get_row_homogeneous(grid);
	}

	public static uint GetRowSpacing(this GtkGridHandle grid)
	{
		return GtkGridExterns.gtk_grid_get_row_spacing(grid);
	}

	public static T InsertColumn<T>(this T grid, int position) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_insert_column(grid, position);
		return grid;
	}

	public static T InsertNextTo<T>(this T grid, GtkWidgetHandle sibling, GtkPositionType side) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_insert_next_to(grid, sibling, side);
		return grid;
	}

	public static T InsertRow<T>(this T grid, int position) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_insert_row(grid, position);
		return grid;
	}

	public static T RemoveColumn<T>(this T grid, int position) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_remove_column(grid, position);
		return grid;
	}

	public static T RemoveRow<T>(this T grid, int position) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_remove_row(grid, position);
		return grid;
	}

	public static T SetBaselineRow<T>(this T grid, int row) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_set_baseline_row(grid, row);
		return grid;
	}

	public static T SetColumnHomogeneous<T>(this T grid, bool homogeneous) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_set_column_homogeneous(grid, homogeneous);
		return grid;
	}

	public static T SetColumnSpacing<T>(this T grid, uint spacing) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_set_column_spacing(grid, spacing);
		return grid;
	}

	public static T SetRowBaselinePosition<T>(this T grid, int row, GtkBaselinePosition pos) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_set_row_baseline_position(grid, row, pos);
		return grid;
	}

	public static T SetRowHomogeneous<T>(this T grid, bool homogeneous) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_set_row_homogeneous(grid, homogeneous);
		return grid;
	}

	public static T SetRowSpacing<T>(this T grid, uint spacing) where T : GtkGridHandle
	{
		GtkGridExterns.gtk_grid_set_row_spacing(grid, spacing);
		return grid;
	}

}

internal class GtkGridExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkGridHandle gtk_grid_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_attach(GtkGridHandle grid, GtkWidgetHandle child, int left, int top, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_attach_next_to(GtkGridHandle grid, GtkWidgetHandle child, GtkWidgetHandle sibling, GtkPositionType side, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_grid_get_baseline_row(GtkGridHandle grid);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_grid_get_child_at(GtkGridHandle grid, int left, int top);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_grid_get_column_homogeneous(GtkGridHandle grid);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_grid_get_column_spacing(GtkGridHandle grid);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBaselinePosition gtk_grid_get_row_baseline_position(GtkGridHandle grid, int row);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_grid_get_row_homogeneous(GtkGridHandle grid);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_grid_get_row_spacing(GtkGridHandle grid);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_insert_column(GtkGridHandle grid, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_insert_next_to(GtkGridHandle grid, GtkWidgetHandle sibling, GtkPositionType side);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_insert_row(GtkGridHandle grid, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_remove_column(GtkGridHandle grid, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_remove_row(GtkGridHandle grid, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_set_baseline_row(GtkGridHandle grid, int row);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_set_column_homogeneous(GtkGridHandle grid, bool homogeneous);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_set_column_spacing(GtkGridHandle grid, uint spacing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_set_row_baseline_position(GtkGridHandle grid, int row, GtkBaselinePosition pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_set_row_homogeneous(GtkGridHandle grid, bool homogeneous);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grid_set_row_spacing(GtkGridHandle grid, uint spacing);

}
