namespace MentorLake.Gtk;


public class GtkEditableInterfaceHandle : BaseSafeHandle
{
}


public static class GtkEditableInterfaceExtensions
{

	public static GtkEditableInterface Dereference(this GtkEditableInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEditableInterface>(x.DangerousGetHandle());
}
internal class GtkEditableInterfaceExterns
{
}


public struct GtkEditableInterface
{
	
public GTypeInterface base_iface;
	
public IntPtr insert_text;
	
public IntPtr delete_text;
	
public IntPtr changed;
	
public IntPtr do_insert_text;
	
public IntPtr do_delete_text;
	
public IntPtr get_chars;
	
public IntPtr set_selection_bounds;
	
public IntPtr get_selection_bounds;
	
public IntPtr set_position;
	
public IntPtr get_position;
}
