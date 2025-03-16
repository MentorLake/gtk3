namespace MentorLake.Gtk;

public class GtkSeparatorToolItemClassHandle : BaseSafeHandle
{
}


public static class GtkSeparatorToolItemClassExtensions
{

	public static GtkSeparatorToolItemClass Dereference(this GtkSeparatorToolItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSeparatorToolItemClass>(x.DangerousGetHandle());
}
internal class GtkSeparatorToolItemClassExterns
{
}

public struct GtkSeparatorToolItemClass
{
	public GtkToolItemClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
