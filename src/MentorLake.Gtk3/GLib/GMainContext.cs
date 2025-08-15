namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The `GMainContext` struct is an opaque data
/// type representing a set of sources to be handled in a main loop.
/// </para>
/// </summary>

public class GMainContextHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new [struct@GLib.MainContext] structure.
/// </para>
/// </summary>

/// <return>
/// the new #GMainContext
/// </return>

	public static MentorLake.GLib.GMainContextHandle New()
	{
		return GMainContextExterns.g_main_context_new();
	}

/// <summary>
/// <para>
/// Creates a new [struct@GLib.MainContext] structure.
/// </para>
/// </summary>

/// <param name="flags">
/// a bitwise-OR combination of #GMainContextFlags flags that can only be
///         set at creation time.
/// </param>
/// <return>
/// the new #GMainContext
/// </return>

	public static MentorLake.GLib.GMainContextHandle NewWithFlags(MentorLake.GLib.GMainContextFlags flags)
	{
		return GMainContextExterns.g_main_context_new_with_flags(flags);
	}

}


public static class GMainContextExtensions
{
/// <summary>
/// <para>
/// Tries to become the owner of the specified context.
/// If some other thread is the owner of the context,
/// returns %FALSE immediately. Ownership is properly
/// recursive: the owner can require ownership again
/// and will release ownership when [method@GLib.MainContext.release]
/// is called as many times as [method@GLib.MainContext.acquire].
/// </para>
/// <para>
/// You must be the owner of a context before you
/// can call [method@GLib.MainContext.prepare], [method@GLib.MainContext.query],
/// [method@GLib.MainContext.check], [method@GLib.MainContext.dispatch],
/// [method@GLib.MainContext.release].
/// </para>
/// <para>
/// Since 2.76 @context can be %NULL to use the global-default
/// main context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <return>
/// %TRUE if the operation succeeded, and
///   this thread is now the owner of @context.
/// </return>

	public static bool Acquire(this MentorLake.GLib.GMainContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_acquire(context);
	}

/// <summary>
/// <para>
/// Adds a file descriptor to the set of file descriptors polled for
/// this context. This will very seldom be used directly. Instead
/// a typical event source will use `g_source_add_unix_fd` instead.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (or %NULL for the global-default
///   main context)
/// </param>
/// <param name="fd">
/// a #GPollFD structure holding information about a file
///      descriptor to watch.
/// </param>
/// <param name="priority">
/// the priority for this file descriptor which should be
///      the same as the priority used for [method@GLib.Source.attach] to ensure
///      that the file descriptor is polled whenever the results may be needed.
/// </param>

	public static void AddPoll(this MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GPollFDHandle fd, int priority)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		GMainContextExterns.g_main_context_add_poll(context, fd, priority);
	}

/// <summary>
/// <para>
/// Passes the results of polling back to the main loop. You should be
/// careful to pass @fds and its length @n_fds as received from
/// [method@GLib.MainContext.query], as this functions relies on assumptions
/// on how @fds is filled.
/// </para>
/// <para>
/// You must have successfully acquired the context with
/// [method@GLib.MainContext.acquire] before you may call this function.
/// </para>
/// <para>
/// Since 2.76 @context can be %NULL to use the global-default
/// main context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <param name="max_priority">
/// the maximum numerical priority of sources to check
/// </param>
/// <param name="fds">
/// array of #GPollFD&apos;s that was passed to
///       the last call to [method@GLib.MainContext.query]
/// </param>
/// <param name="n_fds">
/// return value of [method@GLib.MainContext.query]
/// </param>
/// <return>
/// %TRUE if some sources are ready to be dispatched.
/// </return>

	public static bool Check(this MentorLake.GLib.GMainContextHandle context, int max_priority, MentorLake.GLib.GPollFD[] fds, int n_fds)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_check(context, max_priority, fds, n_fds);
	}

/// <summary>
/// <para>
/// Dispatches all pending sources.
/// </para>
/// <para>
/// You must have successfully acquired the context with
/// [method@GLib.MainContext.acquire] before you may call this function.
/// </para>
/// <para>
/// Since 2.76 @context can be %NULL to use the global-default
/// main context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>

	public static void Dispatch(this MentorLake.GLib.GMainContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		GMainContextExterns.g_main_context_dispatch(context);
	}

