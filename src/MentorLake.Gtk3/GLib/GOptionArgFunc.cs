namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GOptionArgFunc(string option_name, string value, IntPtr data);
