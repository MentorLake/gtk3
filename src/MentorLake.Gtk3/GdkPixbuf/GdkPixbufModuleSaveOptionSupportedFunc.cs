namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Checks whether the given `option_key` is supported when saving.
/// </para>
/// </summary>

/// <param name="option_key">
/// the option key to check
/// </param>
/// <return>
/// `TRUE` if the option is supported
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkPixbufModuleSaveOptionSupportedFunc(string option_key);
