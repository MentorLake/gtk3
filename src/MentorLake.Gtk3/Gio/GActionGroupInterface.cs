namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The virtual function table for [type@Gio.ActionGroup].
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The virtual function table for [type@Gio.ActionGroup].
/// </para>
/// </summary>

public struct GActionGroupInterface
{
	
public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.ActionGroup.has_action]
/// </para>
/// </summary>

public IntPtr has_action;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.ActionGroup.list_actions]
/// </para>
/// </summary>

public IntPtr list_actions;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.ActionGroup.get_action_enabled]
/// </para>
/// </summary>

public IntPtr get_action_enabled;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.ActionGroup.get_action_parameter_type]
/// </para>
/// </summary>

public IntPtr get_action_parameter_type;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.ActionGroup.get_action_state_type]
/// </para>
/// </summary>

public IntPtr get_action_state_type;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.ActionGroup.get_action_state_hint]
/// </para>
/// </summary>

public IntPtr get_action_state_hint;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.ActionGroup.get_action_state]
/// </para>
/// </summary>

public IntPtr get_action_state;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.ActionGroup.change_action_state]
/// </para>
/// </summary>

public IntPtr change_action_state;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.ActionGroup.activate_action]
/// </para>
/// </summary>

public IntPtr activate_action;
	/// <summary>
/// <para>
/// the class closure for the [signal@Gio.ActionGroup::action-added] signal
/// </para>
/// </summary>

public IntPtr action_added;
	/// <summary>
/// <para>
/// the class closure for the [signal@Gio.ActionGroup::action-removed] signal
/// </para>
/// </summary>

public IntPtr action_removed;
	/// <summary>
/// <para>
/// the class closure for the [signal@Gio.ActionGroup::action-enabled-changed] signal
/// </para>
/// </summary>

public IntPtr action_enabled_changed;
	/// <summary>
/// <para>
/// the class closure for the [signal@Gio.ActionGroup::action-enabled-changed] signal
/// </para>
/// </summary>

public IntPtr action_state_changed;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.ActionGroup.query_action]
/// </para>
/// </summary>

public IntPtr query_action;
}
