namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GTraverseFunc(IntPtr key, IntPtr value, IntPtr data);
