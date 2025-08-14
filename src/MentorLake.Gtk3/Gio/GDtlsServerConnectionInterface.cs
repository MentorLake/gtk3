namespace MentorLake.Gio;

/// <summary>
/// <para>
/// vtable for a #GDtlsServerConnection implementation.
/// </para>
/// </summary>

public class GDtlsServerConnectionInterfaceHandle : BaseSafeHandle
{
}


public static class GDtlsServerConnectionInterfaceExtensions
{

	public static GDtlsServerConnectionInterface Dereference(this GDtlsServerConnectionInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDtlsServerConnectionInterface>(x.DangerousGetHandle());
}
internal class GDtlsServerConnectionInterfaceExterns
{
}

/// <summary>
/// <para>
/// vtable for a #GDtlsServerConnection implementation.
/// </para>
/// </summary>

public struct GDtlsServerConnectionInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
}
