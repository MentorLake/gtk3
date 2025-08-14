namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK interface implemented for UI components which contain tabular or row/column information.
/// </para>
/// <para>
/// #AtkTable should be implemented by components which present
/// elements ordered via rows and columns.  It may also be used to
/// present tree-structured information if the nodes of the trees can
/// be said to contain multiple "columns".  Individual elements of an
/// #AtkTable are typically referred to as "cells". Those cells should
/// implement the interface #AtkTableCell, but #Atk doesn't require
/// them to be direct children of the current #AtkTable. They can be
/// grand-children, grand-grand-children etc. #AtkTable provides the
/// API needed to get a individual cell based on the row and column
/// numbers.
/// </para>
/// <para>
/// Children of #AtkTable are frequently "lightweight" objects, that
/// is, they may not have backing widgets in the host UI toolkit.  They
/// are therefore often transient.
/// </para>
/// <para>
/// Since tables are often very complex, #AtkTable includes provision
/// for offering simplified summary information, as well as row and
/// column headers and captions.  Headers and captions are #AtkObjects
/// which may implement other interfaces (#AtkText, #AtkImage, etc.) as
/// appropriate.  #AtkTable summaries may themselves be (simplified)
/// #AtkTables, etc.
/// </para>
/// <para>
/// Note for implementors: in the past, #AtkTable required that all the
/// cells should be direct children of #AtkTable, and provided some
/// index based methods to request the cells. The practice showed that
/// that forcing made #AtkTable implementation complex, and hard to
/// expose other kind of children, like rows or captions. Right now,
/// index-based methods are deprecated.
/// </para>
/// </summary>

public interface AtkTableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkTableHandleImpl : BaseSafeHandle, AtkTableHandle
{
}

public static class AtkTableHandleExtensions
{
/// <summary>
/// <para>
/// Adds the specified @column to the selection.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="column">
/// a #gint representing a column in @table
/// </param>
/// <return>
/// a gboolean representing if the column was successfully added to
/// the selection, or 0 if value does not implement this interface.
/// </return>

	public static bool AddColumnSelection(this MentorLake.Atk.AtkTableHandle table, int column)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_add_column_selection(table, column);
	}

/// <summary>
/// <para>
/// Adds the specified @row to the selection.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="row">
/// a #gint representing a row in @table
/// </param>
/// <return>
/// a gboolean representing if row was successfully added to selection,
/// or 0 if value does not implement this interface.
/// </return>

	public static bool AddRowSelection(this MentorLake.Atk.AtkTableHandle table, int row)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_add_row_selection(table, row);
	}

/// <summary>
/// <para>
/// Gets the caption for the @table.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableInterface
/// </param>
/// <return>
/// a AtkObject* representing the
/// table caption, or %NULL if value does not implement this interface.
/// </return>

	public static MentorLake.Atk.AtkObjectHandle GetCaption(this MentorLake.Atk.AtkTableHandle table)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_caption(table);
	}

/// <summary>
/// <para>
/// Gets a #gint representing the column at the specified @index_.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableInterface
/// </param>
/// <param name="index_">
/// a #gint representing an index in @table
/// </param>
/// <return>
/// a gint representing the column at the specified index,
/// or -1 if the table does not implement this method.
/// </return>

	public static int GetColumnAtIndex(this MentorLake.Atk.AtkTableHandle table, int index_)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_column_at_index(table, index_);
	}

/// <summary>
/// <para>
/// Gets the description text of the specified @column in the table
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="column">
/// a #gint representing a column in @table
/// </param>
/// <return>
/// a gchar* representing the column description, or %NULL
/// if value does not implement this interface.
/// </return>

	public static string GetColumnDescription(this MentorLake.Atk.AtkTableHandle table, int column)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_column_description(table, column);
	}

/// <summary>
/// <para>
/// Gets the number of columns occupied by the accessible object
/// at the specified @row and @column in the @table.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="row">
/// a #gint representing a row in @table
/// </param>
/// <param name="column">
/// a #gint representing a column in @table
/// </param>
/// <return>
/// a gint representing the column extent at specified position, or 0
/// if value does not implement this interface.
/// </return>

	public static int GetColumnExtentAt(this MentorLake.Atk.AtkTableHandle table, int row, int column)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_column_extent_at(table, row, column);
	}

/// <summary>
/// <para>
/// Gets the column header of a specified column in an accessible table.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="column">
/// a #gint representing a column in the table
/// </param>
/// <return>
/// a AtkObject* representing the
/// specified column header, or %NULL if value does not implement this
/// interface.
/// </return>

	public static MentorLake.Atk.AtkObjectHandle GetColumnHeader(this MentorLake.Atk.AtkTableHandle table, int column)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_column_header(table, column);
	}

