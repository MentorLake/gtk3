namespace MentorLake.Atk;


public class AtkTableIfaceHandle : BaseSafeHandle
{
}


public static class AtkTableIfaceExtensions
{

	public static AtkTableIface Dereference(this AtkTableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkTableIface>(x.DangerousGetHandle());
}
internal class AtkTableIfaceExterns
{
}


public struct AtkTableIface
{
	
public GTypeInterface parent;
	
public IntPtr ref_at;
	
public IntPtr get_index_at;
	
public IntPtr get_column_at_index;
	
public IntPtr get_row_at_index;
	
public IntPtr get_n_columns;
	
public IntPtr get_n_rows;
	
public IntPtr get_column_extent_at;
	
public IntPtr get_row_extent_at;
	
public IntPtr get_caption;
	
public IntPtr get_column_description;
	
public IntPtr get_column_header;
	
public IntPtr get_row_description;
	
public IntPtr get_row_header;
	
public IntPtr get_summary;
	
public IntPtr set_caption;
	
public IntPtr set_column_description;
	
public IntPtr set_column_header;
	
public IntPtr set_row_description;
	
public IntPtr set_row_header;
	
public IntPtr set_summary;
	
public IntPtr get_selected_columns;
	
public IntPtr get_selected_rows;
	
public IntPtr is_column_selected;
	
public IntPtr is_row_selected;
	
public IntPtr is_selected;
	
public IntPtr add_row_selection;
	
public IntPtr remove_row_selection;
	
public IntPtr add_column_selection;
	
public IntPtr remove_column_selection;
	
public IntPtr row_inserted;
	
public IntPtr column_inserted;
	
public IntPtr row_deleted;
	
public IntPtr column_deleted;
	
public IntPtr row_reordered;
	
public IntPtr column_reordered;
	
public IntPtr model_changed;
}
