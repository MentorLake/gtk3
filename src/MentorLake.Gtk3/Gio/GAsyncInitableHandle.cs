namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GAsyncInitable` is an interface for asynchronously initializable objects.
/// </para>
/// <para>
/// This is the asynchronous version of [iface@Gio.Initable]; it behaves the same
/// in all ways except that initialization is asynchronous. For more details
/// see the descriptions on `GInitable`.
/// </para>
/// <para>
/// A class may implement both the `GInitable` and `GAsyncInitable` interfaces.
/// </para>
/// <para>
/// Users of objects implementing this are not intended to use the interface
/// method directly; instead it will be used automatically in various ways.
/// For C applications you generally just call [func@Gio.AsyncInitable.new_async]
/// directly, or indirectly via a foo_thing_new_async() wrapper. This will call
/// [method@Gio.AsyncInitable.init_async] under the covers, calling back with `NULL`
/// and a set `GError` on failure.
/// </para>
/// <para>
/// A typical implementation might look something like this:
/// </para>
/// <para>
/// ```c
/// enum {
///    NOT_INITIALIZED,
///    INITIALIZING,
///    INITIALIZED
/// };
/// </para>
/// <para>
/// static void
/// _foo_ready_cb (Foo *self)
/// {
///   GList *l;
/// </para>
/// <para>
///   self->priv->state = INITIALIZED;
/// </para>
/// <para>
///   for (l = self->priv->init_results; l != NULL; l = l->next)
///     {
///       GTask *task = l->data;
/// </para>
/// <para>
///       if (self->priv->success)
///         g_task_return_boolean (task, TRUE);
///       else
///         g_task_return_new_error (task, ...);
///       g_object_unref (task);
///     }
/// </para>
/// <para>
///   g_list_free (self->priv->init_results);
///   self->priv->init_results = NULL;
/// }
/// </para>
/// <para>
/// static void
/// foo_init_async (GAsyncInitable       *initable,
///                 int                   io_priority,
///                 GCancellable         *cancellable,
///                 GAsyncReadyCallback   callback,
///                 gpointer              user_data)
/// {
///   Foo *self = FOO (initable);
///   GTask *task;
/// </para>
/// <para>
///   task = g_task_new (initable, cancellable, callback, user_data);
///   g_task_set_name (task, G_STRFUNC);
/// </para>
/// <para>
///   switch (self->priv->state)
///     {
///       case NOT_INITIALIZED:
///         _foo_get_ready (self);
///         self->priv->init_results = g_list_append (self->priv->init_results,
///                                                   task);
///         self->priv->state = INITIALIZING;
///         break;
///       case INITIALIZING:
///         self->priv->init_results = g_list_append (self->priv->init_results,
///                                                   task);
///         break;
///       case INITIALIZED:
///         if (!self->priv->success)
///           g_task_return_new_error (task, ...);
///         else
///           g_task_return_boolean (task, TRUE);
///         g_object_unref (task);
///         break;
///     }
/// }
/// </para>
/// <para>
/// static gboolean
/// foo_init_finish (GAsyncInitable       *initable,
///                  GAsyncResult         *result,
///                  GError              **error)
/// {
///   g_return_val_if_fail (g_task_is_valid (result, initable), FALSE);
/// </para>
/// <para>
///   return g_task_propagate_boolean (G_TASK (result), error);
/// }
/// </para>
/// <para>
/// static void
/// foo_async_initable_iface_init (gpointer g_iface,
///                                gpointer data)
/// {
///   GAsyncInitableIface *iface = g_iface;
/// </para>
/// <para>
///   iface->init_async = foo_init_async;
///   iface->init_finish = foo_init_finish;
/// }
/// ```
/// </para>
/// </summary>

public interface GAsyncInitableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GAsyncInitableHandleImpl : BaseSafeHandle, GAsyncInitableHandle
{
}

