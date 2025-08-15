namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkTable functions allow the programmer to arrange widgets in rows and
/// columns, making it easy to align many widgets next to each other,
/// horizontally and vertically.
/// </para>
/// <para>
/// Tables are created with a call to gtk_table_new(), the size of which can
/// later be changed with gtk_table_resize().
/// </para>
/// <para>
/// Widgets can be added to a table using gtk_table_attach() or the more
/// convenient (but slightly less flexible) gtk_table_attach_defaults().
/// </para>
/// <para>
/// To alter the space next to a specific row, use gtk_table_set_row_spacing(),
/// and for a column, gtk_table_set_col_spacing().
/// The gaps between all rows or columns can be changed by
/// calling gtk_table_set_row_spacings() or gtk_table_set_col_spacings()
/// respectively. Note that spacing is added between the
/// children, while padding added by gtk_table_attach() is added on
/// either side of the widget it belongs to.
/// </para>
/// <para>
/// gtk_table_set_homogeneous(), can be used to set whether all cells in the
/// table will resize themselves to the size of the largest widget in the table.
/// </para>
/// <para>
/// &amp;gt; #GtkTable has been deprecated. Use #GtkGrid instead. It provides the same
/// &amp;gt; capabilities as GtkTable for arranging widgets in a rectangular grid, but
/// &amp;gt; does support height-for-width geometry management.
/// </para>
/// </summary>

public class GtkTableHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Used to create a new table widget. An initial size must be given by
/// specifying how many rows and columns the table should have, although
/// this can be changed later with gtk_table_resize().  @rows and @columns
/// must both be in the range 1 .. 65535. For historical reasons, 0 is accepted
/// as well and is silently interpreted as 1.
/// </para>
/// </summary>

/// <param name="rows">
/// The number of rows the new table should have.
/// </param>
/// <param name="columns">
/// The number of columns the new table should have.
/// </param>
/// <param name="homogeneous">
/// If set to %TRUE, all table cells are resized to the size of
///   the cell containing the largest widget.
/// </param>
/// <return>
/// A pointer to the newly created table widget.
/// </return>

	public static MentorLake.Gtk.GtkTableHandle New(uint rows, uint columns, bool homogeneous)
	{
		return GtkTableHandleExterns.gtk_table_new(rows, columns, homogeneous);
	}

}

public static class GtkTableHandleExtensions
{
/// <summary>
/// <para>
/// Adds a widget to a table. The number of “cells” that a widget will occupy is
/// specified by @left_attach, @right_attach, @top_attach and @bottom_attach.
/// These each represent the leftmost, rightmost, uppermost and lowest column
/// and row numbers of the table. (Columns and rows are indexed from zero).
/// </para>
/// <para>
/// To make a button occupy the lower right cell of a 2x2 table, use
/// <code>
/// gtk_table_attach (table, button,
/// gtk_table_attach (table, button,
///                   1, 2, // left, right attach
///                   1, 2, // top, bottom attach
///                   xoptions, yoptions,
///                   xpadding, ypadding);
/// </code>
/// </para>
/// </summary>

/// <param name="table">
/// The #GtkTable to add a new widget to.
/// </param>
/// <param name="child">
/// The widget to add.
/// </param>
/// <param name="left_attach">
/// the column number to attach the left side of a child widget to.
/// </param>
/// <param name="right_attach">
/// the column number to attach the right side of a child widget to.
/// </param>
/// <param name="top_attach">
/// the row number to attach the top of a child widget to.
/// </param>
/// <param name="bottom_attach">
/// the row number to attach the bottom of a child widget to.
/// </param>
/// <param name="xoptions">
/// Used to specify the properties of the child widget when the table is resized.
/// </param>
/// <param name="yoptions">
/// The same as xoptions, except this field determines behaviour of vertical resizing.
/// </param>
/// <param name="xpadding">
/// An integer value specifying the padding on the left and right of the widget being added to the table.
/// </param>
/// <param name="ypadding">
/// The amount of padding above and below the child widget.
/// </param>

	public static T Attach<T>(this T table, MentorLake.Gtk.GtkWidgetHandle child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach, MentorLake.Gtk.GtkAttachOptions xoptions, MentorLake.Gtk.GtkAttachOptions yoptions, uint xpadding, uint ypadding) where T : GtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		GtkTableHandleExterns.gtk_table_attach(table, child, left_attach, right_attach, top_attach, bottom_attach, xoptions, yoptions, xpadding, ypadding);
		return table;
	}

/// <summary>
/// <para>
/// As there are many options associated with gtk_table_attach(), this convenience
/// function provides the programmer with a means to add children to a table with
/// identical padding and expansion options. The values used for the #GtkAttachOptions
/// are `GTK_EXPAND | GTK_FILL`, and the padding is set to 0.
/// </para>
/// </summary>

/// <param name="table">
/// The table to add a new child widget to.
/// </param>
/// <param name="widget">
/// The child widget to add.
/// </param>
/// <param name="left_attach">
/// The column number to attach the left side of the child widget to.
/// </param>
/// <param name="right_attach">
/// The column number to attach the right side of the child widget to.
/// </param>
/// <param name="top_attach">
/// The row number to attach the top of the child widget to.
/// </param>
/// <param name="bottom_attach">
/// The row number to attach the bottom of the child widget to.
/// </param>

	public static T AttachDefaults<T>(this T table, MentorLake.Gtk.GtkWidgetHandle widget, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach) where T : GtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		GtkTableHandleExterns.gtk_table_attach_defaults(table, widget, left_attach, right_attach, top_attach, bottom_attach);
		return table;
	}

