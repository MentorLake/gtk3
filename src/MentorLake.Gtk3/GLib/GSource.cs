namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The `GSource` struct is an opaque data type
/// representing an event source.
/// </para>
/// </summary>

public class GSourceHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new [struct@GLib.Source] structure. The size is specified to
/// allow creating structures derived from [struct@GLib.Source] that contain
/// additional data. The size passed in must be at least
/// `sizeof (GSource)`.
/// </para>
/// <para>
/// The source will not initially be associated with any #GMainContext
/// and must be added to one with [method@GLib.Source.attach] before it will be
/// executed.
/// </para>
/// </summary>

/// <param name="source_funcs">
/// structure containing functions that implement
///                the sources behavior.
/// </param>
/// <param name="struct_size">
/// size of the [struct@GLib.Source] structure to create.
/// </param>
/// <return>
/// the newly-created #GSource.
/// </return>

	public static MentorLake.GLib.GSourceHandle New(MentorLake.GLib.GSourceFuncsHandle source_funcs, uint struct_size)
	{
		return GSourceExterns.g_source_new(source_funcs, struct_size);
	}

}


public static class GSourceExtensions
{
/// <summary>
/// <para>
/// Adds @child_source to @source as a "polled" source; when @source is
/// added to a [struct@GLib.MainContext], @child_source will be automatically
/// added with the same priority, when @child_source is triggered, it will
/// cause @source to dispatch (in addition to calling its own
/// callback), and when @source is destroyed, it will destroy
/// @child_source as well. (@source will also still be dispatched if
/// its own prepare/check functions indicate that it is ready.)
/// </para>
/// <para>
/// If you don't need @child_source to do anything on its own when it
/// triggers, you can call g_source_set_dummy_callback() on it to set a
/// callback that does nothing (except return %TRUE if appropriate).
/// </para>
/// <para>
/// @source will hold a reference on @child_source while @child_source
/// is attached to it.
/// </para>
/// <para>
/// This API is only intended to be used by implementations of
/// [struct@GLib.Source]. Do not call this API on a [struct@GLib.Source] that
/// you did not create.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="child_source">
/// a second #GSource that @source should "poll"
/// </param>

	public static void AddChildSource(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceHandle child_source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_add_child_source(source, child_source);
	}

/// <summary>
/// <para>
/// Adds a file descriptor to the set of file descriptors polled for
/// this source. This is usually combined with [ctor@GLib.Source.new] to add an
/// event source. The event source's check function will typically test
/// the @revents field in the #GPollFD struct and return %TRUE if events need
/// to be processed.
/// </para>
/// <para>
/// This API is only intended to be used by implementations of [struct@GLib.Source].
/// Do not call this API on a [struct@GLib.Source] that you did not create.
/// </para>
/// <para>
/// Using this API forces the linear scanning of event sources on each
/// main loop iteration.  Newly-written event sources should try to use
/// `g_source_add_unix_fd` instead of this API.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="fd">
/// a #GPollFD structure holding information about a file
///      descriptor to watch.
/// </param>

	public static void AddPoll(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GPollFDHandle fd)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_add_poll(source, fd);
	}

/// <summary>
/// <para>
/// Monitors @fd for the IO events in @events.
/// </para>
/// <para>
/// The tag returned by this function can be used to remove or modify the
/// monitoring of the fd using [method@GLib.Source.remove_unix_fd] or
/// [method@GLib.Source.modify_unix_fd].
/// </para>
/// <para>
/// It is not necessary to remove the fd before destroying the source; it
/// will be cleaned up automatically.
/// </para>
/// <para>
/// This API is only intended to be used by implementations of #GSource.
/// Do not call this API on a #GSource that you did not create.
/// </para>
/// <para>
/// As the name suggests, this function is not available on Windows.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="fd">
/// the fd to monitor
/// </param>
/// <param name="events">
/// an event mask
/// </param>
/// <return>
/// an opaque tag
/// </return>

	public static IntPtr AddUnixFd(this MentorLake.GLib.GSourceHandle source, int fd, MentorLake.GLib.GIOCondition events)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		return GSourceExterns.g_source_add_unix_fd(source, fd, events);
	}

