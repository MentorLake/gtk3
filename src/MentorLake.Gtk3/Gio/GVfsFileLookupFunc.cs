namespace MentorLake.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gio.GFileHandle GVfsFileLookupFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVfsHandle>))] MentorLake.Gio.GVfsHandle vfs, string identifier, IntPtr user_data);
