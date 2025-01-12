namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GLogFunc(string log_domain, GLogLevelFlags log_level, string message, IntPtr user_data);
