namespace MentorLake.Gio;

/// <summary>
/// <para>
/// This is the function type of the callback used for the #GSource
/// returned by g_cancellable_source_new().
/// </para>
/// </summary>

/// <param name="cancellable">
/// the #GCancellable
/// </param>
/// <param name="data">
/// data passed in by the user.
/// </param>
/// <return>
/// it should return %FALSE if the source should be removed.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GCancellableSourceFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr data);
