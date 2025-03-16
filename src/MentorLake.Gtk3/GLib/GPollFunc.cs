namespace MentorLake.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GPollFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle ufds, uint nfsd, int timeout_);
