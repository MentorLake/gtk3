namespace MentorLake.Gtk;

public class GtkScrollbarClassHandle : BaseSafeHandle
{
}


public static class GtkScrollbarClassExtensions
{

	public static GtkScrollbarClass Dereference(this GtkScrollbarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScrollbarClass>(x.DangerousGetHandle());
}
internal class GtkScrollbarClassExterns
{
}

public struct GtkScrollbarClass
{
	public GtkRangeClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
