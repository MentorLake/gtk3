namespace MentorLake.Gio;

/// <summary>
/// <para>
/// As of GLib 2.46, `GSimpleAsyncResult` is deprecated in favor of
/// [class@Gio.Task], which provides a simpler API.
/// </para>
/// <para>
/// `GSimpleAsyncResult` implements [iface@Gio.AsyncResult].
/// </para>
/// <para>
/// `GSimpleAsyncResult` handles [type@Gio.AsyncReadyCallback]s, error
/// reporting, operation cancellation and the final state of an operation,
/// completely transparent to the application. Results can be returned
/// as a pointer e.g. for functions that return data that is collected
/// asynchronously, a boolean value for checking the success or failure
/// of an operation, or a `gssize` for operations which return the number
/// of bytes modified by the operation; all of the simple return cases
/// are covered.
/// </para>
/// <para>
/// Most of the time, an application will not need to know of the details
/// of this API; it is handled transparently, and any necessary operations
/// are handled by [iface@Gio.AsyncResult]’s interface. However, if implementing
/// a new GIO module, for writing language bindings, or for complex
/// applications that need better control of how asynchronous operations
/// are completed, it is important to understand this functionality.
/// </para>
/// <para>
/// `GSimpleAsyncResult`s are tagged with the calling function to ensure
/// that asynchronous functions and their finishing functions are used
/// together correctly.
/// </para>
/// <para>
/// To create a new `GSimpleAsyncResult`, call [ctor@Gio.SimpleAsyncResult.new].
/// If the result needs to be created for a `GError`, use
/// [ctor@Gio.SimpleAsyncResult.new_from_error] or
/// [ctor@Gio.SimpleAsyncResult.new_take_error]. If a `GError` is not available
/// (e.g. the asynchronous operation doesn’t take a `GError` argument),
/// but the result still needs to be created for an error condition, use
/// [ctor@Gio.SimpleAsyncResult.new_error] (or
/// [method@Gio.SimpleAsyncResult.set_error_va] if your application or binding
/// requires passing a variable argument list directly), and the error can then
/// be propagated through the use of
/// [method@Gio.SimpleAsyncResult.propagate_error].
/// </para>
/// <para>
/// An asynchronous operation can be made to ignore a cancellation event by
/// calling [method@Gio.SimpleAsyncResult.set_handle_cancellation] with a
/// `GSimpleAsyncResult` for the operation and `FALSE`. This is useful for
/// operations that are dangerous to cancel, such as close (which would
/// cause a leak if cancelled before being run).
/// </para>
/// <para>
/// `GSimpleAsyncResult` can integrate into GLib’s event loop,
/// [type@GLib.MainLoop], or it can use [type@GLib.Thread]s.
/// [method@Gio.SimpleAsyncResult.complete] will finish an I/O task directly
/// from the point where it is called.
/// [method@Gio.SimpleAsyncResult.complete_in_idle] will finish it from an idle
/// handler in the  thread-default main context (see
/// [method@GLib.MainContext.push_thread_default]) where the `GSimpleAsyncResult`
/// was created. [method@Gio.SimpleAsyncResult.run_in_thread] will run the job in
/// a separate thread and then use
/// [method@Gio.SimpleAsyncResult.complete_in_idle] to deliver the result.
/// </para>
/// <para>
/// To set the results of an asynchronous function,
/// [method@Gio.SimpleAsyncResult.set_op_res_gpointer],
/// [method@Gio.SimpleAsyncResult.set_op_res_gboolean], and
/// [method@Gio.SimpleAsyncResult.set_op_res_gssize]
/// are provided, setting the operation's result to a `gpointer`, `gboolean`, or
/// `gssize`, respectively.
/// </para>
/// <para>
/// Likewise, to get the result of an asynchronous function,
/// [method@Gio.SimpleAsyncResult.get_op_res_gpointer],
/// [method@Gio.SimpleAsyncResult.get_op_res_gboolean], and
/// [method@Gio.SimpleAsyncResult.get_op_res_gssize] are
/// provided, getting the operation’s result as a `gpointer`, `gboolean`, and
/// `gssize`, respectively.
/// </para>
/// <para>
/// For the details of the requirements implementations must respect, see
/// [iface@Gio.AsyncResult].  A typical implementation of an asynchronous
/// operation using `GSimpleAsyncResult` looks something like this:
/// </para>
/// <para>
/// ```c
/// static void
/// baked_cb (Cake    *cake,
///           gpointer user_data)
/// {
///   // In this example, this callback is not given a reference to the cake,
///   // so the GSimpleAsyncResult has to take a reference to it.
///   GSimpleAsyncResult *result = user_data;
/// </para>
/// <para>
///   if (cake == NULL)
///     g_simple_async_result_set_error (result,
///                                      BAKER_ERRORS,
///                                      BAKER_ERROR_NO_FLOUR,
///                                      "Go to the supermarket");
///   else
///     g_simple_async_result_set_op_res_gpointer (result,
///                                                g_object_ref (cake),
///                                                g_object_unref);
/// </para>
/// <para>
/// </para>
/// <para>
///   // In this example, we assume that baked_cb is called as a callback from
///   // the mainloop, so it's safe to complete the operation synchronously here.
///   // If, however, _baker_prepare_cake () might call its callback without
///   // first returning to the mainloop — inadvisable, but some APIs do so —
///   // we would need to use g_simple_async_result_complete_in_idle().
///   g_simple_async_result_complete (result);
///   g_object_unref (result);
/// }
/// </para>
/// <para>
/// void
/// baker_bake_cake_async (Baker              *self,
///                        guint               radius,
///                        GAsyncReadyCallback callback,
///                        gpointer            user_data)
/// {
///   GSimpleAsyncResult *simple;
///   Cake               *cake;
/// </para>
/// <para>
///   if (radius < 3)
///     {
///       g_simple_async_report_error_in_idle (G_OBJECT (self),
///                                            callback,
///                                            user_data,
///                                            BAKER_ERRORS,
///                                            BAKER_ERROR_TOO_SMALL,
///                                            "%ucm radius cakes are silly",
///                                            radius);
///       return;
///     }
/// </para>
/// <para>
///   simple = g_simple_async_result_new (G_OBJECT (self),
///                                       callback,
///                                       user_data,
///                                       baker_bake_cake_async);
///   cake = _baker_get_cached_cake (self, radius);
/// </para>
/// <para>
///   if (cake != NULL)
///     {
///       g_simple_async_result_set_op_res_gpointer (simple,
///                                                  g_object_ref (cake),
///                                                  g_object_unref);
///       g_simple_async_result_complete_in_idle (simple);
///       g_object_unref (simple);
///       // Drop the reference returned by _baker_get_cached_cake();
///       // the GSimpleAsyncResult has taken its own reference.
///       g_object_unref (cake);
///       return;
///     }
/// </para>
/// <para>
///   _baker_prepare_cake (self, radius, baked_cb, simple);
/// }
/// </para>
/// <para>
/// Cake *
/// baker_bake_cake_finish (Baker        *self,
///                         GAsyncResult *result,
///                         GError      **error)
/// {
///   GSimpleAsyncResult *simple;
///   Cake               *cake;
/// </para>
/// <para>
///   g_return_val_if_fail (g_simple_async_result_is_valid (result,
///                                                         G_OBJECT (self),
///                                                         baker_bake_cake_async),
///                         NULL);
/// </para>
/// <para>
///   simple = (GSimpleAsyncResult *) result;
/// </para>
/// <para>
///   if (g_simple_async_result_propagate_error (simple, error))
///     return NULL;
/// </para>
/// <para>
///   cake = CAKE (g_simple_async_result_get_op_res_gpointer (simple));
///   return g_object_ref (cake);
/// }
/// ```
/// </para>
/// </summary>

