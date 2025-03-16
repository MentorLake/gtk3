namespace MentorLake.Gtk;

public class GtkMenuToolButtonClassHandle : BaseSafeHandle
{
}


public static class GtkMenuToolButtonClassExtensions
{

	public static GtkMenuToolButtonClass Dereference(this GtkMenuToolButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuToolButtonClass>(x.DangerousGetHandle());
}
internal class GtkMenuToolButtonClassExterns
{
}

public struct GtkMenuToolButtonClass
{
	public GtkToolButtonClass parent_class;
	public IntPtr show_menu;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
