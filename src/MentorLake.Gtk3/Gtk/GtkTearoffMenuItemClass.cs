namespace MentorLake.Gtk;

public class GtkTearoffMenuItemClassHandle : BaseSafeHandle
{
}


public static class GtkTearoffMenuItemClassExtensions
{

	public static GtkTearoffMenuItemClass Dereference(this GtkTearoffMenuItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTearoffMenuItemClass>(x.DangerousGetHandle());
}
internal class GtkTearoffMenuItemClassExterns
{
}

public struct GtkTearoffMenuItemClass
{
	public GtkMenuItemClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
