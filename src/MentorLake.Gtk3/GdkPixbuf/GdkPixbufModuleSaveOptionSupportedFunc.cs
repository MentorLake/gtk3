namespace MentorLake.GdkPixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkPixbufModuleSaveOptionSupportedFunc(string option_key);
