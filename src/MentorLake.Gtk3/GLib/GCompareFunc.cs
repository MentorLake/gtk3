namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GCompareFunc(IntPtr a, IntPtr b);