/// <summary>
/// <para>
/// Adds a [struct@GLib.Source] to a @context so that it will be executed within
/// that context. Remove it by calling [method@GLib.Source.destroy].
/// </para>
/// <para>
/// This function is safe to call from any thread, regardless of which thread
/// the @context is running in.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <return>
/// the ID (greater than 0) for the source within the
///   #GMainContext.
/// </return>

	public static uint Attach(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GMainContextHandle context)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		return GSourceExterns.g_source_attach(source, context);
	}

/// <summary>
/// <para>
/// Removes a source from its [struct@GLib.MainContext], if any, and mark it as
/// destroyed.  The source cannot be subsequently added to another
/// context. It is safe to call this on sources which have already been
/// removed from their context.
/// </para>
/// <para>
/// This does not unref the [struct@GLib.Source]: if you still hold a reference,
/// use [method@GLib.Source.unref] to drop it.
/// </para>
/// <para>
/// This function is safe to call from any thread, regardless of which thread
/// the [struct@GLib.MainContext] is running in.
/// </para>
/// <para>
/// If the source is currently attached to a [struct@GLib.MainContext],
/// destroying it will effectively unset the callback similar to calling
/// [method@GLib.Source.set_callback]. This can mean, that the data's
/// #GDestroyNotify gets called right away.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>

	public static void Destroy(this MentorLake.GLib.GSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_destroy(source);
	}

/// <summary>
/// <para>
/// Checks whether a source is allowed to be called recursively.
/// see [method@GLib.Source.set_can_recurse].
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <return>
/// whether recursion is allowed.
/// </return>

	public static bool GetCanRecurse(this MentorLake.GLib.GSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		return GSourceExterns.g_source_get_can_recurse(source);
	}

/// <summary>
/// <para>
/// Gets the [struct@GLib.MainContext] with which the source is associated.
/// </para>
/// <para>
/// You can call this on a source that has been destroyed, provided
/// that the [struct@GLib.MainContext] it was attached to still exists (in which
/// case it will return that [struct@GLib.MainContext]). In particular, you can
/// always call this function on the source returned from
/// [func@GLib.main_current_source]. But calling this function on a source
/// whose [struct@GLib.MainContext] has been destroyed is an error.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <return>
/// the #GMainContext with which the
///               source is associated, or %NULL if the context has not
///               yet been added to a source.
/// </return>

	public static MentorLake.GLib.GMainContextHandle GetContext(this MentorLake.GLib.GSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		return GSourceExterns.g_source_get_context(source);
	}

/// <summary>
/// <para>
/// This function ignores @source and is otherwise the same as
/// [func@GLib.get_current_time].
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="timeval">
/// #GTimeVal structure in which to store current time.
/// </param>

	public static void GetCurrentTime(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GTimeValHandle timeval)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_get_current_time(source, timeval);
	}

/// <summary>
/// <para>
/// Returns the numeric ID for a particular source. The ID of a source
/// is a positive integer which is unique within a particular main loop
/// context. The reverse mapping from ID to source is done by
/// [method@GLib.MainContext.find_source_by_id].
/// </para>
/// <para>
/// You can only call this function while the source is associated to a
/// [struct@GLib.MainContext] instance; calling this function before
/// [method@GLib.Source.attach] or after [method@GLib.Source.destroy] yields
/// undefined behavior. The ID returned is unique within the
/// [struct@GLib.MainContext] instance passed to [method@GLib.Source.attach].
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <return>
/// the ID (greater than 0) for the source
/// </return>

	public static uint GetId(this MentorLake.GLib.GSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		return GSourceExterns.g_source_get_id(source);
	}

/// <summary>
/// <para>
/// Gets a name for the source, used in debugging and profiling.  The
/// name may be #NULL if it has never been set with [method@GLib.Source.set_name].
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <return>
/// the name of the source
/// </return>

	public static string GetName(this MentorLake.GLib.GSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		return GSourceExterns.g_source_get_name(source);
	}

/// <summary>
/// <para>
/// Gets the priority of a source.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <return>
/// the priority of the source
/// </return>

	public static int GetPriority(this MentorLake.GLib.GSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		return GSourceExterns.g_source_get_priority(source);
	}