/// <summary>
/// <para>
/// Gets a #gint representing the index at the specified @row and
/// @column.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="row">
/// a #gint representing a row in @table
/// </param>
/// <param name="column">
/// a #gint representing a column in @table
/// </param>
/// <return>
/// a #gint representing the index at specified position.
/// The value -1 is returned if the object at row,column is not a child
/// of table or table does not implement this interface.
/// </return>

	public static int GetIndexAt(this MentorLake.Atk.AtkTableHandle table, int row, int column)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_index_at(table, row, column);
	}

/// <summary>
/// <para>
/// Gets the number of columns in the table.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <return>
/// a gint representing the number of columns, or 0
/// if value does not implement this interface.
/// </return>

	public static int GetNColumns(this MentorLake.Atk.AtkTableHandle table)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_n_columns(table);
	}

/// <summary>
/// <para>
/// Gets the number of rows in the table.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <return>
/// a gint representing the number of rows, or 0
/// if value does not implement this interface.
/// </return>

	public static int GetNRows(this MentorLake.Atk.AtkTableHandle table)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_n_rows(table);
	}

/// <summary>
/// <para>
/// Gets a #gint representing the row at the specified @index_.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableInterface
/// </param>
/// <param name="index_">
/// a #gint representing an index in @table
/// </param>
/// <return>
/// a gint representing the row at the specified index,
/// or -1 if the table does not implement this method.
/// </return>

	public static int GetRowAtIndex(this MentorLake.Atk.AtkTableHandle table, int index_)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_row_at_index(table, index_);
	}

/// <summary>
/// <para>
/// Gets the description text of the specified row in the table
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="row">
/// a #gint representing a row in @table
/// </param>
/// <return>
/// a gchar* representing the row description, or
/// %NULL if value does not implement this interface.
/// </return>

	public static string GetRowDescription(this MentorLake.Atk.AtkTableHandle table, int row)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_row_description(table, row);
	}

/// <summary>
/// <para>
/// Gets the number of rows occupied by the accessible object
/// at a specified @row and @column in the @table.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="row">
/// a #gint representing a row in @table
/// </param>
/// <param name="column">
/// a #gint representing a column in @table
/// </param>
/// <return>
/// a gint representing the row extent at specified position, or 0
/// if value does not implement this interface.
/// </return>

	public static int GetRowExtentAt(this MentorLake.Atk.AtkTableHandle table, int row, int column)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_row_extent_at(table, row, column);
	}

/// <summary>
/// <para>
/// Gets the row header of a specified row in an accessible table.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="row">
/// a #gint representing a row in the table
/// </param>
/// <return>
/// a AtkObject* representing the
/// specified row header, or %NULL if value does not implement this
/// interface.
/// </return>

	public static MentorLake.Atk.AtkObjectHandle GetRowHeader(this MentorLake.Atk.AtkTableHandle table, int row)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_row_header(table, row);
	}

/// <summary>
/// <para>
/// Gets the selected columns of the table by initializing **selected with
/// the selected column numbers. This array should be freed by the caller.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="selected">
/// a #gint** that is to contain the selected columns numbers
/// </param>
/// <return>
/// a gint representing the number of selected columns,
/// or %0 if value does not implement this interface.
/// </return>

	public static int GetSelectedColumns(this MentorLake.Atk.AtkTableHandle table, int selected)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_selected_columns(table, selected);
	}

/// <summary>
/// <para>
/// Gets the selected rows of the table by initializing **selected with
/// the selected row numbers. This array should be freed by the caller.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="selected">
/// a #gint** that is to contain the selected row numbers
/// </param>
/// <return>
/// a gint representing the number of selected rows,
/// or zero if value does not implement this interface.
/// </return>

	public static int GetSelectedRows(this MentorLake.Atk.AtkTableHandle table, int selected)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_selected_rows(table, selected);
	}

/// <summary>
/// <para>
/// Gets the summary description of the table.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <return>
/// a AtkObject* representing a summary description
/// of the table, or zero if value does not implement this interface.
/// </return>

	public static MentorLake.Atk.AtkObjectHandle GetSummary(this MentorLake.Atk.AtkTableHandle table)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_summary(table);
	}

/// <summary>
/// <para>
/// Gets a boolean value indicating whether the specified @column
/// is selected
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="column">
/// a #gint representing a column in @table
/// </param>
/// <return>
/// a gboolean representing if the column is selected, or 0
/// if value does not implement this interface.
/// </return>

	public static bool IsColumnSelected(this MentorLake.Atk.AtkTableHandle table, int column)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_is_column_selected(table, column);
	}

/// <summary>
/// <para>
/// Gets a boolean value indicating whether the specified @row
/// is selected
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="row">
/// a #gint representing a row in @table
/// </param>
/// <return>
/// a gboolean representing if the row is selected, or 0
/// if value does not implement this interface.
/// </return>

	public static bool IsRowSelected(this MentorLake.Atk.AtkTableHandle table, int row)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_is_row_selected(table, row);
	}

