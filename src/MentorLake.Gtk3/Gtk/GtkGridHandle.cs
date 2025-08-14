namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkGrid is a container which arranges its child widgets in
/// rows and columns, with arbitrary positions and horizontal/vertical spans.
/// </para>
/// <para>
/// Children are added using gtk_grid_attach(). They can span multiple
/// rows or columns. It is also possible to add a child next to an
/// existing child, using gtk_grid_attach_next_to(). The behaviour of
/// GtkGrid when several children occupy the same grid cell is undefined.
/// </para>
/// <para>
/// GtkGrid can be used like a #GtkBox by just using gtk_container_add(),
/// which will place children next to each other in the direction determined
/// by the #GtkOrientable:orientation property. However, if all you want is a
/// single row or column, then #GtkBox is the preferred widget.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkGrid uses a single CSS node with name grid.
/// </para>
/// </summary>

public class GtkGridHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new grid widget.
/// </para>
/// </summary>

/// <return>
/// the new #GtkGrid
/// </return>

	public static MentorLake.Gtk.GtkGridHandle New()
	{
		return GtkGridHandleExterns.gtk_grid_new();
	}

}

public static class GtkGridHandleExtensions
{
/// <summary>
/// <para>
/// Adds a widget to the grid.
/// </para>
/// <para>
/// The position of @child is determined by @left and @top. The
/// number of “cells” that @child will occupy is determined by
/// @width and @height.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="child">
/// the widget to add
/// </param>
/// <param name="left">
/// the column number to attach the left side of @child to
/// </param>
/// <param name="top">
/// the row number to attach the top side of @child to
/// </param>
/// <param name="width">
/// the number of columns that @child will span
/// </param>
/// <param name="height">
/// the number of rows that @child will span
/// </param>

	public static T Attach<T>(this T grid, MentorLake.Gtk.GtkWidgetHandle child, int left, int top, int width, int height) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_attach(grid, child, left, top, width, height);
		return grid;
	}

/// <summary>
/// <para>
/// Adds a widget to the grid.
/// </para>
/// <para>
/// The widget is placed next to @sibling, on the side determined by
/// @side. When @sibling is %NULL, the widget is placed in row (for
/// left or right placement) or column 0 (for top or bottom placement),
/// at the end indicated by @side.
/// </para>
/// <para>
/// Attaching widgets labeled [1], [2], [3] with @sibling == %NULL and
/// @side == %GTK_POS_LEFT yields a layout of [3][2][1].
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="child">
/// the widget to add
/// </param>
/// <param name="sibling">
/// the child of @grid that @child will be placed
///     next to, or %NULL to place @child at the beginning or end
/// </param>
/// <param name="side">
/// the side of @sibling that @child is positioned next to
/// </param>
/// <param name="width">
/// the number of columns that @child will span
/// </param>
/// <param name="height">
/// the number of rows that @child will span
/// </param>

	public static T AttachNextTo<T>(this T grid, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle sibling, MentorLake.Gtk.GtkPositionType side, int width, int height) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_attach_next_to(grid, child, sibling, side, width, height);
		return grid;
	}

/// <summary>
/// <para>
/// Returns which row defines the global baseline of @grid.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <return>
/// the row index defining the global baseline
/// </return>

	public static int GetBaselineRow(this MentorLake.Gtk.GtkGridHandle grid)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_baseline_row(grid);
	}

/// <summary>
/// <para>
/// Gets the child of @grid whose area covers the grid
/// cell whose upper left corner is at @left, @top.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="left">
/// the left edge of the cell
/// </param>
/// <param name="top">
/// the top edge of the cell
/// </param>
/// <return>
/// the child at the given position, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetChildAt(this MentorLake.Gtk.GtkGridHandle grid, int left, int top)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_child_at(grid, left, top);
	}

/// <summary>
/// <para>
/// Returns whether all columns of @grid have the same width.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <return>
/// whether all columns of @grid have the same width.
/// </return>

	public static bool GetColumnHomogeneous(this MentorLake.Gtk.GtkGridHandle grid)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_column_homogeneous(grid);
	}

/// <summary>
/// <para>
/// Returns the amount of space between the columns of @grid.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <return>
/// the column spacing of @grid
/// </return>

	public static uint GetColumnSpacing(this MentorLake.Gtk.GtkGridHandle grid)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_column_spacing(grid);
	}

/// <summary>
/// <para>
/// Returns the baseline position of @row as set
/// by gtk_grid_set_row_baseline_position() or the default value
/// %GTK_BASELINE_POSITION_CENTER.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="row">
/// a row index
/// </param>
/// <return>
/// the baseline position of @row
/// </return>

	public static MentorLake.Gtk.GtkBaselinePosition GetRowBaselinePosition(this MentorLake.Gtk.GtkGridHandle grid, int row)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_row_baseline_position(grid, row);
	}

/// <summary>
/// <para>
/// Returns whether all rows of @grid have the same height.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <return>
/// whether all rows of @grid have the same height.
/// </return>

	public static bool GetRowHomogeneous(this MentorLake.Gtk.GtkGridHandle grid)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_row_homogeneous(grid);
	}

/// <summary>
/// <para>
/// Returns the amount of space between the rows of @grid.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <return>
/// the row spacing of @grid
/// </return>

	public static uint GetRowSpacing(this MentorLake.Gtk.GtkGridHandle grid)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_row_spacing(grid);
	}

