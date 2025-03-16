namespace MentorLake.Gtk;

public class GtkBuildableIfaceHandle : BaseSafeHandle
{
}


public static class GtkBuildableIfaceExtensions
{

	public static GtkBuildableIface Dereference(this GtkBuildableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBuildableIface>(x.DangerousGetHandle());
}
internal class GtkBuildableIfaceExterns
{
}

public struct GtkBuildableIface
{
	public GTypeInterface g_iface;
	public IntPtr set_name;
	public IntPtr get_name;
	public IntPtr add_child;
	public IntPtr set_buildable_property;
	public IntPtr construct_child;
	public IntPtr custom_tag_start;
	public IntPtr custom_tag_end;
	public IntPtr custom_finished;
	public IntPtr parser_finished;
	public IntPtr get_internal_child;
}