public class GSimpleAsyncResultHandle : GObjectHandle, GAsyncResultHandle
{
/// <summary>
/// <para>
/// Creates a #GSimpleAsyncResult.
/// </para>
/// <para>
/// The common convention is to create the #GSimpleAsyncResult in the
/// function that starts the asynchronous operation and use that same
/// function as the @source_tag.
/// </para>
/// <para>
/// If your operation supports cancellation with #GCancellable (which it
/// probably should) then you should provide the user's cancellable to
/// g_simple_async_result_set_check_cancellable() immediately after
/// this function returns.
/// </para>
/// </summary>

/// <param name="source_object">
/// a #GObject, or %NULL.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback.
/// </param>
/// <param name="user_data">
/// user data passed to @callback.
/// </param>
/// <param name="source_tag">
/// the asynchronous function.
/// </param>
/// <return>
/// a #GSimpleAsyncResult.
/// </return>

	public static MentorLake.Gio.GSimpleAsyncResultHandle New(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, IntPtr source_tag)
	{
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_new(source_object, callback, user_data, source_tag);
	}

/// <summary>
/// <para>
/// Creates a new #GSimpleAsyncResult with a set error.
/// </para>
/// </summary>

/// <param name="source_object">
/// a #GObject, or %NULL.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback.
/// </param>
/// <param name="user_data">
/// user data passed to @callback.
/// </param>
/// <param name="domain">
/// a #GQuark.
/// </param>
/// <param name="code">
/// an error code.
/// </param>
/// <param name="format">
/// a string with format characters.
/// </param>
/// <param name="@__arglist">
/// a list of values to insert into @format.
/// </param>
/// <return>
/// a #GSimpleAsyncResult.
/// </return>

