namespace MentorLake.Gtk;


public class GtkTreeViewClassHandle : BaseSafeHandle
{
}


public static class GtkTreeViewClassExtensions
{

	public static GtkTreeViewClass Dereference(this GtkTreeViewClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeViewClass>(x.DangerousGetHandle());
}
internal class GtkTreeViewClassExterns
{
}


public struct GtkTreeViewClass
{
	
public GtkContainerClass parent_class;
	
public IntPtr row_activated;
	
public IntPtr test_expand_row;
	
public IntPtr test_collapse_row;
	
public IntPtr row_expanded;
	
public IntPtr row_collapsed;
	
public IntPtr columns_changed;
	
public IntPtr cursor_changed;
	
public IntPtr move_cursor;
	
public IntPtr select_all;
	
public IntPtr unselect_all;
	
public IntPtr select_cursor_row;
	
public IntPtr toggle_cursor_row;
	
public IntPtr expand_collapse_cursor_row;
	
public IntPtr select_cursor_parent;
	
public IntPtr start_interactive_search;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
	
public IntPtr _gtk_reserved6;
	
public IntPtr _gtk_reserved7;
	
public IntPtr _gtk_reserved8;
}