public static class GAsyncInitableHandleExtensions
{
/// <summary>
/// <para>
/// Starts asynchronous initialization of the object implementing the
/// interface. This must be done before any real use of the object after
/// initial construction. If the object also implements #GInitable you can
/// optionally call g_initable_init() instead.
/// </para>
/// <para>
/// This method is intended for language bindings. If writing in C,
/// g_async_initable_new_async() should typically be used instead.
/// </para>
/// <para>
/// When the initialization is finished, @callback will be called. You can
/// then call g_async_initable_init_finish() to get the result of the
/// initialization.
/// </para>
/// <para>
/// Implementations may also support cancellation. If @cancellable is not
/// %NULL, then initialization can be cancelled by triggering the cancellable
/// object from another thread. If the operation was cancelled, the error
/// %G_IO_ERROR_CANCELLED will be returned. If @cancellable is not %NULL, and
/// the object doesn't support cancellable initialization, the error
/// %G_IO_ERROR_NOT_SUPPORTED will be returned.
/// </para>
/// <para>
/// As with #GInitable, if the object is not initialized, or initialization
/// returns with an error, then all operations on the object except
/// g_object_ref() and g_object_unref() are considered to be invalid, and
/// have undefined behaviour. They will often fail with g_critical() or
/// g_warning(), but this must not be relied on.
/// </para>
/// <para>
/// Callers should not assume that a class which implements #GAsyncInitable can
/// be initialized multiple times; for more information, see g_initable_init().
/// If a class explicitly supports being initialized multiple times,
/// implementation requires yielding all subsequent calls to init_async() on the
/// results of the first call.
/// </para>
/// <para>
/// For classes that also support the #GInitable interface, the default
/// implementation of this method will run the g_initable_init() function
/// in a thread, so if you want to support asynchronous initialization via
/// threads, just implement the #GAsyncInitable interface without overriding
/// any interface methods.
/// </para>
/// </summary>

/// <param name="initable">
/// a #GAsyncInitable.
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the operation
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T InitAsync<T>(this T initable, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GAsyncInitableHandle
	{
		if (initable.IsInvalid) throw new Exception("Invalid handle (GAsyncInitableHandle)");
		GAsyncInitableHandleExterns.g_async_initable_init_async(initable, io_priority, cancellable, callback, user_data);
		return initable;
	}

/// <summary>
/// <para>
/// Finishes asynchronous initialization and returns the result.
/// See g_async_initable_init_async().
/// </para>
/// </summary>

/// <param name="initable">
/// a #GAsyncInitable.
/// </param>
/// <param name="res">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if successful. If an error has occurred, this function
/// will return %FALSE and set @error appropriately if present.
/// </return>

	public static bool InitFinish(this MentorLake.Gio.GAsyncInitableHandle initable, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (initable.IsInvalid) throw new Exception("Invalid handle (GAsyncInitableHandle)");
		var externCallResult = GAsyncInitableHandleExterns.g_async_initable_init_finish(initable, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finishes the async construction for the various g_async_initable_new
/// calls, returning the created object or %NULL on error.
/// </para>
/// </summary>

/// <param name="initable">
/// the #GAsyncInitable from the callback
/// </param>
/// <param name="res">
/// the #GAsyncResult from the callback
/// </param>
/// <return>
/// a newly created #GObject,
///      or %NULL on error. Free with g_object_unref().
/// </return>

	public static MentorLake.GObject.GObjectHandle NewFinish(this MentorLake.Gio.GAsyncInitableHandle initable, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (initable.IsInvalid) throw new Exception("Invalid handle (GAsyncInitableHandle)");
		var externCallResult = GAsyncInitableHandleExterns.g_async_initable_new_finish(initable, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Helper function for constructing #GAsyncInitable object. This is
/// similar to g_object_new() but also initializes the object asynchronously.
/// </para>
/// <para>
/// When the initialization is finished, @callback will be called. You can
/// then call g_async_initable_new_finish() to get the new object and check
/// for any errors.
/// </para>
/// </summary>

/// <param name="object_type">
/// a #GType supporting #GAsyncInitable.
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the operation
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the initialization is
///     finished
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>
/// <param name="first_property_name">
/// the name of the first property, or %NULL if no
///     properties
/// </param>
/// <param name="@__arglist">
/// the value of the first property, followed by other property
///    value pairs, and ended by %NULL.
/// </param>

	public static void NewAsync(MentorLake.GObject.GType object_type, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, string first_property_name, IntPtr @__arglist)
	{
		GAsyncInitableHandleExterns.g_async_initable_new_async(object_type, io_priority, cancellable, callback, user_data, first_property_name, @__arglist);
	}

/// <summary>
/// <para>
/// Helper function for constructing #GAsyncInitable object. This is
/// similar to g_object_new_valist() but also initializes the object
/// asynchronously.
/// </para>
/// <para>
/// When the initialization is finished, @callback will be called. You can
/// then call g_async_initable_new_finish() to get the new object and check
/// for any errors.
/// </para>
/// </summary>

/// <param name="object_type">
/// a #GType supporting #GAsyncInitable.
/// </param>
/// <param name="first_property_name">
/// the name of the first property, followed by
/// the value, and other property value pairs, and ended by %NULL.
/// </param>
/// <param name="var_args">
/// The var args list generated from @first_property_name.
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the operation
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the initialization is
///     finished
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static void NewValistAsync(MentorLake.GObject.GType object_type, string first_property_name, IntPtr var_args, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAsyncInitableHandleExterns.g_async_initable_new_valist_async(object_type, first_property_name, var_args, io_priority, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Helper function for constructing #GAsyncInitable object. This is
/// similar to g_object_newv() but also initializes the object asynchronously.
/// </para>
/// <para>
/// When the initialization is finished, @callback will be called. You can
/// then call g_async_initable_new_finish() to get the new object and check
/// for any errors.
/// </para>
/// </summary>

/// <param name="object_type">
/// a #GType supporting #GAsyncInitable.
/// </param>
/// <param name="n_parameters">
/// the number of parameters in @parameters
/// </param>
/// <param name="parameters">
/// the parameters to use to construct the object
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the operation
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the initialization is
///     finished
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static void NewvAsync(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameterHandle parameters, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAsyncInitableHandleExterns.g_async_initable_newv_async(object_type, n_parameters, parameters, io_priority, cancellable, callback, user_data);
	}

}

internal class GAsyncInitableHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_async_initable_init_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncInitableHandleImpl>))] MentorLake.Gio.GAsyncInitableHandle initable, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_async_initable_init_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncInitableHandleImpl>))] MentorLake.Gio.GAsyncInitableHandle initable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_async_initable_new_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncInitableHandleImpl>))] MentorLake.Gio.GAsyncInitableHandle initable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_async_initable_new_async(MentorLake.GObject.GType object_type, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, string first_property_name, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_async_initable_new_valist_async(MentorLake.GObject.GType object_type, string first_property_name, IntPtr var_args, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_async_initable_newv_async(MentorLake.GObject.GType object_type, uint n_parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParameterHandle>))] MentorLake.GObject.GParameterHandle parameters, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

}
