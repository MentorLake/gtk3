namespace MentorLake.Atk;

/// <summary>
/// <para>
/// AtkTableCell is an interface for cells inside an #AtkTable.
/// </para>
/// </summary>

public class AtkTableCellIfaceHandle : BaseSafeHandle
{
}


public static class AtkTableCellIfaceExtensions
{

	public static AtkTableCellIface Dereference(this AtkTableCellIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkTableCellIface>(x.DangerousGetHandle());
}
internal class AtkTableCellIfaceExterns
{
}

/// <summary>
/// <para>
/// AtkTableCell is an interface for cells inside an #AtkTable.
/// </para>
/// </summary>

public struct AtkTableCellIface
{
	/// <summary>
/// <para>
/// virtual function that returns the number of
///   columns occupied by this cell accessible
/// </para>
/// </summary>

public IntPtr get_column_span;
	/// <summary>
/// <para>
/// virtual function that returns the column
///   headers as an array of cell accessibles
/// </para>
/// </summary>

public IntPtr get_column_header_cells;
	/// <summary>
/// <para>
/// virtual function that retrieves the tabular position
///   of this cell
/// </para>
/// </summary>

public IntPtr get_position;
	/// <summary>
/// <para>
/// virtual function that returns the number of rows
///   occupied by this cell
/// </para>
/// </summary>

public IntPtr get_row_span;
	/// <summary>
/// <para>
/// virtual function that returns the row
///   headers as an array of cell accessibles
/// </para>
/// </summary>

public IntPtr get_row_header_cells;
	/// <summary>
/// <para>
/// virtual function that get the row an column
///   indexes and span of this cell
/// </para>
/// </summary>

public IntPtr get_row_column_span;
	/// <summary>
/// <para>
/// virtual function that returns a reference to the
///   accessible of the containing table
/// </para>
/// </summary>

public IntPtr get_table;
}
