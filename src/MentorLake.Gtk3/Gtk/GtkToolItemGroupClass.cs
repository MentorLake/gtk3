namespace MentorLake.Gtk;

public class GtkToolItemGroupClassHandle : BaseSafeHandle
{
}


public static class GtkToolItemGroupClassExtensions
{

	public static GtkToolItemGroupClass Dereference(this GtkToolItemGroupClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolItemGroupClass>(x.DangerousGetHandle());
}
internal class GtkToolItemGroupClassExterns
{
}

public struct GtkToolItemGroupClass
{
	public GtkContainerClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
