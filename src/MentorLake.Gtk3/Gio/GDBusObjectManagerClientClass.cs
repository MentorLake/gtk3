namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GDBusObjectManagerClient.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Class structure for #GDBusObjectManagerClient.
/// </para>
/// </summary>

public struct GDBusObjectManagerClientClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// Signal class handler for the #GDBusObjectManagerClient::interface-proxy-signal signal.
/// </para>
/// </summary>

public IntPtr interface_proxy_signal;
	/// <summary>
/// <para>
/// Signal class handler for the #GDBusObjectManagerClient::interface-proxy-properties-changed signal.
/// </para>
/// </summary>

public IntPtr interface_proxy_properties_changed;
}
