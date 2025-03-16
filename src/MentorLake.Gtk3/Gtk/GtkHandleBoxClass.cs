namespace MentorLake.Gtk;

public class GtkHandleBoxClassHandle : BaseSafeHandle
{
}


public static class GtkHandleBoxClassExtensions
{

	public static GtkHandleBoxClass Dereference(this GtkHandleBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHandleBoxClass>(x.DangerousGetHandle());
}
internal class GtkHandleBoxClassExterns
{
}

public struct GtkHandleBoxClass
{
	public GtkBinClass parent_class;
	public IntPtr child_attached;
	public IntPtr child_detached;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
