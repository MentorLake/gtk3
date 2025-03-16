namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GTranslateFunc(string str, IntPtr data);
