namespace MentorLake.GdkPixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkPixbufModuleStopLoadFunc(IntPtr context);