/// <summary>
/// <para>
/// Finds a source with the given source functions and user data.  If
/// multiple sources exist with the same source function and user data,
/// the first one found will be returned.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used).
/// </param>
/// <param name="funcs">
/// the @source_funcs passed to [ctor@GLib.Source.new].
/// </param>
/// <param name="user_data">
/// the user data from the callback.
/// </param>
/// <return>
/// the source, if one was found, otherwise %NULL
/// </return>

	public static MentorLake.GLib.GSourceHandle FindSourceByFuncsUserData(this MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GSourceFuncsHandle funcs, IntPtr user_data)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_find_source_by_funcs_user_data(context, funcs, user_data);
	}

/// <summary>
/// <para>
/// Finds a #GSource given a pair of context and ID.
/// </para>
/// <para>
/// It is a programmer error to attempt to look up a non-existent source.
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

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <param name="source_id">
/// the source ID, as returned by [method@GLib.Source.get_id].
/// </param>
/// <return>
/// the #GSource
/// </return>

	public static MentorLake.GLib.GSourceHandle FindSourceById(this MentorLake.GLib.GMainContextHandle context, uint source_id)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_find_source_by_id(context, source_id);
	}

/// <summary>
/// <para>
/// Finds a source with the given user data for the callback.  If
/// multiple sources exist with the same user data, the first
/// one found will be returned.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <param name="user_data">
/// the user_data for the callback.
/// </param>
/// <return>
/// the source, if one was found, otherwise %NULL
/// </return>

	public static MentorLake.GLib.GSourceHandle FindSourceByUserData(this MentorLake.GLib.GMainContextHandle context, IntPtr user_data)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_find_source_by_user_data(context, user_data);
	}

/// <summary>
/// <para>
/// Gets the poll function set by [method@GLib.MainContext.set_poll_func].
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <return>
/// the poll function
/// </return>

	public static MentorLake.GLib.GPollFunc GetPollFunc(this MentorLake.GLib.GMainContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_get_poll_func(context);
	}

/// <summary>
/// <para>
/// Invokes a function in such a way that @context is owned during the
/// invocation of @function.
/// </para>
/// <para>
/// If @context is %NULL then the global-default main context — as
/// returned by [func@GLib.MainContext.default] — is used.
/// </para>
/// <para>
/// If @context is owned by the current thread, @function is called
/// directly.  Otherwise, if @context is the thread-default main context
/// of the current thread and [method@GLib.MainContext.acquire] succeeds, then
/// @function is called and [method@GLib.MainContext.release] is called
/// afterwards.
/// </para>
/// <para>
/// In any other case, an idle source is created to call @function and
/// that source is attached to @context (presumably to be run in another
/// thread).  The idle source is attached with [const@GLib.PRIORITY_DEFAULT]
/// priority.  If you want a different priority, use
/// [method@GLib.MainContext.invoke_full].
/// </para>
/// <para>
/// Note that, as with normal idle functions, @function should probably
/// return %FALSE.  If it returns %TRUE, it will be continuously run in a
/// loop (and may prevent this call from returning).
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext, or %NULL for the global-default
///   main context
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>

	public static void Invoke(this MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		GMainContextExterns.g_main_context_invoke(context, function, data);
	}

/// <summary>
/// <para>
/// Invokes a function in such a way that @context is owned during the
/// invocation of @function.
/// </para>
/// <para>
/// This function is the same as [method@GLib.MainContext.invoke] except that it
/// lets you specify the priority in case @function ends up being
/// scheduled as an idle and also lets you give a #GDestroyNotify for @data.
/// </para>
/// <para>
/// @notify should not assume that it is called from any particular
/// thread or with any particular context acquired.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext, or %NULL for the global-default
///   main context
/// </param>
/// <param name="priority">
/// the priority at which to run @function
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <param name="notify">
/// a function to call when @data is no longer in use, or %NULL.
/// </param>

	public static void InvokeFull(this MentorLake.GLib.GMainContextHandle context, int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		GMainContextExterns.g_main_context_invoke_full(context, priority, function, data, notify);
	}

