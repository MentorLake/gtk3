namespace MentorLake.Gtk;


public class GtkImageClassHandle : BaseSafeHandle
{
}


public static class GtkImageClassExtensions
{

	public static GtkImageClass Dereference(this GtkImageClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkImageClass>(x.DangerousGetHandle());
}
internal class GtkImageClassExterns
{
}


public struct GtkImageClass
{
	
public GtkMiscClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
