namespace MentorLake.Gtk;


public class GtkHeaderBarClassHandle : BaseSafeHandle
{
}


public static class GtkHeaderBarClassExtensions
{

	public static GtkHeaderBarClass Dereference(this GtkHeaderBarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHeaderBarClass>(x.DangerousGetHandle());
}
internal class GtkHeaderBarClassExterns
{
}


public struct GtkHeaderBarClass
{
	
public GtkContainerClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
