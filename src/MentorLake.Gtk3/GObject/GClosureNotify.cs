namespace MentorLake.Gtk3.GObject;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GClosureNotify(IntPtr data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GClosureHandle>))] GClosureHandle closure);
