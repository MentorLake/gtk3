namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GChildWatchFunc(MentorLake.GLib.GPid pid, int wait_status, IntPtr user_data);
