namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GThreadFunc(IntPtr data);
