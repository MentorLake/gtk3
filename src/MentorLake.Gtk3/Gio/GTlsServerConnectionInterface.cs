namespace MentorLake.Gio;

/// <summary>
/// <para>
/// vtable for a #GTlsServerConnection implementation.
/// </para>
/// </summary>

public class GTlsServerConnectionInterfaceHandle : BaseSafeHandle
{
}


public static class GTlsServerConnectionInterfaceExtensions
{

	public static GTlsServerConnectionInterface Dereference(this GTlsServerConnectionInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsServerConnectionInterface>(x.DangerousGetHandle());
}
internal class GTlsServerConnectionInterfaceExterns
{
}

/// <summary>
/// <para>
/// vtable for a #GTlsServerConnection implementation.
/// </para>
/// </summary>

public struct GTlsServerConnectionInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
}
