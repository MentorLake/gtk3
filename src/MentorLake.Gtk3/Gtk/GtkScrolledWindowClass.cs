namespace MentorLake.Gtk;

public class GtkScrolledWindowClassHandle : BaseSafeHandle
{
}


public static class GtkScrolledWindowClassExtensions
{

	public static GtkScrolledWindowClass Dereference(this GtkScrolledWindowClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScrolledWindowClass>(x.DangerousGetHandle());
}
internal class GtkScrolledWindowClassExterns
{
}

public struct GtkScrolledWindowClass
{
	public GtkBinClass parent_class;
	public int scrollbar_spacing;
	public IntPtr scroll_child;
	public IntPtr move_focus_out;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
