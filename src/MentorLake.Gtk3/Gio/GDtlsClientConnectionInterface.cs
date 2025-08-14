namespace MentorLake.Gio;

/// <summary>
/// <para>
/// vtable for a #GDtlsClientConnection implementation.
/// </para>
/// </summary>

public class GDtlsClientConnectionInterfaceHandle : BaseSafeHandle
{
}


public static class GDtlsClientConnectionInterfaceExtensions
{

	public static GDtlsClientConnectionInterface Dereference(this GDtlsClientConnectionInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDtlsClientConnectionInterface>(x.DangerousGetHandle());
}
internal class GDtlsClientConnectionInterfaceExterns
{
}

/// <summary>
/// <para>
/// vtable for a #GDtlsClientConnection implementation.
/// </para>
/// </summary>

public struct GDtlsClientConnectionInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
}