/// <summary>
/// <para>
/// Determines whether this thread holds the (recursive)
/// ownership of this [struct@GLib.MainContext]. This is useful to
/// know before waiting on another thread that may be
/// blocking to get ownership of @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <return>
/// %TRUE if current thread is owner of @context.
/// </return>

	public static bool IsOwner(this MentorLake.GLib.GMainContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_is_owner(context);
	}

/// <summary>
/// <para>
/// Runs a single iteration for the given main loop. This involves
/// checking to see if any event sources are ready to be processed,
/// then if no events sources are ready and @may_block is %TRUE, waiting
/// for a source to become ready, then dispatching the highest priority
/// events sources that are ready. Otherwise, if @may_block is %FALSE
/// sources are not waited to become ready, only those highest priority
/// events sources will be dispatched (if any), that are ready at this
/// given moment without further waiting.
/// </para>
/// <para>
/// Note that even when @may_block is %TRUE, it is still possible for
/// [method@GLib.MainContext.iteration] to return %FALSE, since the wait may
/// be interrupted for other reasons than an event source becoming ready.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <param name="may_block">
/// whether the call may block.
/// </param>
/// <return>
/// %TRUE if events were dispatched.
/// </return>

	public static bool Iteration(this MentorLake.GLib.GMainContextHandle context, bool may_block)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_iteration(context, may_block);
	}

/// <summary>
/// <para>
/// Checks if any sources have pending events for the given context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <return>
/// %TRUE if events are pending.
/// </return>

	public static bool Pending(this MentorLake.GLib.GMainContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_pending(context);
	}

/// <summary>
/// <para>
/// Pops @context off the thread-default context stack (verifying that
/// it was on the top of the stack).
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext, or %NULL for the global-default
///   main context
/// </param>

	public static void PopThreadDefault(this MentorLake.GLib.GMainContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		GMainContextExterns.g_main_context_pop_thread_default(context);
	}

/// <summary>
/// <para>
/// Prepares to poll sources within a main loop. The resulting information
/// for polling is determined by calling [method@GLib.MainContext.query].
/// </para>
/// <para>
/// You must have successfully acquired the context with
/// [method@GLib.MainContext.acquire] before you may call this function.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <param name="priority">
/// location to store priority of highest priority
///            source already ready.
/// </param>
/// <return>
/// %TRUE if some source is ready to be dispatched
///               prior to polling.
/// </return>

	public static bool Prepare(this MentorLake.GLib.GMainContextHandle context, out int priority)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_prepare(context, out priority);
	}

/// <summary>
/// <para>
/// Acquires @context and sets it as the thread-default context for the
/// current thread. This will cause certain asynchronous operations
/// (such as most [gio][gio]-based I/O) which are
/// started in this thread to run under @context and deliver their
/// results to its main loop, rather than running under the global
/// default main context in the main thread. Note that calling this function
/// changes the context returned by [func@GLib.MainContext.get_thread_default],
/// not the one returned by [func@GLib.MainContext.default], so it does not
/// affect the context used by functions like [func@GLib.idle_add].
/// </para>
/// <para>
/// Normally you would call this function shortly after creating a new
/// thread, passing it a [struct@GLib.MainContext] which will be run by a
/// [struct@GLib.MainLoop] in that thread, to set a new default context for all
/// async operations in that thread. In this case you may not need to
/// ever call [method@GLib.MainContext.pop_thread_default], assuming you want
/// the new [struct@GLib.MainContext] to be the default for the whole lifecycle
/// of the thread.
/// </para>
/// <para>
/// If you don&apos;t have control over how the new thread was created (e.g.
/// in the new thread isn&apos;t newly created, or if the thread life
/// cycle is managed by a #GThreadPool), it is always suggested to wrap
/// the logic that needs to use the new [struct@GLib.MainContext] inside a
/// [method@GLib.MainContext.push_thread_default] /
/// [method@GLib.MainContext.pop_thread_default] pair, otherwise threads that
/// are re-used will end up never explicitly releasing the
/// [struct@GLib.MainContext] reference they hold.
/// </para>
/// <para>
/// In some cases you may want to schedule a single operation in a
/// non-default context, or temporarily use a non-default context in
/// the main thread. In that case, you can wrap the call to the
/// asynchronous operation inside a
/// [method@GLib.MainContext.push_thread_default] /
/// [method@GLib.MainContext.pop_thread_default] pair, but it is up to you to
/// ensure that no other asynchronous operations accidentally get
/// started while the non-default context is active.
/// </para>
/// <para>
/// Beware that libraries that predate this function may not correctly
/// handle being used from a thread with a thread-default context. Eg,
/// see g_file_supports_thread_contexts().
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext, or %NULL for the global-default
///   main context
/// </param>

	public static void PushThreadDefault(this MentorLake.GLib.GMainContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		GMainContextExterns.g_main_context_push_thread_default(context);
	}

