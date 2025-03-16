namespace MentorLake.Gtk;

public class GtkAccelGroupClassHandle : BaseSafeHandle
{
}


public static class GtkAccelGroupClassExtensions
{

	public static GtkAccelGroupClass Dereference(this GtkAccelGroupClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAccelGroupClass>(x.DangerousGetHandle());
}
internal class GtkAccelGroupClassExterns
{
}

public struct GtkAccelGroupClass
{
	public GObjectClass parent_class;
	public IntPtr accel_changed;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