	public static MentorLake.Gio.GSimpleAsyncResultHandle NewError(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist)
	{
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_new_error(source_object, callback, user_data, domain, code, format, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a #GSimpleAsyncResult from an error condition.
/// </para>
/// </summary>

/// <param name="source_object">
/// a #GObject, or %NULL.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback.
/// </param>
/// <param name="user_data">
/// user data passed to @callback.
/// </param>
/// <param name="error">
/// a #GError
/// </param>
/// <return>
/// a #GSimpleAsyncResult.
/// </return>

	public static MentorLake.Gio.GSimpleAsyncResultHandle NewFromError(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GErrorHandle error)
	{
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_new_from_error(source_object, callback, user_data, error);
	}

/// <summary>
/// <para>
/// Creates a #GSimpleAsyncResult from an error condition, and takes over the
/// caller's ownership of @error, so the caller does not need to free it anymore.
/// </para>
/// </summary>

/// <param name="source_object">
/// a #GObject, or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback.
/// </param>
/// <param name="user_data">
/// user data passed to @callback.
/// </param>
/// <param name="error">
/// a #GError
/// </param>
/// <return>
/// a #GSimpleAsyncResult
/// </return>

	public static MentorLake.Gio.GSimpleAsyncResultHandle NewTakeError(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GErrorHandle error)
	{
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_new_take_error(source_object, callback, user_data, error);
	}

/// <summary>
/// <para>
/// Ensures that the data passed to the _finish function of an async
/// operation is consistent.  Three checks are performed.
/// </para>
/// <para>
/// First, @result is checked to ensure that it is really a
/// #GSimpleAsyncResult.  Second, @source is checked to ensure that it
/// matches the source object of @result.  Third, @source_tag is
/// checked to ensure that it is equal to the @source_tag argument given
/// to g_simple_async_result_new() (which, by convention, is a pointer
/// to the _async function corresponding to the _finish function from
/// which this function is called).  (Alternatively, if either
/// @source_tag or @result's source tag is %NULL, then the source tag
/// check is skipped.)
/// </para>
/// </summary>

/// <param name="result">
/// the #GAsyncResult passed to the _finish function.
/// </param>
/// <param name="source">
/// the #GObject passed to the _finish function.
/// </param>
/// <param name="source_tag">
/// the asynchronous function.
/// </param>
/// <return>
/// #TRUE if all checks passed or #FALSE if any failed.
/// </return>

	public static bool IsValid(MentorLake.Gio.GAsyncResultHandle result, MentorLake.GObject.GObjectHandle source, IntPtr source_tag)
	{
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_is_valid(result, source, source_tag);
	}

}

public static class GSimpleAsyncResultHandleExtensions
{
/// <summary>
/// <para>
/// Completes an asynchronous I/O job immediately. Must be called in
/// the thread where the asynchronous result was to be delivered, as it
/// invokes the callback directly. If you are in a different thread use
/// g_simple_async_result_complete_in_idle().
/// </para>
/// <para>
/// Calling this function takes a reference to @simple for as long as
/// is needed to complete the call.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>

	public static T Complete<T>(this T simple) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_complete(simple);
		return simple;
	}

/// <summary>
/// <para>
/// Completes an asynchronous function in an idle handler in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread that @simple was initially created in
/// (and re-pushes that context around the invocation of the callback).
/// </para>
/// <para>
/// Calling this function takes a reference to @simple for as long as
/// is needed to complete the call.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>

	public static T CompleteInIdle<T>(this T simple) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_complete_in_idle(simple);
		return simple;
	}

/// <summary>
/// <para>
/// Gets the operation result boolean from within the asynchronous result.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <return>
/// %TRUE if the operation's result was %TRUE, %FALSE
///     if the operation's result was %FALSE.
/// </return>

