namespace MentorLake.Gtk;

public class GtkMenuBarClassHandle : BaseSafeHandle
{
}


public static class GtkMenuBarClassExtensions
{

	public static GtkMenuBarClass Dereference(this GtkMenuBarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuBarClass>(x.DangerousGetHandle());
}
internal class GtkMenuBarClassExterns
{
}

public struct GtkMenuBarClass
{
	public GtkMenuShellClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
