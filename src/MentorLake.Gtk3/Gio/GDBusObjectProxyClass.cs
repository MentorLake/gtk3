namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GDBusObjectProxy.
/// </para>
/// </summary>

public class GDBusObjectProxyClassHandle : BaseSafeHandle
{
}


public static class GDBusObjectProxyClassExtensions
{

	public static GDBusObjectProxyClass Dereference(this GDBusObjectProxyClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectProxyClass>(x.DangerousGetHandle());
}
internal class GDBusObjectProxyClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GDBusObjectProxy.
/// </para>
/// </summary>

public struct GDBusObjectProxyClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
}