/// <summary>
/// <para>
/// Gets the "ready time" of @source, as set by
/// [method@GLib.Source.set_ready_time].
/// </para>
/// <para>
/// Any time before or equal to the current monotonic time (including 0)
/// is an indication that the source will fire immediately.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <return>
/// the monotonic ready time, -1 for "never"
/// </return>

	public static long GetReadyTime(this MentorLake.GLib.GSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		return GSourceExterns.g_source_get_ready_time(source);
	}

/// <summary>
/// <para>
/// Gets the time to be used when checking this source. The advantage of
/// calling this function over calling [func@GLib.get_monotonic_time] directly is
/// that when checking multiple sources, GLib can cache a single value
/// instead of having to repeatedly get the system monotonic time.
/// </para>
/// <para>
/// The time here is the system monotonic time, if available, or some
/// other reasonable alternative otherwise.  See [func@GLib.get_monotonic_time].
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <return>
/// the monotonic time in microseconds
/// </return>

	public static long GetTime(this MentorLake.GLib.GSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		return GSourceExterns.g_source_get_time(source);
	}

/// <summary>
/// <para>
/// Returns whether @source has been destroyed.
/// </para>
/// <para>
/// This is important when you operate upon your objects
/// from within idle handlers, but may have freed the object
/// before the dispatch of your idle handler.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static gboolean
/// idle_callback (gpointer data)
/// {
///   SomeWidget *self = data;
/// </para>
/// <para>
///   g_mutex_lock (&self->idle_id_mutex);
///   // do stuff with self
///   self->idle_id = 0;
///   g_mutex_unlock (&self->idle_id_mutex);
/// </para>
/// <para>
///   return G_SOURCE_REMOVE;
/// }
/// </para>
/// <para>
/// static void
/// some_widget_do_stuff_later (SomeWidget *self)
/// {
///   g_mutex_lock (&self->idle_id_mutex);
///   self->idle_id = g_idle_add (idle_callback, self);
///   g_mutex_unlock (&self->idle_id_mutex);
/// }
/// </para>
/// <para>
/// static void
/// some_widget_init (SomeWidget *self)
/// {
///   g_mutex_init (&self->idle_id_mutex);
/// </para>
/// <para>
///   // ...
/// }
/// </para>
/// <para>
/// static void
/// some_widget_finalize (GObject *object)
/// {
///   SomeWidget *self = SOME_WIDGET (object);
/// </para>
/// <para>
///   if (self->idle_id)
///     g_source_remove (self->idle_id);
/// </para>
/// <para>
///   g_mutex_clear (&self->idle_id_mutex);
/// </para>
/// <para>
///   G_OBJECT_CLASS (parent_class)->finalize (object);
/// }
/// ]|
/// </para>
/// <para>
/// This will fail in a multi-threaded application if the
/// widget is destroyed before the idle handler fires due
/// to the use after free in the callback. A solution, to
/// this particular problem, is to check to if the source
/// has already been destroy within the callback.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static gboolean
/// idle_callback (gpointer data)
/// {
///   SomeWidget *self = data;
/// </para>
/// <para>
///   g_mutex_lock (&self->idle_id_mutex);
///   if (!g_source_is_destroyed (g_main_current_source ()))
///     {
///       // do stuff with self
///     }
///   g_mutex_unlock (&self->idle_id_mutex);
/// </para>
/// <para>
///   return FALSE;
/// }
/// ]|
/// </para>
/// <para>
/// Calls to this function from a thread other than the one acquired by the
/// [struct@GLib.MainContext] the #GSource is attached to are typically
/// redundant, as the source could be destroyed immediately after this function
/// returns. However, once a source is destroyed it cannot be un-destroyed, so
/// this function can be used for opportunistic checks from any thread.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <return>
/// %TRUE if the source has been destroyed
/// </return>

	public static bool IsDestroyed(this MentorLake.GLib.GSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		return GSourceExterns.g_source_is_destroyed(source);
	}

