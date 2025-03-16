namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GErrorClearFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);
