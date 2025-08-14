namespace MentorLake.Gtk;


public class GtkMenuShellClassHandle : BaseSafeHandle
{
}


public static class GtkMenuShellClassExtensions
{

	public static GtkMenuShellClass Dereference(this GtkMenuShellClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuShellClass>(x.DangerousGetHandle());
}
internal class GtkMenuShellClassExterns
{
}


public struct GtkMenuShellClass
{
	
public GtkContainerClass parent_class;
	
public uint submenu_placement;
	
public IntPtr deactivate;
	
public IntPtr selection_done;
	
public IntPtr move_current;
	
public IntPtr activate_current;
	
public IntPtr cancel;
	
public IntPtr select_item;
	
public IntPtr insert;
	
public IntPtr get_popup_delay;
	
public IntPtr move_selected;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
