namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GLogWriterOutput GLogWriterFunc(GLogLevelFlags log_level, GLogField[] fields, UIntPtr n_fields, IntPtr user_data);
