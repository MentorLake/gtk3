namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GHRFunc(IntPtr key, IntPtr value, IntPtr user_data);
