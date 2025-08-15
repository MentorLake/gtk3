namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The virtual function table for [type@Gio.Action].
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The virtual function table for [type@Gio.Action].
/// </para>
/// </summary>

public struct GActionInterface
{
	
public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.Action.get_name]
/// </para>
/// </summary>

public IntPtr get_name;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.Action.get_parameter_type]
/// </para>
/// </summary>

public IntPtr get_parameter_type;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.Action.get_state_type]
/// </para>
/// </summary>

public IntPtr get_state_type;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.Action.get_state_hint]
/// </para>
/// </summary>

public IntPtr get_state_hint;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.Action.get_enabled]
/// </para>
/// </summary>

public IntPtr get_enabled;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.Action.get_state]
/// </para>
/// </summary>

public IntPtr get_state;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.Action.change_state]
/// </para>
/// </summary>

public IntPtr change_state;
	/// <summary>
/// <para>
/// the virtual function pointer for [method@Gio.Action.activate].  Note that [type@Gio.Action] does not have an
///            &apos;activate&apos; signal but that implementations of it may have one.
/// </para>
/// </summary>

public IntPtr activate;
}