/// <summary>
/// <para>
/// Gets the amount of space between column @col, and
/// column @col + 1. See gtk_table_set_col_spacing().
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTable
/// </param>
/// <param name="column">
/// a column in the table, 0 indicates the first column
/// </param>
/// <return>
/// the column spacing
/// </return>

	public static uint GetColSpacing(this MentorLake.Gtk.GtkTableHandle table, uint column)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		return GtkTableHandleExterns.gtk_table_get_col_spacing(table, column);
	}

/// <summary>
/// <para>
/// Gets the default column spacing for the table. This is
/// the spacing that will be used for newly added columns.
/// (See gtk_table_set_col_spacings())
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTable
/// </param>
/// <return>
/// the default column spacing
/// </return>

	public static uint GetDefaultColSpacing(this MentorLake.Gtk.GtkTableHandle table)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		return GtkTableHandleExterns.gtk_table_get_default_col_spacing(table);
	}

/// <summary>
/// <para>
/// Gets the default row spacing for the table. This is
/// the spacing that will be used for newly added rows.
/// (See gtk_table_set_row_spacings())
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTable
/// </param>
/// <return>
/// the default row spacing
/// </return>

	public static uint GetDefaultRowSpacing(this MentorLake.Gtk.GtkTableHandle table)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		return GtkTableHandleExterns.gtk_table_get_default_row_spacing(table);
	}

/// <summary>
/// <para>
/// Returns whether the table cells are all constrained to the same
/// width and height. (See gtk_table_set_homogeneous ())
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTable
/// </param>
/// <return>
/// %TRUE if the cells are all constrained to the same size
/// </return>

	public static bool GetHomogeneous(this MentorLake.Gtk.GtkTableHandle table)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		return GtkTableHandleExterns.gtk_table_get_homogeneous(table);
	}

/// <summary>
/// <para>
/// Gets the amount of space between row @row, and
/// row @row + 1. See gtk_table_set_row_spacing().
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTable
/// </param>
/// <param name="row">
/// a row in the table, 0 indicates the first row
/// </param>
/// <return>
/// the row spacing
/// </return>

	public static uint GetRowSpacing(this MentorLake.Gtk.GtkTableHandle table, uint row)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		return GtkTableHandleExterns.gtk_table_get_row_spacing(table, row);
	}

/// <summary>
/// <para>
/// Gets the number of rows and columns in the table.
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTable
/// </param>
/// <param name="rows">
/// return location for the number of
///   rows, or %NULL
/// </param>
/// <param name="columns">
/// return location for the number
///   of columns, or %NULL
/// </param>

	public static T GetSize<T>(this T table, out uint rows, out uint columns) where T : GtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		GtkTableHandleExterns.gtk_table_get_size(table, out rows, out columns);
		return table;
	}

/// <summary>
/// <para>
/// If you need to change a table’s size after
/// it has been created, this function allows you to do so.
/// </para>
/// </summary>

/// <param name="table">
/// The #GtkTable you wish to change the size of.
/// </param>
/// <param name="rows">
/// The new number of rows.
/// </param>
/// <param name="columns">
/// The new number of columns.
/// </param>

	public static T Resize<T>(this T table, uint rows, uint columns) where T : GtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		GtkTableHandleExterns.gtk_table_resize(table, rows, columns);
		return table;
	}

/// <summary>
/// <para>
/// Alters the amount of space between a given table column and the following
/// column.
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTable.
/// </param>
/// <param name="column">
/// the column whose spacing should be changed.
/// </param>
/// <param name="spacing">
/// number of pixels that the spacing should take up.
/// </param>

	public static T SetColSpacing<T>(this T table, uint column, uint spacing) where T : GtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		GtkTableHandleExterns.gtk_table_set_col_spacing(table, column, spacing);
		return table;
	}

/// <summary>
/// <para>
/// Sets the space between every column in @table equal to @spacing.
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTable.
/// </param>
/// <param name="spacing">
/// the number of pixels of space to place between every column
///   in the table.
/// </param>

	public static T SetColSpacings<T>(this T table, uint spacing) where T : GtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		GtkTableHandleExterns.gtk_table_set_col_spacings(table, spacing);
		return table;
	}

/// <summary>
/// <para>
/// Changes the homogenous property of table cells, ie. whether all cells are
/// an equal size or not.
/// </para>
/// </summary>

/// <param name="table">
/// The #GtkTable you wish to set the homogeneous properties of.
/// </param>
/// <param name="homogeneous">
/// Set to %TRUE to ensure all table cells are the same size. Set
///   to %FALSE if this is not your desired behaviour.
/// </param>

	public static T SetHomogeneous<T>(this T table, bool homogeneous) where T : GtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		GtkTableHandleExterns.gtk_table_set_homogeneous(table, homogeneous);
		return table;
	}

/// <summary>
/// <para>
/// Changes the space between a given table row and the subsequent row.
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTable containing the row whose properties you wish to change.
/// </param>
/// <param name="row">
/// row number whose spacing will be changed.
/// </param>
/// <param name="spacing">
/// number of pixels that the spacing should take up.
/// </param>

	public static T SetRowSpacing<T>(this T table, uint row, uint spacing) where T : GtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		GtkTableHandleExterns.gtk_table_set_row_spacing(table, row, spacing);
		return table;
	}

/// <summary>
/// <para>
/// Sets the space between every row in @table equal to @spacing.
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTable.
/// </param>
/// <param name="spacing">
/// the number of pixels of space to place between every row in the table.
/// </param>

	public static T SetRowSpacings<T>(this T table, uint spacing) where T : GtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTableHandle)");
		GtkTableHandleExterns.gtk_table_set_row_spacings(table, spacing);
		return table;
	}

}

internal class GtkTableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTableHandle>))]
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
