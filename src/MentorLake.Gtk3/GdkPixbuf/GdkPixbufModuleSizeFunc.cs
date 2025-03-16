namespace MentorLake.GdkPixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkPixbufModuleSizeFunc(int width, int height, IntPtr user_data);
