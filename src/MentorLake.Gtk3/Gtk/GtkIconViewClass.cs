namespace MentorLake.Gtk;


public class GtkIconViewClassHandle : BaseSafeHandle
{
}


public static class GtkIconViewClassExtensions
{

	public static GtkIconViewClass Dereference(this GtkIconViewClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconViewClass>(x.DangerousGetHandle());
}
internal class GtkIconViewClassExterns
{
}


public struct GtkIconViewClass
{
	
public GtkContainerClass parent_class;
	
public IntPtr item_activated;
	
public IntPtr selection_changed;
	
public IntPtr select_all;
	
public IntPtr unselect_all;
	
public IntPtr select_cursor_item;
	
public IntPtr toggle_cursor_item;
	
public IntPtr move_cursor;
	
public IntPtr activate_cursor_item;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
