namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GTestLogFatalFunc(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string message, IntPtr user_data);
