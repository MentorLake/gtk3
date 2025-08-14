namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the prototype of fatal log handler functions.
/// </para>
/// </summary>

/// <param name="log_domain">
/// the log domain of the message
/// </param>
/// <param name="log_level">
/// the log level of the message (including the fatal and recursion flags)
/// </param>
/// <param name="message">
/// the message to process
/// </param>
/// <param name="user_data">
/// user data, set in g_test_log_set_fatal_handler()
/// </param>
/// <return>
/// %TRUE if the program should abort, %FALSE otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GTestLogFatalFunc(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string message, IntPtr user_data);
