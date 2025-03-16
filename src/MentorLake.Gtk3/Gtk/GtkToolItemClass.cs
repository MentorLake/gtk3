namespace MentorLake.Gtk;

public class GtkToolItemClassHandle : BaseSafeHandle
{
}


public static class GtkToolItemClassExtensions
{

	public static GtkToolItemClass Dereference(this GtkToolItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolItemClass>(x.DangerousGetHandle());
}
internal class GtkToolItemClassExterns
{
}

public struct GtkToolItemClass
{
	public GtkBinClass parent_class;
	public IntPtr create_menu_proxy;
	public IntPtr toolbar_reconfigured;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
