namespace MentorLake.Gtk;


public interface GtkCellAccessibleParentHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkCellAccessibleParentHandleImpl : BaseSafeHandle, GtkCellAccessibleParentHandle
{
}

public static class GtkCellAccessibleParentHandleExtensions
{

/// <param name="parent">
/// </param>
/// <param name="cell">
/// </param>

	public static T Activate<T>(this T parent, MentorLake.Gtk.GtkCellAccessibleHandle cell) where T : GtkCellAccessibleParentHandle
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GtkCellAccessibleParentHandle)");
		GtkCellAccessibleParentHandleExterns.gtk_cell_accessible_parent_activate(parent, cell);
		return parent;
	}


/// <param name="parent">
/// </param>
/// <param name="cell">
/// </param>

	public static T Edit<T>(this T parent, MentorLake.Gtk.GtkCellAccessibleHandle cell) where T : GtkCellAccessibleParentHandle
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GtkCellAccessibleParentHandle)");
		GtkCellAccessibleParentHandleExterns.gtk_cell_accessible_parent_edit(parent, cell);
		return parent;
	}


/// <param name="parent">
/// </param>
/// <param name="cell">
/// </param>

	public static T ExpandCollapse<T>(this T parent, MentorLake.Gtk.GtkCellAccessibleHandle cell) where T : GtkCellAccessibleParentHandle
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GtkCellAccessibleParentHandle)");
		GtkCellAccessibleParentHandleExterns.gtk_cell_accessible_parent_expand_collapse(parent, cell);
		return parent;
	}


/// <param name="parent">
/// </param>
/// <param name="cell">
/// </param>
/// <param name="cell_rect">
/// </param>

	public static T GetCellArea<T>(this T parent, MentorLake.Gtk.GtkCellAccessibleHandle cell, out MentorLake.Gdk.GdkRectangle cell_rect) where T : GtkCellAccessibleParentHandle
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GtkCellAccessibleParentHandle)");
		GtkCellAccessibleParentHandleExterns.gtk_cell_accessible_parent_get_cell_area(parent, cell, out cell_rect);
		return parent;
	}


/// <param name="parent">
/// </param>
/// <param name="cell">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>
/// <param name="width">
/// </param>
/// <param name="height">
/// </param>
/// <param name="coord_type">
/// </param>

	public static T GetCellExtents<T>(this T parent, MentorLake.Gtk.GtkCellAccessibleHandle cell, out int x, out int y, out int width, out int height, MentorLake.Atk.AtkCoordType coord_type) where T : GtkCellAccessibleParentHandle
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GtkCellAccessibleParentHandle)");
		GtkCellAccessibleParentHandleExterns.gtk_cell_accessible_parent_get_cell_extents(parent, cell, out x, out y, out width, out height, coord_type);
		return parent;
	}


/// <param name="parent">
/// </param>
/// <param name="cell">
/// </param>
/// <param name="row">
/// </param>
/// <param name="column">
/// </param>

	public static T GetCellPosition<T>(this T parent, MentorLake.Gtk.GtkCellAccessibleHandle cell, out int row, out int column) where T : GtkCellAccessibleParentHandle
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GtkCellAccessibleParentHandle)");
		GtkCellAccessibleParentHandleExterns.gtk_cell_accessible_parent_get_cell_position(parent, cell, out row, out column);
		return parent;
	}


/// <param name="parent">
/// </param>
/// <param name="cell">
/// </param>

	public static int GetChildIndex(this MentorLake.Gtk.GtkCellAccessibleParentHandle parent, MentorLake.Gtk.GtkCellAccessibleHandle cell)
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GtkCellAccessibleParentHandle)");
		return GtkCellAccessibleParentHandleExterns.gtk_cell_accessible_parent_get_child_index(parent, cell);
	}


/// <param name="parent">
/// </param>
/// <param name="cell">
/// </param>

	public static MentorLake.GLib.GPtrArrayHandle GetColumnHeaderCells(this MentorLake.Gtk.GtkCellAccessibleParentHandle parent, MentorLake.Gtk.GtkCellAccessibleHandle cell)
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GtkCellAccessibleParentHandle)");
		return GtkCellAccessibleParentHandleExterns.gtk_cell_accessible_parent_get_column_header_cells(parent, cell);
	}


