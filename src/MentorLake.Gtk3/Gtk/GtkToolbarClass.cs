namespace MentorLake.Gtk;


public class GtkToolbarClassHandle : BaseSafeHandle
{
}


public static class GtkToolbarClassExtensions
{

	public static GtkToolbarClass Dereference(this GtkToolbarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolbarClass>(x.DangerousGetHandle());
}
internal class GtkToolbarClassExterns
{
}


public struct GtkToolbarClass
{
	
public GtkContainerClass parent_class;
	
public IntPtr orientation_changed;
	
public IntPtr style_changed;
	
public IntPtr popup_context_menu;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
