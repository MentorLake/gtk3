namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// Function used to iterate options.
/// </para>
/// <para>
/// Not that @description string is not localized.
/// </para>
/// </summary>

/// <param name="option">
/// the option name
/// </param>
/// <param name="type">
/// the option #JSCOptionType
/// </param>
/// <param name="description">
/// the option description, or %NULL
/// </param>
/// <param name="user_data">
/// user data
/// </param>
/// <return>
/// %TRUE to stop the iteration, or %FALSE otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool JSCOptionsFunc(string option, MentorLake.JavaScriptCore.JSCOptionType type, string description, IntPtr user_data);
