namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDataForeachFunc(MentorLake.GLib.GQuark key_id, IntPtr data, IntPtr user_data);
