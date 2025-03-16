namespace MentorLake.Atk;

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

public struct AtkTableCellIface
{
	public IntPtr get_column_span;
	public IntPtr get_column_header_cells;
	public IntPtr get_position;
	public IntPtr get_row_span;
	public IntPtr get_row_header_cells;
	public IntPtr get_row_column_span;
	public IntPtr get_table;
}
