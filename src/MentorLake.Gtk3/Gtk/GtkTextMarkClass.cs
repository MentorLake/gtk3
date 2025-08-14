namespace MentorLake.Gtk;


public class GtkTextMarkClassHandle : BaseSafeHandle
{
}


public static class GtkTextMarkClassExtensions
{

	public static GtkTextMarkClass Dereference(this GtkTextMarkClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextMarkClass>(x.DangerousGetHandle());
}
internal class GtkTextMarkClassExterns
{
}


public struct GtkTextMarkClass
{
	
public GObjectClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
