namespace MentorLake.Gtk;


public class GtkActionBarClassHandle : BaseSafeHandle
{
}


public static class GtkActionBarClassExtensions
{

	public static GtkActionBarClass Dereference(this GtkActionBarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkActionBarClass>(x.DangerousGetHandle());
}
internal class GtkActionBarClassExterns
{
}


public struct GtkActionBarClass
{
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
