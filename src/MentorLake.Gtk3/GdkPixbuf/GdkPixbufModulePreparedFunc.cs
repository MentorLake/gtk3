namespace MentorLake.GdkPixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkPixbufModulePreparedFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle anim, IntPtr user_data);
