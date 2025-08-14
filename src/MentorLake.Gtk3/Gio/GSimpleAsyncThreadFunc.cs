namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Simple thread function that runs an asynchronous operation and
/// checks for cancellation.
/// </para>
/// </summary>

/// <param name="res">
/// a #GSimpleAsyncResult.
/// </param>
/// <param name="@object">
/// a #GObject.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GSimpleAsyncThreadFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle res, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);
