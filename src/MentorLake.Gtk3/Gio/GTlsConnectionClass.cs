namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The class structure for the #GTlsConnection type.
/// </para>
/// </summary>

public class GTlsConnectionClassHandle : BaseSafeHandle
{
}


public static class GTlsConnectionClassExtensions
{

	public static GTlsConnectionClass Dereference(this GTlsConnectionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsConnectionClass>(x.DangerousGetHandle());
}
internal class GTlsConnectionClassExterns
{
}

/// <summary>
/// <para>
/// The class structure for the #GTlsConnection type.
/// </para>
/// </summary>

public struct GTlsConnectionClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GIOStreamClass parent_class;
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
/// Retrieve TLS channel binding data (Since: 2.66)
/// </para>
/// </summary>

public IntPtr get_binding_data;
	/// <summary>
/// <para>
/// Get ALPN-negotiated protocol (Since: 2.70)
/// </para>
/// </summary>

public IntPtr get_negotiated_protocol;
}
