namespace MentorLake.Atk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool AtkFunction(IntPtr user_data);
