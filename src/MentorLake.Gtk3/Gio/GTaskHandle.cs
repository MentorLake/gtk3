namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GTask` represents and manages a cancellable ‘task’.
/// </para>
/// <para>
/// ## Asynchronous operations
/// </para>
/// <para>
/// The most common usage of `GTask` is as a [iface@Gio.AsyncResult], to
/// manage data during an asynchronous operation. You call
/// [ctor@Gio.Task.new] in the ‘start’ method, followed by
/// [method@Gio.Task.set_task_data] and the like if you need to keep some
/// additional data associated with the task, and then pass the
/// task object around through your asynchronous operation.
/// Eventually, you will call a method such as
/// [method@Gio.Task.return_pointer] or [method@Gio.Task.return_error], which
/// will save the value you give it and then invoke the task’s callback
/// function in the thread-default main context (see
/// [method@GLib.MainContext.push_thread_default])
/// where it was created (waiting until the next iteration of the main
/// loop first, if necessary). The caller will pass the `GTask` back to
/// the operation’s finish function (as a [iface@Gio.AsyncResult]), and you can
/// use [method@Gio.Task.propagate_pointer] or the like to extract the
/// return value.
/// </para>
/// <para>
/// Using `GTask` requires the thread-default [struct@GLib.MainContext] from when
/// the `GTask` was constructed to be running at least until the task has
/// completed and its data has been freed.
/// </para>
/// <para>
/// If a `GTask` has been constructed and its callback set, it is an error to
/// not call `g_task_return_*()` on it. GLib will warn at runtime if this happens
/// (since 2.76).
/// </para>
/// <para>
/// Here is an example for using `GTask` as a [iface@Gio.AsyncResult]:
/// ```c
/// typedef struct {
///   CakeFrostingType frosting;
///   char *message;
/// } DecorationData;
/// </para>
/// <para>
/// static void
/// decoration_data_free (DecorationData *decoration)
/// {
///   g_free (decoration->message);
///   g_slice_free (DecorationData, decoration);
/// }
/// </para>
/// <para>
/// static void
/// baked_cb (Cake     *cake,
///           gpointer  user_data)
/// {
///   GTask *task = user_data;
///   DecorationData *decoration = g_task_get_task_data (task);
///   GError *error = NULL;
/// </para>
/// <para>
///   if (cake == NULL)
///     {
///       g_task_return_new_error (task, BAKER_ERROR, BAKER_ERROR_NO_FLOUR,
///                                "Go to the supermarket");
///       g_object_unref (task);
///       return;
///     }
/// </para>
/// <para>
///   if (!cake_decorate (cake, decoration->frosting, decoration->message, &error))
///     {
///       g_object_unref (cake);
///       // g_task_return_error() takes ownership of error
///       g_task_return_error (task, error);
///       g_object_unref (task);
///       return;
///     }
/// </para>
/// <para>
///   g_task_return_pointer (task, cake, g_object_unref);
///   g_object_unref (task);
/// }
/// </para>
/// <para>
/// void
/// baker_bake_cake_async (Baker               *self,
///                        guint                radius,
///                        CakeFlavor           flavor,
///                        CakeFrostingType     frosting,
///                        const char          *message,
///                        GCancellable        *cancellable,
///                        GAsyncReadyCallback  callback,
///                        gpointer             user_data)
/// {
///   GTask *task;
///   DecorationData *decoration;
///   Cake  *cake;
/// </para>
/// <para>
///   task = g_task_new (self, cancellable, callback, user_data);
///   if (radius < 3)
///     {
///       g_task_return_new_error (task, BAKER_ERROR, BAKER_ERROR_TOO_SMALL,
///                                "%ucm radius cakes are silly",
///                                radius);
///       g_object_unref (task);
///       return;
///     }
/// </para>
/// <para>
///   cake = _baker_get_cached_cake (self, radius, flavor, frosting, message);
///   if (cake != NULL)
///     {
///       // _baker_get_cached_cake() returns a reffed cake
///       g_task_return_pointer (task, cake, g_object_unref);
///       g_object_unref (task);
///       return;
///     }
/// </para>
/// <para>
///   decoration = g_slice_new (DecorationData);
///   decoration->frosting = frosting;
///   decoration->message = g_strdup (message);
///   g_task_set_task_data (task, decoration, (GDestroyNotify) decoration_data_free);
/// </para>
/// <para>
///   _baker_begin_cake (self, radius, flavor, cancellable, baked_cb, task);
/// }
/// </para>
/// <para>
/// Cake *
/// baker_bake_cake_finish (Baker         *self,
///                         GAsyncResult  *result,
///                         GError       **error)
/// {
///   g_return_val_if_fail (g_task_is_valid (result, self), NULL);
/// </para>
/// <para>
///   return g_task_propagate_pointer (G_TASK (result), error);
/// }
/// ```
/// </para>
/// <para>
/// ## Chained asynchronous operations
/// </para>
/// <para>
/// `GTask` also tries to simplify asynchronous operations that
/// internally chain together several smaller asynchronous
/// operations. [method@Gio.Task.get_cancellable], [method@Gio.Task.get_context],
/// and [method@Gio.Task.get_priority] allow you to get back the task’s
/// [class@Gio.Cancellable], [struct@GLib.MainContext], and
/// [I/O priority](iface.AsyncResult.html#io-priority)
/// when starting a new subtask, so you don’t have to keep track
/// of them yourself. [method@Gio.Task.attach_source] simplifies the case
/// of waiting for a source to fire (automatically using the correct
/// [struct@GLib.MainContext] and priority).
/// </para>
/// <para>
/// Here is an example for chained asynchronous operations:
/// ```c
/// typedef struct {
///   Cake *cake;
///   CakeFrostingType frosting;
///   char *message;
/// } BakingData;
/// </para>
/// <para>
/// static void
/// decoration_data_free (BakingData *bd)
/// {
///   if (bd->cake)
///     g_object_unref (bd->cake);
///   g_free (bd->message);
///   g_slice_free (BakingData, bd);
/// }
/// </para>
/// <para>
/// static void
/// decorated_cb (Cake         *cake,
///               GAsyncResult *result,
///               gpointer      user_data)
/// {
///   GTask *task = user_data;
///   GError *error = NULL;
/// </para>
/// <para>
///   if (!cake_decorate_finish (cake, result, &error))
///     {
///       g_object_unref (cake);
///       g_task_return_error (task, error);
///       g_object_unref (task);
///       return;
///     }
/// </para>
/// <para>
///   // baking_data_free() will drop its ref on the cake, so we have to
///   // take another here to give to the caller.
///   g_task_return_pointer (task, g_object_ref (cake), g_object_unref);
///   g_object_unref (task);
/// }
/// </para>
/// <para>
/// static gboolean
/// decorator_ready (gpointer user_data)
/// {
///   GTask *task = user_data;
///   BakingData *bd = g_task_get_task_data (task);
/// </para>
/// <para>
///   cake_decorate_async (bd->cake, bd->frosting, bd->message,
///                        g_task_get_cancellable (task),
///                        decorated_cb, task);
/// </para>
/// <para>
///   return G_SOURCE_REMOVE;
/// }
/// </para>
/// <para>
/// static void
/// baked_cb (Cake     *cake,
///           gpointer  user_data)
/// {
///   GTask *task = user_data;
///   BakingData *bd = g_task_get_task_data (task);
///   GError *error = NULL;
/// </para>
/// <para>
///   if (cake == NULL)
///     {
///       g_task_return_new_error (task, BAKER_ERROR, BAKER_ERROR_NO_FLOUR,
///                                "Go to the supermarket");
///       g_object_unref (task);
///       return;
///     }
/// </para>
/// <para>
///   bd->cake = cake;
/// </para>
/// <para>
///   // Bail out now if the user has already cancelled
///   if (g_task_return_error_if_cancelled (task))
///     {
///       g_object_unref (task);
///       return;
///     }
/// </para>
/// <para>
///   if (cake_decorator_available (cake))
///     decorator_ready (task);
///   else
///     {
///       GSource *source;
/// </para>
/// <para>
///       source = cake_decorator_wait_source_new (cake);
///       // Attach @source to @task’s GMainContext and have it call
///       // decorator_ready() when it is ready.
///       g_task_attach_source (task, source, decorator_ready);
///       g_source_unref (source);
///     }
/// }
/// </para>
/// <para>
/// void
/// baker_bake_cake_async (Baker               *self,
///                        guint                radius,
///                        CakeFlavor           flavor,
///                        CakeFrostingType     frosting,
///                        const char          *message,
///                        gint                 priority,
///                        GCancellable        *cancellable,
///                        GAsyncReadyCallback  callback,
///                        gpointer             user_data)
/// {
///   GTask *task;
///   BakingData *bd;
/// </para>
/// <para>
///   task = g_task_new (self, cancellable, callback, user_data);
///   g_task_set_priority (task, priority);
/// </para>
/// <para>
///   bd = g_slice_new0 (BakingData);
///   bd->frosting = frosting;
///   bd->message = g_strdup (message);
///   g_task_set_task_data (task, bd, (GDestroyNotify) baking_data_free);
/// </para>
/// <para>
///   _baker_begin_cake (self, radius, flavor, cancellable, baked_cb, task);
/// }
/// </para>
/// <para>
/// Cake *
/// baker_bake_cake_finish (Baker         *self,
///                         GAsyncResult  *result,
///                         GError       **error)
/// {
///   g_return_val_if_fail (g_task_is_valid (result, self), NULL);
/// </para>
/// <para>
///   return g_task_propagate_pointer (G_TASK (result), error);
/// }
/// ```
/// </para>
/// <para>
/// ## Asynchronous operations from synchronous ones
/// </para>
/// <para>
/// You can use [method@Gio.Task.run_in_thread] to turn a synchronous
/// operation into an asynchronous one, by running it in a thread.
/// When it completes, the result will be dispatched to the thread-default main
/// context (see [method@GLib.MainContext.push_thread_default]) where the `GTask`
/// was created.
/// </para>
/// <para>
/// Running a task in a thread:
/// ```c
/// typedef struct {
///   guint radius;
///   CakeFlavor flavor;
///   CakeFrostingType frosting;
///   char *message;
/// } CakeData;
/// </para>
/// <para>
/// static void
/// cake_data_free (CakeData *cake_data)
/// {
///   g_free (cake_data->message);
///   g_slice_free (CakeData, cake_data);
/// }
/// </para>
/// <para>
/// static void
/// bake_cake_thread (GTask         *task,
///                   gpointer       source_object,
///                   gpointer       task_data,
///                   GCancellable  *cancellable)
/// {
///   Baker *self = source_object;
///   CakeData *cake_data = task_data;
///   Cake *cake;
///   GError *error = NULL;
/// </para>
/// <para>
///   cake = bake_cake (baker, cake_data->radius, cake_data->flavor,
///                     cake_data->frosting, cake_data->message,
///                     cancellable, &error);
///   if (cake)
///     g_task_return_pointer (task, cake, g_object_unref);
///   else
///     g_task_return_error (task, error);
/// }
/// </para>
/// <para>
/// void
/// baker_bake_cake_async (Baker               *self,
///                        guint                radius,
///                        CakeFlavor           flavor,
///                        CakeFrostingType     frosting,
///                        const char          *message,
///                        GCancellable        *cancellable,
///                        GAsyncReadyCallback  callback,
///                        gpointer             user_data)
/// {
///   CakeData *cake_data;
///   GTask *task;
/// </para>
/// <para>
///   cake_data = g_slice_new (CakeData);
///   cake_data->radius = radius;
///   cake_data->flavor = flavor;
///   cake_data->frosting = frosting;
///   cake_data->message = g_strdup (message);
///   task = g_task_new (self, cancellable, callback, user_data);
///   g_task_set_task_data (task, cake_data, (GDestroyNotify) cake_data_free);
///   g_task_run_in_thread (task, bake_cake_thread);
///   g_object_unref (task);
/// }
/// </para>
/// <para>
/// Cake *
/// baker_bake_cake_finish (Baker         *self,
///                         GAsyncResult  *result,
///                         GError       **error)
/// {
///   g_return_val_if_fail (g_task_is_valid (result, self), NULL);
/// </para>
/// <para>
///   return g_task_propagate_pointer (G_TASK (result), error);
/// }
/// ```
/// </para>
/// <para>
/// ## Adding cancellability to uncancellable tasks
/// </para>
/// <para>
/// Finally, [method@Gio.Task.run_in_thread] and
/// [method@Gio.Task.run_in_thread_sync] can be used to turn an uncancellable
/// operation into a cancellable one. If you call
/// [method@Gio.Task.set_return_on_cancel], passing `TRUE`, then if the task’s
/// [class@Gio.Cancellable] is cancelled, it will return control back to the
/// caller immediately, while allowing the task thread to continue running in the
/// background (and simply discarding its result when it finally does finish).
/// Provided that the task thread is careful about how it uses
/// locks and other externally-visible resources, this allows you
/// to make ‘GLib-friendly’ asynchronous and cancellable
/// synchronous variants of blocking APIs.
/// </para>
/// <para>
/// Cancelling a task:
/// ```c
/// static void
/// bake_cake_thread (GTask         *task,
///                   gpointer       source_object,
///                   gpointer       task_data,
///                   GCancellable  *cancellable)
/// {
///   Baker *self = source_object;
///   CakeData *cake_data = task_data;
///   Cake *cake;
///   GError *error = NULL;
/// </para>
/// <para>
///   cake = bake_cake (baker, cake_data->radius, cake_data->flavor,
///                     cake_data->frosting, cake_data->message,
///                     &error);
///   if (error)
///     {
///       g_task_return_error (task, error);
///       return;
///     }
/// </para>
/// <para>
///   // If the task has already been cancelled, then we don’t want to add
///   // the cake to the cake cache. Likewise, we don’t  want to have the
///   // task get cancelled in the middle of updating the cache.
///   // g_task_set_return_on_cancel() will return %TRUE here if it managed
///   // to disable return-on-cancel, or %FALSE if the task was cancelled
///   // before it could.
///   if (g_task_set_return_on_cancel (task, FALSE))
///     {
///       // If the caller cancels at this point, their
///       // GAsyncReadyCallback won’t be invoked until we return,
///       // so we don’t have to worry that this code will run at
///       // the same time as that code does. But if there were
///       // other functions that might look at the cake cache,
///       // then we’d probably need a GMutex here as well.
///       baker_add_cake_to_cache (baker, cake);
///       g_task_return_pointer (task, cake, g_object_unref);
///     }
/// }
/// </para>
/// <para>
/// void
/// baker_bake_cake_async (Baker               *self,
///                        guint                radius,
///                        CakeFlavor           flavor,
///                        CakeFrostingType     frosting,
///                        const char          *message,
///                        GCancellable        *cancellable,
///                        GAsyncReadyCallback  callback,
///                        gpointer             user_data)
/// {
///   CakeData *cake_data;
///   GTask *task;
/// </para>
/// <para>
///   cake_data = g_slice_new (CakeData);
/// </para>
/// <para>
///   ...
/// </para>
/// <para>
///   task = g_task_new (self, cancellable, callback, user_data);
///   g_task_set_task_data (task, cake_data, (GDestroyNotify) cake_data_free);
///   g_task_set_return_on_cancel (task, TRUE);
///   g_task_run_in_thread (task, bake_cake_thread);
/// }
/// </para>
/// <para>
/// Cake *
/// baker_bake_cake_sync (Baker               *self,
///                       guint                radius,
///                       CakeFlavor           flavor,
///                       CakeFrostingType     frosting,
///                       const char          *message,
///                       GCancellable        *cancellable,
///                       GError             **error)
/// {
///   CakeData *cake_data;
///   GTask *task;
///   Cake *cake;
/// </para>
/// <para>
///   cake_data = g_slice_new (CakeData);
/// </para>
/// <para>
///   ...
/// </para>
/// <para>
///   task = g_task_new (self, cancellable, NULL, NULL);
///   g_task_set_task_data (task, cake_data, (GDestroyNotify) cake_data_free);
///   g_task_set_return_on_cancel (task, TRUE);
///   g_task_run_in_thread_sync (task, bake_cake_thread);
/// </para>
/// <para>
///   cake = g_task_propagate_pointer (task, error);
///   g_object_unref (task);
///   return cake;
/// }
/// ```
/// </para>
/// <para>
/// ## Porting from [class@Gio.SimpleAsyncResult]
/// </para>
/// <para>
/// `GTask`’s API attempts to be simpler than [class@Gio.SimpleAsyncResult]’s
/// in several ways:
/// </para>
/// <para>
/// - You can save task-specific data with [method@Gio.Task.set_task_data], and
///   retrieve it later with [method@Gio.Task.get_task_data]. This replaces the
///   abuse of [method@Gio.SimpleAsyncResult.set_op_res_gpointer] for the same
///   purpose with [class@Gio.SimpleAsyncResult].
/// - In addition to the task data, `GTask` also keeps track of the
///   [priority](iface.AsyncResult.html#io-priority), [class@Gio.Cancellable],
///   and [struct@GLib.MainContext] associated with the task, so tasks that
///   consist of a chain of simpler asynchronous operations will have easy access
///   to those values when starting each sub-task.
/// - [method@Gio.Task.return_error_if_cancelled] provides simplified
///   handling for cancellation. In addition, cancellation
///   overrides any other `GTask` return value by default, like
///   [class@Gio.SimpleAsyncResult] does when
///   [method@Gio.SimpleAsyncResult.set_check_cancellable] is called.
///   (You can use [method@Gio.Task.set_check_cancellable] to turn off that
///   behavior.) On the other hand, [method@Gio.Task.run_in_thread]
///   guarantees that it will always run your
///   `task_func`, even if the task’s [class@Gio.Cancellable]
///   is already cancelled before the task gets a chance to run;
///   you can start your `task_func` with a
///   [method@Gio.Task.return_error_if_cancelled] check if you need the
///   old behavior.
/// - The ‘return’ methods (eg, [method@Gio.Task.return_pointer])
///   automatically cause the task to be ‘completed’ as well, and
///   there is no need to worry about the ‘complete’ vs ‘complete in idle’
///   distinction. (`GTask` automatically figures out
///   whether the task’s callback can be invoked directly, or
///   if it needs to be sent to another [struct@GLib.MainContext], or delayed
///   until the next iteration of the current [struct@GLib.MainContext].)
/// - The ‘finish’ functions for `GTask` based operations are generally
///   much simpler than [class@Gio.SimpleAsyncResult] ones, normally consisting
///   of only a single call to [method@Gio.Task.propagate_pointer] or the like.
///   Since [method@Gio.Task.propagate_pointer] ‘steals’ the return value from
///   the `GTask`, it is not necessary to juggle pointers around to
///   prevent it from being freed twice.
/// - With [class@Gio.SimpleAsyncResult], it was common to call
///   [method@Gio.SimpleAsyncResult.propagate_error] from the
///   `_finish()` wrapper function, and have
///   virtual method implementations only deal with successful
///   returns. This behavior is deprecated, because it makes it
///   difficult for a subclass to chain to a parent class’s async
///   methods. Instead, the wrapper function should just be a
///   simple wrapper, and the virtual method should call an
///   appropriate `g_task_propagate_` function.
///   Note that wrapper methods can now use
///   [method@Gio.AsyncResult.legacy_propagate_error] to do old-style
///   [class@Gio.SimpleAsyncResult] error-returning behavior, and
///   [method@Gio.AsyncResult.is_tagged] to check if a result is tagged as
///   having come from the `_async()` wrapper
///   function (for ‘short-circuit’ results, such as when passing
///   `0` to [method@Gio.InputStream.read_async]).
/// </para>
/// <para>
/// ## Thread-safety considerations
/// </para>
/// <para>
/// Due to some infelicities in the API design, there is a
/// thread-safety concern that users of `GTask` have to be aware of:
/// </para>
/// <para>
/// If the `main` thread drops its last reference to the source object
/// or the task data before the task is finalized, then the finalizers
/// of these objects may be called on the worker thread.
/// </para>
/// <para>
/// This is a problem if the finalizers use non-threadsafe API, and
/// can lead to hard-to-debug crashes. Possible workarounds include:
/// </para>
/// <para>
/// - Clear task data in a signal handler for `notify::completed`
/// - Keep iterating a main context in the main thread and defer
///   dropping the reference to the source object to that main
///   context when the task is finalized
/// </para>
/// </summary>

