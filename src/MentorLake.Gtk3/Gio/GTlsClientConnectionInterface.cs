namespace MentorLake.Gio;

/// <summary>
/// <para>
/// vtable for a #GTlsClientConnection implementation.
/// </para>
/// </summary>

public class GTlsClientConnectionInterfaceHandle : BaseSafeHandle
{
}


public static class GTlsClientConnectionInterfaceExtensions
{

	public static GTlsClientConnectionInterface Dereference(this GTlsClientConnectionInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsClientConnectionInterface>(x.DangerousGetHandle());
}
internal class GTlsClientConnectionInterfaceExterns
{
}

/// <summary>
/// <para>
/// vtable for a #GTlsClientConnection implementation.
/// </para>
/// </summary>

public struct GTlsClientConnectionInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Copies session state from one #GTlsClientConnection to another.
/// </para>
/// </summary>

public IntPtr copy_session_state;
}
