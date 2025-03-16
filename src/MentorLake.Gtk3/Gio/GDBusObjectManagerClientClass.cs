namespace MentorLake.Gio;

public class GDBusObjectManagerClientClassHandle : BaseSafeHandle
{
}


public static class GDBusObjectManagerClientClassExtensions
{

	public static GDBusObjectManagerClientClass Dereference(this GDBusObjectManagerClientClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectManagerClientClass>(x.DangerousGetHandle());
}
internal class GDBusObjectManagerClientClassExterns
{
}

public struct GDBusObjectManagerClientClass
{
	public GObjectClass parent_class;
	public IntPtr interface_proxy_signal;
	public IntPtr interface_proxy_properties_changed;
}
