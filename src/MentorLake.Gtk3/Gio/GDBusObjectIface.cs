namespace MentorLake.Gio;

public class GDBusObjectIfaceHandle : BaseSafeHandle
{
}


public static class GDBusObjectIfaceExtensions
{

	public static GDBusObjectIface Dereference(this GDBusObjectIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectIface>(x.DangerousGetHandle());
}
internal class GDBusObjectIfaceExterns
{
}

public struct GDBusObjectIface
{
	public GTypeInterface parent_iface;
	public IntPtr get_object_path;
	public IntPtr get_interfaces;
	public IntPtr get_interface;
	public IntPtr interface_added;
	public IntPtr interface_removed;
}
