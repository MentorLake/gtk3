namespace MentorLake.Gtk;


public class GtkStatusIconClassHandle : BaseSafeHandle
{
}


public static class GtkStatusIconClassExtensions
{

	public static GtkStatusIconClass Dereference(this GtkStatusIconClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStatusIconClass>(x.DangerousGetHandle());
}
internal class GtkStatusIconClassExterns
{
}


public struct GtkStatusIconClass
{
	
public GObjectClass parent_class;
	
public IntPtr activate;
	
public IntPtr popup_menu;
	
public IntPtr size_changed;
	
public IntPtr button_press_event;
	
public IntPtr button_release_event;
	
public IntPtr scroll_event;
	
public IntPtr query_tooltip;
	
public IntPtr __gtk_reserved1;
	
public IntPtr __gtk_reserved2;
	
public IntPtr __gtk_reserved3;
	
public IntPtr __gtk_reserved4;
}
