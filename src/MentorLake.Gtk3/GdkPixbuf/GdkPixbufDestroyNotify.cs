namespace MentorLake.GdkPixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkPixbufDestroyNotify(byte[] pixels, IntPtr data);
