namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Type definition for a function that will be called back when an asynchronous
/// operation within GIO has been completed. #GAsyncReadyCallback
/// callbacks from #GTask are guaranteed to be invoked in a later
/// iteration of the
/// [thread-default main context][g-main-context-push-thread-default]
/// where the #GTask was created. All other users of
/// #GAsyncReadyCallback must likewise call it asynchronously in a
/// later iteration of the main context.
/// </para>
/// <para>
/// The asynchronous operation is guaranteed to have held a reference to
/// @source_object from the time when the `*_async()` function was called, until
/// after this callback returns.
/// </para>
/// </summary>

/// <param name="source_object">
/// the object the asynchronous operation was started with.
/// </param>
/// <param name="res">
/// a #GAsyncResult.
/// </param>
/// <param name="data">
/// user data passed to the callback.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GAsyncReadyCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr data);
