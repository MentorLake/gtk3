namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GEqualFunc(IntPtr a, IntPtr b);