/// <summary>
/// <para>
/// Inserts a column at the specified position.
/// </para>
/// <para>
/// Children which are attached at or to the right of this position
/// are moved one column to the right. Children which span across this
/// position are grown to span the new column.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="position">
/// the position to insert the column at
/// </param>

	public static T InsertColumn<T>(this T grid, int position) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_insert_column(grid, position);
		return grid;
	}

/// <summary>
/// <para>
/// Inserts a row or column at the specified position.
/// </para>
/// <para>
/// The new row or column is placed next to @sibling, on the side
/// determined by @side. If @side is %GTK_POS_TOP or %GTK_POS_BOTTOM,
/// a row is inserted. If @side is %GTK_POS_LEFT of %GTK_POS_RIGHT,
/// a column is inserted.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="sibling">
/// the child of @grid that the new row or column will be
///     placed next to
/// </param>
/// <param name="side">
/// the side of @sibling that @child is positioned next to
/// </param>

	public static T InsertNextTo<T>(this T grid, MentorLake.Gtk.GtkWidgetHandle sibling, MentorLake.Gtk.GtkPositionType side) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_insert_next_to(grid, sibling, side);
		return grid;
	}

/// <summary>
/// <para>
/// Inserts a row at the specified position.
/// </para>
/// <para>
/// Children which are attached at or below this position
/// are moved one row down. Children which span across this
/// position are grown to span the new row.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="position">
/// the position to insert the row at
/// </param>

	public static T InsertRow<T>(this T grid, int position) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_insert_row(grid, position);
		return grid;
	}

/// <summary>
/// <para>
/// Removes a column from the grid.
/// </para>
/// <para>
/// Children that are placed in this column are removed,
/// spanning children that overlap this column have their
/// width reduced by one, and children after the column
/// are moved to the left.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="position">
/// the position of the column to remove
/// </param>

	public static T RemoveColumn<T>(this T grid, int position) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_remove_column(grid, position);
		return grid;
	}

/// <summary>
/// <para>
/// Removes a row from the grid.
/// </para>
/// <para>
/// Children that are placed in this row are removed,
/// spanning children that overlap this row have their
/// height reduced by one, and children below the row
/// are moved up.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="position">
/// the position of the row to remove
/// </param>

	public static T RemoveRow<T>(this T grid, int position) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_remove_row(grid, position);
		return grid;
	}

/// <summary>
/// <para>
/// Sets which row defines the global baseline for the entire grid.
/// Each row in the grid can have its own local baseline, but only
/// one of those is global, meaning it will be the baseline in the
/// parent of the @grid.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="row">
/// the row index
/// </param>

	public static T SetBaselineRow<T>(this T grid, int row) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_set_baseline_row(grid, row);
		return grid;
	}

/// <summary>
/// <para>
/// Sets whether all columns of @grid will have the same width.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="homogeneous">
/// %TRUE to make columns homogeneous
/// </param>

	public static T SetColumnHomogeneous<T>(this T grid, bool homogeneous) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_set_column_homogeneous(grid, homogeneous);
		return grid;
	}

/// <summary>
/// <para>
/// Sets the amount of space between columns of @grid.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="spacing">
/// the amount of space to insert between columns
/// </param>

	public static T SetColumnSpacing<T>(this T grid, uint spacing) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_set_column_spacing(grid, spacing);
		return grid;
	}

/// <summary>
/// <para>
/// Sets how the baseline should be positioned on @row of the
/// grid, in case that row is assigned more space than is requested.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="row">
/// a row index
/// </param>
/// <param name="pos">
/// a #GtkBaselinePosition
/// </param>

	public static T SetRowBaselinePosition<T>(this T grid, int row, MentorLake.Gtk.GtkBaselinePosition pos) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_set_row_baseline_position(grid, row, pos);
		return grid;
	}

/// <summary>
/// <para>
/// Sets whether all rows of @grid will have the same height.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="homogeneous">
/// %TRUE to make rows homogeneous
/// </param>

	public static T SetRowHomogeneous<T>(this T grid, bool homogeneous) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_set_row_homogeneous(grid, homogeneous);
		return grid;
	}

/// <summary>
/// <para>
/// Sets the amount of space between rows of @grid.
/// </para>
/// </summary>

/// <param name="grid">
/// a #GtkGrid
/// </param>
/// <param name="spacing">
/// the amount of space to insert between rows
/// </param>

	public static T SetRowSpacing<T>(this T grid, uint spacing) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_set_row_spacing(grid, spacing);
		return grid;
	}

}

internal class GtkGridHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))]
	internal static extern MentorLake.Gtk.GtkGridHandle gtk_grid_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int left, int top, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_attach_next_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle sibling, MentorLake.Gtk.GtkPositionType side, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_grid_get_baseline_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_grid_get_child_at([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, int left, int top);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_grid_get_column_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_grid_get_column_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBaselinePosition gtk_grid_get_row_baseline_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, int row);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_grid_get_row_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_grid_get_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_insert_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_insert_next_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle sibling, MentorLake.Gtk.GtkPositionType side);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_insert_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_remove_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_remove_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_set_baseline_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, int row);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_set_column_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, bool homogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_set_column_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, uint spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_set_row_baseline_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, int row, MentorLake.Gtk.GtkBaselinePosition pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_set_row_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, bool homogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grid_set_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGridHandle>))] MentorLake.Gtk.GtkGridHandle grid, uint spacing);

}
