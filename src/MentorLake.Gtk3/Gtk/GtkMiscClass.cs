namespace MentorLake.Gtk;


public class GtkMiscClassHandle : BaseSafeHandle
{
}


public static class GtkMiscClassExtensions
{

	public static GtkMiscClass Dereference(this GtkMiscClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMiscClass>(x.DangerousGetHandle());
}
internal class GtkMiscClassExterns
{
}


public struct GtkMiscClass
{
	
public GtkWidgetClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
