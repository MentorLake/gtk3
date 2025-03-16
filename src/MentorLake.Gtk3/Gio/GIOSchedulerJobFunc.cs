namespace MentorLake.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GIOSchedulerJobFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOSchedulerJobHandle>))] MentorLake.Gio.GIOSchedulerJobHandle job, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr data);
