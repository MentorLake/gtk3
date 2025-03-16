namespace MentorLake.cairo;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_status_t cairo_write_func_t(IntPtr closure, byte data, uint length);
