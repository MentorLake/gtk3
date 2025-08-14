namespace MentorLake.Gtk;


public class GtkLayoutClassHandle : BaseSafeHandle
{
}


public static class GtkLayoutClassExtensions
{

	public static GtkLayoutClass Dereference(this GtkLayoutClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLayoutClass>(x.DangerousGetHandle());
}
internal class GtkLayoutClassExterns
{
}


public struct GtkLayoutClass
{
	
public GtkContainerClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
