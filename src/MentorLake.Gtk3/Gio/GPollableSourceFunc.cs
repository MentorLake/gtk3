namespace MentorLake.Gtk3.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GPollableSourceFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle pollable_stream, IntPtr data);
