namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The prototype for a task function to be run in a thread via
/// g_task_run_in_thread() or g_task_run_in_thread_sync().
/// </para>
/// <para>
/// If the return-on-cancel flag is set on @task, and @cancellable gets
/// cancelled, then the #GTask will be completed immediately (as though
/// g_task_return_error_if_cancelled() had been called), without
/// waiting for the task function to complete. However, the task
/// function will continue running in its thread in the background. The
/// function therefore needs to be careful about how it uses
/// externally-visible state in this case. See
/// g_task_set_return_on_cancel() for more details.
/// </para>
/// <para>
/// Other than in that case, @task will be completed when the
/// #GTaskThreadFunc returns, not when it calls a
/// `g_task_return_` function.
/// </para>
/// </summary>

/// <param name="task">
/// the #GTask
/// </param>
/// <param name="source_object">
/// @task&apos;s source object
/// </param>
/// <param name="task_data">
/// @task&apos;s task data
/// </param>
/// <param name="cancellable">
/// @task&apos;s #GCancellable, or %NULL
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTaskThreadFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, IntPtr task_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);
