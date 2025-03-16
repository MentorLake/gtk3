namespace MentorLake.GdkPixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkPixbufModuleUpdatedFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, int x, int y, int width, int height, IntPtr user_data);