/// <summary>
/// <para>
/// Gets a boolean value indicating whether the accessible object
/// at the specified @row and @column is selected
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="row">
/// a #gint representing a row in @table
/// </param>
/// <param name="column">
/// a #gint representing a column in @table
/// </param>
/// <return>
/// a gboolean representing if the cell is selected, or 0
/// if value does not implement this interface.
/// </return>

	public static bool IsSelected(this MentorLake.Atk.AtkTableHandle table, int row, int column)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_is_selected(table, row, column);
	}

/// <summary>
/// <para>
/// Get a reference to the table cell at @row, @column. This cell
/// should implement the interface #AtkTableCell
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="row">
/// a #gint representing a row in @table
/// </param>
/// <param name="column">
/// a #gint representing a column in @table
/// </param>
/// <return>
/// an #AtkObject representing the referred
/// to accessible
/// </return>

	public static MentorLake.Atk.AtkObjectHandle RefAt(this MentorLake.Atk.AtkTableHandle table, int row, int column)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_ref_at(table, row, column);
	}

/// <summary>
/// <para>
/// Adds the specified @column to the selection.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="column">
/// a #gint representing a column in @table
/// </param>
/// <return>
/// a gboolean representing if the column was successfully removed from
/// the selection, or 0 if value does not implement this interface.
/// </return>

	public static bool RemoveColumnSelection(this MentorLake.Atk.AtkTableHandle table, int column)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_remove_column_selection(table, column);
	}

/// <summary>
/// <para>
/// Removes the specified @row from the selection.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="row">
/// a #gint representing a row in @table
/// </param>
/// <return>
/// a gboolean representing if the row was successfully removed from
/// the selection, or 0 if value does not implement this interface.
/// </return>

	public static bool RemoveRowSelection(this MentorLake.Atk.AtkTableHandle table, int row)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_remove_row_selection(table, row);
	}

/// <summary>
/// <para>
/// Sets the caption for the table.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="caption">
/// a #AtkObject representing the caption to set for @table
/// </param>

	public static T SetCaption<T>(this T table, MentorLake.Atk.AtkObjectHandle caption) where T : AtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		AtkTableHandleExterns.atk_table_set_caption(table, caption);
		return table;
	}

/// <summary>
/// <para>
/// Sets the description text for the specified @column of the @table.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="column">
/// a #gint representing a column in @table
/// </param>
/// <param name="description">
/// a #gchar representing the description text
/// to set for the specified @column of the @table
/// </param>

	public static T SetColumnDescription<T>(this T table, int column, string description) where T : AtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		AtkTableHandleExterns.atk_table_set_column_description(table, column, description);
		return table;
	}

/// <summary>
/// <para>
/// Sets the specified column header to @header.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="column">
/// a #gint representing a column in @table
/// </param>
/// <param name="header">
/// an #AtkTable
/// </param>

	public static T SetColumnHeader<T>(this T table, int column, MentorLake.Atk.AtkObjectHandle header) where T : AtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		AtkTableHandleExterns.atk_table_set_column_header(table, column, header);
		return table;
	}

/// <summary>
/// <para>
/// Sets the description text for the specified @row of @table.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="row">
/// a #gint representing a row in @table
/// </param>
/// <param name="description">
/// a #gchar representing the description text
/// to set for the specified @row of @table
/// </param>

	public static T SetRowDescription<T>(this T table, int row, string description) where T : AtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		AtkTableHandleExterns.atk_table_set_row_description(table, row, description);
		return table;
	}

/// <summary>
/// <para>
/// Sets the specified row header to @header.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="row">
/// a #gint representing a row in @table
/// </param>
/// <param name="header">
/// an #AtkTable
/// </param>

	public static T SetRowHeader<T>(this T table, int row, MentorLake.Atk.AtkObjectHandle header) where T : AtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		AtkTableHandleExterns.atk_table_set_row_header(table, row, header);
		return table;
	}

/// <summary>
/// <para>
/// Sets the summary description of the table.
/// </para>
/// </summary>

/// <param name="table">
/// a GObject instance that implements AtkTableIface
/// </param>
/// <param name="accessible">
/// an #AtkObject representing the summary description
/// to set for @table
/// </param>

	public static T SetSummary<T>(this T table, MentorLake.Atk.AtkObjectHandle accessible) where T : AtkTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (AtkTableHandle)");
		AtkTableHandleExterns.atk_table_set_summary(table, accessible);
		return table;
	}

}

internal class AtkTableHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_add_column_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int column);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_add_row_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_table_get_caption([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_column_at_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int index_);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_table_get_column_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int column);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_column_extent_at([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row, int column);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_table_get_column_header([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int column);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_index_at([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row, int column);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_n_columns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_n_rows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_row_at_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int index_);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_table_get_row_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_row_extent_at([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row, int column);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_table_get_row_header([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_selected_columns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int selected);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_selected_rows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int selected);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_table_get_summary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_is_column_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int column);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_is_row_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row, int column);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_table_ref_at([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row, int column);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_remove_column_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int column);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_remove_row_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_table_set_caption([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle caption);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_table_set_column_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int column, string description);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_table_set_column_header([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle header);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_table_set_row_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row, string description);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_table_set_row_header([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle header);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_table_set_summary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

}
