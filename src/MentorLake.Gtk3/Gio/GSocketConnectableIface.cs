namespace MentorLake.Gio;

public class GSocketConnectableIfaceHandle : BaseSafeHandle
{
}


public static class GSocketConnectableIfaceExtensions
{

	public static GSocketConnectableIface Dereference(this GSocketConnectableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketConnectableIface>(x.DangerousGetHandle());
}
internal class GSocketConnectableIfaceExterns
{
}

public struct GSocketConnectableIface
{
	public GTypeInterface g_iface;
	public IntPtr enumerate;
	public IntPtr proxy_enumerate;
	public IntPtr to_string;
}
