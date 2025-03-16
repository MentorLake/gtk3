namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GCacheNewFunc(IntPtr key);