	public static bool GetOpResGboolean(this MentorLake.Gio.GSimpleAsyncResultHandle simple)
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_get_op_res_gboolean(simple);
	}

/// <summary>
/// <para>
/// Gets a pointer result as returned by the asynchronous function.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <return>
/// a pointer from the result.
/// </return>

	public static IntPtr GetOpResGpointer(this MentorLake.Gio.GSimpleAsyncResultHandle simple)
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_get_op_res_gpointer(simple);
	}

/// <summary>
/// <para>
/// Gets a gssize from the asynchronous result.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <return>
/// a gssize returned from the asynchronous function.
/// </return>

	public static UIntPtr GetOpResGssize(this MentorLake.Gio.GSimpleAsyncResultHandle simple)
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_get_op_res_gssize(simple);
	}

/// <summary>
/// <para>
/// Gets the source tag for the #GSimpleAsyncResult.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <return>
/// a #gpointer to the source object for the #GSimpleAsyncResult.
/// </return>

	public static IntPtr GetSourceTag(this MentorLake.Gio.GSimpleAsyncResultHandle simple)
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_get_source_tag(simple);
	}

/// <summary>
/// <para>
/// Propagates an error from within the simple asynchronous result to
/// a given destination.
/// </para>
/// <para>
/// If the #GCancellable given to a prior call to
/// g_simple_async_result_set_check_cancellable() is cancelled then this
/// function will return %TRUE with @dest set appropriately.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <return>
/// %TRUE if the error was propagated to @dest. %FALSE otherwise.
/// </return>

	public static bool PropagateError(this MentorLake.Gio.GSimpleAsyncResultHandle simple)
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		var externCallResult = GSimpleAsyncResultHandleExterns.g_simple_async_result_propagate_error(simple, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Runs the asynchronous job in a separate thread and then calls
/// g_simple_async_result_complete_in_idle() on @simple to return
/// the result to the appropriate main loop.
/// </para>
/// <para>
/// Calling this function takes a reference to @simple for as long as
/// is needed to run the job and report its completion.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <param name="func">
/// a #GSimpleAsyncThreadFunc.
/// </param>
/// <param name="io_priority">
/// the io priority of the request.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>

	public static T RunInThread<T>(this T simple, MentorLake.Gio.GSimpleAsyncThreadFunc func, int io_priority, MentorLake.Gio.GCancellableHandle cancellable) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_run_in_thread(simple, func, io_priority, cancellable);
		return simple;
	}

/// <summary>
/// <para>
/// Sets a #GCancellable to check before dispatching results.
/// </para>
/// <para>
/// This function has one very specific purpose: the provided cancellable
/// is checked at the time of g_simple_async_result_propagate_error() If
/// it is cancelled, these functions will return an "Operation was
/// cancelled" error (%G_IO_ERROR_CANCELLED).
/// </para>
/// <para>
/// Implementors of cancellable asynchronous functions should use this in
/// order to provide a guarantee to their callers that cancelling an
/// async operation will reliably result in an error being returned for
/// that operation (even if a positive result for the operation has
/// already been sent as an idle to the main context to be dispatched).
/// </para>
/// <para>
/// The checking described above is done regardless of any call to the
/// unrelated g_simple_async_result_set_handle_cancellation() function.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult
/// </param>
/// <param name="check_cancellable">
/// a #GCancellable to check, or %NULL to unset
/// </param>

	public static T SetCheckCancellable<T>(this T simple, MentorLake.Gio.GCancellableHandle check_cancellable) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_check_cancellable(simple, check_cancellable);
		return simple;
	}

/// <summary>
/// <para>
/// Sets an error within the asynchronous result without a #GError.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <param name="domain">
/// a #GQuark (usually %G_IO_ERROR).
/// </param>
/// <param name="code">
/// an error code.
/// </param>
/// <param name="format">
/// a formatted error reporting string.
/// </param>
/// <param name="@__arglist">
/// a list of variables to fill in @format.
/// </param>

	public static T SetError<T>(this T simple, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_error(simple, domain, code, format, @__arglist);
		return simple;
	}

