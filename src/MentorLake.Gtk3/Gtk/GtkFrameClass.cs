namespace MentorLake.Gtk;

public class GtkFrameClassHandle : BaseSafeHandle
{
}


public static class GtkFrameClassExtensions
{

	public static GtkFrameClass Dereference(this GtkFrameClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFrameClass>(x.DangerousGetHandle());
}
internal class GtkFrameClassExterns
{
}

public struct GtkFrameClass
{
	public GtkBinClass parent_class;
	public IntPtr compute_child_allocation;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
