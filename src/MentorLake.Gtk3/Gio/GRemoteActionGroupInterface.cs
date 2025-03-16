namespace MentorLake.Gio;

public class GRemoteActionGroupInterfaceHandle : BaseSafeHandle
{
}


public static class GRemoteActionGroupInterfaceExtensions
{

	public static GRemoteActionGroupInterface Dereference(this GRemoteActionGroupInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRemoteActionGroupInterface>(x.DangerousGetHandle());
}
internal class GRemoteActionGroupInterfaceExterns
{
}

public struct GRemoteActionGroupInterface
{
	public GTypeInterface g_iface;
	public IntPtr activate_action_full;
	public IntPtr change_action_state_full;
}
