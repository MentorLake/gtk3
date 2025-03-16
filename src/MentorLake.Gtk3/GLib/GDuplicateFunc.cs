namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GDuplicateFunc(IntPtr data, IntPtr user_data);
