namespace MentorLake.Gtk;

public class GtkCellRendererTextClassHandle : BaseSafeHandle
{
}


public static class GtkCellRendererTextClassExtensions
{

	public static GtkCellRendererTextClass Dereference(this GtkCellRendererTextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererTextClass>(x.DangerousGetHandle());
}
internal class GtkCellRendererTextClassExterns
{
}

public struct GtkCellRendererTextClass
{
	public GtkCellRendererClass parent_class;
	public IntPtr edited;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
