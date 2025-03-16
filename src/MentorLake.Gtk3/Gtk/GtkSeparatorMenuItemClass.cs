namespace MentorLake.Gtk;

public class GtkSeparatorMenuItemClassHandle : BaseSafeHandle
{
}


public static class GtkSeparatorMenuItemClassExtensions
{

	public static GtkSeparatorMenuItemClass Dereference(this GtkSeparatorMenuItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSeparatorMenuItemClass>(x.DangerousGetHandle());
}
internal class GtkSeparatorMenuItemClassExterns
{
}

public struct GtkSeparatorMenuItemClass
{
	public GtkMenuItemClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
