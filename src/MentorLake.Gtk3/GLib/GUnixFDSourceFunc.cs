namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GUnixFDSourceFunc(int fd, GIOCondition condition, IntPtr user_data);
