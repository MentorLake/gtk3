namespace MentorLake.Gtk;


public class GtkNotebookClassHandle : BaseSafeHandle
{
}


public static class GtkNotebookClassExtensions
{

	public static GtkNotebookClass Dereference(this GtkNotebookClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkNotebookClass>(x.DangerousGetHandle());
}
internal class GtkNotebookClassExterns
{
}


public struct GtkNotebookClass
{
	
public GtkContainerClass parent_class;
	
public IntPtr switch_page;
	
public IntPtr select_page;
	
public IntPtr focus_tab;
	
public IntPtr change_current_page;
	
public IntPtr move_focus_out;
	
public IntPtr reorder_tab;
	
public IntPtr insert_page;
	
public IntPtr create_window;
	
public IntPtr page_reordered;
	
public IntPtr page_removed;
	
public IntPtr page_added;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
	
public IntPtr _gtk_reserved6;
	
public IntPtr _gtk_reserved7;
	
public IntPtr _gtk_reserved8;
}