/// <summary>
/// <para>
/// Updates the event mask to watch for the fd identified by @tag.
/// </para>
/// <para>
/// @tag is the tag returned from [method@GLib.Source.add_unix_fd].
/// </para>
/// <para>
/// If you want to remove a fd, don't set its event mask to zero.
/// Instead, call [method@GLib.Source.remove_unix_fd].
/// </para>
/// <para>
/// This API is only intended to be used by implementations of #GSource.
/// Do not call this API on a #GSource that you did not create.
/// </para>
/// <para>
/// As the name suggests, this function is not available on Windows.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="tag">
/// the tag from [method@GLib.Source.add_unix_fd]
/// </param>
/// <param name="new_events">
/// the new event mask to watch
/// </param>

	public static void ModifyUnixFd(this MentorLake.GLib.GSourceHandle source, IntPtr tag, MentorLake.GLib.GIOCondition new_events)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_modify_unix_fd(source, tag, new_events);
	}

/// <summary>
/// <para>
/// Queries the events reported for the fd corresponding to @tag on
/// @source during the last poll.
/// </para>
/// <para>
/// The return value of this function is only defined when the function
/// is called from the check or dispatch functions for @source.
/// </para>
/// <para>
/// This API is only intended to be used by implementations of #GSource.
/// Do not call this API on a #GSource that you did not create.
/// </para>
/// <para>
/// As the name suggests, this function is not available on Windows.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="tag">
/// the tag from [method@GLib.Source.add_unix_fd]
/// </param>
/// <return>
/// the conditions reported on the fd
/// </return>

	public static MentorLake.GLib.GIOCondition QueryUnixFd(this MentorLake.GLib.GSourceHandle source, IntPtr tag)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		return GSourceExterns.g_source_query_unix_fd(source, tag);
	}

/// <summary>
/// <para>
/// Increases the reference count on a source by one.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <return>
/// @source
/// </return>

	public static MentorLake.GLib.GSourceHandle Ref(this MentorLake.GLib.GSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		return GSourceExterns.g_source_ref(source);
	}

/// <summary>
/// <para>
/// Detaches @child_source from @source and destroys it.
/// </para>
/// <para>
/// This API is only intended to be used by implementations of #GSource.
/// Do not call this API on a #GSource that you did not create.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="child_source">
/// a #GSource previously passed to
///     [method@GLib.Source.add_child_source].
/// </param>

	public static void RemoveChildSource(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceHandle child_source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_remove_child_source(source, child_source);
	}

/// <summary>
/// <para>
/// Removes a file descriptor from the set of file descriptors polled for
/// this source.
/// </para>
/// <para>
/// This API is only intended to be used by implementations of [struct@GLib.Source].
/// Do not call this API on a [struct@GLib.Source] that you did not create.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="fd">
/// a #GPollFD structure previously passed to [method@GLib.Source.add_poll].
/// </param>

	public static void RemovePoll(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GPollFDHandle fd)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_remove_poll(source, fd);
	}

/// <summary>
/// <para>
/// Reverses the effect of a previous call to [method@GLib.Source.add_unix_fd].
/// </para>
/// <para>
/// You only need to call this if you want to remove an fd from being
/// watched while keeping the same source around.  In the normal case you
/// will just want to destroy the source.
/// </para>
/// <para>
/// This API is only intended to be used by implementations of #GSource.
/// Do not call this API on a #GSource that you did not create.
/// </para>
/// <para>
/// As the name suggests, this function is not available on Windows.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="tag">
/// the tag from [method@GLib.Source.add_unix_fd]
/// </param>

	public static void RemoveUnixFd(this MentorLake.GLib.GSourceHandle source, IntPtr tag)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_remove_unix_fd(source, tag);
	}

/// <summary>
/// <para>
/// Sets the callback function for a source. The callback for a source is
/// called from the source's dispatch function.
/// </para>
/// <para>
/// The exact type of @func depends on the type of source; ie. you
/// should not count on @func being called with @data as its first
/// parameter. Cast @func with [func@GLib.SOURCE_FUNC] to avoid warnings about
/// incompatible function types.
/// </para>
/// <para>
/// See [mainloop memory management](main-loop.html#memory-management-of-sources) for details
/// on how to handle memory management of @data.
/// </para>
/// <para>
/// Typically, you won't use this function. Instead use functions specific
/// to the type of source you are using, such as [func@GLib.idle_add] or
/// [func@GLib.timeout_add].
/// </para>
/// <para>
/// It is safe to call this function multiple times on a source which has already
/// been attached to a context. The changes will take effect for the next time
/// the source is dispatched after this call returns.
/// </para>
/// <para>
/// Note that [method@GLib.Source.destroy] for a currently attached source has the effect
/// of also unsetting the callback.
/// </para>
/// </summary>

