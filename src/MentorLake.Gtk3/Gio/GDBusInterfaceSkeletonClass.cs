namespace MentorLake.Gio;

public class GDBusInterfaceSkeletonClassHandle : BaseSafeHandle
{
}


public static class GDBusInterfaceSkeletonClassExtensions
{

	public static GDBusInterfaceSkeletonClass Dereference(this GDBusInterfaceSkeletonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusInterfaceSkeletonClass>(x.DangerousGetHandle());
}
internal class GDBusInterfaceSkeletonClassExterns
{
}

public struct GDBusInterfaceSkeletonClass
{
	public GObjectClass parent_class;
	public IntPtr get_info;
	public IntPtr get_vtable;
	public IntPtr get_properties;
	public IntPtr flush;
	public IntPtr g_authorize_method;
}
