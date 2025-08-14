namespace MentorLake.Gtk;


public class GtkCellRendererComboClassHandle : BaseSafeHandle
{
}


public static class GtkCellRendererComboClassExtensions
{

	public static GtkCellRendererComboClass Dereference(this GtkCellRendererComboClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererComboClass>(x.DangerousGetHandle());
}
internal class GtkCellRendererComboClassExterns
{
}


public struct GtkCellRendererComboClass
{
	
public GtkCellRendererTextClass parent;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