/// <summary>
/// <para>
/// Sets an error within the asynchronous result without a #GError.
/// Unless writing a binding, see g_simple_async_result_set_error().
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <param name="domain">
/// a #GQuark (usually %G_IO_ERROR).
/// </param>
/// <param name="code">
/// an error code.
/// </param>
/// <param name="format">
/// a formatted error reporting string.
/// </param>
/// <param name="args">
/// va_list of arguments.
/// </param>

	public static T SetErrorVa<T>(this T simple, MentorLake.GLib.GQuark domain, int code, string format, IntPtr args) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_error_va(simple, domain, code, format, args);
		return simple;
	}

/// <summary>
/// <para>
/// Sets the result from a #GError.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <param name="error">
/// #GError.
/// </param>

	public static T SetFromError<T>(this T simple, MentorLake.GLib.GErrorHandle error) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_from_error(simple, error);
		return simple;
	}

/// <summary>
/// <para>
/// Sets whether to handle cancellation within the asynchronous operation.
/// </para>
/// <para>
/// This function has nothing to do with
/// g_simple_async_result_set_check_cancellable().  It only refers to the
/// #GCancellable passed to g_simple_async_result_run_in_thread().
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <param name="handle_cancellation">
/// a #gboolean.
/// </param>

	public static T SetHandleCancellation<T>(this T simple, bool handle_cancellation) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_handle_cancellation(simple, handle_cancellation);
		return simple;
	}

/// <summary>
/// <para>
/// Sets the operation result to a boolean within the asynchronous result.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <param name="op_res">
/// a #gboolean.
/// </param>

	public static T SetOpResGboolean<T>(this T simple, bool op_res) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_op_res_gboolean(simple, op_res);
		return simple;
	}

/// <summary>
/// <para>
/// Sets the operation result within the asynchronous result to a pointer.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <param name="op_res">
/// a pointer result from an asynchronous function.
/// </param>
/// <param name="destroy_op_res">
/// a #GDestroyNotify function.
/// </param>

	public static T SetOpResGpointer<T>(this T simple, IntPtr op_res, MentorLake.GLib.GDestroyNotify destroy_op_res) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_op_res_gpointer(simple, op_res, destroy_op_res);
		return simple;
	}

/// <summary>
/// <para>
/// Sets the operation result within the asynchronous result to
/// the given @op_res.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult.
/// </param>
/// <param name="op_res">
/// a #gssize.
/// </param>

	public static T SetOpResGssize<T>(this T simple, UIntPtr op_res) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_op_res_gssize(simple, op_res);
		return simple;
	}

/// <summary>
/// <para>
/// Sets the result from @error, and takes over the caller's ownership
/// of @error, so the caller does not need to free it any more.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAsyncResult
/// </param>
/// <param name="error">
/// a #GError
/// </param>

	public static T TakeError<T>(this T simple, MentorLake.GLib.GErrorHandle error) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_take_error(simple, error);
		return simple;
	}

}

internal class GSimpleAsyncResultHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))]
	internal static extern MentorLake.Gio.GSimpleAsyncResultHandle g_simple_async_result_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, IntPtr source_tag);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))]
	internal static extern MentorLake.Gio.GSimpleAsyncResultHandle g_simple_async_result_new_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))]
	internal static extern MentorLake.Gio.GSimpleAsyncResultHandle g_simple_async_result_new_from_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))]
	internal static extern MentorLake.Gio.GSimpleAsyncResultHandle g_simple_async_result_new_take_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_complete_in_idle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_simple_async_result_get_op_res_gboolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_simple_async_result_get_op_res_gpointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_simple_async_result_get_op_res_gssize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_simple_async_result_get_source_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_simple_async_result_propagate_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_run_in_thread([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, MentorLake.Gio.GSimpleAsyncThreadFunc func, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_check_cancellable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle check_cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_error_va([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, MentorLake.GLib.GQuark domain, int code, string format, IntPtr args);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_from_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_handle_cancellation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, bool handle_cancellation);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_op_res_gboolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, bool op_res);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_op_res_gpointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, IntPtr op_res, MentorLake.GLib.GDestroyNotify destroy_op_res);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_op_res_gssize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, UIntPtr op_res);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_take_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_simple_async_result_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source, IntPtr source_tag);

}
