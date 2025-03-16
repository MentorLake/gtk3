namespace MentorLake.Gtk;

public class GtkHSVClassHandle : BaseSafeHandle
{
}


public static class GtkHSVClassExtensions
{

	public static GtkHSVClass Dereference(this GtkHSVClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHSVClass>(x.DangerousGetHandle());
}
internal class GtkHSVClassExterns
{
}

public struct GtkHSVClass
{
	public GtkWidgetClass parent_class;
	public IntPtr changed;
	public IntPtr move;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
