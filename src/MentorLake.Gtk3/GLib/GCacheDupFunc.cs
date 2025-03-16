namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GCacheDupFunc(IntPtr value);
