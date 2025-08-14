namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the prototype of log handler functions.
/// </para>
/// <para>
/// The default log handler, [func@GLib.log_default_handler], automatically appends a
/// new-line character to @message when printing it. It is advised that any
/// custom log handler functions behave similarly, so that logging calls in user
/// code do not need modifying to add a new-line character to the message if the
/// log handler is changed.
/// </para>
/// <para>
/// The `log_domain` parameter can be set to `NULL` or an empty string to use the default
/// application domain.
/// </para>
/// <para>
/// This is not used if structured logging is enabled; see
/// [Using Structured Logging](logging.html#using-structured-logging).
/// </para>
/// </summary>

/// <param name="log_domain">
/// the log domain of the message
/// </param>
/// <param name="log_level">
/// the log level of the message (including the
///   fatal and recursion flags)
/// </param>
/// <param name="message">
/// the message to process
/// </param>
/// <param name="user_data">
/// user data, set in [func@GLib.log_set_handler]
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GLogFunc(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string message, IntPtr user_data);
