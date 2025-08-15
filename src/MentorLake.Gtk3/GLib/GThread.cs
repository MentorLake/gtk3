namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GThread struct represents a running thread. This struct
/// is returned by g_thread_new() or g_thread_try_new(). You can
/// obtain the #GThread struct representing the current thread by
/// calling g_thread_self().
/// </para>
/// <para>
/// GThread is refcounted, see g_thread_ref() and g_thread_unref().
/// The thread represented by it holds a reference while it is running,
/// and g_thread_join() consumes the reference that it is given, so
/// it is normally not necessary to manage GThread references
/// explicitly.
/// </para>
/// <para>
/// The structure is opaque -- none of its fields may be directly
/// accessed.
/// </para>
/// </summary>

public class GThreadHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// This function creates a new thread. The new thread starts by invoking
/// @func with the argument data. The thread will run until @func returns
/// or until g_thread_exit() is called from the new thread. The return value
/// of @func becomes the return value of the thread, which can be obtained
/// with g_thread_join().
/// </para>
/// <para>
/// The @name can be useful for discriminating threads in a debugger.
/// It is not used for other purposes and does not have to be unique.
/// Some systems restrict the length of @name to 16 bytes.
/// </para>
/// <para>
/// If the thread can not be created the program aborts. See
/// g_thread_try_new() if you want to attempt to deal with failures.
/// </para>
/// <para>
/// If you are using threads to offload (potentially many) short-lived tasks,
/// #GThreadPool may be more appropriate than manually spawning and tracking
/// multiple #GThreads.
/// </para>
/// <para>
/// To free the struct returned by this function, use g_thread_unref().
/// Note that g_thread_join() implicitly unrefs the #GThread as well.
/// </para>
/// <para>
/// New threads by default inherit their scheduler policy (POSIX) or thread
/// priority (Windows) of the thread creating the new thread.
/// </para>
/// <para>
/// This behaviour changed in GLib 2.64: before threads on Windows were not
/// inheriting the thread priority but were spawned with the default priority.
/// Starting with GLib 2.64 the behaviour is now consistent between Windows and
/// POSIX and all threads inherit their parent thread&apos;s priority.
/// </para>
/// </summary>

/// <param name="name">
/// an (optional) name for the new thread
/// </param>
/// <param name="func">
/// a function to execute in the new thread
/// </param>
/// <param name="data">
/// an argument to supply to the new thread
/// </param>
/// <return>
/// the new #GThread
/// </return>

	public static MentorLake.GLib.GThreadHandle New(string name, MentorLake.GLib.GThreadFunc func, IntPtr data)
	{
		return GThreadExterns.g_thread_new(name, func, data);
	}

/// <summary>
/// <para>
/// This function is the same as g_thread_new() except that
/// it allows for the possibility of failure.
/// </para>
/// <para>
/// If a thread can not be created (due to resource limits),
/// @error is set and %NULL is returned.
/// </para>
/// </summary>

