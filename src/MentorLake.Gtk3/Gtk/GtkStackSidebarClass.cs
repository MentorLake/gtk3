namespace MentorLake.Gtk;


public class GtkStackSidebarClassHandle : BaseSafeHandle
{
}


public static class GtkStackSidebarClassExtensions
{

	public static GtkStackSidebarClass Dereference(this GtkStackSidebarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStackSidebarClass>(x.DangerousGetHandle());
}
internal class GtkStackSidebarClassExterns
{
}


public struct GtkStackSidebarClass
{
	
public GtkBinClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
