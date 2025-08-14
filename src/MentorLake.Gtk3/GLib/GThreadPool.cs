namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The `GThreadPool` struct represents a thread pool.
/// </para>
/// <para>
/// A thread pool is useful when you wish to asynchronously fork out the execution of work
/// and continue working in your own thread. If that will happen often, the overhead of starting
/// and destroying a thread each time might be too high. In such cases reusing already started
/// threads seems like a good idea. And it indeed is, but implementing this can be tedious
/// and error-prone.
/// </para>
/// <para>
/// Therefore GLib provides thread pools for your convenience. An added advantage is, that the
/// threads can be shared between the different subsystems of your program, when they are using GLib.
/// </para>
/// <para>
/// To create a new thread pool, you use [func@GLib.ThreadPool.new].
/// It is destroyed by [method@GLib.ThreadPool.free].
/// </para>
/// <para>
/// If you want to execute a certain task within a thread pool, use [method@GLib.ThreadPool.push].
/// </para>
/// <para>
/// To get the current number of running threads you call [method@GLib.ThreadPool.get_num_threads].
/// To get the number of still unprocessed tasks you call [method@GLib.ThreadPool.unprocessed].
/// To control the maximum number of threads for a thread pool, you use
/// [method@GLib.ThreadPool.get_max_threads]. and [method@GLib.ThreadPool.set_max_threads].
/// </para>
/// <para>
/// Finally you can control the number of unused threads, that are kept alive by GLib for future use.
/// The current number can be fetched with [func@GLib.ThreadPool.get_num_unused_threads].
/// The maximum number can be controlled by [func@GLib.ThreadPool.get_max_unused_threads] and
/// [func@GLib.ThreadPool.set_max_unused_threads]. All currently unused threads
/// can be stopped by calling [func@GLib.ThreadPool.stop_unused_threads].
/// </para>
/// </summary>

public class GThreadPoolHandle : BaseSafeHandle
{
}


public static class GThreadPoolExtensions
{
/// <summary>
/// <para>
/// Frees all resources allocated for @pool.
/// </para>
/// <para>
/// If @immediate is %TRUE, no new task is processed for @pool.
/// Otherwise @pool is not freed before the last task is processed.
/// Note however, that no thread of this pool is interrupted while
/// processing a task. Instead at least all still running threads
/// can finish their tasks before the @pool is freed.
/// </para>
/// <para>
/// If @wait_ is %TRUE, this function does not return before all
/// tasks to be processed (dependent on @immediate, whether all
/// or only the currently running) are ready.
/// Otherwise this function returns immediately.
/// </para>
/// <para>
/// After calling this function @pool must not be used anymore.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GThreadPool
/// </param>
/// <param name="immediate">
/// should @pool shut down immediately?
/// </param>
/// <param name="wait_">
/// should the function wait for all tasks to be finished?
/// </param>

	public static void Free(this MentorLake.GLib.GThreadPoolHandle pool, bool immediate, bool wait_)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GThreadPool)");
		GThreadPoolExterns.g_thread_pool_free(pool, immediate, wait_);
	}

/// <summary>
/// <para>
/// Returns the maximal number of threads for @pool.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GThreadPool
/// </param>
/// <return>
/// the maximal number of threads
/// </return>

	public static int GetMaxThreads(this MentorLake.GLib.GThreadPoolHandle pool)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GThreadPool)");
		return GThreadPoolExterns.g_thread_pool_get_max_threads(pool);
	}

/// <summary>
/// <para>
/// Returns the number of threads currently running in @pool.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GThreadPool
/// </param>
/// <return>
/// the number of threads currently running
/// </return>

	public static uint GetNumThreads(this MentorLake.GLib.GThreadPoolHandle pool)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GThreadPool)");
		return GThreadPoolExterns.g_thread_pool_get_num_threads(pool);
	}

/// <summary>
/// <para>
/// Moves the item to the front of the queue of unprocessed
/// items, so that it will be processed next.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GThreadPool
/// </param>
/// <param name="data">
/// an unprocessed item in the pool
/// </param>
/// <return>
/// %TRUE if the item was found and moved
/// </return>

	public static bool MoveToFront(this MentorLake.GLib.GThreadPoolHandle pool, IntPtr data)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GThreadPool)");
		return GThreadPoolExterns.g_thread_pool_move_to_front(pool, data);
	}

