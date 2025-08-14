namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The virtual function table for #GRemoteActionGroup.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The virtual function table for #GRemoteActionGroup.
/// </para>
/// </summary>

public struct GRemoteActionGroupInterface
{
	
public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// the virtual function pointer for g_remote_action_group_activate_action_full()
/// </para>
/// </summary>

public IntPtr activate_action_full;
	/// <summary>
/// <para>
/// the virtual function pointer for g_remote_action_group_change_action_state_full()
/// </para>
/// </summary>

public IntPtr change_action_state_full;
}