/// <summary>
/// <para>
/// Push @main_context as the new thread-default main context for the current
/// thread, using [method@GLib.MainContext.push_thread_default], and return a
/// new [alias@GLib.MainContextPusher]. Pop with g_main_context_pusher_free().
/// Using [method@GLib.MainContext.pop_thread_default] on @main_context while a
/// [alias@GLib.MainContextPusher] exists for it can lead to undefined behaviour.
/// </para>
/// <para>
/// Using two [alias@GLib.MainContextPusher]s in the same scope is not allowed,
/// as it leads to an undefined pop order.
/// </para>
/// <para>
/// This is intended to be used with g_autoptr().  Note that g_autoptr()
/// is only available when using GCC or clang, so the following example
/// will only work with those compilers:
/// <code>
/// typedef struct
/// typedef struct
/// {
///   ...
///   GMainContext *context;
///   ...
/// } MyObject;
/// 
/// static void
/// my_object_do_stuff (MyObject *self)
/// {
///   g_autoptr(GMainContextPusher) pusher = g_main_context_pusher_new (self-&amp;gt;context);
/// 
///   // Code with main context as the thread default here
/// 
///   if (cond)
///     // No need to pop
///     return;
/// 
///   // Optionally early pop
///   g_clear_pointer (&amp;pusher, g_main_context_pusher_free);
/// 
///   // Code with main context no longer the thread default here
/// }
/// </code>
/// </para>
/// </summary>

/// <param name="main_context">
/// a main context to push
/// </param>
/// <return>
/// a #GMainContextPusher
/// </return>

	public static MentorLake.GLib.GMainContextPusherHandle PusherNew(this MentorLake.GLib.GMainContextHandle main_context)
	{
		if (main_context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_pusher_new(main_context);
	}

/// <summary>
/// <para>
/// Determines information necessary to poll this main loop. You should
/// be careful to pass the resulting @fds array and its length @n_fds
/// as is when calling [method@GLib.MainContext.check], as this function relies
/// on assumptions made when the array is filled.
/// </para>
/// <para>
/// You must have successfully acquired the context with
/// [method@GLib.MainContext.acquire] before you may call this function.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <param name="max_priority">
/// maximum priority source to check
/// </param>
/// <param name="timeout_">
/// location to store timeout to be used in polling
/// </param>
/// <param name="fds">
/// location to
///       store #GPollFD records that need to be polled.
/// </param>
/// <param name="n_fds">
/// length of @fds.
/// </param>
/// <return>
/// the number of records actually stored in @fds,
///   or, if more than @n_fds records need to be stored, the number
///   of records that need to be stored.
/// </return>

	public static int Query(this MentorLake.GLib.GMainContextHandle context, int max_priority, out int timeout_, out MentorLake.GLib.GPollFD[] fds, int n_fds)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_query(context, max_priority, out timeout_, out fds, n_fds);
	}

/// <summary>
/// <para>
/// Increases the reference count on a [struct@GLib.MainContext] object by one.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext
/// </param>
/// <return>
/// the @context that was passed in (since 2.6)
/// </return>

	public static MentorLake.GLib.GMainContextHandle Ref(this MentorLake.GLib.GMainContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_ref(context);
	}

