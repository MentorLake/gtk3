namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GHFunc(IntPtr key, IntPtr value, IntPtr user_data);
