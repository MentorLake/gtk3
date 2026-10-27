namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Contains metrics collected while loading a [class@Message] either from the
/// network or the disk cache.
/// </para>
/// <para>
/// Metrics are not collected by default for a [class@Message], you need to add the
/// flag %SOUP_MESSAGE_COLLECT_METRICS to enable the feature.
/// </para>
/// <para>
/// Temporal metrics are expressed as a monotonic time and always start with a
/// fetch start event and finish with response end. All other events are optional.
/// An event can be 0 because it hasn&apos;t happened yet, because it&apos;s optional or
/// because the load failed before the event reached.
/// </para>
/// <para>
/// Size metrics are expressed in bytes and are updated while the [class@Message] is
/// being loaded. You can connect to different [class@Message] signals to get the
/// final result of every value.
/// </para>
/// </summary>

public class SoupMessageMetricsHandle : BaseSafeHandle
{
}


public static class SoupMessageMetricsExtensions
{
/// <summary>
/// <para>
/// Copies @metrics.
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// a copy of @metrics
/// </return>

	public static MentorLake.Soup.SoupMessageMetricsHandle Copy(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_copy(metrics);
	}

/// <summary>
/// <para>
/// Frees @metrics.
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>

	public static void Free(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		SoupMessageMetricsExterns.soup_message_metrics_free(metrics);
	}

/// <summary>
/// <para>
/// Get the time immediately after the [class@Message] completed the
/// connection to the server. This includes the time for the proxy
/// negotiation and TLS handshake.
/// </para>
/// <para>
/// It will be 0 if no network connection was required to fetch the resource (a
/// persistent connection was used or resource was loaded from the local disk
/// cache).
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the connection end time
/// </return>

	public static ulong GetConnectEnd(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_connect_end(metrics);
	}

/// <summary>
/// <para>
/// Get the time immediately before the [class@Message] started to
/// establish the connection to the server.
/// </para>
/// <para>
/// It will be 0 if no network connection was required to fetch the resource (a
/// persistent connection was used or resource was loaded from the local disk
/// cache).
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the connection start time
/// </return>

	public static ulong GetConnectStart(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_connect_start(metrics);
	}

/// <summary>
/// <para>
/// Get the time immediately after the [class@Message] completed the
/// domain lookup name for the resource.
/// </para>
/// <para>
/// It will be 0 if no domain lookup was required to fetch the resource (a
/// persistent connection was used or resource was loaded from the local disk
/// cache).
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the domain lookup end time
/// </return>

	public static ulong GetDnsEnd(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_dns_end(metrics);
	}

/// <summary>
/// <para>
/// Get the time immediately before the [class@Message] started the
/// domain lookup name for the resource.
/// </para>
/// <para>
/// It will be 0 if no domain lookup was required to fetch the resource (a
/// persistent connection was used or resource was loaded from the local disk
/// cache).
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the domain lookup start time
/// </return>

	public static ulong GetDnsStart(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_dns_start(metrics);
	}

/// <summary>
/// <para>
/// Get the time immediately before the [class@Message] started to
/// fetch a resource either from a remote server or local disk cache.
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the fetch start time
/// </return>

	public static ulong GetFetchStart(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_fetch_start(metrics);
	}

/// <summary>
/// <para>
/// Get the number of bytes sent to the network for the request body.
/// </para>
/// <para>
/// This is the size of the body sent, after encodings are applied, so it might
/// be greater than the value returned by
/// [method@MessageMetrics.get_request_body_size]. This value is available right
/// before [signal@Message::wrote-body] signal is emitted, but you might get an
/// intermediate value if called before.
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the request body bytes sent
/// </return>

	public static ulong GetRequestBodyBytesSent(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_request_body_bytes_sent(metrics);
	}

/// <summary>
/// <para>
/// Get the request body size in bytes. This is the size of the original body
/// given to the request before any encoding is applied.
/// </para>
/// <para>
/// This value is available right before [signal@Message::wrote-body] signal is
/// emitted, but you might get an intermediate value if called before.
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the request body size
/// </return>

	public static ulong GetRequestBodySize(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_request_body_size(metrics);
	}

/// <summary>
/// <para>
/// Get the number of bytes sent to the network for the request headers.
/// </para>
/// <para>
/// This value is available right before [signal@Message::wrote-headers] signal
/// is emitted, but you might get an intermediate value if called before.
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the request headers bytes sent
/// </return>

