namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Debug logging support
/// </para>
/// <para>
/// [class@Logger] watches a [class@Session] and logs the HTTP traffic that
/// it generates, for debugging purposes. Many applications use an
/// environment variable to determine whether or not to use
/// [class@Logger], and to determine the amount of debugging output.
/// </para>
/// <para>
/// To use [class@Logger], first create a logger with [ctor@Logger.new], optionally
/// configure it with [method@Logger.set_request_filter],
/// [method@Logger.set_response_filter], and [method@Logger.set_printer], and
/// then attach it to a session (or multiple sessions) with
/// [method@Session.add_feature].
/// </para>
/// <para>
/// By default, the debugging output is sent to `stdout`, and looks something
/// like:
/// </para>
/// <para>
/// ```
/// &amp;gt; POST /unauth HTTP/1.1
/// &amp;gt; Soup-Debug-Timestamp: 1200171744
/// &amp;gt; Soup-Debug: SoupSession 1 (0x612190), SoupMessage 1 (0x617000), GSocket 1 (0x612220)
/// &amp;gt; Host: localhost
/// &amp;gt; Content-Type: text/plain
/// &amp;gt; Connection: close
/// </para>
/// <para>
/// &amp;lt; HTTP/1.1 201 Created
/// &amp;lt; Soup-Debug-Timestamp: 1200171744
/// &amp;lt; Soup-Debug: SoupMessage 1 (0x617000)
/// &amp;lt; Date: Sun, 12 Jan 2008 21:02:24 GMT
/// &amp;lt; Content-Length: 0
/// ```
/// </para>
/// <para>
/// The `Soup-Debug-Timestamp` line gives the time (as a `time_t`) when the
/// request was sent, or the response fully received.
/// </para>
/// <para>
/// The `Soup-Debug` line gives further debugging information about the
/// [class@Session], [class@Message], and [class@Gio.Socket] involved; the hex
/// numbers are the addresses of the objects in question (which may be useful if
/// you are running in a debugger). The decimal IDs are simply counters that
/// uniquely identify objects across the lifetime of the [class@Logger]. In
/// particular, this can be used to identify when multiple messages are sent
/// across the same connection.
/// </para>
/// <para>
/// Currently, the request half of the message is logged just before
/// the first byte of the request gets written to the network (from the
/// [signal@Message::starting] signal).
/// </para>
/// <para>
/// The response is logged just after the last byte of the response body is read
/// from the network (from the [signal@Message::got-body] or
/// [signal@Message::got-informational] signal), which means that the
/// [signal@Message::got-headers] signal, and anything triggered off it (such as
/// [signal@Message::authenticate]) will be emitted *before* the response headers are
/// actually logged.
/// </para>
/// <para>
/// If the response doesn&apos;t happen to trigger the [signal@Message::got-body] nor
/// [signal@Message::got-informational] signals due to, for example, a
/// cancellation before receiving the last byte of the response body, the
/// response will still be logged on the event of the [signal@Message::finished]
/// signal.
/// </para>
/// </summary>

public class SoupLoggerHandle : GObjectHandle, SoupSessionFeatureHandle
{
/// <summary>
/// <para>
/// Creates a new [class@Logger] with the given debug level.
/// </para>
/// <para>
/// If you need finer control over what message parts are and aren&apos;t
/// logged, use [method@Logger.set_request_filter] and
/// [method@Logger.set_response_filter].
/// </para>
/// </summary>

/// <param name="level">
/// the debug level
/// </param>
/// <return>
/// a new #SoupLogger
/// </return>

	public static MentorLake.Soup.SoupLoggerHandle New(MentorLake.Soup.SoupLoggerLogLevel level)
	{
		return SoupLoggerHandleExterns.soup_logger_new(level);
	}

}

public static class SoupLoggerHandleExtensions
{
/// <summary>
/// <para>
/// Get the maximum body size for @logger.
/// </para>
/// </summary>

/// <param name="logger">
/// a #SoupLogger
/// </param>
/// <return>
/// the maximum body size, or -1 if unlimited
/// </return>

	public static int GetMaxBodySize(this MentorLake.Soup.SoupLoggerHandle logger)
	{
		if (logger.IsInvalid) throw new Exception("Invalid handle (SoupLoggerHandle)");
		return SoupLoggerHandleExterns.soup_logger_get_max_body_size(logger);
	}

/// <summary>
/// <para>
/// Sets the maximum body size for @logger (-1 means no limit).
/// </para>
/// </summary>

/// <param name="logger">
/// a #SoupLogger
/// </param>
/// <param name="max_body_size">
/// the maximum body size to log
/// </param>

