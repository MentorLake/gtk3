namespace MentorLake.Gtk;


public class GtkTableClassHandle : BaseSafeHandle
{
}


public static class GtkTableClassExtensions
{

	public static GtkTableClass Dereference(this GtkTableClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTableClass>(x.DangerousGetHandle());
}
internal class GtkTableClassExterns
{
}


public struct GtkTableClass
{
	
public GtkContainerClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
