namespace MentorLake.Gtk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkPrintSettingsFunc(string key, string value, IntPtr user_data);
