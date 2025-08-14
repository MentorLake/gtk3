namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The type of function to be passed as callback for %G_OPTION_ARG_CALLBACK
/// options.
/// </para>
/// </summary>

/// <param name="option_name">
/// The name of the option being parsed. This will be either a
///  single dash followed by a single letter (for a short name) or two dashes
///  followed by a long option name.
/// </param>
/// <param name="value">
/// The value to be parsed.
/// </param>
/// <param name="data">
/// User data added to the #GOptionGroup containing the option when it
///  was created with g_option_group_new()
/// </param>
/// <return>
/// %TRUE if the option was successfully parsed, %FALSE if an error
///  occurred, in which case @error should be set with g_set_error()
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GOptionArgFunc(string option_name, string value, IntPtr data);