/// <param name="source">
/// the source
/// </param>
/// <param name="func">
/// a callback function
/// </param>
/// <param name="data">
/// the data to pass to callback function
/// </param>
/// <param name="notify">
/// a function to call when @data is no longer in use, or %NULL.
/// </param>

	public static void SetCallback(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_set_callback(source, func, data, notify);
	}

/// <summary>
/// <para>
/// Sets the callback function storing the data as a refcounted callback
/// "object". This is used internally. Note that calling
/// [method@GLib.Source.set_callback_indirect] assumes
/// an initial reference count on @callback_data, and thus
/// @callback_funcs->unref will eventually be called once more
/// than @callback_funcs->ref.
/// </para>
/// <para>
/// It is safe to call this function multiple times on a source which has already
/// been attached to a context. The changes will take effect for the next time
/// the source is dispatched after this call returns.
/// </para>
/// </summary>

/// <param name="source">
/// the source
/// </param>
/// <param name="callback_data">
/// pointer to callback data "object"
/// </param>
/// <param name="callback_funcs">
/// functions for reference counting @callback_data
///                  and getting the callback and data
/// </param>

	public static void SetCallbackIndirect(this MentorLake.GLib.GSourceHandle source, IntPtr callback_data, MentorLake.GLib.GSourceCallbackFuncsHandle callback_funcs)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_set_callback_indirect(source, callback_data, callback_funcs);
	}

/// <summary>
/// <para>
/// Sets whether a source can be called recursively. If @can_recurse is
/// %TRUE, then while the source is being dispatched then this source
/// will be processed normally. Otherwise, all processing of this
/// source is blocked until the dispatch function returns.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="can_recurse">
/// whether recursion is allowed for this source
/// </param>

	public static void SetCanRecurse(this MentorLake.GLib.GSourceHandle source, bool can_recurse)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_set_can_recurse(source, can_recurse);
	}

/// <summary>
/// <para>
/// Set @dispose as dispose function on @source. @dispose will be called once
/// the reference count of @source reaches 0 but before any of the state of the
/// source is freed, especially before the finalize function is called.
/// </para>
/// <para>
/// This means that at this point @source is still a valid [struct@GLib.Source]
/// and it is allow for the reference count to increase again until @dispose
/// returns.
/// </para>
/// <para>
/// The dispose function can be used to clear any "weak" references to the
/// @source in other data structures in a thread-safe way where it is possible
/// for another thread to increase the reference count of @source again while
/// it is being freed.
/// </para>
/// <para>
/// The finalize function can not be used for this purpose as at that point
/// @source is already partially freed and not valid anymore.
/// </para>
/// <para>
/// This should only ever be called from #GSource implementations.
/// </para>
/// </summary>

/// <param name="source">
/// A #GSource to set the dispose function on
/// </param>
/// <param name="dispose">
/// #GSourceDisposeFunc to set on the source
/// </param>

	public static void SetDisposeFunction(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceDisposeFunc dispose)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_set_dispose_function(source, dispose);
	}

/// <summary>
/// <para>
/// Sets the source functions (can be used to override
/// default implementations) of an unattached source.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="funcs">
/// the new #GSourceFuncs
/// </param>

	public static void SetFuncs(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceFuncsHandle funcs)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_set_funcs(source, funcs);
	}

/// <summary>
/// <para>
/// Sets a name for the source, used in debugging and profiling.
/// The name defaults to #NULL.
/// </para>
/// <para>
/// The source name should describe in a human-readable way
/// what the source does. For example, "X11 event queue"
/// or "GTK repaint idle handler" or whatever it is.
/// </para>
/// <para>
/// It is permitted to call this function multiple times, but is not
/// recommended due to the potential performance impact.  For example,
/// one could change the name in the "check" function of a #GSourceFuncs
/// to include details like the event type in the source name.
/// </para>
/// <para>
/// Use caution if changing the name while another thread may be
/// accessing it with [method@GLib.Source.get_name]; that function does not copy
/// the value, and changing the value will free it while the other thread
/// may be attempting to use it.
/// </para>
/// <para>
/// Also see [method@GLib.Source.set_static_name].
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="name">
/// debug name for the source
/// </param>

	public static void SetName(this MentorLake.GLib.GSourceHandle source, string name)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_set_name(source, name);
	}