/// <summary>
/// <para>
/// Releases ownership of a context previously acquired by this thread
/// with [method@GLib.MainContext.acquire]. If the context was acquired multiple
/// times, the ownership will be released only when [method@GLib.MainContext.release]
/// is called as many times as it was acquired.
/// </para>
/// <para>
/// You must have successfully acquired the context with
/// [method@GLib.MainContext.acquire] before you may call this function.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>

	public static void Release(this MentorLake.GLib.GMainContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		GMainContextExterns.g_main_context_release(context);
	}

/// <summary>
/// <para>
/// Removes file descriptor from the set of file descriptors to be
/// polled for a particular context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <param name="fd">
/// a #GPollFD descriptor previously added with
///   [method@GLib.MainContext.add_poll]
/// </param>

	public static void RemovePoll(this MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GPollFDHandle fd)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		GMainContextExterns.g_main_context_remove_poll(context, fd);
	}

/// <summary>
/// <para>
/// Sets the function to use to handle polling of file descriptors. It
/// will be used instead of the poll() system call
/// (or GLib&apos;s replacement function, which is used where
/// poll() isn&apos;t available).
/// </para>
/// <para>
/// This function could possibly be used to integrate the GLib event
/// loop with an external event loop.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <param name="func">
/// the function to call to poll all file descriptors
/// </param>

	public static void SetPollFunc(this MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GPollFunc func)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		GMainContextExterns.g_main_context_set_poll_func(context, func);
	}

/// <summary>
/// <para>
/// Decreases the reference count on a [struct@GLib.MainContext] object by one.
/// If
/// the result is zero, free the context and free all associated memory.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext
/// </param>

	public static void Unref(this MentorLake.GLib.GMainContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		GMainContextExterns.g_main_context_unref(context);
	}

/// <summary>
/// <para>
/// Tries to become the owner of the specified context,
/// as with [method@GLib.MainContext.acquire]. But if another thread
/// is the owner, atomically drop @mutex and wait on @cond until
/// that owner releases ownership or until @cond is signaled, then
/// try again (once) to become the owner.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>
/// <param name="cond">
/// a condition variable
/// </param>
/// <param name="mutex">
/// a mutex, currently held
/// </param>
/// <return>
/// %TRUE if the operation succeeded, and
///   this thread is now the owner of @context.
/// </return>

	public static bool Wait(this MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GCondHandle cond, MentorLake.GLib.GMutexHandle mutex)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		return GMainContextExterns.g_main_context_wait(context, cond, mutex);
	}

/// <summary>
/// <para>
/// If @context is currently blocking in [method@GLib.MainContext.iteration]
/// waiting for a source to become ready, cause it to stop blocking
/// and return.  Otherwise, cause the next invocation of
/// [method@GLib.MainContext.iteration] to return without blocking.
/// </para>
/// <para>
/// This API is useful for low-level control over [struct@GLib.MainContext]; for
/// example, integrating it with main loop implementations such as
/// [struct@GLib.MainLoop].
/// </para>
/// <para>
/// Another related use for this function is when implementing a main
/// loop with a termination condition, computed from multiple threads:
/// </para>
/// <code>
///   #define NUM_TASKS 10
///   #define NUM_TASKS 10
///   static gint tasks_remaining = NUM_TASKS;  // (atomic)
///   ...
/// 
///   while (g_atomic_int_get (&amp;tasks_remaining) != 0)
///     g_main_context_iteration (NULL, TRUE);
/// </code>
/// <para>
/// Then in a thread:
/// <code>
///   perform_work();
///   perform_work();
/// 
///   if (g_atomic_int_dec_and_test (&amp;tasks_remaining))
///     g_main_context_wakeup (NULL);
/// </code>
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext (if %NULL, the global-default
///   main context will be used)
/// </param>

	public static void Wakeup(this MentorLake.GLib.GMainContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMainContext)");
		GMainContextExterns.g_main_context_wakeup(context);
	}


	public static GMainContext Dereference(this GMainContextHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMainContext>(x.DangerousGetHandle());
}
internal class GMainContextExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_new();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_new_with_flags(MentorLake.GLib.GMainContextFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_acquire([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_add_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle fd, int priority);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, int max_priority, MentorLake.GLib.GPollFD[] fds, int n_fds);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_dispatch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_main_context_find_source_by_funcs_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceFuncsHandle>))] MentorLake.GLib.GSourceFuncsHandle funcs, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_main_context_find_source_by_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, uint source_id);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_main_context_find_source_by_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPollFunc g_main_context_get_poll_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_invoke([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GSourceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_invoke_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_is_owner([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_iteration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, bool may_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_pop_thread_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_prepare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, out int priority);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_push_thread_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextPusherHandle>))]
	internal static extern MentorLake.GLib.GMainContextPusherHandle g_main_context_pusher_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle main_context);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_main_context_query([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, int max_priority, out int timeout_, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out MentorLake.GLib.GPollFD[] fds, int n_fds);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_remove_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_set_poll_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GPollFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_wait([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCondHandle>))] MentorLake.GLib.GCondHandle cond, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_wakeup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_default();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_get_thread_default();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_pusher_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextPusherHandle>))] MentorLake.GLib.GMainContextPusherHandle pusher);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_ref_thread_default();

}

