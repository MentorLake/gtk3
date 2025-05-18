namespace MentorLake.Gtk;

public interface GtkCellLayoutHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkCellLayoutHandleImpl : BaseSafeHandle, GtkCellLayoutHandle
{
}

public static class GtkCellLayoutHandleExtensions
{
	public static T AddAttribute<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell, string attribute, int column) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_add_attribute(cell_layout, cell, attribute, column);
		return cell_layout;
	}

	public static T Clear<T>(this T cell_layout) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_clear(cell_layout);
		return cell_layout;
	}

	public static T ClearAttributes<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_clear_attributes(cell_layout, cell);
		return cell_layout;
	}

	public static MentorLake.Gtk.GtkCellAreaHandle GetArea(this MentorLake.Gtk.GtkCellLayoutHandle cell_layout)
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		return GtkCellLayoutHandleExterns.gtk_cell_layout_get_area(cell_layout);
	}

	public static MentorLake.GLib.GListHandle GetCells(this MentorLake.Gtk.GtkCellLayoutHandle cell_layout)
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		return GtkCellLayoutHandleExterns.gtk_cell_layout_get_cells(cell_layout);
	}

	public static T PackEnd<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell, bool expand) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_pack_end(cell_layout, cell, expand);
		return cell_layout;
	}

	public static T PackStart<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell, bool expand) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_pack_start(cell_layout, cell, expand);
		return cell_layout;
	}

	public static T Reorder<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell, int position) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_reorder(cell_layout, cell, position);
		return cell_layout;
	}

	public static T SetAttributes<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell, IntPtr @__arglist) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_set_attributes(cell_layout, cell, @__arglist);
		return cell_layout;
	}

	public static T SetCellDataFunc<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gtk.GtkCellLayoutDataFunc func, IntPtr func_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_set_cell_data_func(cell_layout, cell, func, func_data, destroy);
		return cell_layout;
	}

}

internal class GtkCellLayoutHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_add_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, string attribute, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_clear_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))]
	internal static extern MentorLake.Gtk.GtkCellAreaHandle gtk_cell_layout_get_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_cell_layout_get_cells([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_pack_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_pack_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_reorder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_set_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_set_cell_data_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gtk.GtkCellLayoutDataFunc func, IntPtr func_data, MentorLake.GLib.GDestroyNotify destroy);

}
