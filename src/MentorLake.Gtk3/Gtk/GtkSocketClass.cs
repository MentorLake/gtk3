namespace MentorLake.Gtk;


public class GtkSocketClassHandle : BaseSafeHandle
{
}


public static class GtkSocketClassExtensions
{

	public static GtkSocketClass Dereference(this GtkSocketClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSocketClass>(x.DangerousGetHandle());
}
internal class GtkSocketClassExterns
{
}


public struct GtkSocketClass
{
	
public GtkContainerClass parent_class;
	
public IntPtr plug_added;
	
public IntPtr plug_removed;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
