namespace MentorLake.Gio;

public class GDBusInterfaceIfaceHandle : BaseSafeHandle
{
}


public static class GDBusInterfaceIfaceExtensions
{

	public static GDBusInterfaceIface Dereference(this GDBusInterfaceIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusInterfaceIface>(x.DangerousGetHandle());
}
internal class GDBusInterfaceIfaceExterns
{
}

public struct GDBusInterfaceIface
{
	public GTypeInterface parent_iface;
	public IntPtr get_info;
	public IntPtr get_object;
	public IntPtr set_object;
	public IntPtr dup_object;
}
