namespace MentorLake.Gtk3.Gtk3;

public class GtkTableHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkTableHandle New(uint rows, uint columns, bool homogeneous)
	{
		return GtkTableExterns.gtk_table_new(rows, columns, homogeneous);
	}

}

public static class GtkTableHandleExtensions
{
	public static GtkTableHandle Attach(this GtkTableHandle table, GtkWidgetHandle child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach, GtkAttachOptions xoptions, GtkAttachOptions yoptions, uint xpadding, uint ypadding)
	{
		GtkTableExterns.gtk_table_attach(table, child, left_attach, right_attach, top_attach, bottom_attach, xoptions, yoptions, xpadding, ypadding);
		return table;
	}

	public static GtkTableHandle AttachDefaults(this GtkTableHandle table, GtkWidgetHandle widget, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach)
	{
		GtkTableExterns.gtk_table_attach_defaults(table, widget, left_attach, right_attach, top_attach, bottom_attach);
		return table;
	}

	public static uint GetColSpacing(this GtkTableHandle table, uint column)
	{
		return GtkTableExterns.gtk_table_get_col_spacing(table, column);
	}

	public static uint GetDefaultColSpacing(this GtkTableHandle table)
	{
		return GtkTableExterns.gtk_table_get_default_col_spacing(table);
	}

	public static uint GetDefaultRowSpacing(this GtkTableHandle table)
	{
		return GtkTableExterns.gtk_table_get_default_row_spacing(table);
	}

	public static bool GetHomogeneous(this GtkTableHandle table)
	{
		return GtkTableExterns.gtk_table_get_homogeneous(table);
	}

	public static uint GetRowSpacing(this GtkTableHandle table, uint row)
	{
		return GtkTableExterns.gtk_table_get_row_spacing(table, row);
	}

	public static GtkTableHandle GetSize(this GtkTableHandle table, out uint rows, out uint columns)
	{
		GtkTableExterns.gtk_table_get_size(table, out rows, out columns);
		return table;
	}

	public static GtkTableHandle Resize(this GtkTableHandle table, uint rows, uint columns)
	{
		GtkTableExterns.gtk_table_resize(table, rows, columns);
		return table;
	}

	public static GtkTableHandle SetColSpacing(this GtkTableHandle table, uint column, uint spacing)
	{
		GtkTableExterns.gtk_table_set_col_spacing(table, column, spacing);
		return table;
	}

	public static GtkTableHandle SetColSpacings(this GtkTableHandle table, uint spacing)
	{
		GtkTableExterns.gtk_table_set_col_spacings(table, spacing);
		return table;
	}

	public static GtkTableHandle SetHomogeneous(this GtkTableHandle table, bool homogeneous)
	{
		GtkTableExterns.gtk_table_set_homogeneous(table, homogeneous);
		return table;
	}

	public static GtkTableHandle SetRowSpacing(this GtkTableHandle table, uint row, uint spacing)
	{
		GtkTableExterns.gtk_table_set_row_spacing(table, row, spacing);
		return table;
	}

	public static GtkTableHandle SetRowSpacings(this GtkTableHandle table, uint spacing)
	{
		GtkTableExterns.gtk_table_set_row_spacings(table, spacing);
		return table;
	}

}

internal class GtkTableExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTableHandle gtk_table_new(uint rows, uint columns, bool homogeneous);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_table_attach(GtkTableHandle table, GtkWidgetHandle child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach, GtkAttachOptions xoptions, GtkAttachOptions yoptions, uint xpadding, uint ypadding);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_table_attach_defaults(GtkTableHandle table, GtkWidgetHandle widget, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_table_get_col_spacing(GtkTableHandle table, uint column);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_table_get_default_col_spacing(GtkTableHandle table);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_table_get_default_row_spacing(GtkTableHandle table);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_table_get_homogeneous(GtkTableHandle table);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_table_get_row_spacing(GtkTableHandle table, uint row);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_table_get_size(GtkTableHandle table, out uint rows, out uint columns);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_table_resize(GtkTableHandle table, uint rows, uint columns);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_table_set_col_spacing(GtkTableHandle table, uint column, uint spacing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_table_set_col_spacings(GtkTableHandle table, uint spacing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_table_set_homogeneous(GtkTableHandle table, bool homogeneous);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_table_set_row_spacing(GtkTableHandle table, uint row, uint spacing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_table_set_row_spacings(GtkTableHandle table, uint spacing);

}
