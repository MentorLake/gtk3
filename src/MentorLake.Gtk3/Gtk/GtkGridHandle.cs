namespace MentorLake.Gtk;

public class GtkGridHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkGridHandle New()
	{
		return GtkGridHandleExterns.gtk_grid_new();
	}

}

public static class GtkGridHandleExtensions
{
	public static T Attach<T>(this T grid, MentorLake.Gtk.GtkWidgetHandle child, int left, int top, int width, int height) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_attach(grid, child, left, top, width, height);
		return grid;
	}

	public static T AttachNextTo<T>(this T grid, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle sibling, MentorLake.Gtk.GtkPositionType side, int width, int height) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_attach_next_to(grid, child, sibling, side, width, height);
		return grid;
	}

	public static int GetBaselineRow(this MentorLake.Gtk.GtkGridHandle grid)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_baseline_row(grid);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetChildAt(this MentorLake.Gtk.GtkGridHandle grid, int left, int top)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_child_at(grid, left, top);
	}

	public static bool GetColumnHomogeneous(this MentorLake.Gtk.GtkGridHandle grid)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_column_homogeneous(grid);
	}

	public static uint GetColumnSpacing(this MentorLake.Gtk.GtkGridHandle grid)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_column_spacing(grid);
	}

	public static MentorLake.Gtk.GtkBaselinePosition GetRowBaselinePosition(this MentorLake.Gtk.GtkGridHandle grid, int row)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_row_baseline_position(grid, row);
	}

	public static bool GetRowHomogeneous(this MentorLake.Gtk.GtkGridHandle grid)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_row_homogeneous(grid);
	}

	public static uint GetRowSpacing(this MentorLake.Gtk.GtkGridHandle grid)
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		return GtkGridHandleExterns.gtk_grid_get_row_spacing(grid);
	}

	public static T InsertColumn<T>(this T grid, int position) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_insert_column(grid, position);
		return grid;
	}

	public static T InsertNextTo<T>(this T grid, MentorLake.Gtk.GtkWidgetHandle sibling, MentorLake.Gtk.GtkPositionType side) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_insert_next_to(grid, sibling, side);
		return grid;
	}

	public static T InsertRow<T>(this T grid, int position) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_insert_row(grid, position);
		return grid;
	}

	public static T RemoveColumn<T>(this T grid, int position) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_remove_column(grid, position);
		return grid;
	}

	public static T RemoveRow<T>(this T grid, int position) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_remove_row(grid, position);
		return grid;
	}

	public static T SetBaselineRow<T>(this T grid, int row) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_set_baseline_row(grid, row);
		return grid;
	}

	public static T SetColumnHomogeneous<T>(this T grid, bool homogeneous) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_set_column_homogeneous(grid, homogeneous);
		return grid;
	}

	public static T SetColumnSpacing<T>(this T grid, uint spacing) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_set_column_spacing(grid, spacing);
		return grid;
	}

	public static T SetRowBaselinePosition<T>(this T grid, int row, MentorLake.Gtk.GtkBaselinePosition pos) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_set_row_baseline_position(grid, row, pos);
		return grid;
	}

	public static T SetRowHomogeneous<T>(this T grid, bool homogeneous) where T : GtkGridHandle
	{
		if (grid.IsInvalid) throw new Exception("Invalid handle (GtkGridHandle)");
		GtkGridHandleExterns.gtk_grid_set_row_homogeneous(grid, homogeneous);
		return grid;
	}

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
