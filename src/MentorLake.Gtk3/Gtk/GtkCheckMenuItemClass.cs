namespace MentorLake.Gtk;

public class GtkCheckMenuItemClassHandle : BaseSafeHandle
{
}


public static class GtkCheckMenuItemClassExtensions
{

	public static GtkCheckMenuItemClass Dereference(this GtkCheckMenuItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCheckMenuItemClass>(x.DangerousGetHandle());
}
internal class GtkCheckMenuItemClassExterns
{
}

public struct GtkCheckMenuItemClass
{
	public GtkMenuItemClass parent_class;
	public IntPtr toggled;
	public IntPtr draw_indicator;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
