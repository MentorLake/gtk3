namespace MentorLake.Gio;

public class GActionGroupInterfaceHandle : BaseSafeHandle
{
}


public static class GActionGroupInterfaceExtensions
{

	public static GActionGroupInterface Dereference(this GActionGroupInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GActionGroupInterface>(x.DangerousGetHandle());
}
internal class GActionGroupInterfaceExterns
{
}

public struct GActionGroupInterface
{
	public GTypeInterface g_iface;
	public IntPtr has_action;
	public IntPtr list_actions;
	public IntPtr get_action_enabled;
	public IntPtr get_action_parameter_type;
	public IntPtr get_action_state_type;
	public IntPtr get_action_state_hint;
	public IntPtr get_action_state;
	public IntPtr change_action_state;
	public IntPtr activate_action;
	public IntPtr action_added;
	public IntPtr action_removed;
	public IntPtr action_enabled_changed;
	public IntPtr action_state_changed;
	public IntPtr query_action;
}