	public static T SetMaxBodySize<T>(this T logger, int max_body_size) where T : SoupLoggerHandle
	{
		if (logger.IsInvalid) throw new Exception("Invalid handle (SoupLoggerHandle)");
		SoupLoggerHandleExterns.soup_logger_set_max_body_size(logger, max_body_size);
		return logger;
	}

/// <summary>
/// <para>
/// Sets up an alternate log printing routine, if you don&apos;t want
/// the log to go to `stdout`.
/// </para>
/// </summary>

/// <param name="logger">
/// a #SoupLogger
/// </param>
/// <param name="printer">
/// the callback for printing logging output
/// </param>
/// <param name="printer_data">
/// data to pass to the callback
/// </param>
/// <param name="destroy">
/// a #GDestroyNotify to free @printer_data
/// </param>

	public static T SetPrinter<T>(this T logger, MentorLake.Soup.SoupLoggerPrinter printer, IntPtr printer_data, MentorLake.GLib.GDestroyNotify destroy) where T : SoupLoggerHandle
	{
		if (logger.IsInvalid) throw new Exception("Invalid handle (SoupLoggerHandle)");
		SoupLoggerHandleExterns.soup_logger_set_printer(logger, printer, printer_data, destroy);
		return logger;
	}

/// <summary>
/// <para>
/// Sets up a filter to determine the log level for a given request.
/// </para>
/// <para>
/// For each HTTP request @logger will invoke @request_filter to
/// determine how much (if any) of that request to log. (If you do not
/// set a request filter, @logger will just always log requests at the
/// level passed to [ctor@Logger.new].)
/// </para>
/// </summary>

/// <param name="logger">
/// a #SoupLogger
/// </param>
/// <param name="request_filter">
/// the callback for request debugging
/// </param>
/// <param name="filter_data">
/// data to pass to the callback
/// </param>
/// <param name="destroy">
/// a #GDestroyNotify to free @filter_data
/// </param>

	public static T SetRequestFilter<T>(this T logger, MentorLake.Soup.SoupLoggerFilter request_filter, IntPtr filter_data, MentorLake.GLib.GDestroyNotify destroy) where T : SoupLoggerHandle
	{
		if (logger.IsInvalid) throw new Exception("Invalid handle (SoupLoggerHandle)");
		SoupLoggerHandleExterns.soup_logger_set_request_filter(logger, request_filter, filter_data, destroy);
		return logger;
	}

/// <summary>
/// <para>
/// Sets up a filter to determine the log level for a given response.
/// </para>
/// <para>
/// For each HTTP response @logger will invoke @response_filter to
/// determine how much (if any) of that response to log. (If you do not
/// set a response filter, @logger will just always log responses at
/// the level passed to [ctor@Logger.new].)
/// </para>
/// </summary>

/// <param name="logger">
/// a #SoupLogger
/// </param>
/// <param name="response_filter">
/// the callback for response debugging
/// </param>
/// <param name="filter_data">
/// data to pass to the callback
/// </param>
/// <param name="destroy">
/// a #GDestroyNotify to free @filter_data
/// </param>

	public static T SetResponseFilter<T>(this T logger, MentorLake.Soup.SoupLoggerFilter response_filter, IntPtr filter_data, MentorLake.GLib.GDestroyNotify destroy) where T : SoupLoggerHandle
	{
		if (logger.IsInvalid) throw new Exception("Invalid handle (SoupLoggerHandle)");
		SoupLoggerHandleExterns.soup_logger_set_response_filter(logger, response_filter, filter_data, destroy);
		return logger;
	}

}

internal class SoupLoggerHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupLoggerHandle>))]
	internal static extern MentorLake.Soup.SoupLoggerHandle soup_logger_new(MentorLake.Soup.SoupLoggerLogLevel level);

	[DllImport(SoupLibrary.Name)]
	internal static extern int soup_logger_get_max_body_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupLoggerHandle>))] MentorLake.Soup.SoupLoggerHandle logger);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_logger_set_max_body_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupLoggerHandle>))] MentorLake.Soup.SoupLoggerHandle logger, int max_body_size);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_logger_set_printer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupLoggerHandle>))] MentorLake.Soup.SoupLoggerHandle logger, MentorLake.Soup.SoupLoggerPrinter printer, IntPtr printer_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_logger_set_request_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupLoggerHandle>))] MentorLake.Soup.SoupLoggerHandle logger, MentorLake.Soup.SoupLoggerFilter request_filter, IntPtr filter_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_logger_set_response_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupLoggerHandle>))] MentorLake.Soup.SoupLoggerHandle logger, MentorLake.Soup.SoupLoggerFilter response_filter, IntPtr filter_data, MentorLake.GLib.GDestroyNotify destroy);

}
