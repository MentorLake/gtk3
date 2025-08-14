namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK interface implemented for a cell inside a two-dimentional #AtkTable
/// </para>
/// <para>
/// Being #AtkTable a component which present elements ordered via rows
/// and columns, an #AtkTableCell is the interface which each of those
/// elements, so "cells" should implement.
/// </para>
/// <para>
/// See [iface@AtkTable]
/// </para>
/// </summary>

public interface AtkTableCellHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkTableCellHandleImpl : BaseSafeHandle, AtkTableCellHandle
{
}

public static class AtkTableCellHandleExtensions
{
/// <summary>
/// <para>
/// Returns the column headers as an array of cell accessibles.
/// </para>
/// </summary>

/// <param name="cell">
/// a GObject instance that implements AtkTableCellIface
/// </param>
/// <return>
/// a GPtrArray of AtkObjects
/// representing the column header cells.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle GetColumnHeaderCells(this MentorLake.Atk.AtkTableCellHandle cell)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_column_header_cells(cell);
	}

/// <summary>
/// <para>
/// Returns the number of columns occupied by this cell accessible.
/// </para>
/// </summary>

/// <param name="cell">
/// a GObject instance that implements AtkTableCellIface
/// </param>
/// <return>
/// a gint representing the number of columns occupied by this cell,
/// or 0 if the cell does not implement this method.
/// </return>

	public static int GetColumnSpan(this MentorLake.Atk.AtkTableCellHandle cell)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_column_span(cell);
	}

/// <summary>
/// <para>
/// Retrieves the tabular position of this cell.
/// </para>
/// </summary>

/// <param name="cell">
/// a GObject instance that implements AtkTableCellIface
/// </param>
/// <param name="row">
/// the row of the given cell.
/// </param>
/// <param name="column">
/// the column of the given cell.
/// </param>
/// <return>
/// TRUE if successful; FALSE otherwise.
/// </return>

	public static bool GetPosition(this MentorLake.Atk.AtkTableCellHandle cell, out int row, out int column)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_position(cell, out row, out column);
	}

/// <summary>
/// <para>
/// Gets the row and column indexes and span of this cell accessible.
/// </para>
/// <para>
/// Note: If the object does not implement this function, then, by default, atk
/// will implement this function by calling get_row_span and get_column_span
/// on the object.
/// </para>
/// </summary>

/// <param name="cell">
/// a GObject instance that implements AtkTableCellIface
/// </param>
/// <param name="row">
/// the row index of the given cell.
/// </param>
/// <param name="column">
/// the column index of the given cell.
/// </param>
/// <param name="row_span">
/// the number of rows occupied by this cell.
/// </param>
/// <param name="column_span">
/// the number of columns occupied by this cell.
/// </param>
/// <return>
/// TRUE if successful; FALSE otherwise.
/// </return>

	public static bool GetRowColumnSpan(this MentorLake.Atk.AtkTableCellHandle cell, out int row, out int column, out int row_span, out int column_span)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_row_column_span(cell, out row, out column, out row_span, out column_span);
	}

/// <summary>
/// <para>
/// Returns the row headers as an array of cell accessibles.
/// </para>
/// </summary>

/// <param name="cell">
/// a GObject instance that implements AtkTableCellIface
/// </param>
/// <return>
/// a GPtrArray of AtkObjects
/// representing the row header cells.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle GetRowHeaderCells(this MentorLake.Atk.AtkTableCellHandle cell)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_row_header_cells(cell);
	}

/// <summary>
/// <para>
/// Returns the number of rows occupied by this cell accessible.
/// </para>
/// </summary>

/// <param name="cell">
/// a GObject instance that implements AtkTableCellIface
/// </param>
/// <return>
/// a gint representing the number of rows occupied by this cell,
/// or 0 if the cell does not implement this method.
/// </return>

	public static int GetRowSpan(this MentorLake.Atk.AtkTableCellHandle cell)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_row_span(cell);
	}

/// <summary>
/// <para>
/// Returns a reference to the accessible of the containing table.
/// </para>
/// </summary>

/// <param name="cell">
/// a GObject instance that implements AtkTableCellIface
/// </param>
/// <return>
/// the atk object for the containing table.
/// </return>

	public static MentorLake.Atk.AtkObjectHandle GetTable(this MentorLake.Atk.AtkTableCellHandle cell)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_table(cell);
	}

}

internal class AtkTableCellHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle atk_table_cell_get_column_header_cells([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_cell_get_column_span([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_cell_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell, out int row, out int column);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_cell_get_row_column_span([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell, out int row, out int column, out int row_span, out int column_span);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle atk_table_cell_get_row_header_cells([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_cell_get_row_span([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_table_cell_get_table([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell);

}
