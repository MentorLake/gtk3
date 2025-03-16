namespace MentorLake.Gtk;

public class GtkMenuClassHandle : BaseSafeHandle
{
}


public static class GtkMenuClassExtensions
{

	public static GtkMenuClass Dereference(this GtkMenuClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuClass>(x.DangerousGetHandle());
}
internal class GtkMenuClassExterns
{
}

public struct GtkMenuClass
{
	public GtkMenuShellClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