	public static ulong GetRequestHeaderBytesSent(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_request_header_bytes_sent(metrics);
	}

/// <summary>
/// <para>
/// Get the time immediately before the [class@Message] started the
/// request of the resource from the server or the local disk cache.
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the request start time
/// </return>

	public static ulong GetRequestStart(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_request_start(metrics);
	}

/// <summary>
/// <para>
/// Get the number of bytes received from the network for the response body.
/// </para>
/// <para>
/// This value is available right before [signal@Message::got-body] signal is
/// emitted, but you might get an intermediate value if called before. For
/// resources loaded from the disk cache this value is always 0.
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the response body bytes received
/// </return>

	public static ulong GetResponseBodyBytesReceived(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_response_body_bytes_received(metrics);
	}

/// <summary>
/// <para>
/// Get the response body size in bytes.
/// </para>
/// <para>
/// This is the size of the body as given to the user after all encodings are
/// applied, so it might be greater than the value returned by
/// [method@MessageMetrics.get_response_body_bytes_received]. This value is
/// available right before [signal@Message::got-body] signal is emitted, but you
/// might get an intermediate value if called before.
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the response body size
/// </return>

	public static ulong GetResponseBodySize(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_response_body_size(metrics);
	}

/// <summary>
/// <para>
/// Get the time immediately after the [class@Message] received the last
/// bytes of the response from the server or the local disk cache.
/// </para>
/// <para>
/// In case of load failure, this returns the time immediately before the
/// fetch is aborted.
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the response end time
/// </return>

	public static ulong GetResponseEnd(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_response_end(metrics);
	}

/// <summary>
/// <para>
/// Get the number of bytes received from the network for the response headers.
/// </para>
/// <para>
/// This value is available right before [signal@Message::got-headers] signal
/// is emitted, but you might get an intermediate value if called before.
/// For resources loaded from the disk cache this value is always 0.
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the response headers bytes received
/// </return>

	public static ulong GetResponseHeaderBytesReceived(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_response_header_bytes_received(metrics);
	}

/// <summary>
/// <para>
/// Get the time immediately after the [class@Message] received the first
/// bytes of the response from the server or the local disk cache.
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the response start time
/// </return>

	public static ulong GetResponseStart(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_response_start(metrics);
	}

/// <summary>
/// <para>
/// Get the time immediately before the [class@Message] started the
/// TLS handshake.
/// </para>
/// <para>
/// It will be 0 if no TLS handshake was required to fetch the resource
/// (connection was not secure, a persistent connection was used or resource was
/// loaded from the local disk cache).
/// </para>
/// </summary>

/// <param name="metrics">
/// a #SoupMessageMetrics
/// </param>
/// <return>
/// the tls start time
/// </return>

	public static ulong GetTlsStart(this MentorLake.Soup.SoupMessageMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (SoupMessageMetrics)");
		return SoupMessageMetricsExterns.soup_message_metrics_get_tls_start(metrics);
	}


	public static SoupMessageMetrics Dereference(this SoupMessageMetricsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupMessageMetrics>(x.DangerousGetHandle());
}
internal class SoupMessageMetricsExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))]
	internal static extern MentorLake.Soup.SoupMessageMetricsHandle soup_message_metrics_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_metrics_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_connect_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_connect_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_dns_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_dns_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_fetch_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_request_body_bytes_sent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_request_body_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_request_header_bytes_sent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_request_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_response_body_bytes_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_response_body_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_response_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_response_header_bytes_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_response_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_metrics_get_tls_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))] MentorLake.Soup.SoupMessageMetricsHandle metrics);

}

/// <summary>
/// <para>
/// Contains metrics collected while loading a [class@Message] either from the
/// network or the disk cache.
/// </para>
/// <para>
/// Metrics are not collected by default for a [class@Message], you need to add the
/// flag %SOUP_MESSAGE_COLLECT_METRICS to enable the feature.
/// </para>
/// <para>
/// Temporal metrics are expressed as a monotonic time and always start with a
/// fetch start event and finish with response end. All other events are optional.
/// An event can be 0 because it hasn&apos;t happened yet, because it&apos;s optional or
/// because the load failed before the event reached.
/// </para>
/// <para>
/// Size metrics are expressed in bytes and are updated while the [class@Message] is
/// being loaded. You can connect to different [class@Message] signals to get the
/// final result of every value.
/// </para>
/// </summary>

public struct SoupMessageMetrics
{
}
