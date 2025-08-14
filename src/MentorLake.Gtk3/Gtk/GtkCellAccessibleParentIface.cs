namespace MentorLake.Gtk;


public class GtkCellAccessibleParentIfaceHandle : BaseSafeHandle
{
}


public static class GtkCellAccessibleParentIfaceExtensions
{

	public static GtkCellAccessibleParentIface Dereference(this GtkCellAccessibleParentIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellAccessibleParentIface>(x.DangerousGetHandle());
}
internal class GtkCellAccessibleParentIfaceExterns
{
}


public struct GtkCellAccessibleParentIface
{
	
public GTypeInterface parent;
	
public IntPtr get_cell_extents;
	
public IntPtr get_cell_area;
	
public IntPtr grab_focus;
	
public IntPtr get_child_index;
	
public IntPtr get_renderer_state;
	
public IntPtr expand_collapse;
	
public IntPtr activate;
	
public IntPtr edit;
	
public IntPtr update_relationset;
	
public IntPtr get_cell_position;
	
public IntPtr get_column_header_cells;
	
public IntPtr get_row_header_cells;
}
