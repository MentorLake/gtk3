namespace MentorLake.Gdk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkWindowChildFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, IntPtr user_data);
