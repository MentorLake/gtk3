namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GAsyncResult` provides a base class for implementing asynchronous function results.
/// </para>
/// <para>
/// Asynchronous operations are broken up into two separate operations
/// which are chained together by a `GAsyncReadyCallback`. To begin
/// an asynchronous operation, provide a `GAsyncReadyCallback` to the
/// asynchronous function. This callback will be triggered when the
/// operation has completed, and must be run in a later iteration of
/// the thread-default main context (see
/// [method@GLib.MainContext.push_thread_default]) from where the operation was
/// initiated. It will be passed a `GAsyncResult` instance filled with the
/// details of the operation's success or failure, the object the asynchronous
/// function was started for and any error codes returned. The asynchronous
/// callback function is then expected to call the corresponding `_finish()`
/// function, passing the object the function was called for, the
/// `GAsyncResult` instance, and (optionally) an @error to grab any
/// error conditions that may have occurred.
/// </para>
/// <para>
/// The `_finish()` function for an operation takes the generic result
/// (of type `GAsyncResult`) and returns the specific result that the
/// operation in question yields (e.g. a [class@Gio.FileEnumerator] for a
/// "enumerate children" operation). If the result or error status of the
/// operation is not needed, there is no need to call the `_finish()`
/// function; GIO will take care of cleaning up the result and error
/// information after the `GAsyncReadyCallback` returns. You can pass
/// `NULL` for the `GAsyncReadyCallback` if you don't need to take any
/// action at all after the operation completes. Applications may also
/// take a reference to the `GAsyncResult` and call `_finish()` later;
/// however, the `_finish()` function may be called at most once.
/// </para>
/// <para>
/// Example of a typical asynchronous operation flow:
/// </para>
/// <para>
/// ```c
/// void _theoretical_frobnitz_async (Theoretical         *t,
///                                   GCancellable        *c,
///                                   GAsyncReadyCallback  cb,
///                                   gpointer             u);
/// </para>
/// <para>
/// gboolean _theoretical_frobnitz_finish (Theoretical   *t,
///                                        GAsyncResult  *res,
///                                        GError       **e);
/// </para>
/// <para>
/// static void
/// frobnitz_result_func (GObject      *source_object,
/// 		 GAsyncResult *res,
/// 		 gpointer      user_data)
/// {
///   gboolean success = FALSE;
/// </para>
/// <para>
///   success = _theoretical_frobnitz_finish (source_object, res, NULL);
/// </para>
/// <para>
///   if (success)
///     g_printf ("Hurray!\n");
///   else
///     g_printf ("Uh oh!\n");
/// </para>
/// <para>
///   ...
/// </para>
/// <para>
/// }
/// </para>
/// <para>
/// int main (int argc, void *argv[])
/// {
///    ...
/// </para>
/// <para>
///    _theoretical_frobnitz_async (theoretical_data,
///                                 NULL,
///                                 frobnitz_result_func,
///                                 NULL);
/// </para>
/// <para>
///    ...
/// }
/// ```
/// </para>
/// <para>
/// The callback for an asynchronous operation is called only once, and is
/// always called, even in the case of a cancelled operation. On cancellation
/// the result is a `G_IO_ERROR_CANCELLED` error.
/// </para>
/// <para>
/// ## I/O Priority
/// </para>
/// <para>
/// Many I/O-related asynchronous operations have a priority parameter,
/// which is used in certain cases to determine the order in which
/// operations are executed. They are not used to determine system-wide
/// I/O scheduling. Priorities are integers, with lower numbers indicating
/// higher priority. It is recommended to choose priorities between
/// `G_PRIORITY_LOW` and `G_PRIORITY_HIGH`, with `G_PRIORITY_DEFAULT`
/// as a default.
/// </para>
/// </summary>

public interface GAsyncResultHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GAsyncResultHandleImpl : BaseSafeHandle, GAsyncResultHandle
{
}

public static class GAsyncResultHandleExtensions
{
/// <summary>
/// <para>
/// Gets the source object from a [iface@Gio.AsyncResult].
/// </para>
/// </summary>

/// <param name="res">
/// a [iface@Gio.AsyncResult]
/// </param>
/// <return>
/// a new reference to the source
///    object for the @res, or `NULL` if there is none.
/// </return>

	public static MentorLake.GObject.GObjectHandle GetSourceObject(this MentorLake.Gio.GAsyncResultHandle res)
	{
		if (res.IsInvalid) throw new Exception("Invalid handle (GAsyncResultHandle)");
		return GAsyncResultHandleExterns.g_async_result_get_source_object(res);
	}

/// <summary>
/// <para>
/// Gets the user data from a [iface@Gio.AsyncResult].
/// </para>
/// </summary>

/// <param name="res">
/// a [iface@Gio.AsyncResult].
/// </param>
/// <return>
/// the user data for @res.
/// </return>

	public static IntPtr GetUserData(this MentorLake.Gio.GAsyncResultHandle res)
	{
		if (res.IsInvalid) throw new Exception("Invalid handle (GAsyncResultHandle)");
		return GAsyncResultHandleExterns.g_async_result_get_user_data(res);
	}

/// <summary>
/// <para>
/// Checks if @res has the given @source_tag (generally a function
/// pointer indicating the function @res was created by).
/// </para>
/// </summary>

/// <param name="res">
/// a [iface@Gio.AsyncResult]
/// </param>
/// <param name="source_tag">
/// an application-defined tag
/// </param>
/// <return>
/// `TRUE` if @res has the indicated @source_tag, `FALSE` if
///   not.
/// </return>

	public static bool IsTagged(this MentorLake.Gio.GAsyncResultHandle res, IntPtr source_tag)
	{
		if (res.IsInvalid) throw new Exception("Invalid handle (GAsyncResultHandle)");
		return GAsyncResultHandleExterns.g_async_result_is_tagged(res, source_tag);
	}

/// <summary>
/// <para>
/// If @res is a [class@Gio.SimpleAsyncResult], this is equivalent to
/// [method@Gio.SimpleAsyncResult.propagate_error]. Otherwise it returns
/// `FALSE`.
/// </para>
/// <para>
/// This can be used for legacy error handling in async `*_finish()`
/// wrapper functions that traditionally handled [class@Gio.SimpleAsyncResult]
/// error returns themselves rather than calling into the virtual method.
/// This should not be used in new code; [iface@Gio.AsyncResult] errors that are
/// set by virtual methods should also be extracted by virtual methods,
/// to enable subclasses to chain up correctly.
/// </para>
/// </summary>

/// <param name="res">
/// a [iface@Gio.AsyncResult]
/// </param>
/// <return>
/// `TRUE` if @error is has been filled in with an error from
///   @res, `FALSE` if not.
/// </return>

	public static bool LegacyPropagateError(this MentorLake.Gio.GAsyncResultHandle res)
	{
		if (res.IsInvalid) throw new Exception("Invalid handle (GAsyncResultHandle)");
		var externCallResult = GAsyncResultHandleExterns.g_async_result_legacy_propagate_error(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GAsyncResultHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_async_result_get_source_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_async_result_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_async_result_is_tagged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr source_tag);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_async_result_legacy_propagate_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

}