/// <summary>
/// <para>
/// Inserts @data into the list of tasks to be executed by @pool.
/// </para>
/// <para>
/// When the number of currently running threads is lower than the
/// maximal allowed number of threads, a new thread is started (or
/// reused) with the properties given to g_thread_pool_new().
/// Otherwise, @data stays in the queue until a thread in this pool
/// finishes its previous task and processes @data.
/// </para>
/// <para>
/// @error can be %NULL to ignore errors, or non-%NULL to report
/// errors. An error can only occur when a new thread couldn't be
/// created. In that case @data is simply appended to the queue of
/// work to do.
/// </para>
/// <para>
/// Before version 2.32, this function did not return a success status.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GThreadPool
/// </param>
/// <param name="data">
/// a new task for @pool
/// </param>
/// <return>
/// %TRUE on success, %FALSE if an error occurred
/// </return>

	public static bool Push(this MentorLake.GLib.GThreadPoolHandle pool, IntPtr data)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GThreadPool)");
		var externCallResult = GThreadPoolExterns.g_thread_pool_push(pool, data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the maximal allowed number of threads for @pool.
/// A value of -1 means that the maximal number of threads
/// is unlimited. If @pool is an exclusive thread pool, setting
/// the maximal number of threads to -1 is not allowed.
/// </para>
/// <para>
/// Setting @max_threads to 0 means stopping all work for @pool.
/// It is effectively frozen until @max_threads is set to a non-zero
/// value again.
/// </para>
/// <para>
/// A thread is never terminated while calling @func, as supplied by
/// g_thread_pool_new(). Instead the maximal number of threads only
/// has effect for the allocation of new threads in g_thread_pool_push().
/// A new thread is allocated, whenever the number of currently
/// running threads in @pool is smaller than the maximal number.
/// </para>
/// <para>
/// @error can be %NULL to ignore errors, or non-%NULL to report
/// errors. An error can only occur when a new thread couldn't be
/// created.
/// </para>
/// <para>
/// Before version 2.32, this function did not return a success status.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GThreadPool
/// </param>
/// <param name="max_threads">
/// a new maximal number of threads for @pool,
///     or -1 for unlimited
/// </param>
/// <return>
/// %TRUE on success, %FALSE if an error occurred
/// </return>

	public static bool SetMaxThreads(this MentorLake.GLib.GThreadPoolHandle pool, int max_threads)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GThreadPool)");
		var externCallResult = GThreadPoolExterns.g_thread_pool_set_max_threads(pool, max_threads, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the function used to sort the list of tasks. This allows the
/// tasks to be processed by a priority determined by @func, and not
/// just in the order in which they were added to the pool.
/// </para>
/// <para>
/// Note, if the maximum number of threads is more than 1, the order
/// that threads are executed cannot be guaranteed 100%. Threads are
/// scheduled by the operating system and are executed at random. It
/// cannot be assumed that threads are executed in the order they are
/// created.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GThreadPool
/// </param>
/// <param name="func">
/// the #GCompareDataFunc used to sort the list of tasks.
///     This function is passed two tasks. It should return
///     0 if the order in which they are handled does not matter,
///     a negative value if the first task should be processed before
///     the second or a positive value if the second task should be
///     processed first.
/// </param>
/// <param name="user_data">
/// user data passed to @func
/// </param>

	public static void SetSortFunction(this MentorLake.GLib.GThreadPoolHandle pool, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GThreadPool)");
		GThreadPoolExterns.g_thread_pool_set_sort_function(pool, func, user_data);
	}

