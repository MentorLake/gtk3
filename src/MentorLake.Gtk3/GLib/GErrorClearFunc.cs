namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GErrorClearFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GErrorHandle>))] GErrorHandle error);
