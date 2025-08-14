namespace MentorLake.Gtk;


public class GtkInvisibleClassHandle : BaseSafeHandle
{
}


public static class GtkInvisibleClassExtensions
{

	public static GtkInvisibleClass Dereference(this GtkInvisibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkInvisibleClass>(x.DangerousGetHandle());
}
internal class GtkInvisibleClassExterns
{
}


public struct GtkInvisibleClass
{
	
public GtkWidgetClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
