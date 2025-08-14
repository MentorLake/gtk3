namespace MentorLake.Gtk;


public class GtkCellRendererSpinnerClassHandle : BaseSafeHandle
{
}


public static class GtkCellRendererSpinnerClassExtensions
{

	public static GtkCellRendererSpinnerClass Dereference(this GtkCellRendererSpinnerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererSpinnerClass>(x.DangerousGetHandle());
}
internal class GtkCellRendererSpinnerClassExterns
{
}


public struct GtkCellRendererSpinnerClass
{
	
public GtkCellRendererClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