/// <summary>
/// <para>
/// Sets the priority of a source. While the main loop is being run, a
/// source will be dispatched if it is ready to be dispatched and no
/// sources at a higher (numerically smaller) priority are ready to be
/// dispatched.
/// </para>
/// <para>
/// A child source always has the same priority as its parent.  It is not
/// permitted to change the priority of a source once it has been added
/// as a child of another source.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="priority">
/// the new priority.
/// </param>

	public static void SetPriority(this MentorLake.GLib.GSourceHandle source, int priority)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_set_priority(source, priority);
	}

/// <summary>
/// <para>
/// Sets a #GSource to be dispatched when the given monotonic time is
/// reached (or passed).  If the monotonic time is in the past (as it
/// always will be if @ready_time is 0) then the source will be
/// dispatched immediately.
/// </para>
/// <para>
/// If @ready_time is -1 then the source is never woken up on the basis
/// of the passage of time.
/// </para>
/// <para>
/// Dispatching the source does not reset the ready time.  You should do
/// so yourself, from the source dispatch function.
/// </para>
/// <para>
/// Note that if you have a pair of sources where the ready time of one
/// suggests that it will be delivered first but the priority for the
/// other suggests that it would be delivered first, and the ready time
/// for both sources is reached during the same main context iteration,
/// then the order of dispatch is undefined.
/// </para>
/// <para>
/// It is a no-op to call this function on a #GSource which has already been
/// destroyed with [method@GLib.Source.destroy].
/// </para>
/// <para>
/// This API is only intended to be used by implementations of #GSource.
/// Do not call this API on a #GSource that you did not create.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="ready_time">
/// the monotonic time at which the source will be ready,
///              0 for "immediately", -1 for "never"
/// </param>

	public static void SetReadyTime(this MentorLake.GLib.GSourceHandle source, long ready_time)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_set_ready_time(source, ready_time);
	}

/// <summary>
/// <para>
/// A variant of [method@GLib.Source.set_name] that does not
/// duplicate the @name, and can only be used with
/// string literals.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>
/// <param name="name">
/// debug name for the source
/// </param>

	public static void SetStaticName(this MentorLake.GLib.GSourceHandle source, string name)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_set_static_name(source, name);
	}

/// <summary>
/// <para>
/// Decreases the reference count of a source by one. If the
/// resulting reference count is zero the source and associated
/// memory will be destroyed.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSource
/// </param>

	public static void Unref(this MentorLake.GLib.GSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSource)");
		GSourceExterns.g_source_unref(source);
	}


	public static GSource Dereference(this GSourceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSource>(x.DangerousGetHandle());
}
internal class GSourceExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_source_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceFuncsHandle>))] MentorLake.GLib.GSourceFuncsHandle source_funcs, uint struct_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_add_child_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle child_source);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_add_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_source_add_unix_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, int fd, MentorLake.GLib.GIOCondition events);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_source_attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_get_can_recurse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))]
	internal static extern MentorLake.GLib.GMainContextHandle g_source_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_get_current_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle timeval);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_source_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_source_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_source_get_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_source_get_ready_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_source_get_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_is_destroyed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_modify_unix_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, IntPtr tag, MentorLake.GLib.GIOCondition new_events);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOCondition g_source_query_unix_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, IntPtr tag);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_source_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_remove_child_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle child_source);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_remove_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_remove_unix_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, IntPtr tag);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_callback_indirect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, IntPtr callback_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceCallbackFuncsHandle>))] MentorLake.GLib.GSourceCallbackFuncsHandle callback_funcs);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_can_recurse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, bool can_recurse);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_dispose_function([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceDisposeFunc dispose);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_funcs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceFuncsHandle>))] MentorLake.GLib.GSourceFuncsHandle funcs);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, string name);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, int priority);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_ready_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, long ready_time);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_static_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, string name);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_remove(uint tag);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_remove_by_funcs_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceFuncsHandle>))] MentorLake.GLib.GSourceFuncsHandle funcs, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_remove_by_user_data(IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_name_by_id(uint tag, string name);

}

