namespace MentorLake.Gtk3.GObject;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GObjectFinalizeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle @object);