/// <param name="name">
/// an (optional) name for the new thread
/// </param>
/// <param name="func">
/// a function to execute in the new thread
/// </param>
/// <param name="data">
/// an argument to supply to the new thread
/// </param>
/// <return>
/// the new #GThread, or %NULL if an error occurred
/// </return>

	public static MentorLake.GLib.GThreadHandle TryNew(string name, MentorLake.GLib.GThreadFunc func, IntPtr data)
	{
		var externCallResult = GThreadExterns.g_thread_try_new(name, func, data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}


public static class GThreadExtensions
{
/// <summary>
/// <para>
/// Gets the name of the thread.
/// </para>
/// <para>
/// This function is intended for debugging purposes.
/// </para>
/// </summary>

/// <param name="thread">
/// a thread
/// </param>
/// <return>
/// the name of the thread
/// </return>

	public static string GetName(this MentorLake.GLib.GThreadHandle thread)
	{
		if (thread.IsInvalid) throw new Exception("Invalid handle (GThread)");
		return GThreadExterns.g_thread_get_name(thread);
	}

/// <summary>
/// <para>
/// Waits until @thread finishes, i.e. the function @func, as
/// given to g_thread_new(), returns or g_thread_exit() is called.
/// If @thread has already terminated, then g_thread_join()
/// returns immediately.
/// </para>
/// <para>
/// Any thread can wait for any other thread by calling g_thread_join(),
/// not just its &apos;creator&apos;. Calling g_thread_join() from multiple threads
/// for the same @thread leads to undefined behaviour.
/// </para>
/// <para>
/// The value returned by @func or given to g_thread_exit() is
/// returned by this function.
/// </para>
/// <para>
/// g_thread_join() consumes the reference to the passed-in @thread.
/// This will usually cause the #GThread struct and associated resources
/// to be freed. Use g_thread_ref() to obtain an extra reference if you
/// want to keep the GThread alive beyond the g_thread_join() call.
/// </para>
/// </summary>

/// <param name="thread">
/// a #GThread
/// </param>
/// <return>
/// the return value of the thread
/// </return>

	public static IntPtr Join(this MentorLake.GLib.GThreadHandle thread)
	{
		if (thread.IsInvalid) throw new Exception("Invalid handle (GThread)");
		return GThreadExterns.g_thread_join(thread);
	}

/// <summary>
/// <para>
/// Increase the reference count on @thread.
/// </para>
/// </summary>

/// <param name="thread">
/// a #GThread
/// </param>
/// <return>
/// a new reference to @thread
/// </return>

	public static MentorLake.GLib.GThreadHandle Ref(this MentorLake.GLib.GThreadHandle thread)
	{
		if (thread.IsInvalid) throw new Exception("Invalid handle (GThread)");
		return GThreadExterns.g_thread_ref(thread);
	}

/// <summary>
/// <para>
/// This function does nothing.
/// </para>
/// </summary>

/// <param name="thread">
/// a #GThread.
/// </param>
/// <param name="priority">
/// ignored
/// </param>

	public static void SetPriority(this MentorLake.GLib.GThreadHandle thread, MentorLake.GLib.GThreadPriority priority)
	{
		if (thread.IsInvalid) throw new Exception("Invalid handle (GThread)");
		GThreadExterns.g_thread_set_priority(thread, priority);
	}

/// <summary>
/// <para>
/// Decrease the reference count on @thread, possibly freeing all
/// resources associated with it.
/// </para>
/// <para>
/// Note that each thread holds a reference to its #GThread while
/// it is running, so it is safe to drop your own reference to it
/// if you don&apos;t need it anymore.
/// </para>
/// </summary>

/// <param name="thread">
/// a #GThread
/// </param>

	public static void Unref(this MentorLake.GLib.GThreadHandle thread)
	{
		if (thread.IsInvalid) throw new Exception("Invalid handle (GThread)");
		GThreadExterns.g_thread_unref(thread);
	}


	public static GThread Dereference(this GThreadHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GThread>(x.DangerousGetHandle());
}
internal class GThreadExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_new(string name, MentorLake.GLib.GThreadFunc func, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_try_new(string name, MentorLake.GLib.GThreadFunc func, IntPtr data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_thread_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))] MentorLake.GLib.GThreadHandle thread);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_thread_join([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))] MentorLake.GLib.GThreadHandle thread);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))] MentorLake.GLib.GThreadHandle thread);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_set_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))] MentorLake.GLib.GThreadHandle thread, MentorLake.GLib.GThreadPriority priority);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))] MentorLake.GLib.GThreadHandle thread);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_create(MentorLake.GLib.GThreadFunc func, IntPtr data, bool joinable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_create_full(MentorLake.GLib.GThreadFunc func, IntPtr data, ulong stack_size, bool joinable, bool bound, MentorLake.GLib.GThreadPriority priority, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_thread_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_exit(IntPtr retval);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_foreach(MentorLake.GLib.GFunc thread_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_thread_get_initialized();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_init(IntPtr vtable);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_init_with_errorcheck_mutexes(IntPtr vtable);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_self();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_yield();

}

/// <summary>
/// <para>
/// The #GThread struct represents a running thread. This struct
/// is returned by g_thread_new() or g_thread_try_new(). You can
/// obtain the #GThread struct representing the current thread by
/// calling g_thread_self().
/// </para>
/// <para>
/// GThread is refcounted, see g_thread_ref() and g_thread_unref().
/// The thread represented by it holds a reference while it is running,
/// and g_thread_join() consumes the reference that it is given, so
/// it is normally not necessary to manage GThread references
/// explicitly.
/// </para>
/// <para>
/// The structure is opaque -- none of its fields may be directly
/// accessed.
/// </para>
/// </summary>

public struct GThread
{
/// <summary>
/// <para>
/// This function creates a new thread.
/// </para>
/// <para>
/// The new thread executes the function @func with the argument @data.
/// If the thread was created successfully, it is returned.
/// </para>
/// <para>
/// @error can be %NULL to ignore errors, or non-%NULL to report errors.
/// The error is set, if and only if the function returns %NULL.
/// </para>
/// <para>
/// This function returns a reference to the created thread only if
/// @joinable is %TRUE.  In that case, you must free this reference by
/// calling g_thread_unref() or g_thread_join().  If @joinable is %FALSE
/// then you should probably not touch the return value.
/// </para>
/// </summary>

/// <param name="func">
/// a function to execute in the new thread
/// </param>
/// <param name="data">
/// an argument to supply to the new thread
/// </param>
/// <param name="joinable">
/// should this thread be joinable?
/// </param>
/// <return>
/// the new #GThread on success
/// </return>

	public static MentorLake.GLib.GThreadHandle Create(MentorLake.GLib.GThreadFunc func, IntPtr data, bool joinable)
	{
		var externCallResult = GThreadExterns.g_thread_create(func, data, joinable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This function creates a new thread.
/// </para>
/// </summary>

/// <param name="func">
/// a function to execute in the new thread.
/// </param>
/// <param name="data">
/// an argument to supply to the new thread.
/// </param>
/// <param name="stack_size">
/// a stack size for the new thread.
/// </param>
/// <param name="joinable">
/// should this thread be joinable?
/// </param>
/// <param name="bound">
/// ignored
/// </param>
/// <param name="priority">
/// ignored
/// </param>
/// <return>
/// the new #GThread on success.
/// </return>

	public static MentorLake.GLib.GThreadHandle CreateFull(MentorLake.GLib.GThreadFunc func, IntPtr data, ulong stack_size, bool joinable, bool bound, MentorLake.GLib.GThreadPriority priority)
	{
		var externCallResult = GThreadExterns.g_thread_create_full(func, data, stack_size, joinable, bound, priority, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}



	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GThreadExterns.g_thread_error_quark();
	}

/// <summary>
/// <para>
/// Terminates the current thread.
/// </para>
/// <para>
/// If another thread is waiting for us using g_thread_join() then the
/// waiting thread will be woken up and get @retval as the return value
/// of g_thread_join().
/// </para>
/// <para>
/// Calling g_thread_exit() with a parameter @retval is equivalent to
/// returning @retval from the function @func, as given to g_thread_new().
/// </para>
/// <para>
/// You must only call g_thread_exit() from a thread that you created
/// yourself with g_thread_new() or related APIs. You must not call
/// this function from a thread created with another threading library
/// or or from within a #GThreadPool.
/// </para>
/// </summary>

/// <param name="retval">
/// the return value of this thread
/// </param>

	public static void Exit(IntPtr retval)
	{
		GThreadExterns.g_thread_exit(retval);
	}

/// <summary>
/// <para>
/// Call @thread_func on all #GThreads that have been
/// created with g_thread_create().
/// </para>
/// <para>
/// Note that threads may decide to exit while @thread_func is
/// running, so without intimate knowledge about the lifetime of
/// foreign threads, @thread_func shouldn&apos;t access the GThread*
/// pointer passed in as first argument. However, @thread_func will
/// not be called for threads which are known to have exited already.
/// </para>
/// <para>
/// Due to thread lifetime checks, this function has an execution complexity
/// which is quadratic in the number of existing threads.
/// </para>
/// </summary>

/// <param name="thread_func">
/// function to call for all #GThread structures
/// </param>
/// <param name="user_data">
/// second argument to @thread_func
/// </param>

	public static void Foreach(MentorLake.GLib.GFunc thread_func, IntPtr user_data)
	{
		GThreadExterns.g_thread_foreach(thread_func, user_data);
	}

/// <summary>
/// <para>
/// Indicates if g_thread_init() has been called.
/// </para>
/// </summary>

/// <return>
/// %TRUE if threads have been initialized.
/// </return>

	public static bool GetInitialized()
	{
		return GThreadExterns.g_thread_get_initialized();
	}

/// <summary>
/// <para>
/// If you use GLib from more than one thread, you must initialize the
/// thread system by calling g_thread_init().
/// </para>
/// <para>
/// Since version 2.24, calling g_thread_init() multiple times is allowed,
/// but nothing happens except for the first call.
/// </para>
/// <para>
/// Since version 2.32, GLib does not support custom thread implementations
/// anymore and the @vtable parameter is ignored and you should pass %NULL.
/// </para>
/// <para>
/// ::: note
///     g_thread_init() must not be called directly or indirectly in a
///     callback from GLib. Also no mutexes may be currently locked
///     while calling g_thread_init().
/// </para>
/// <para>
/// ::: note
///     To use g_thread_init() in your program, you have to link with
///     the libraries that the command `pkg-config --libs gthread-2.0`
///     outputs. This is not the case for all the other thread-related
///     functions of GLib. Those can be used without having to link
///     with the thread libraries.
/// </para>
/// </summary>

/// <param name="vtable">
/// a function table of type #GThreadFunctions, that provides
///     the entry points to the thread system to be used. Since 2.32,
///     this parameter is ignored and should always be %NULL
/// </param>

	public static void Init(IntPtr vtable)
	{
		GThreadExterns.g_thread_init(vtable);
	}


/// <param name="vtable">
/// </param>

	public static void InitWithErrorcheckMutexes(IntPtr vtable)
	{
		GThreadExterns.g_thread_init_with_errorcheck_mutexes(vtable);
	}

/// <summary>
/// <para>
/// This function returns the #GThread corresponding to the
/// current thread. Note that this function does not increase
/// the reference count of the returned struct.
/// </para>
/// <para>
/// This function will return a #GThread even for threads that
/// were not created by GLib (i.e. those created by other threading
/// APIs). This may be useful for thread identification purposes
/// (i.e. comparisons) but you must not use GLib functions (such
/// as g_thread_join()) on these threads.
/// </para>
/// </summary>

/// <return>
/// the #GThread representing the current thread
/// </return>

	public static MentorLake.GLib.GThreadHandle Self()
	{
		return GThreadExterns.g_thread_self();
	}

/// <summary>
/// <para>
/// Causes the calling thread to voluntarily relinquish the CPU, so
/// that other threads can run.
/// </para>
/// <para>
/// This function is often used as a method to make busy wait less evil.
/// </para>
/// </summary>


	public static void Yield()
	{
		GThreadExterns.g_thread_yield();
	}

}
