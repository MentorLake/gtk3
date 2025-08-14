namespace MentorLake.Gtk;


public class GtkScaleButtonClassHandle : BaseSafeHandle
{
}


public static class GtkScaleButtonClassExtensions
{

	public static GtkScaleButtonClass Dereference(this GtkScaleButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScaleButtonClass>(x.DangerousGetHandle());
}
internal class GtkScaleButtonClassExterns
{
}


public struct GtkScaleButtonClass
{
	
public GtkButtonClass parent_class;
	
public IntPtr value_changed;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
