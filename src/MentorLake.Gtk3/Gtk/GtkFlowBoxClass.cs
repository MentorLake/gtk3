namespace MentorLake.Gtk;


public class GtkFlowBoxClassHandle : BaseSafeHandle
{
}


public static class GtkFlowBoxClassExtensions
{

	public static GtkFlowBoxClass Dereference(this GtkFlowBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFlowBoxClass>(x.DangerousGetHandle());
}
internal class GtkFlowBoxClassExterns
{
}


public struct GtkFlowBoxClass
{
	
public GtkContainerClass parent_class;
	
public IntPtr child_activated;
	
public IntPtr selected_children_changed;
	
public IntPtr activate_cursor_child;
	
public IntPtr toggle_cursor_child;
	
public IntPtr move_cursor;
	
public IntPtr select_all;
	
public IntPtr unselect_all;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
	
public IntPtr _gtk_reserved6;
}
