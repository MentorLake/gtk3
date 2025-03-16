namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.GLib.GLogWriterOutput GLogWriterFunc(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data);
