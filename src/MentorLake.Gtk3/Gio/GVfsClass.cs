namespace MentorLake.Gio;

public class GVfsClassHandle : BaseSafeHandle
{
}


public static class GVfsClassExtensions
{

	public static GVfsClass Dereference(this GVfsClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVfsClass>(x.DangerousGetHandle());
}
internal class GVfsClassExterns
{
}

public struct GVfsClass
{
	public GObjectClass parent_class;
	public IntPtr is_active;
	public IntPtr get_file_for_path;
	public IntPtr get_file_for_uri;
	public IntPtr get_supported_uri_schemes;
	public IntPtr parse_name;
	public IntPtr local_file_add_info;
	public IntPtr add_writable_namespaces;
	public IntPtr local_file_set_attributes;
	public IntPtr local_file_removed;
	public IntPtr local_file_moved;
	public IntPtr deserialize_icon;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
}
