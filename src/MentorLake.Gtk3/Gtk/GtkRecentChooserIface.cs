namespace MentorLake.Gtk;

public class GtkRecentChooserIfaceHandle : BaseSafeHandle
{
}


public static class GtkRecentChooserIfaceExtensions
{

	public static GtkRecentChooserIface Dereference(this GtkRecentChooserIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentChooserIface>(x.DangerousGetHandle());
}
internal class GtkRecentChooserIfaceExterns
{
}

public struct GtkRecentChooserIface
{
	public IntPtr set_current_uri;
	public IntPtr get_current_uri;
	public IntPtr select_uri;
	public IntPtr unselect_uri;
	public IntPtr select_all;
	public IntPtr unselect_all;
	public IntPtr get_items;
	public IntPtr get_recent_manager;
	public IntPtr add_filter;
	public IntPtr remove_filter;
	public IntPtr list_filters;
	public IntPtr set_sort_func;
	public IntPtr item_activated;
	public IntPtr selection_changed;
}
