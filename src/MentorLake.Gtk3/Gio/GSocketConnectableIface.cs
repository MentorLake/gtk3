namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Provides an interface for returning a #GSocketAddressEnumerator
/// and #GProxyAddressEnumerator
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Provides an interface for returning a #GSocketAddressEnumerator
/// and #GProxyAddressEnumerator
/// </para>
/// </summary>

public struct GSocketConnectableIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Creates a #GSocketAddressEnumerator
/// </para>
/// </summary>

public IntPtr enumerate;
	/// <summary>
/// <para>
/// Creates a #GProxyAddressEnumerator
/// </para>
/// </summary>

public IntPtr proxy_enumerate;
	/// <summary>
/// <para>
/// Format the connectable’s address as a string for debugging.
///    Implementing this is optional. (Since: 2.48)
/// </para>
/// </summary>

public IntPtr to_string;
}