/// <summary>
/// <para>
/// The `GSource` struct is an opaque data type
/// representing an event source.
/// </para>
/// </summary>

public struct GSource
{
/// <summary>
/// <para>
/// Removes the source with the given ID from the default main context. You must
/// use [method@GLib.Source.destroy] for sources added to a non-default main context.
/// </para>
/// <para>
/// The ID of a #GSource is given by [method@GLib.Source.get_id], or will be
/// returned by the functions [method@GLib.Source.attach], [func@GLib.idle_add],
/// [func@GLib.idle_add_full], [func@GLib.timeout_add],
/// [func@GLib.timeout_add_full], [func@GLib.child_watch_add],
/// [func@GLib.child_watch_add_full], [func@GLib.io_add_watch], and
/// [func@GLib.io_add_watch_full].
/// </para>
/// <para>
/// It is a programmer error to attempt to remove a non-existent source.
/// </para>
/// <para>
/// More specifically: source IDs can be reissued after a source has been
/// destroyed and therefore it is never valid to use this function with a
/// source ID which may have already been removed.  An example is when
/// scheduling an idle to run in another thread with [func@GLib.idle_add]: the
/// idle may already have run and been removed by the time this function
/// is called on its (now invalid) source ID.  This source ID may have
/// been reissued, leading to the operation being performed against the
/// wrong source.
/// </para>
/// </summary>

/// <param name="tag">
/// the ID of the source to remove.
/// </param>
/// <return>
/// %TRUE if the source was found and removed.
/// </return>

	public static bool Remove(uint tag)
	{
		return GSourceExterns.g_source_remove(tag);
	}

/// <summary>
/// <para>
/// Removes a source from the default main loop context given the
/// source functions and user data. If multiple sources exist with the
/// same source functions and user data, only one will be destroyed.
/// </para>
/// </summary>

/// <param name="funcs">
/// The @source_funcs passed to [ctor@GLib.Source.new]
/// </param>
/// <param name="user_data">
/// the user data for the callback
/// </param>
/// <return>
/// %TRUE if a source was found and removed.
/// </return>

	public static bool RemoveByFuncsUserData(MentorLake.GLib.GSourceFuncsHandle funcs, IntPtr user_data)
	{
		return GSourceExterns.g_source_remove_by_funcs_user_data(funcs, user_data);
	}

/// <summary>
/// <para>
/// Removes a source from the default main loop context given the user
/// data for the callback. If multiple sources exist with the same user
/// data, only one will be destroyed.
/// </para>
/// </summary>

/// <param name="user_data">
/// the user_data for the callback.
/// </param>
/// <return>
/// %TRUE if a source was found and removed.
/// </return>

	public static bool RemoveByUserData(IntPtr user_data)
	{
		return GSourceExterns.g_source_remove_by_user_data(user_data);
	}

/// <summary>
/// <para>
/// Sets the name of a source using its ID.
/// </para>
/// <para>
/// This is a convenience utility to set source names from the return
/// value of [func@GLib.idle_add], [func@GLib.timeout_add], etc.
/// </para>
/// <para>
/// It is a programmer error to attempt to set the name of a non-existent
/// source.
/// </para>
/// <para>
/// More specifically: source IDs can be reissued after a source has been
/// destroyed and therefore it is never valid to use this function with a
/// source ID which may have already been removed.  An example is when
/// scheduling an idle to run in another thread with [func@GLib.idle_add]: the
/// idle may already have run and been removed by the time this function
/// is called on its (now invalid) source ID.  This source ID may have
/// been reissued, leading to the operation being performed against the
/// wrong source.
/// </para>
/// </summary>

/// <param name="tag">
/// a #GSource ID
/// </param>
/// <param name="name">
/// debug name for the source
/// </param>

	public static void SetNameById(uint tag, string name)
	{
		GSourceExterns.g_source_set_name_by_id(tag, name);
	}

}