public class GTaskHandle : GObjectHandle, GAsyncResultHandle
{
/// <summary>
/// <para>
/// Creates a #GTask acting on @source_object, which will eventually be
/// used to invoke @callback in the current
/// [thread-default main context][g-main-context-push-thread-default].
/// </para>
/// <para>
/// Call this in the "start" method of your asynchronous method, and
/// pass the #GTask around throughout the asynchronous operation. You
/// can use g_task_set_task_data() to attach task-specific data to the
/// object, which you can retrieve later via g_task_get_task_data().
/// </para>
/// <para>
/// By default, if @cancellable is cancelled, then the return value of
/// the task will always be %G_IO_ERROR_CANCELLED, even if the task had
/// already completed before the cancellation. This allows for
/// simplified handling in cases where cancellation may imply that
/// other objects that the task depends on have been destroyed. If you
/// do not want this behavior, you can use
/// g_task_set_check_cancellable() to change it.
/// </para>
/// </summary>

/// <param name="source_object">
/// the #GObject that owns
///   this task, or %NULL.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback.
/// </param>
/// <param name="callback_data">
/// user data passed to @callback.
/// </param>
/// <return>
/// a #GTask.
/// </return>

	public static MentorLake.Gio.GTaskHandle New(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr callback_data)
	{
		return GTaskHandleExterns.g_task_new(source_object, cancellable, callback, callback_data);
	}

/// <summary>
/// <para>
/// Checks that @result is a #GTask, and that @source_object is its
/// source object (or that @source_object is %NULL and @result has no
/// source object). This can be used in g_return_if_fail() checks.
/// </para>
/// </summary>

/// <param name="result">
/// A #GAsyncResult
/// </param>
/// <param name="source_object">
/// the source object
///   expected to be associated with the task
/// </param>
/// <return>
/// %TRUE if @result and @source_object are valid, %FALSE
/// if not
/// </return>

