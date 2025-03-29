namespace MentorLake.Atk;

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
	public static bool AddColumnSelection(this MentorLake.Atk.AtkTableHandle table, int column)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_add_column_selection(table, column);
	}

	public static bool AddRowSelection(this MentorLake.Atk.AtkTableHandle table, int row)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_add_row_selection(table, row);
	}

	public static MentorLake.Atk.AtkObjectHandle GetCaption(this MentorLake.Atk.AtkTableHandle table)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_caption(table);
	}

	public static int GetColumnAtIndex(this MentorLake.Atk.AtkTableHandle table, int index_)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_column_at_index(table, index_);
	}

	public static string GetColumnDescription(this MentorLake.Atk.AtkTableHandle table, int column)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_column_description(table, column);
	}

	public static int GetColumnExtentAt(this MentorLake.Atk.AtkTableHandle table, int row, int column)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_column_extent_at(table, row, column);
	}

	public static MentorLake.Atk.AtkObjectHandle GetColumnHeader(this MentorLake.Atk.AtkTableHandle table, int column)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_column_header(table, column);
	}

	public static int GetIndexAt(this MentorLake.Atk.AtkTableHandle table, int row, int column)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_index_at(table, row, column);
	}

	public static int GetNColumns(this MentorLake.Atk.AtkTableHandle table)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_n_columns(table);
	}

	public static int GetNRows(this MentorLake.Atk.AtkTableHandle table)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_n_rows(table);
	}

	public static int GetRowAtIndex(this MentorLake.Atk.AtkTableHandle table, int index_)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_row_at_index(table, index_);
	}

	public static string GetRowDescription(this MentorLake.Atk.AtkTableHandle table, int row)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_row_description(table, row);
	}

	public static int GetRowExtentAt(this MentorLake.Atk.AtkTableHandle table, int row, int column)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_row_extent_at(table, row, column);
	}

	public static MentorLake.Atk.AtkObjectHandle GetRowHeader(this MentorLake.Atk.AtkTableHandle table, int row)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_row_header(table, row);
	}

	public static int GetSelectedColumns(this MentorLake.Atk.AtkTableHandle table, int selected)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_selected_columns(table, selected);
	}

	public static int GetSelectedRows(this MentorLake.Atk.AtkTableHandle table, int selected)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_selected_rows(table, selected);
	}

	public static MentorLake.Atk.AtkObjectHandle GetSummary(this MentorLake.Atk.AtkTableHandle table)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_get_summary(table);
	}

	public static bool IsColumnSelected(this MentorLake.Atk.AtkTableHandle table, int column)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_is_column_selected(table, column);
	}

	public static bool IsRowSelected(this MentorLake.Atk.AtkTableHandle table, int row)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_is_row_selected(table, row);
	}

	public static bool IsSelected(this MentorLake.Atk.AtkTableHandle table, int row, int column)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_is_selected(table, row, column);
	}

	public static MentorLake.Atk.AtkObjectHandle RefAt(this MentorLake.Atk.AtkTableHandle table, int row, int column)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_ref_at(table, row, column);
	}

	public static bool RemoveColumnSelection(this MentorLake.Atk.AtkTableHandle table, int column)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_remove_column_selection(table, column);
	}

	public static bool RemoveRowSelection(this MentorLake.Atk.AtkTableHandle table, int row)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		return AtkTableHandleExterns.atk_table_remove_row_selection(table, row);
	}

	public static T SetCaption<T>(this T table, MentorLake.Atk.AtkObjectHandle caption) where T : AtkTableHandle
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		AtkTableHandleExterns.atk_table_set_caption(table, caption);
		return table;
	}

	public static T SetColumnDescription<T>(this T table, int column, string description) where T : AtkTableHandle
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		AtkTableHandleExterns.atk_table_set_column_description(table, column, description);
		return table;
	}

	public static T SetColumnHeader<T>(this T table, int column, MentorLake.Atk.AtkObjectHandle header) where T : AtkTableHandle
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		AtkTableHandleExterns.atk_table_set_column_header(table, column, header);
		return table;
	}

	public static T SetRowDescription<T>(this T table, int row, string description) where T : AtkTableHandle
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		AtkTableHandleExterns.atk_table_set_row_description(table, row, description);
		return table;
	}

	public static T SetRowHeader<T>(this T table, int row, MentorLake.Atk.AtkObjectHandle header) where T : AtkTableHandle
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
		AtkTableHandleExterns.atk_table_set_row_header(table, row, header);
		return table;
	}

	public static T SetSummary<T>(this T table, MentorLake.Atk.AtkObjectHandle accessible) where T : AtkTableHandle
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (AtkTableHandle)");
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
	internal static extern MentorLake.Atk.AtkObjectHandle atk_table_get_caption([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_column_at_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int index_);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_table_get_column_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int column);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_column_extent_at([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row, int column);

	[DllImport(AtkLibrary.Name)]
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
	internal static extern MentorLake.Atk.AtkObjectHandle atk_table_get_row_header([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_selected_columns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int selected);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_table_get_selected_rows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int selected);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_table_get_summary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_is_column_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int column);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_is_row_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_table_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle table, int row, int column);

	[DllImport(AtkLibrary.Name)]
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
