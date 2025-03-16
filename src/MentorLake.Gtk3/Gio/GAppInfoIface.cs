namespace MentorLake.Gio;

public class GAppInfoIfaceHandle : BaseSafeHandle
{
}


public static class GAppInfoIfaceExtensions
{

	public static GAppInfoIface Dereference(this GAppInfoIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GAppInfoIface>(x.DangerousGetHandle());
}
internal class GAppInfoIfaceExterns
{
}

public struct GAppInfoIface
{
	public GTypeInterface g_iface;
	public IntPtr dup;
	public IntPtr equal;
	public IntPtr get_id;
	public IntPtr get_name;
	public IntPtr get_description;
	public IntPtr get_executable;
	public IntPtr get_icon;
	public IntPtr launch;
	public IntPtr supports_uris;
	public IntPtr supports_files;
	public IntPtr launch_uris;
	public IntPtr should_show;
	public IntPtr set_as_default_for_type;
	public IntPtr set_as_default_for_extension;
	public IntPtr add_supports_type;
	public IntPtr can_remove_supports_type;
	public IntPtr remove_supports_type;
	public IntPtr can_delete;
	public IntPtr do_delete;
	public IntPtr get_commandline;
	public IntPtr get_display_name;
	public IntPtr set_as_last_used_for_type;
	public IntPtr get_supported_types;
	public IntPtr launch_uris_async;
	public IntPtr launch_uris_finish;
}