	public static bool IsValid(MentorLake.Gio.GAsyncResultHandle result, MentorLake.GObject.GObjectHandle source_object)
	{
		return GTaskHandleExterns.g_task_is_valid(result, source_object);
	}

/// <summary>
/// <para>
/// Creates a #GTask and then immediately calls g_task_return_error()
/// on it. Use this in the wrapper function of an asynchronous method
/// when you want to avoid even calling the virtual method. You can
/// then use g_async_result_is_tagged() in the finish method wrapper to
/// check if the result there is tagged as having been created by the
/// wrapper method, and deal with it appropriately if so.
/// </para>
/// <para>
/// See also g_task_report_new_error().
/// </para>
/// </summary>

/// <param name="source_object">
/// the #GObject that owns
///   this task, or %NULL.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback.
/// </param>
/// <param name="callback_data">
/// user data passed to @callback.
/// </param>
/// <param name="source_tag">
/// an opaque pointer indicating the source of this task
/// </param>
/// <param name="error">
/// error to report
/// </param>

	public static void ReportError(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, MentorLake.GLib.GErrorHandle error)
	{
		GTaskHandleExterns.g_task_report_error(source_object, callback, callback_data, source_tag, error);
	}

/// <summary>
/// <para>
/// Creates a #GTask and then immediately calls
/// g_task_return_new_error() on it. Use this in the wrapper function
/// of an asynchronous method when you want to avoid even calling the
/// virtual method. You can then use g_async_result_is_tagged() in the
/// finish method wrapper to check if the result there is tagged as
/// having been created by the wrapper method, and deal with it
/// appropriately if so.
/// </para>
/// <para>
/// See also g_task_report_error().
/// </para>
/// </summary>

/// <param name="source_object">
/// the #GObject that owns
///   this task, or %NULL.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback.
/// </param>
/// <param name="callback_data">
/// user data passed to @callback.
/// </param>
/// <param name="source_tag">
/// an opaque pointer indicating the source of this task
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

