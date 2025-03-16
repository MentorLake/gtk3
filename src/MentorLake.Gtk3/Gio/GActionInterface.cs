namespace MentorLake.Gio;

public class GActionInterfaceHandle : BaseSafeHandle
{
}


public static class GActionInterfaceExtensions
{

	public static GActionInterface Dereference(this GActionInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GActionInterface>(x.DangerousGetHandle());
}
internal class GActionInterfaceExterns
{
}

public struct GActionInterface
{
	public GTypeInterface g_iface;
	public IntPtr get_name;
	public IntPtr get_parameter_type;
	public IntPtr get_state_type;
	public IntPtr get_state_hint;
	public IntPtr get_enabled;
	public IntPtr get_state;
	public IntPtr change_state;
	public IntPtr activate;
}
