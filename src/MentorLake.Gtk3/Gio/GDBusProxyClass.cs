namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GDBusProxy.
/// </para>
/// </summary>

public class GDBusProxyClassHandle : BaseSafeHandle
{
}


public static class GDBusProxyClassExtensions
{

	public static GDBusProxyClass Dereference(this GDBusProxyClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusProxyClass>(x.DangerousGetHandle());
}
internal class GDBusProxyClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GDBusProxy.
/// </para>
/// </summary>

public struct GDBusProxyClass
{
	/// <summary>
/// <para>
/// Signal class handler for the #GDBusProxy::g-properties-changed signal.
/// </para>
/// </summary>

public IntPtr g_properties_changed;
	/// <summary>
/// <para>
/// Signal class handler for the #GDBusProxy::g-signal signal.
/// </para>
/// </summary>

public IntPtr g_signal;
}