/// <summary>
/// <para>
/// The `GMainContext` struct is an opaque data
/// type representing a set of sources to be handled in a main loop.
/// </para>
/// </summary>

public struct GMainContext
{
/// <summary>
/// <para>
/// Returns the global-default main context. This is the main context
/// used for main loop functions when a main loop is not explicitly
/// specified, and corresponds to the &quot;main&quot; main loop. See also
/// [func@GLib.MainContext.get_thread_default].
/// </para>
/// </summary>

/// <return>
/// the global-default main context.
/// </return>

	public static MentorLake.GLib.GMainContextHandle Default()
	{
		return GMainContextExterns.g_main_context_default();
	}

/// <summary>
/// <para>
/// Gets the thread-default #GMainContext for this thread. Asynchronous
/// operations that want to be able to be run in contexts other than
/// the default one should call this method or
/// [func@GLib.MainContext.ref_thread_default] to get a
/// [struct@GLib.MainContext] to add their [struct@GLib.Source]s to. (Note that
/// even in single-threaded programs applications may sometimes want to
/// temporarily push a non-default context, so it is not safe to assume that
/// this will always return %NULL if you are running in the default thread.)
/// </para>
/// <para>
/// If you need to hold a reference on the context, use
/// [func@GLib.MainContext.ref_thread_default] instead.
/// </para>
/// </summary>

/// <return>
/// the thread-default #GMainContext, or
/// %NULL if the thread-default context is the global-default main context.
/// </return>

	public static MentorLake.GLib.GMainContextHandle GetThreadDefault()
	{
		return GMainContextExterns.g_main_context_get_thread_default();
	}

/// <summary>
/// <para>
/// Pop @pusher’s main context as the thread default main context.
/// See g_main_context_pusher_new() for details.
/// </para>
/// <para>
/// This will pop the [struct@GLib.MainContext] as the current thread-default
/// main context, but will not call [method@GLib.MainContext.unref] on it.
/// </para>
/// </summary>

/// <param name="pusher">
/// a #GMainContextPusher
/// </param>

	public static void PusherFree(MentorLake.GLib.GMainContextPusherHandle pusher)
	{
		GMainContextExterns.g_main_context_pusher_free(pusher);
	}

/// <summary>
/// <para>
/// Gets the thread-default [struct@GLib.MainContext] for this thread, as with
/// [func@GLib.MainContext.get_thread_default], but also adds a reference to
/// it with [method@GLib.MainContext.ref]. In addition, unlike
/// [func@GLib.MainContext.get_thread_default], if the thread-default context
/// is the global-default context, this will return that
/// [struct@GLib.MainContext] (with a ref added to it) rather than returning
/// %NULL.
/// </para>
/// </summary>

/// <return>
/// the thread-default #GMainContext. Unref
///     with [method@GLib.MainContext.unref] when you are done with it.
/// </return>

	public static MentorLake.GLib.GMainContextHandle RefThreadDefault()
	{
		return GMainContextExterns.g_main_context_ref_thread_default();
	}

}
