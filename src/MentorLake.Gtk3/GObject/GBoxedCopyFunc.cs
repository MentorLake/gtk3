namespace MentorLake.GObject;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GBoxedCopyFunc(IntPtr boxed);
