namespace MentorLake.cairo;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_status_t cairo_read_func_t(IntPtr closure, byte data, uint length);