	public static void ReportNewError(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist)
	{
		GTaskHandleExterns.g_task_report_new_error(source_object, callback, callback_data, source_tag, domain, code, format, @__arglist);
	}

}

public static class GTaskHandleExtensions
{
/// <summary>
/// <para>
/// A utility function for dealing with async operations where you need
/// to wait for a #GSource to trigger. Attaches @source to @task's
/// #GMainContext with @task's [priority](iface.AsyncResult.html#io-priority),
/// and sets @source's callback to @callback, with @task as the callback's
/// `user_data`.
/// </para>
/// <para>
/// It will set the @source’s name to the task’s name (as set with
/// g_task_set_name()), if one has been set on the task and the source doesn’t
/// yet have a name.
/// </para>
/// <para>
/// This takes a reference on @task until @source is destroyed.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <param name="source">
/// the source to attach
/// </param>
/// <param name="callback">
/// the callback to invoke when @source triggers
/// </param>

	public static T AttachSource<T>(this T task, MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceFunc callback) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_attach_source(task, source, callback);
		return task;
	}

/// <summary>
/// <para>
/// Gets @task's #GCancellable
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <return>
/// @task's #GCancellable
/// </return>

	public static MentorLake.Gio.GCancellableHandle GetCancellable(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_get_cancellable(task);
	}

