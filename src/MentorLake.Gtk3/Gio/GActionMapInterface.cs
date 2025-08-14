namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The virtual function table for [iface@Gio.ActionMap].
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The virtual function table for [iface@Gio.ActionMap].
/// </para>
/// </summary>

public struct GActionMapInterface
{
	
public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// the virtual function pointer for
///   [method@Gio.ActionMap.lookup_action]
/// </para>
/// </summary>

public IntPtr lookup_action;
	/// <summary>
/// <para>
/// the virtual function pointer for
///   [method@Gio.ActionMap.add_action]
/// </para>
/// </summary>

public IntPtr add_action;
	/// <summary>
/// <para>
/// the virtual function pointer for
///   [method@Gio.ActionMap.remove_action]
/// </para>
/// </summary>

public IntPtr remove_action;
}
