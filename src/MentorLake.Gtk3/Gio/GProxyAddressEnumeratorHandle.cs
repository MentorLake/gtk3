namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GProxyAddressEnumerator` is a wrapper around
/// [class@Gio.SocketAddressEnumerator] which takes the [class@Gio.SocketAddress]
/// instances returned by the [class@Gio.SocketAddressEnumerator]
/// and wraps them in [class@Gio.ProxyAddress] instances, using the given
/// [property@Gio.ProxyAddressEnumerator:proxy-resolver].
/// </para>
/// <para>
/// This enumerator will be returned (for example, by
/// [method@Gio.SocketConnectable.enumerate]) as appropriate when a proxy is
/// configured; there should be no need to manually wrap a
/// [class@Gio.SocketAddressEnumerator] instance with one.
/// </para>
/// </summary>

public class GProxyAddressEnumeratorHandle : GSocketAddressEnumeratorHandle
{
}

public static class GProxyAddressEnumeratorHandleExtensions
{
}

internal class GProxyAddressEnumeratorHandleExterns
{
}
