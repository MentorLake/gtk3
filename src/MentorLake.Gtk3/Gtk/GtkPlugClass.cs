namespace MentorLake.Gtk;


public class GtkPlugClassHandle : BaseSafeHandle
{
}


public static class GtkPlugClassExtensions
{

	public static GtkPlugClass Dereference(this GtkPlugClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPlugClass>(x.DangerousGetHandle());
}
internal class GtkPlugClassExterns
{
}


public struct GtkPlugClass
{
	
public GtkWindowClass parent_class;
	
public IntPtr embedded;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