/// <summary>
/// <para>
/// Gets @task's check-cancellable flag. See
/// g_task_set_check_cancellable() for more details.
/// </para>
/// </summary>

/// <param name="task">
/// the #GTask
/// </param>

	public static bool GetCheckCancellable(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_get_check_cancellable(task);
	}

/// <summary>
/// <para>
/// Gets the value of #GTask:completed. This changes from %FALSE to %TRUE after
/// the task’s callback is invoked, and will return %FALSE if called from inside
/// the callback.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask.
/// </param>
/// <return>
/// %TRUE if the task has completed, %FALSE otherwise.
/// </return>

	public static bool GetCompleted(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_get_completed(task);
	}

/// <summary>
/// <para>
/// Gets the #GMainContext that @task will return its result in (that
/// is, the context that was the
/// [thread-default main context][g-main-context-push-thread-default]
/// at the point when @task was created).
/// </para>
/// <para>
/// This will always return a non-%NULL value, even if the task's
/// context is the default #GMainContext.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <return>
/// @task's #GMainContext
/// </return>

	public static MentorLake.GLib.GMainContextHandle GetContext(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_get_context(task);
	}

/// <summary>
/// <para>
/// Gets @task’s name. See g_task_set_name().
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <return>
/// @task’s name, or %NULL
/// </return>

	public static string GetName(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_get_name(task);
	}

/// <summary>
/// <para>
/// Gets @task's priority
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <return>
/// @task's priority
/// </return>

	public static int GetPriority(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_get_priority(task);
	}

/// <summary>
/// <para>
/// Gets @task's return-on-cancel flag. See
/// g_task_set_return_on_cancel() for more details.
/// </para>
/// </summary>

/// <param name="task">
/// the #GTask
/// </param>

	public static bool GetReturnOnCancel(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_get_return_on_cancel(task);
	}

/// <summary>
/// <para>
/// Gets the source object from @task. Like
/// g_async_result_get_source_object(), but does not ref the object.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <return>
/// @task's source object, or %NULL
/// </return>

	public static MentorLake.GObject.GObjectHandle GetSourceObject(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_get_source_object(task);
	}

/// <summary>
/// <para>
/// Gets @task's source tag. See g_task_set_source_tag().
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <return>
/// @task's source tag
/// </return>

	public static IntPtr GetSourceTag(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_get_source_tag(task);
	}

/// <summary>
/// <para>
/// Gets @task's `task_data`.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <return>
/// @task's `task_data`.
/// </return>

	public static IntPtr GetTaskData(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_get_task_data(task);
	}

/// <summary>
/// <para>
/// Tests if @task resulted in an error.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask.
/// </param>
/// <return>
/// %TRUE if the task resulted in an error, %FALSE otherwise.
/// </return>

	public static bool HadError(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_had_error(task);
	}

