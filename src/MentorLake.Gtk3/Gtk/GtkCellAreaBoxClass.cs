namespace MentorLake.Gtk;

public class GtkCellAreaBoxClassHandle : BaseSafeHandle
{
}


public static class GtkCellAreaBoxClassExtensions
{

	public static GtkCellAreaBoxClass Dereference(this GtkCellAreaBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellAreaBoxClass>(x.DangerousGetHandle());
}
internal class GtkCellAreaBoxClassExterns
{
}

public struct GtkCellAreaBoxClass
{
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
