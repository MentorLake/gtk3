namespace MentorLake.Gio;

public class GActionMapInterfaceHandle : BaseSafeHandle
{
}


public static class GActionMapInterfaceExtensions
{

	public static GActionMapInterface Dereference(this GActionMapInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GActionMapInterface>(x.DangerousGetHandle());
}
internal class GActionMapInterfaceExterns
{
}

public struct GActionMapInterface
{
	public GTypeInterface g_iface;
	public IntPtr lookup_action;
	public IntPtr add_action;
	public IntPtr remove_action;
}
