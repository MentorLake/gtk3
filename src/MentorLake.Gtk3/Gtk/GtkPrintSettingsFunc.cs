namespace MentorLake.Gtk;


/// <param name="key">
/// </param>
/// <param name="value">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkPrintSettingsFunc(string key, string value, IntPtr user_data);
