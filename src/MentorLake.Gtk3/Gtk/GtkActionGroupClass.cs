namespace MentorLake.Gtk;

public class GtkActionGroupClassHandle : BaseSafeHandle
{
}


public static class GtkActionGroupClassExtensions
{

	public static GtkActionGroupClass Dereference(this GtkActionGroupClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkActionGroupClass>(x.DangerousGetHandle());
}
internal class GtkActionGroupClassExterns
{
}

public struct GtkActionGroupClass
{
	public GObjectClass parent_class;
	public IntPtr get_action;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
