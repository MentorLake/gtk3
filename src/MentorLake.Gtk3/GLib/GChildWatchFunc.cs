namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GChildWatchFunc(GPid pid, int wait_status, IntPtr user_data);
