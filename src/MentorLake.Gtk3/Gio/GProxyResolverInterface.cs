namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The virtual function table for #GProxyResolver.
/// </para>
/// </summary>

public class GProxyResolverInterfaceHandle : BaseSafeHandle
{
}


public static class GProxyResolverInterfaceExtensions
{

	public static GProxyResolverInterface Dereference(this GProxyResolverInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GProxyResolverInterface>(x.DangerousGetHandle());
}
internal class GProxyResolverInterfaceExterns
{
}

/// <summary>
/// <para>
/// The virtual function table for #GProxyResolver.
/// </para>
/// </summary>

public struct GProxyResolverInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// the virtual function pointer for g_proxy_resolver_is_supported()
/// </para>
/// </summary>

public IntPtr is_supported;
	/// <summary>
/// <para>
/// the virtual function pointer for g_proxy_resolver_lookup()
/// </para>
/// </summary>

public IntPtr lookup;
	/// <summary>
/// <para>
/// the virtual function pointer for
///  g_proxy_resolver_lookup_async()
/// </para>
/// </summary>

public IntPtr lookup_async;
	/// <summary>
/// <para>
/// the virtual function pointer for
///  g_proxy_resolver_lookup_finish()
/// </para>
/// </summary>

public IntPtr lookup_finish;
}