/// <param name="parent">
/// </param>
/// <param name="cell">
/// </param>

	public static MentorLake.Gtk.GtkCellRendererState GetRendererState(this MentorLake.Gtk.GtkCellAccessibleParentHandle parent, MentorLake.Gtk.GtkCellAccessibleHandle cell)
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GtkCellAccessibleParentHandle)");
		return GtkCellAccessibleParentHandleExterns.gtk_cell_accessible_parent_get_renderer_state(parent, cell);
	}


/// <param name="parent">
/// </param>
/// <param name="cell">
/// </param>

	public static MentorLake.GLib.GPtrArrayHandle GetRowHeaderCells(this MentorLake.Gtk.GtkCellAccessibleParentHandle parent, MentorLake.Gtk.GtkCellAccessibleHandle cell)
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GtkCellAccessibleParentHandle)");
		return GtkCellAccessibleParentHandleExterns.gtk_cell_accessible_parent_get_row_header_cells(parent, cell);
	}


/// <param name="parent">
/// </param>
/// <param name="cell">
/// </param>

	public static bool GrabFocus(this MentorLake.Gtk.GtkCellAccessibleParentHandle parent, MentorLake.Gtk.GtkCellAccessibleHandle cell)
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GtkCellAccessibleParentHandle)");
		return GtkCellAccessibleParentHandleExterns.gtk_cell_accessible_parent_grab_focus(parent, cell);
	}


/// <param name="parent">
/// </param>
/// <param name="cell">
/// </param>
/// <param name="relationset">
/// </param>

	public static T UpdateRelationset<T>(this T parent, MentorLake.Gtk.GtkCellAccessibleHandle cell, MentorLake.Atk.AtkRelationSetHandle relationset) where T : GtkCellAccessibleParentHandle
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GtkCellAccessibleParentHandle)");
		GtkCellAccessibleParentHandleExterns.gtk_cell_accessible_parent_update_relationset(parent, cell, relationset);
		return parent;
	}

}

internal class GtkCellAccessibleParentHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_accessible_parent_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleParentHandleImpl>))] MentorLake.Gtk.GtkCellAccessibleParentHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_accessible_parent_edit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleParentHandleImpl>))] MentorLake.Gtk.GtkCellAccessibleParentHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_accessible_parent_expand_collapse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleParentHandleImpl>))] MentorLake.Gtk.GtkCellAccessibleParentHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_accessible_parent_get_cell_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleParentHandleImpl>))] MentorLake.Gtk.GtkCellAccessibleParentHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle cell, out MentorLake.Gdk.GdkRectangle cell_rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_accessible_parent_get_cell_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleParentHandleImpl>))] MentorLake.Gtk.GtkCellAccessibleParentHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle cell, out int x, out int y, out int width, out int height, MentorLake.Atk.AtkCoordType coord_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_accessible_parent_get_cell_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleParentHandleImpl>))] MentorLake.Gtk.GtkCellAccessibleParentHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle cell, out int row, out int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_cell_accessible_parent_get_child_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleParentHandleImpl>))] MentorLake.Gtk.GtkCellAccessibleParentHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle cell);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle gtk_cell_accessible_parent_get_column_header_cells([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleParentHandleImpl>))] MentorLake.Gtk.GtkCellAccessibleParentHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCellRendererState gtk_cell_accessible_parent_get_renderer_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleParentHandleImpl>))] MentorLake.Gtk.GtkCellAccessibleParentHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle cell);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle gtk_cell_accessible_parent_get_row_header_cells([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleParentHandleImpl>))] MentorLake.Gtk.GtkCellAccessibleParentHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_accessible_parent_grab_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleParentHandleImpl>))] MentorLake.Gtk.GtkCellAccessibleParentHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_accessible_parent_update_relationset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleParentHandleImpl>))] MentorLake.Gtk.GtkCellAccessibleParentHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle relationset);

}
