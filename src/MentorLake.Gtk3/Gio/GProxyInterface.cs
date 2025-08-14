namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Provides an interface for handling proxy connection and payload.
/// </para>
/// </summary>

public class GProxyInterfaceHandle : BaseSafeHandle
{
}


public static class GProxyInterfaceExtensions
{

	public static GProxyInterface Dereference(this GProxyInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GProxyInterface>(x.DangerousGetHandle());
}
internal class GProxyInterfaceExterns
{
}

/// <summary>
/// <para>
/// Provides an interface for handling proxy connection and payload.
/// </para>
/// </summary>

public struct GProxyInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Connect to proxy server and wrap (if required) the #connection
///           to handle payload.
/// </para>
/// </summary>

public IntPtr connect;
	/// <summary>
/// <para>
/// Same as connect() but asynchronous.
/// </para>
/// </summary>

public IntPtr connect_async;
	/// <summary>
/// <para>
/// Returns the result of connect_async()
/// </para>
/// </summary>

public IntPtr connect_finish;
	/// <summary>
/// <para>
/// Returns whether the proxy supports hostname lookups.
/// </para>
/// </summary>

public IntPtr supports_hostname;
}
