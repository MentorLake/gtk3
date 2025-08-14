namespace MentorLake.Gtk;


public class GtkDrawingAreaClassHandle : BaseSafeHandle
{
}


public static class GtkDrawingAreaClassExtensions
{

	public static GtkDrawingAreaClass Dereference(this GtkDrawingAreaClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkDrawingAreaClass>(x.DangerousGetHandle());
}
internal class GtkDrawingAreaClassExterns
{
}


public struct GtkDrawingAreaClass
{
	
public GtkWidgetClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
