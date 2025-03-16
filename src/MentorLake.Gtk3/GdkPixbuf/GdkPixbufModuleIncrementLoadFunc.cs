namespace MentorLake.GdkPixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkPixbufModuleIncrementLoadFunc(IntPtr context, byte[] buf, uint size);
