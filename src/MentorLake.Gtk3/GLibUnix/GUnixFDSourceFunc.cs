namespace MentorLake.GLibUnix;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GUnixFDSourceFunc(int fd, MentorLake.GLib.GIOCondition condition, IntPtr user_data);
