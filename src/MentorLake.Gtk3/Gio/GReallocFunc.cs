namespace MentorLake.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GReallocFunc(IntPtr data, UIntPtr size);
