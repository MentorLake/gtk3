namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Virtual method table for a #GDtlsConnection implementation.
/// </para>
/// </summary>

public class GDtlsConnectionInterfaceHandle : BaseSafeHandle
{
}


public static class GDtlsConnectionInterfaceExtensions
{

	public static GDtlsConnectionInterface Dereference(this GDtlsConnectionInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDtlsConnectionInterface>(x.DangerousGetHandle());
}
internal class GDtlsConnectionInterfaceExterns
{
}

/// <summary>
/// <para>
/// Virtual method table for a #GDtlsConnection implementation.
/// </para>
/// </summary>

public struct GDtlsConnectionInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Check whether to accept a certificate.
/// </para>
/// </summary>

public IntPtr accept_certificate;
	/// <summary>
/// <para>
/// Perform a handshake operation.
/// </para>
/// </summary>

public IntPtr handshake;
	/// <summary>
/// <para>
/// Start an asynchronous handshake operation.
/// </para>
/// </summary>

public IntPtr handshake_async;
	/// <summary>
/// <para>
/// Finish an asynchronous handshake operation.
/// </para>
/// </summary>

public IntPtr handshake_finish;
	/// <summary>
/// <para>
/// Shut down one or both directions of the connection.
/// </para>
/// </summary>

public IntPtr shutdown;
	/// <summary>
/// <para>
/// Start an asynchronous shutdown operation.
/// </para>
/// </summary>

public IntPtr shutdown_async;
	/// <summary>
/// <para>
/// Finish an asynchronous shutdown operation.
/// </para>
/// </summary>

public IntPtr shutdown_finish;
	/// <summary>
/// <para>
/// Set APLN protocol list (Since: 2.60)
/// </para>
/// </summary>

public IntPtr set_advertised_protocols;
	/// <summary>
/// <para>
/// Get ALPN-negotiated protocol (Since: 2.60)
/// </para>
/// </summary>

public IntPtr get_negotiated_protocol;
	/// <summary>
/// <para>
/// Retrieve TLS channel binding data (Since: 2.66)
/// </para>
/// </summary>

public IntPtr get_binding_data;
}
