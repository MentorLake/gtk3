namespace MentorLake.Atk;

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
	public static MentorLake.GLib.GPtrArrayHandle GetColumnHeaderCells(this MentorLake.Atk.AtkTableCellHandle cell)
	{
		if (cell.IsInvalid || cell.IsClosed) throw new Exception("Invalid or closed handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_column_header_cells(cell);
	}

	public static int GetColumnSpan(this MentorLake.Atk.AtkTableCellHandle cell)
	{
		if (cell.IsInvalid || cell.IsClosed) throw new Exception("Invalid or closed handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_column_span(cell);
	}

	public static bool GetPosition(this MentorLake.Atk.AtkTableCellHandle cell, out int row, out int column)
	{
		if (cell.IsInvalid || cell.IsClosed) throw new Exception("Invalid or closed handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_position(cell, out row, out column);
	}

	public static bool GetRowColumnSpan(this MentorLake.Atk.AtkTableCellHandle cell, out int row, out int column, out int row_span, out int column_span)
	{
		if (cell.IsInvalid || cell.IsClosed) throw new Exception("Invalid or closed handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_row_column_span(cell, out row, out column, out row_span, out column_span);
	}

	public static MentorLake.GLib.GPtrArrayHandle GetRowHeaderCells(this MentorLake.Atk.AtkTableCellHandle cell)
	{
		if (cell.IsInvalid || cell.IsClosed) throw new Exception("Invalid or closed handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_row_header_cells(cell);
	}

	public static int GetRowSpan(this MentorLake.Atk.AtkTableCellHandle cell)
	{
		if (cell.IsInvalid || cell.IsClosed) throw new Exception("Invalid or closed handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_row_span(cell);
	}

	public static MentorLake.Atk.AtkObjectHandle GetTable(this MentorLake.Atk.AtkTableCellHandle cell)
	{
		if (cell.IsInvalid || cell.IsClosed) throw new Exception("Invalid or closed handle (AtkTableCellHandle)");
		return AtkTableCellHandleExterns.atk_table_cell_get_table(cell);
	}

}

internal class AtkTableCellHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle atk_table_cell_get_column_header_cells([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_cell_get_column_span([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_cell_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell, out int row, out int column);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_cell_get_row_column_span([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell, out int row, out int column, out int row_span, out int column_span);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle atk_table_cell_get_row_header_cells([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_cell_get_row_span([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_table_cell_get_table([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableCellHandleImpl>))] MentorLake.Atk.AtkTableCellHandle cell);

}
