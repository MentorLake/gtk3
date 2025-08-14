namespace MentorLake.Gio;

/// <summary>
/// <para>
/// I/O Job function.
/// </para>
/// <para>
/// Long-running jobs should periodically check the @cancellable
/// to see if they have been cancelled.
/// </para>
/// </summary>

/// <param name="job">
/// a #GIOSchedulerJob.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="data">
/// data passed to the callback function
/// </param>
/// <return>
/// %TRUE if this function should be called again to
///    complete the job, %FALSE if the job is complete (or cancelled)
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GIOSchedulerJobFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOSchedulerJobHandle>))] MentorLake.Gio.GIOSchedulerJobHandle job, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr data);
