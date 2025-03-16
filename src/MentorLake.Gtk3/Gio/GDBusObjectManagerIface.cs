namespace MentorLake.Gio;

public class GDBusObjectManagerIfaceHandle : BaseSafeHandle
{
}


public static class GDBusObjectManagerIfaceExtensions
{

	public static GDBusObjectManagerIface Dereference(this GDBusObjectManagerIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectManagerIface>(x.DangerousGetHandle());
}
internal class GDBusObjectManagerIfaceExterns
{
}

public struct GDBusObjectManagerIface
{
	public GTypeInterface parent_iface;
	public IntPtr get_object_path;
	public IntPtr get_objects;
	public IntPtr get_object;
	public IntPtr get_interface;
	public IntPtr object_added;
	public IntPtr object_removed;
	public IntPtr interface_added;
	public IntPtr interface_removed;
}
