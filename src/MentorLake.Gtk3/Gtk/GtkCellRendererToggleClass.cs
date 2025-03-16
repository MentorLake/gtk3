namespace MentorLake.Gtk;

public class GtkCellRendererToggleClassHandle : BaseSafeHandle
{
}


public static class GtkCellRendererToggleClassExtensions
{

	public static GtkCellRendererToggleClass Dereference(this GtkCellRendererToggleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererToggleClass>(x.DangerousGetHandle());
}
internal class GtkCellRendererToggleClassExterns
{
}

public struct GtkCellRendererToggleClass
{
	public GtkCellRendererClass parent_class;
	public IntPtr toggled;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
