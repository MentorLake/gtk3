namespace MentorLake.Gtk;


public class GtkRecentActionClassHandle : BaseSafeHandle
{
}


public static class GtkRecentActionClassExtensions
{

	public static GtkRecentActionClass Dereference(this GtkRecentActionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentActionClass>(x.DangerousGetHandle());
}
internal class GtkRecentActionClassExterns
{
}


public struct GtkRecentActionClass
{
	
public GtkActionClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
