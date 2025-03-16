namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GCopyFunc(IntPtr src, IntPtr data);