/// <summary>
/// <para>
/// Gets the result of @task as a #gboolean.
/// </para>
/// <para>
/// If the task resulted in an error, or was cancelled, then this will
/// instead return %FALSE and set @error.
/// </para>
/// <para>
/// Since this method transfers ownership of the return value (or
/// error) to the caller, you may only call it once.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask.
/// </param>
/// <return>
/// the task result, or %FALSE on error
/// </return>

	public static bool PropagateBoolean(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		var externCallResult = GTaskHandleExterns.g_task_propagate_boolean(task, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the result of @task as an integer (#gssize).
/// </para>
/// <para>
/// If the task resulted in an error, or was cancelled, then this will
/// instead return -1 and set @error.
/// </para>
/// <para>
/// Since this method transfers ownership of the return value (or
/// error) to the caller, you may only call it once.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask.
/// </param>
/// <return>
/// the task result, or -1 on error
/// </return>

	public static UIntPtr PropagateInt(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		var externCallResult = GTaskHandleExterns.g_task_propagate_int(task, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the result of @task as a pointer, and transfers ownership
/// of that value to the caller.
/// </para>
/// <para>
/// If the task resulted in an error, or was cancelled, then this will
/// instead return %NULL and set @error.
/// </para>
/// <para>
/// Since this method transfers ownership of the return value (or
/// error) to the caller, you may only call it once.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <return>
/// the task result, or %NULL on error
/// </return>

	public static IntPtr PropagatePointer(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		var externCallResult = GTaskHandleExterns.g_task_propagate_pointer(task, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the result of @task as a #GValue, and transfers ownership of
/// that value to the caller. As with g_task_return_value(), this is
/// a generic low-level method; g_task_propagate_pointer() and the like
/// will usually be more useful for C code.
/// </para>
/// <para>
/// If the task resulted in an error, or was cancelled, then this will
/// instead set @error and return %FALSE.
/// </para>
/// <para>
/// Since this method transfers ownership of the return value (or
/// error) to the caller, you may only call it once.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <param name="value">
/// return location for the #GValue
/// </param>
/// <return>
/// %TRUE if @task succeeded, %FALSE on error.
/// </return>

	public static bool PropagateValue(this MentorLake.Gio.GTaskHandle task, out MentorLake.GObject.GValue value)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		var externCallResult = GTaskHandleExterns.g_task_propagate_value(task, out value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @task's result to @result and completes the task (see
/// g_task_return_pointer() for more discussion of exactly what this
/// means).
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask.
/// </param>
/// <param name="result">
/// the #gboolean result of a task function.
/// </param>

	public static T ReturnBoolean<T>(this T task, bool result) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_return_boolean(task, result);
		return task;
	}

/// <summary>
/// <para>
/// Sets @task's result to @error (which @task assumes ownership of)
/// and completes the task (see g_task_return_pointer() for more
/// discussion of exactly what this means).
/// </para>
/// <para>
/// Note that since the task takes ownership of @error, and since the
/// task may be completed before returning from g_task_return_error(),
/// you cannot assume that @error is still valid after calling this.
/// Call g_error_copy() on the error if you need to keep a local copy
/// as well.
/// </para>
/// <para>
/// See also [method@Gio.Task.return_new_error],
/// [method@Gio.Task.return_new_error_literal].
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask.
/// </param>
/// <param name="error">
/// the #GError result of a task function.
/// </param>

	public static T ReturnError<T>(this T task, MentorLake.GLib.GErrorHandle error) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_return_error(task, error);
		return task;
	}

/// <summary>
/// <para>
/// Checks if @task's #GCancellable has been cancelled, and if so, sets
/// @task's error accordingly and completes the task (see
/// g_task_return_pointer() for more discussion of exactly what this
/// means).
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <return>
/// %TRUE if @task has been cancelled, %FALSE if not
/// </return>

	public static bool ReturnErrorIfCancelled(this MentorLake.Gio.GTaskHandle task)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_return_error_if_cancelled(task);
	}

/// <summary>
/// <para>
/// Sets @task's result to @result and completes the task (see
/// g_task_return_pointer() for more discussion of exactly what this
/// means).
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask.
/// </param>
/// <param name="result">
/// the integer (#gssize) result of a task function.
/// </param>

	public static T ReturnInt<T>(this T task, UIntPtr result) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_return_int(task, result);
		return task;
	}

/// <summary>
/// <para>
/// Sets @task's result to a new #GError created from @domain, @code,
/// @format, and the remaining arguments, and completes the task (see
/// g_task_return_pointer() for more discussion of exactly what this
/// means).
/// </para>
/// <para>
/// See also g_task_return_error().
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask.
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

	public static T ReturnNewError<T>(this T task, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_return_new_error(task, domain, code, format, @__arglist);
		return task;
	}

/// <summary>
/// <para>
/// Sets @task’s result to a new [type@GLib.Error] created from @domain, @code,
/// @message and completes the task.
/// </para>
/// <para>
/// See [method@Gio.Task.return_pointer] for more discussion of exactly what
/// ‘completing the task’ means.
/// </para>
/// <para>
/// See also [method@Gio.Task.return_new_error].
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask.
/// </param>
/// <param name="domain">
/// a #GQuark.
/// </param>
/// <param name="code">
/// an error code.
/// </param>
/// <param name="message">
/// an error message
/// </param>

	public static T ReturnNewErrorLiteral<T>(this T task, MentorLake.GLib.GQuark domain, int code, string message) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_return_new_error_literal(task, domain, code, message);
		return task;
	}

/// <summary>
/// <para>
/// Sets @task's result to @result and completes the task. If @result
/// is not %NULL, then @result_destroy will be used to free @result if
/// the caller does not take ownership of it with
/// g_task_propagate_pointer().
/// </para>
/// <para>
/// "Completes the task" means that for an ordinary asynchronous task
/// it will either invoke the task's callback, or else queue that
/// callback to be invoked in the proper #GMainContext, or in the next
/// iteration of the current #GMainContext. For a task run via
/// g_task_run_in_thread() or g_task_run_in_thread_sync(), calling this
/// method will save @result to be returned to the caller later, but
/// the task will not actually be completed until the #GTaskThreadFunc
/// exits.
/// </para>
/// <para>
/// Note that since the task may be completed before returning from
/// g_task_return_pointer(), you cannot assume that @result is still
/// valid after calling this, unless you are still holding another
/// reference on it.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <param name="result">
/// the pointer result of a task
///     function
/// </param>
/// <param name="result_destroy">
/// a #GDestroyNotify function.
/// </param>

	public static T ReturnPointer<T>(this T task, IntPtr result, MentorLake.GLib.GDestroyNotify result_destroy) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_return_pointer(task, result, result_destroy);
		return task;
	}

/// <summary>
/// <para>
/// Sets @task's result to @error (which @task assumes ownership of), with
/// the message prefixed according to @format, and completes the task
/// (see g_task_return_pointer() for more discussion of exactly what this
/// means).
/// </para>
/// <para>
/// Note that since the task takes ownership of @error, and since the
/// task may be completed before returning from g_task_return_prefixed_error(),
/// you cannot assume that @error is still valid after calling this.
/// Call g_error_copy() on the error if you need to keep a local copy
/// as well.
/// </para>
/// <para>
/// See also g_task_return_error(), g_prefix_error().
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask.
/// </param>
/// <param name="error">
/// the #GError result of a task function.
/// </param>
/// <param name="format">
/// a string with format characters.
/// </param>
/// <param name="@__arglist">
/// a list of values to insert into @format.
/// </param>

	public static T ReturnPrefixedError<T>(this T task, MentorLake.GLib.GErrorHandle error, string format, IntPtr @__arglist) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_return_prefixed_error(task, error, format, @__arglist);
		return task;
	}

/// <summary>
/// <para>
/// Sets @task's result to @result (by copying it) and completes the task.
/// </para>
/// <para>
/// If @result is %NULL then a #GValue of type %G_TYPE_POINTER
/// with a value of %NULL will be used for the result.
/// </para>
/// <para>
/// This is a very generic low-level method intended primarily for use
/// by language bindings; for C code, g_task_return_pointer() and the
/// like will normally be much easier to use.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <param name="result">
/// the #GValue result of
///                                      a task function
/// </param>

	public static T ReturnValue<T>(this T task, MentorLake.GObject.GValueHandle result) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_return_value(task, result);
		return task;
	}

