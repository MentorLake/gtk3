namespace MentorLake.Gtk;

public class GtkCellLayoutIfaceHandle : BaseSafeHandle
{
}


public static class GtkCellLayoutIfaceExtensions
{

	public static GtkCellLayoutIface Dereference(this GtkCellLayoutIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellLayoutIface>(x.DangerousGetHandle());
}
internal class GtkCellLayoutIfaceExterns
{
}

public struct GtkCellLayoutIface
{
	public IntPtr pack_start;
	public IntPtr pack_end;
	public IntPtr clear;
	public IntPtr add_attribute;
	public IntPtr set_cell_data_func;
	public IntPtr clear_attributes;
	public IntPtr reorder;
	public IntPtr get_cells;
	public IntPtr get_area;
}
