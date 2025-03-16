namespace MentorLake.Gtk;

public class GtkTableHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkTableHandle New(uint rows, uint columns, bool homogeneous)
	{
		return GtkTableHandleExterns.gtk_table_new(rows, columns, homogeneous);
	}

}

public static class GtkTableHandleExtensions
{
	public static T Attach<T>(this T table, MentorLake.Gtk.GtkWidgetHandle child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach, MentorLake.Gtk.GtkAttachOptions xoptions, MentorLake.Gtk.GtkAttachOptions yoptions, uint xpadding, uint ypadding) where T : GtkTableHandle
	{
		GtkTableHandleExterns.gtk_table_attach(table, child, left_attach, right_attach, top_attach, bottom_attach, xoptions, yoptions, xpadding, ypadding);
		return table;
	}

	public static T AttachDefaults<T>(this T table, MentorLake.Gtk.GtkWidgetHandle widget, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach) where T : GtkTableHandle
	{
		GtkTableHandleExterns.gtk_table_attach_defaults(table, widget, left_attach, right_attach, top_attach, bottom_attach);
		return table;
	}

	public static uint GetColSpacing(this MentorLake.Gtk.GtkTableHandle table, uint column)
	{
		return GtkTableHandleExterns.gtk_table_get_col_spacing(table, column);
	}

	public static uint GetDefaultColSpacing(this MentorLake.Gtk.GtkTableHandle table)
	{
		return GtkTableHandleExterns.gtk_table_get_default_col_spacing(table);
	}

	public static uint GetDefaultRowSpacing(this MentorLake.Gtk.GtkTableHandle table)
	{
		return GtkTableHandleExterns.gtk_table_get_default_row_spacing(table);
	}

	public static bool GetHomogeneous(this MentorLake.Gtk.GtkTableHandle table)
	{
		return GtkTableHandleExterns.gtk_table_get_homogeneous(table);
	}

	public static uint GetRowSpacing(this MentorLake.Gtk.GtkTableHandle table, uint row)
	{
		return GtkTableHandleExterns.gtk_table_get_row_spacing(table, row);
	}

	public static T GetSize<T>(this T table, out uint rows, out uint columns) where T : GtkTableHandle
	{
		GtkTableHandleExterns.gtk_table_get_size(table, out rows, out columns);
		return table;
	}

	public static T Resize<T>(this T table, uint rows, uint columns) where T : GtkTableHandle
	{
		GtkTableHandleExterns.gtk_table_resize(table, rows, columns);
		return table;
	}

	public static T SetColSpacing<T>(this T table, uint column, uint spacing) where T : GtkTableHandle
	{
		GtkTableHandleExterns.gtk_table_set_col_spacing(table, column, spacing);
		return table;
	}

	public static T SetColSpacings<T>(this T table, uint spacing) where T : GtkTableHandle
	{
		GtkTableHandleExterns.gtk_table_set_col_spacings(table, spacing);
		return table;
	}

	public static T SetHomogeneous<T>(this T table, bool homogeneous) where T : GtkTableHandle
	{
		GtkTableHandleExterns.gtk_table_set_homogeneous(table, homogeneous);
		return table;
	}

	public static T SetRowSpacing<T>(this T table, uint row, uint spacing) where T : GtkTableHandle
	{
		GtkTableHandleExterns.gtk_table_set_row_spacing(table, row, spacing);
		return table;
	}

	public static T SetRowSpacings<T>(this T table, uint spacing) where T : GtkTableHandle
	{
		GtkTableHandleExterns.gtk_table_set_row_spacings(table, spacing);
		return table;
	}

}

internal class GtkTableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTableHandle gtk_table_new(uint rows, uint columns, bool homogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_table_attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach, MentorLake.Gtk.GtkAttachOptions xoptions, MentorLake.Gtk.GtkAttachOptions yoptions, uint xpadding, uint ypadding);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_table_attach_defaults([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_table_get_col_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table, uint column);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_table_get_default_col_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_table_get_default_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_table_get_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_table_get_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table, uint row);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_table_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table, out uint rows, out uint columns);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_table_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table, uint rows, uint columns);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_table_set_col_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table, uint column, uint spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_table_set_col_spacings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table, uint spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_table_set_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table, bool homogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_table_set_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table, uint row, uint spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_table_set_row_spacings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))] MentorLake.Gtk.GtkTableHandle table, uint spacing);

}
