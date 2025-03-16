namespace MentorLake.Gtk;

public class GtkMenuItemClassHandle : BaseSafeHandle
{
}


public static class GtkMenuItemClassExtensions
{

	public static GtkMenuItemClass Dereference(this GtkMenuItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuItemClass>(x.DangerousGetHandle());
}
internal class GtkMenuItemClassExterns
{
}

public struct GtkMenuItemClass
{
	public GtkBinClass parent_class;
	public uint hide_on_activate;
	public IntPtr activate;
	public IntPtr activate_item;
	public IntPtr toggle_size_request;
	public IntPtr toggle_size_allocate;
	public IntPtr set_label;
	public IntPtr get_label;
	public IntPtr select;
	public IntPtr deselect;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
