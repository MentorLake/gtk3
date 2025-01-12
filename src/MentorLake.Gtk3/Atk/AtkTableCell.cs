namespace MentorLake.Gtk3.Atk;

public interface AtkTableCellHandle
{
}

internal class AtkTableCellHandleImpl : BaseSafeHandle, AtkTableCellHandle
{
}

public static class AtkTableCellHandleExtensions
{
	public static IntPtr GetColumnHeaderCells(this AtkTableCellHandle cell)
	{
		return AtkTableCellExterns.atk_table_cell_get_column_header_cells(cell);
	}

	public static int GetColumnSpan(this AtkTableCellHandle cell)
	{
		return AtkTableCellExterns.atk_table_cell_get_column_span(cell);
	}

	public static bool GetPosition(this AtkTableCellHandle cell, out int row, out int column)
	{
		return AtkTableCellExterns.atk_table_cell_get_position(cell, out row, out column);
	}

	public static bool GetRowColumnSpan(this AtkTableCellHandle cell, out int row, out int column, out int row_span, out int column_span)
	{
		return AtkTableCellExterns.atk_table_cell_get_row_column_span(cell, out row, out column, out row_span, out column_span);
	}

	public static IntPtr GetRowHeaderCells(this AtkTableCellHandle cell)
	{
		return AtkTableCellExterns.atk_table_cell_get_row_header_cells(cell);
	}

	public static int GetRowSpan(this AtkTableCellHandle cell)
	{
		return AtkTableCellExterns.atk_table_cell_get_row_span(cell);
	}

	public static AtkObjectHandle GetTable(this AtkTableCellHandle cell)
	{
		return AtkTableCellExterns.atk_table_cell_get_table(cell);
	}

}

internal class AtkTableCellExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern IntPtr atk_table_cell_get_column_header_cells(AtkTableCellHandle cell);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_table_cell_get_column_span(AtkTableCellHandle cell);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_table_cell_get_position(AtkTableCellHandle cell, out int row, out int column);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_table_cell_get_row_column_span(AtkTableCellHandle cell, out int row, out int column, out int row_span, out int column_span);

	[DllImport(Libraries.Atk)]
	internal static extern IntPtr atk_table_cell_get_row_header_cells(AtkTableCellHandle cell);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_table_cell_get_row_span(AtkTableCellHandle cell);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_table_cell_get_table(AtkTableCellHandle cell);

}
