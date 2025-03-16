namespace MentorLake.Gtk;

public class GtkUIManagerClassHandle : BaseSafeHandle
{
}


public static class GtkUIManagerClassExtensions
{

	public static GtkUIManagerClass Dereference(this GtkUIManagerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkUIManagerClass>(x.DangerousGetHandle());
}
internal class GtkUIManagerClassExterns
{
}

public struct GtkUIManagerClass
{
	public GObjectClass parent_class;
	public IntPtr add_widget;
	public IntPtr actions_changed;
	public IntPtr connect_proxy;
	public IntPtr disconnect_proxy;
	public IntPtr pre_activate;
	public IntPtr post_activate;
	public IntPtr get_widget;
	public IntPtr get_action;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
