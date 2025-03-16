namespace MentorLake.Gtk;

public class GtkWindowGroupClassHandle : BaseSafeHandle
{
}


public static class GtkWindowGroupClassExtensions
{

	public static GtkWindowGroupClass Dereference(this GtkWindowGroupClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWindowGroupClass>(x.DangerousGetHandle());
}
internal class GtkWindowGroupClassExterns
{
}

public struct GtkWindowGroupClass
{
	public GObjectClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
