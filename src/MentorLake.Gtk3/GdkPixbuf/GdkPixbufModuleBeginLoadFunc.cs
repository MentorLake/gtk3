namespace MentorLake.GdkPixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GdkPixbufModuleBeginLoadFunc(MentorLake.GdkPixbuf.GdkPixbufModuleSizeFunc size_func, MentorLake.GdkPixbuf.GdkPixbufModulePreparedFunc prepared_func, MentorLake.GdkPixbuf.GdkPixbufModuleUpdatedFunc updated_func, IntPtr user_data);