/// <summary>
/// <para>
/// Returns the number of tasks still unprocessed in @pool.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GThreadPool
/// </param>
/// <return>
/// the number of unprocessed tasks
/// </return>

	public static uint Unprocessed(this MentorLake.GLib.GThreadPoolHandle pool)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GThreadPool)");
		return GThreadPoolExterns.g_thread_pool_unprocessed(pool);
	}


	public static GThreadPool Dereference(this GThreadPoolHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GThreadPool>(x.DangerousGetHandle());
}
internal class GThreadPoolExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool, bool immediate, bool wait_);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_thread_pool_get_max_threads([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_thread_pool_get_num_threads([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_thread_pool_move_to_front([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_thread_pool_push([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool, IntPtr data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_thread_pool_set_max_threads([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool, int max_threads, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_set_sort_function([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_thread_pool_unprocessed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_thread_pool_get_max_idle_time();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_thread_pool_get_max_unused_threads();

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_thread_pool_get_num_unused_threads();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))]
	internal static extern MentorLake.GLib.GThreadPoolHandle g_thread_pool_new(MentorLake.GLib.GFunc func, IntPtr user_data, int max_threads, bool exclusive, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))]
	internal static extern MentorLake.GLib.GThreadPoolHandle g_thread_pool_new_full(MentorLake.GLib.GFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify item_free_func, int max_threads, bool exclusive, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_set_max_idle_time(uint interval);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_set_max_unused_threads(int max_threads);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_stop_unused_threads();

}

/// <summary>
/// <para>
/// The `GThreadPool` struct represents a thread pool.
/// </para>
/// <para>
/// A thread pool is useful when you wish to asynchronously fork out the execution of work
/// and continue working in your own thread. If that will happen often, the overhead of starting
/// and destroying a thread each time might be too high. In such cases reusing already started
/// threads seems like a good idea. And it indeed is, but implementing this can be tedious
/// and error-prone.
/// </para>
/// <para>
/// Therefore GLib provides thread pools for your convenience. An added advantage is, that the
/// threads can be shared between the different subsystems of your program, when they are using GLib.
/// </para>
/// <para>
/// To create a new thread pool, you use [func@GLib.ThreadPool.new].
/// It is destroyed by [method@GLib.ThreadPool.free].
/// </para>
/// <para>
/// If you want to execute a certain task within a thread pool, use [method@GLib.ThreadPool.push].
/// </para>
/// <para>
/// To get the current number of running threads you call [method@GLib.ThreadPool.get_num_threads].
/// To get the number of still unprocessed tasks you call [method@GLib.ThreadPool.unprocessed].
/// To control the maximum number of threads for a thread pool, you use
/// [method@GLib.ThreadPool.get_max_threads]. and [method@GLib.ThreadPool.set_max_threads].
/// </para>
/// <para>
/// Finally you can control the number of unused threads, that are kept alive by GLib for future use.
/// The current number can be fetched with [func@GLib.ThreadPool.get_num_unused_threads].
/// The maximum number can be controlled by [func@GLib.ThreadPool.get_max_unused_threads] and
/// [func@GLib.ThreadPool.set_max_unused_threads]. All currently unused threads
/// can be stopped by calling [func@GLib.ThreadPool.stop_unused_threads].
/// </para>
/// </summary>

public struct GThreadPool
{
	/// <summary>
/// <para>
/// the function to execute in the threads of this pool
/// </para>
/// </summary>

public GFunc func;
	/// <summary>
/// <para>
/// the user data for the threads of this pool
/// </para>
/// </summary>

public IntPtr user_data;
	/// <summary>
/// <para>
/// are all threads exclusive to this pool
/// </para>
/// </summary>

public bool exclusive;
/// <summary>
/// <para>
/// This function will return the maximum @interval that a
/// thread will wait in the thread pool for new tasks before
/// being stopped.
/// </para>
/// <para>
/// If this function returns 0, threads waiting in the thread
/// pool for new work are not stopped.
/// </para>
/// </summary>

/// <return>
/// the maximum @interval (milliseconds) to wait
///     for new tasks in the thread pool before stopping the
///     thread
/// </return>

	public static uint GetMaxIdleTime()
	{
		return GThreadPoolExterns.g_thread_pool_get_max_idle_time();
	}

/// <summary>
/// <para>
/// Returns the maximal allowed number of unused threads.
/// </para>
/// </summary>

/// <return>
/// the maximal number of unused threads
/// </return>

	public static int GetMaxUnusedThreads()
	{
		return GThreadPoolExterns.g_thread_pool_get_max_unused_threads();
	}

/// <summary>
/// <para>
/// Returns the number of currently unused threads.
/// </para>
/// </summary>

/// <return>
/// the number of currently unused threads
/// </return>

	public static uint GetNumUnusedThreads()
	{
		return GThreadPoolExterns.g_thread_pool_get_num_unused_threads();
	}

/// <summary>
/// <para>
/// This function creates a new thread pool.
/// </para>
/// <para>
/// Whenever you call g_thread_pool_push(), either a new thread is
/// created or an unused one is reused. At most @max_threads threads
/// are running concurrently for this thread pool. @max_threads = -1
/// allows unlimited threads to be created for this thread pool. The
/// newly created or reused thread now executes the function @func
/// with the two arguments. The first one is the parameter to
/// g_thread_pool_push() and the second one is @user_data.
/// </para>
/// <para>
/// Pass g_get_num_processors() to @max_threads to create as many threads as
/// there are logical processors on the system. This will not pin each thread to
/// a specific processor.
/// </para>
/// <para>
/// The parameter @exclusive determines whether the thread pool owns
/// all threads exclusive or shares them with other thread pools.
/// If @exclusive is %TRUE, @max_threads threads are started
/// immediately and they will run exclusively for this thread pool
/// until it is destroyed by g_thread_pool_free(). If @exclusive is
/// %FALSE, threads are created when needed and shared between all
/// non-exclusive thread pools. This implies that @max_threads may
/// not be -1 for exclusive thread pools. Besides, exclusive thread
/// pools are not affected by g_thread_pool_set_max_idle_time()
/// since their threads are never considered idle and returned to the
/// global pool.
/// </para>
/// <para>
/// Note that the threads used by exclusive thread pools will all inherit the
/// scheduler settings of the current thread while the threads used by
/// non-exclusive thread pools will inherit the scheduler settings from the
/// first thread that created such a thread pool.
/// </para>
/// <para>
/// At least one thread will be spawned when this function is called, either to
/// create the @max_threads exclusive threads, or to preserve the scheduler
/// settings of the current thread for future spawns.
/// </para>
/// <para>
/// @error can be %NULL to ignore errors, or non-%NULL to report
/// errors. An error can only occur when @exclusive is set to %TRUE
/// and not all @max_threads threads could be created.
/// See #GThreadError for possible errors that may occur.
/// Note, even in case of error a valid #GThreadPool is returned.
/// </para>
/// </summary>

/// <param name="func">
/// a function to execute in the threads of the new thread pool
/// </param>
/// <param name="user_data">
/// user data that is handed over to @func every time it
///     is called
/// </param>
/// <param name="max_threads">
/// the maximal number of threads to execute concurrently
///     in  the new thread pool, -1 means no limit
/// </param>
/// <param name="exclusive">
/// should this thread pool be exclusive?
/// </param>
/// <return>
/// the new #GThreadPool
/// </return>

	public static MentorLake.GLib.GThreadPoolHandle New(MentorLake.GLib.GFunc func, IntPtr user_data, int max_threads, bool exclusive)
	{
		var externCallResult = GThreadPoolExterns.g_thread_pool_new(func, user_data, max_threads, exclusive, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This function creates a new thread pool similar to g_thread_pool_new()
/// but allowing @item_free_func to be specified to free the data passed
/// to g_thread_pool_push() in the case that the #GThreadPool is stopped
/// and freed before all tasks have been executed.
/// </para>
/// <para>
/// @item_free_func will *not* be called on items successfully passed to @func.
/// @func is responsible for freeing the items passed to it.
/// </para>
/// </summary>

/// <param name="func">
/// a function to execute in the threads of the new thread pool
/// </param>
/// <param name="user_data">
/// user data that is handed over to @func every time it
///     is called
/// </param>
/// <param name="item_free_func">
/// used to pass as a free function to
///     g_async_queue_new_full()
/// </param>
/// <param name="max_threads">
/// the maximal number of threads to execute concurrently
///     in the new thread pool, `-1` means no limit
/// </param>
/// <param name="exclusive">
/// should this thread pool be exclusive?
/// </param>
/// <return>
/// the new #GThreadPool
/// </return>

	public static MentorLake.GLib.GThreadPoolHandle NewFull(MentorLake.GLib.GFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify item_free_func, int max_threads, bool exclusive)
	{
		var externCallResult = GThreadPoolExterns.g_thread_pool_new_full(func, user_data, item_free_func, max_threads, exclusive, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This function will set the maximum @interval that a thread
/// waiting in the pool for new tasks can be idle for before
/// being stopped. This function is similar to calling
/// g_thread_pool_stop_unused_threads() on a regular timeout,
/// except this is done on a per thread basis.
/// </para>
/// <para>
/// By setting @interval to 0, idle threads will not be stopped.
/// </para>
/// <para>
/// The default value is 15000 (15 seconds).
/// </para>
/// </summary>

/// <param name="interval">
/// the maximum @interval (in milliseconds)
///     a thread can be idle
/// </param>

	public static void SetMaxIdleTime(uint interval)
	{
		GThreadPoolExterns.g_thread_pool_set_max_idle_time(interval);
	}

/// <summary>
/// <para>
/// Sets the maximal number of unused threads to @max_threads.
/// If @max_threads is -1, no limit is imposed on the number
/// of unused threads.
/// </para>
/// <para>
/// The default value is 8 since GLib 2.84. Previously the default value was 2.
/// </para>
/// </summary>

/// <param name="max_threads">
/// maximal number of unused threads
/// </param>

	public static void SetMaxUnusedThreads(int max_threads)
	{
		GThreadPoolExterns.g_thread_pool_set_max_unused_threads(max_threads);
	}

/// <summary>
/// <para>
/// Stops all currently unused threads. This does not change the
/// maximal number of unused threads. This function can be used to
/// regularly stop all unused threads e.g. from g_timeout_add().
/// </para>
/// </summary>


	public static void StopUnusedThreads()
	{
		GThreadPoolExterns.g_thread_pool_stop_unused_threads();
	}

}
