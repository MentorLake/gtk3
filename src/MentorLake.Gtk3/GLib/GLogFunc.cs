namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GLogFunc(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string message, IntPtr user_data);
