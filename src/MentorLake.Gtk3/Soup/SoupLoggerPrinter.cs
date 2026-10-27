namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The prototype for a custom printing callback.
/// </para>
/// <para>
/// @level indicates what kind of information is being printed. Eg, it
/// will be %SOUP_LOGGER_LOG_HEADERS if @data is header data.
/// </para>
/// <para>
/// @direction is either &apos;&amp;lt;&apos;, &apos;&amp;gt;&apos;, or &apos; &apos;, and @data is the single line
/// to print; the printer is expected to add a terminating newline.
/// </para>
/// <para>
/// To get the effect of the default printer, you would do:
/// </para>
/// <para>
/// ```c
/// printf (&quot;%c %s\n&quot;, direction, data);
/// ```
/// </para>
/// </summary>

/// <param name="logger">
/// the #SoupLogger
/// </param>
/// <param name="level">
/// the level of the information being printed.
/// </param>
/// <param name="direction">
/// a single-character prefix to @data
/// </param>
/// <param name="data">
/// data to print
/// </param>
/// <param name="user_data">
/// the data passed to [method@Logger.set_printer]
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void SoupLoggerPrinter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupLoggerHandle>))] MentorLake.Soup.SoupLoggerHandle logger, MentorLake.Soup.SoupLoggerLogLevel level, char direction, string data, IntPtr user_data);
