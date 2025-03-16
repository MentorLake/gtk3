namespace MentorLake.Gtk;

public class GtkCellRendererPixbufClassHandle : BaseSafeHandle
{
}


public static class GtkCellRendererPixbufClassExtensions
{

	public static GtkCellRendererPixbufClass Dereference(this GtkCellRendererPixbufClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererPixbufClass>(x.DangerousGetHandle());
}
internal class GtkCellRendererPixbufClassExterns
{
}

public struct GtkCellRendererPixbufClass
{
	public GtkCellRendererClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
