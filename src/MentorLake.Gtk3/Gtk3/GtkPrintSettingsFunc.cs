namespace MentorLake.Gtk3.Gtk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkPrintSettingsFunc(string key, string value, IntPtr user_data);
