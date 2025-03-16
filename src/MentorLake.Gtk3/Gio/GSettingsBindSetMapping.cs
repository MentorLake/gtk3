namespace MentorLake.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.GLib.GVariantHandle GSettingsBindSetMapping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle expected_type, IntPtr user_data);
