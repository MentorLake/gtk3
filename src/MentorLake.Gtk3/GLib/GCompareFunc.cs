namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GCompareFunc(IntPtr a, IntPtr b);
