namespace MentorLake.Gtk;

public class GtkStyleContextClassHandle : BaseSafeHandle
{
}


public static class GtkStyleContextClassExtensions
{

	public static GtkStyleContextClass Dereference(this GtkStyleContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStyleContextClass>(x.DangerousGetHandle());
}
internal class GtkStyleContextClassExterns
{
}

public struct GtkStyleContextClass
{
	public GObjectClass parent_class;
	public IntPtr changed;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