/// <summary>
/// <para>
/// Runs @task_func in another thread. When @task_func returns, @task's
/// #GAsyncReadyCallback will be invoked in @task's #GMainContext.
/// </para>
/// <para>
/// This takes a ref on @task until the task completes.
/// </para>
/// <para>
/// See #GTaskThreadFunc for more details about how @task_func is handled.
/// </para>
/// <para>
/// Although GLib currently rate-limits the tasks queued via
/// g_task_run_in_thread(), you should not assume that it will always
/// do this. If you have a very large number of tasks to run (several tens of
/// tasks), but don't want them to all run at once, you should only queue a
/// limited number of them (around ten) at a time.
/// </para>
/// <para>
/// Be aware that if your task depends on other tasks to complete, use of this
/// function could lead to a livelock if the other tasks also use this function
/// and enough of them (around 10) execute in a dependency chain, as that will
/// exhaust the thread pool. If this situation is possible, consider using a
/// separate worker thread or thread pool explicitly, rather than using
/// g_task_run_in_thread().
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <param name="task_func">
/// a #GTaskThreadFunc
/// </param>

	public static T RunInThread<T>(this T task, MentorLake.Gio.GTaskThreadFunc task_func) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_run_in_thread(task, task_func);
		return task;
	}

/// <summary>
/// <para>
/// Runs @task_func in another thread, and waits for it to return or be
/// cancelled. You can use g_task_propagate_pointer(), etc, afterward
/// to get the result of @task_func.
/// </para>
/// <para>
/// See #GTaskThreadFunc for more details about how @task_func is handled.
/// </para>
/// <para>
/// Normally this is used with tasks created with a %NULL
/// `callback`, but note that even if the task does
/// have a callback, it will not be invoked when @task_func returns.
/// #GTask:completed will be set to %TRUE just before this function returns.
/// </para>
/// <para>
/// Although GLib currently rate-limits the tasks queued via
/// g_task_run_in_thread_sync(), you should not assume that it will
/// always do this. If you have a very large number of tasks to run,
/// but don't want them to all run at once, you should only queue a
/// limited number of them at a time.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <param name="task_func">
/// a #GTaskThreadFunc
/// </param>

	public static T RunInThreadSync<T>(this T task, MentorLake.Gio.GTaskThreadFunc task_func) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_run_in_thread_sync(task, task_func);
		return task;
	}

/// <summary>
/// <para>
/// Sets or clears @task's check-cancellable flag. If this is %TRUE
/// (the default), then g_task_propagate_pointer(), etc, and
/// g_task_had_error() will check the task's #GCancellable first, and
/// if it has been cancelled, then they will consider the task to have
/// returned an "Operation was cancelled" error
/// (%G_IO_ERROR_CANCELLED), regardless of any other error or return
/// value the task may have had.
/// </para>
/// <para>
/// If @check_cancellable is %FALSE, then the #GTask will not check the
/// cancellable itself, and it is up to @task's owner to do this (eg,
/// via g_task_return_error_if_cancelled()).
/// </para>
/// <para>
/// If you are using g_task_set_return_on_cancel() as well, then
/// you must leave check-cancellable set %TRUE.
/// </para>
/// </summary>

/// <param name="task">
/// the #GTask
/// </param>
/// <param name="check_cancellable">
/// whether #GTask will check the state of
///   its #GCancellable for you.
/// </param>

	public static T SetCheckCancellable<T>(this T task, bool check_cancellable) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_set_check_cancellable(task, check_cancellable);
		return task;
	}

/// <summary>
/// <para>
/// Sets @task’s name, used in debugging and profiling. The name defaults to
/// %NULL.
/// </para>
/// <para>
/// The task name should describe in a human readable way what the task does.
/// For example, ‘Open file’ or ‘Connect to network host’. It is used to set the
/// name of the #GSource used for idle completion of the task.
/// </para>
/// <para>
/// This function may only be called before the @task is first used in a thread
/// other than the one it was constructed in.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <param name="name">
/// a human readable name for the task, or %NULL to unset it
/// </param>

	public static T SetName<T>(this T task, string name) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_set_name(task, name);
		return task;
	}

/// <summary>
/// <para>
/// Sets @task's priority. If you do not call this, it will default to
/// %G_PRIORITY_DEFAULT.
/// </para>
/// <para>
/// This will affect the priority of #GSources created with
/// g_task_attach_source() and the scheduling of tasks run in threads,
/// and can also be explicitly retrieved later via
/// g_task_get_priority().
/// </para>
/// </summary>

