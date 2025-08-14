namespace MentorLake.Gtk;


public class GtkCellRendererSpinClassHandle : BaseSafeHandle
{
}


public static class GtkCellRendererSpinClassExtensions
{

	public static GtkCellRendererSpinClass Dereference(this GtkCellRendererSpinClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererSpinClass>(x.DangerousGetHandle());
}
internal class GtkCellRendererSpinClassExterns
{
}


public struct GtkCellRendererSpinClass
{
	
public GtkCellRendererTextClass parent;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
