namespace MentorLake.Gtk;


public class GtkCellRendererAccelClassHandle : BaseSafeHandle
{
}


public static class GtkCellRendererAccelClassExtensions
{

	public static GtkCellRendererAccelClass Dereference(this GtkCellRendererAccelClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererAccelClass>(x.DangerousGetHandle());
}
internal class GtkCellRendererAccelClassExterns
{
}


public struct GtkCellRendererAccelClass
{
	
public GtkCellRendererTextClass parent_class;
	
public IntPtr accel_edited;
	
public IntPtr accel_cleared;
	
public IntPtr _gtk_reserved0;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
