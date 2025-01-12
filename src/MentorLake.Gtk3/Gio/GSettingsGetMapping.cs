namespace MentorLake.Gtk3.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSettingsGetMapping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVariantHandle>))] GVariantHandle value, out IntPtr result, IntPtr user_data);
