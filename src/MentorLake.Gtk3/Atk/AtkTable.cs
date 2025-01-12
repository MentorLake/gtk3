namespace MentorLake.Gtk3.Atk;

public interface AtkTableHandle
{
}

internal class AtkTableHandleImpl : BaseSafeHandle, AtkTableHandle
{
}

public static class AtkTableHandleExtensions
{
	public static bool AddColumnSelection(this AtkTableHandle table, int column)
	{
		return AtkTableExterns.atk_table_add_column_selection(table, column);
	}

	public static bool AddRowSelection(this AtkTableHandle table, int row)
	{
		return AtkTableExterns.atk_table_add_row_selection(table, row);
	}

	public static AtkObjectHandle GetCaption(this AtkTableHandle table)
	{
		return AtkTableExterns.atk_table_get_caption(table);
	}

	public static int GetColumnAtIndex(this AtkTableHandle table, int index_)
	{
		return AtkTableExterns.atk_table_get_column_at_index(table, index_);
	}

	public static string GetColumnDescription(this AtkTableHandle table, int column)
	{
		return AtkTableExterns.atk_table_get_column_description(table, column);
	}

	public static int GetColumnExtentAt(this AtkTableHandle table, int row, int column)
	{
		return AtkTableExterns.atk_table_get_column_extent_at(table, row, column);
	}

	public static AtkObjectHandle GetColumnHeader(this AtkTableHandle table, int column)
	{
		return AtkTableExterns.atk_table_get_column_header(table, column);
	}

	public static int GetIndexAt(this AtkTableHandle table, int row, int column)
	{
		return AtkTableExterns.atk_table_get_index_at(table, row, column);
	}

	public static int GetNColumns(this AtkTableHandle table)
	{
		return AtkTableExterns.atk_table_get_n_columns(table);
	}

	public static int GetNRows(this AtkTableHandle table)
	{
		return AtkTableExterns.atk_table_get_n_rows(table);
	}

	public static int GetRowAtIndex(this AtkTableHandle table, int index_)
	{
		return AtkTableExterns.atk_table_get_row_at_index(table, index_);
	}

	public static string GetRowDescription(this AtkTableHandle table, int row)
	{
		return AtkTableExterns.atk_table_get_row_description(table, row);
	}

	public static int GetRowExtentAt(this AtkTableHandle table, int row, int column)
	{
		return AtkTableExterns.atk_table_get_row_extent_at(table, row, column);
	}

	public static AtkObjectHandle GetRowHeader(this AtkTableHandle table, int row)
	{
		return AtkTableExterns.atk_table_get_row_header(table, row);
	}

	public static int GetSelectedColumns(this AtkTableHandle table, ref int[] selected)
	{
		return AtkTableExterns.atk_table_get_selected_columns(table, ref selected);
	}

	public static int GetSelectedRows(this AtkTableHandle table, ref int[] selected)
	{
		return AtkTableExterns.atk_table_get_selected_rows(table, ref selected);
	}

	public static AtkObjectHandle GetSummary(this AtkTableHandle table)
	{
		return AtkTableExterns.atk_table_get_summary(table);
	}

	public static bool IsColumnSelected(this AtkTableHandle table, int column)
	{
		return AtkTableExterns.atk_table_is_column_selected(table, column);
	}

	public static bool IsRowSelected(this AtkTableHandle table, int row)
	{
		return AtkTableExterns.atk_table_is_row_selected(table, row);
	}

	public static bool IsSelected(this AtkTableHandle table, int row, int column)
	{
		return AtkTableExterns.atk_table_is_selected(table, row, column);
	}

	public static AtkObjectHandle RefAt(this AtkTableHandle table, int row, int column)
	{
		return AtkTableExterns.atk_table_ref_at(table, row, column);
	}

	public static bool RemoveColumnSelection(this AtkTableHandle table, int column)
	{
		return AtkTableExterns.atk_table_remove_column_selection(table, column);
	}

	public static bool RemoveRowSelection(this AtkTableHandle table, int row)
	{
		return AtkTableExterns.atk_table_remove_row_selection(table, row);
	}

	public static AtkTableHandle SetCaption(this AtkTableHandle table, AtkObjectHandle caption)
	{
		AtkTableExterns.atk_table_set_caption(table, caption);
		return table;
	}

	public static AtkTableHandle SetColumnDescription(this AtkTableHandle table, int column, string description)
	{
		AtkTableExterns.atk_table_set_column_description(table, column, description);
		return table;
	}

	public static AtkTableHandle SetColumnHeader(this AtkTableHandle table, int column, AtkObjectHandle header)
	{
		AtkTableExterns.atk_table_set_column_header(table, column, header);
		return table;
	}

	public static AtkTableHandle SetRowDescription(this AtkTableHandle table, int row, string description)
	{
		AtkTableExterns.atk_table_set_row_description(table, row, description);
		return table;
	}

	public static AtkTableHandle SetRowHeader(this AtkTableHandle table, int row, AtkObjectHandle header)
	{
		AtkTableExterns.atk_table_set_row_header(table, row, header);
		return table;
	}

	public static AtkTableHandle SetSummary(this AtkTableHandle table, AtkObjectHandle accessible)
	{
		AtkTableExterns.atk_table_set_summary(table, accessible);
		return table;
	}

}

internal class AtkTableExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern bool atk_table_add_column_selection(AtkTableHandle table, int column);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_table_add_row_selection(AtkTableHandle table, int row);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_table_get_caption(AtkTableHandle table);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_table_get_column_at_index(AtkTableHandle table, int index_);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_table_get_column_description(AtkTableHandle table, int column);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_table_get_column_extent_at(AtkTableHandle table, int row, int column);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_table_get_column_header(AtkTableHandle table, int column);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_table_get_index_at(AtkTableHandle table, int row, int column);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_table_get_n_columns(AtkTableHandle table);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_table_get_n_rows(AtkTableHandle table);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_table_get_row_at_index(AtkTableHandle table, int index_);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_table_get_row_description(AtkTableHandle table, int row);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_table_get_row_extent_at(AtkTableHandle table, int row, int column);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_table_get_row_header(AtkTableHandle table, int row);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_table_get_selected_columns(AtkTableHandle table, ref int[] selected);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_table_get_selected_rows(AtkTableHandle table, ref int[] selected);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_table_get_summary(AtkTableHandle table);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_table_is_column_selected(AtkTableHandle table, int column);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_table_is_row_selected(AtkTableHandle table, int row);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_table_is_selected(AtkTableHandle table, int row, int column);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_table_ref_at(AtkTableHandle table, int row, int column);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_table_remove_column_selection(AtkTableHandle table, int column);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_table_remove_row_selection(AtkTableHandle table, int row);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_table_set_caption(AtkTableHandle table, AtkObjectHandle caption);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_table_set_column_description(AtkTableHandle table, int column, string description);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_table_set_column_header(AtkTableHandle table, int column, AtkObjectHandle header);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_table_set_row_description(AtkTableHandle table, int row, string description);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_table_set_row_header(AtkTableHandle table, int row, AtkObjectHandle header);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_table_set_summary(AtkTableHandle table, AtkObjectHandle accessible);

}
