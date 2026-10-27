namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The prototype for a logging filter.
/// </para>
/// <para>
/// The filter callback will be invoked for each request or response, and should
/// analyze it and return a [enum@LoggerLogLevel] value indicating how much of
/// the message to log.
/// </para>
/// </summary>

/// <param name="logger">
/// the #SoupLogger
/// </param>
/// <param name="msg">
/// the message being logged
/// </param>
/// <param name="user_data">
/// the data passed to [method@Logger.set_request_filter]
///   or [method@Logger.set_response_filter]
/// </param>
/// <return>
/// a [enum@LoggerLogLevel] value indicating how much of the message to
///   log
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Soup.SoupLoggerLogLevel SoupLoggerFilter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupLoggerHandle>))] MentorLake.Soup.SoupLoggerHandle logger, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, IntPtr user_data);