/// <param name="task">
/// the #GTask
/// </param>
/// <param name="priority">
/// the [priority](iface.AsyncResult.html#io-priority) of the request
/// </param>

	public static T SetPriority<T>(this T task, int priority) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_set_priority(task, priority);
		return task;
	}

/// <summary>
/// <para>
/// Sets or clears @task's return-on-cancel flag. This is only
/// meaningful for tasks run via g_task_run_in_thread() or
/// g_task_run_in_thread_sync().
/// </para>
/// <para>
/// If @return_on_cancel is %TRUE, then cancelling @task's
/// #GCancellable will immediately cause it to return, as though the
/// task's #GTaskThreadFunc had called
/// g_task_return_error_if_cancelled() and then returned.
/// </para>
/// <para>
/// This allows you to create a cancellable wrapper around an
/// uninterruptible function. The #GTaskThreadFunc just needs to be
/// careful that it does not modify any externally-visible state after
/// it has been cancelled. To do that, the thread should call
/// g_task_set_return_on_cancel() again to (atomically) set
/// return-on-cancel %FALSE before making externally-visible changes;
/// if the task gets cancelled before the return-on-cancel flag could
/// be changed, g_task_set_return_on_cancel() will indicate this by
/// returning %FALSE.
/// </para>
/// <para>
/// You can disable and re-enable this flag multiple times if you wish.
/// If the task's #GCancellable is cancelled while return-on-cancel is
/// %FALSE, then calling g_task_set_return_on_cancel() to set it %TRUE
/// again will cause the task to be cancelled at that point.
/// </para>
/// <para>
/// If the task's #GCancellable is already cancelled before you call
/// g_task_run_in_thread()/g_task_run_in_thread_sync(), then the
/// #GTaskThreadFunc will still be run (for consistency), but the task
/// will also be completed right away.
/// </para>
/// </summary>

/// <param name="task">
/// the #GTask
/// </param>
/// <param name="return_on_cancel">
/// whether the task returns automatically when
///   it is cancelled.
/// </param>
/// <return>
/// %TRUE if @task's return-on-cancel flag was changed to
///   match @return_on_cancel. %FALSE if @task has already been
///   cancelled.
/// </return>

	public static bool SetReturnOnCancel(this MentorLake.Gio.GTaskHandle task, bool return_on_cancel)
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		return GTaskHandleExterns.g_task_set_return_on_cancel(task, return_on_cancel);
	}

/// <summary>
/// <para>
/// Sets @task's source tag.
/// </para>
/// <para>
/// You can use this to tag a task return
/// value with a particular pointer (usually a pointer to the function
/// doing the tagging) and then later check it using
/// g_task_get_source_tag() (or g_async_result_is_tagged()) in the
/// task's "finish" function, to figure out if the response came from a
/// particular place.
/// </para>
/// <para>
/// A macro wrapper around this function will automatically set the
/// task’s name to the string form of @source_tag if it’s not already
/// set, for convenience.
/// </para>
/// </summary>

/// <param name="task">
/// the #GTask
/// </param>
/// <param name="source_tag">
/// an opaque pointer indicating the source of this task
/// </param>

	public static T SetSourceTag<T>(this T task, IntPtr source_tag) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_set_source_tag(task, source_tag);
		return task;
	}

/// <summary>
/// <para>
/// Sets @task’s name, used in debugging and profiling.
/// </para>
/// <para>
/// This is a variant of g_task_set_name() that avoids copying @name.
/// </para>
/// <para>
/// This function is called automatically by [method@Gio.Task.set_source_tag]
/// unless a name is set.
/// </para>
/// </summary>

/// <param name="task">
/// a #GTask
/// </param>
/// <param name="name">
/// a human readable name for the task. Must be a string literal
/// </param>

	public static T SetStaticName<T>(this T task, string name) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_set_static_name(task, name);
		return task;
	}

/// <summary>
/// <para>
/// Sets @task's task data (freeing the existing task data, if any).
/// </para>
/// </summary>

/// <param name="task">
/// the #GTask
/// </param>
/// <param name="task_data">
/// task-specific data
/// </param>
/// <param name="task_data_destroy">
/// #GDestroyNotify for @task_data
/// </param>

	public static T SetTaskData<T>(this T task, IntPtr task_data, MentorLake.GLib.GDestroyNotify task_data_destroy) where T : GTaskHandle
	{
		if (task.IsInvalid) throw new Exception("Invalid handle (GTaskHandle)");
		GTaskHandleExterns.g_task_set_task_data(task, task_data, task_data_destroy);
		return task;
	}

}

internal class GTaskHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))]
	internal static extern MentorLake.Gio.GTaskHandle g_task_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr callback_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_attach_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceFunc callback);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))]
	internal static extern MentorLake.Gio.GCancellableHandle g_task_get_cancellable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_get_check_cancellable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_get_completed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))]
	internal static extern MentorLake.GLib.GMainContextHandle g_task_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_task_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_task_get_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_get_return_on_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_task_get_source_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_task_get_source_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_task_get_task_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_had_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_propagate_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_task_propagate_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_task_propagate_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_propagate_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, out MentorLake.GObject.GValue value, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, bool result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_return_error_if_cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, UIntPtr result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_new_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_new_error_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, MentorLake.GLib.GQuark domain, int code, string message);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, IntPtr result, MentorLake.GLib.GDestroyNotify result_destroy);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_prefixed_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_run_in_thread([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, MentorLake.Gio.GTaskThreadFunc task_func);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_run_in_thread_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, MentorLake.Gio.GTaskThreadFunc task_func);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_set_check_cancellable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, bool check_cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_set_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, int priority);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_set_return_on_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, bool return_on_cancel);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_set_source_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, IntPtr source_tag);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_set_static_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_set_task_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, IntPtr task_data, MentorLake.GLib.GDestroyNotify task_data_destroy);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_report_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_report_new_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

}
