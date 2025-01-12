namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GCompareDataFunc(IntPtr a, IntPtr b, IntPtr user_data);
