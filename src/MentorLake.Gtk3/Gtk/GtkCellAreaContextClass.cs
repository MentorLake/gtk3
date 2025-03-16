namespace MentorLake.Gtk;

public class GtkCellAreaContextClassHandle : BaseSafeHandle
{
}


public static class GtkCellAreaContextClassExtensions
{

	public static GtkCellAreaContextClass Dereference(this GtkCellAreaContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellAreaContextClass>(x.DangerousGetHandle());
}
internal class GtkCellAreaContextClassExterns
{
}

public struct GtkCellAreaContextClass
{
	public IntPtr allocate;
	public IntPtr reset;
	public IntPtr get_preferred_height_for_width;
	public IntPtr get_preferred_width_for_height;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
}
