namespace MentorLake.Gtk;

public class GtkCellViewClassHandle : BaseSafeHandle
{
}


public static class GtkCellViewClassExtensions
{

	public static GtkCellViewClass Dereference(this GtkCellViewClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellViewClass>(x.DangerousGetHandle());
}
internal class GtkCellViewClassExterns
{
}

public struct GtkCellViewClass
{
	public GtkWidgetClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
