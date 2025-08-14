namespace MentorLake.Gtk;


public class GtkCellRendererProgressClassHandle : BaseSafeHandle
{
}


public static class GtkCellRendererProgressClassExtensions
{

	public static GtkCellRendererProgressClass Dereference(this GtkCellRendererProgressClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererProgressClass>(x.DangerousGetHandle());
}
internal class GtkCellRendererProgressClassExterns
{
}


public struct GtkCellRendererProgressClass
{
	
public GtkCellRendererClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
