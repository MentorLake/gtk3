namespace MentorLake.Gtk;

public class GtkOverlayClassHandle : BaseSafeHandle
{
}


public static class GtkOverlayClassExtensions
{

	public static GtkOverlayClass Dereference(this GtkOverlayClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkOverlayClass>(x.DangerousGetHandle());
}
internal class GtkOverlayClassExterns
{
}

public struct GtkOverlayClass
{
	public GtkBinClass parent_class;
	public IntPtr get_child_position;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
}
