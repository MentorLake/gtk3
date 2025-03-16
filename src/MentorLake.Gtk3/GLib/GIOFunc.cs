namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GIOFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle source, MentorLake.GLib.GIOCondition condition, IntPtr data);
