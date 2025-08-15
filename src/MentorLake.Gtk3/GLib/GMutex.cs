namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GMutex struct is an opaque data structure to represent a mutex
/// (mutual exclusion). It can be used to protect data against shared
/// access.
/// </para>
/// <para>
/// Take for example the following function:
/// <code>
///   int
///   int
///   give_me_next_number (void)
///   {
///     static int current_number = 0;
/// 
///     // now do a very complicated calculation to calculate the new
///     // number, this might for example be a random number generator
///     current_number = calc_next_number (current_number);
/// 
///     return current_number;
///   }
/// </code>
/// application. There current_number must be protected against shared
/// access. A #GMutex can be used as a solution to this problem:
/// <code>
///   int
///   int
///   give_me_next_number (void)
///   {
///     static GMutex mutex;
///     static int current_number = 0;
///     int ret_val;
/// 
///     g_mutex_lock (&amp;mutex);
///     ret_val = current_number = calc_next_number (current_number);
///     g_mutex_unlock (&amp;mutex);
/// 
///     return ret_val;
///   }
/// </code>
/// Its placement in static storage ensures that it will be initialised
/// to all-zeros, which is appropriate.
/// </para>
/// <para>
/// If a #GMutex is placed in other contexts (eg: embedded in a struct)
/// then it must be explicitly initialised using g_mutex_init().
/// </para>
/// <para>
/// A #GMutex should only be accessed via g_mutex_ functions.
/// </para>
/// </summary>

public class GMutexHandle : BaseSafeHandle
{
}


public static class GMutexExtensions
{
/// <summary>
/// <para>
/// Frees the resources allocated to a mutex with g_mutex_init().
/// </para>
/// <para>
/// This function should not be used with a #GMutex that has been
/// statically allocated.
/// </para>
/// <para>
/// Calling g_mutex_clear() on a locked mutex leads to undefined
/// behaviour.
/// </para>
/// </summary>

/// <param name="mutex">
/// an initialized #GMutex
/// </param>

	public static void Clear(this MentorLake.GLib.GMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GMutex)");
		GMutexExterns.g_mutex_clear(mutex);
	}

/// <summary>
/// <para>
/// Destroys a @mutex that has been created with g_mutex_new().
/// </para>
/// <para>
/// Calling g_mutex_free() on a locked mutex may result
/// in undefined behaviour.
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GMutex
/// </param>

	public static void Free(this MentorLake.GLib.GMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GMutex)");
		GMutexExterns.g_mutex_free(mutex);
	}

/// <summary>
/// <para>
/// Initializes a #GMutex so that it can be used.
/// </para>
/// <para>
/// This function is useful to initialize a mutex that has been
/// allocated on the stack, or as part of a larger structure.
/// It is not necessary to initialize a mutex that has been
/// statically allocated.
/// </para>
/// <code>
///   typedef struct {
///   typedef struct {
///     GMutex m;
///     ...
///   } Blob;
/// 
/// Blob *b;
/// 
/// b = g_new (Blob, 1);
/// g_mutex_init (&amp;b-&amp;gt;m);
/// </code>
/// <para>
/// To undo the effect of g_mutex_init() when a mutex is no longer
/// needed, use g_mutex_clear().
/// </para>
/// <para>
/// Calling g_mutex_init() on an already initialized #GMutex leads
/// to undefined behaviour.
/// </para>
/// </summary>

/// <param name="mutex">
/// an uninitialized #GMutex
/// </param>

	public static void Init(this MentorLake.GLib.GMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GMutex)");
		GMutexExterns.g_mutex_init(mutex);
	}

/// <summary>
/// <para>
/// Locks @mutex. If @mutex is already locked by another thread, the
/// current thread will block until @mutex is unlocked by the other
/// thread.
/// </para>
/// <para>
/// #GMutex is neither guaranteed to be recursive nor to be
/// non-recursive.  As such, calling g_mutex_lock() on a #GMutex that has
/// already been locked by the same thread results in undefined behaviour
/// (including but not limited to deadlocks).
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GMutex
/// </param>

	public static void Lock(this MentorLake.GLib.GMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GMutex)");
		GMutexExterns.g_mutex_lock(mutex);
	}

/// <summary>
/// <para>
/// Tries to lock @mutex. If @mutex is already locked by another thread,
/// it immediately returns %FALSE. Otherwise it locks @mutex and returns
/// %TRUE.
/// </para>
/// <para>
/// #GMutex is neither guaranteed to be recursive nor to be
/// non-recursive.  As such, calling g_mutex_lock() on a #GMutex that has
/// already been locked by the same thread results in undefined behaviour
/// (including but not limited to deadlocks or arbitrary return values).
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GMutex
/// </param>
/// <return>
/// %TRUE if @mutex could be locked
/// </return>

	public static bool Trylock(this MentorLake.GLib.GMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GMutex)");
		return GMutexExterns.g_mutex_trylock(mutex);
	}

/// <summary>
/// <para>
/// Unlocks @mutex. If another thread is blocked in a g_mutex_lock()
/// call for @mutex, it will become unblocked and can lock @mutex itself.
/// </para>
/// <para>
/// Calling g_mutex_unlock() on a mutex that is not locked by the
/// current thread leads to undefined behaviour.
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GMutex
/// </param>

	public static void Unlock(this MentorLake.GLib.GMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GMutex)");
		GMutexExterns.g_mutex_unlock(mutex);
	}


	public static GMutex Dereference(this GMutexHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMutex>(x.DangerousGetHandle());
}
internal class GMutexExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mutex_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mutex_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mutex_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mutex_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_mutex_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mutex_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))]
	internal static extern MentorLake.GLib.GMutexHandle g_mutex_new();

}

/// <summary>
/// <para>
/// The #GMutex struct is an opaque data structure to represent a mutex
/// (mutual exclusion). It can be used to protect data against shared
/// access.
/// </para>
/// <para>
/// Take for example the following function:
/// <code>
///   int
///   int
///   give_me_next_number (void)
///   {
///     static int current_number = 0;
/// 
///     // now do a very complicated calculation to calculate the new
///     // number, this might for example be a random number generator
///     current_number = calc_next_number (current_number);
/// 
///     return current_number;
///   }
/// </code>
/// application. There current_number must be protected against shared
/// access. A #GMutex can be used as a solution to this problem:
/// <code>
///   int
///   int
///   give_me_next_number (void)
///   {
///     static GMutex mutex;
///     static int current_number = 0;
///     int ret_val;
/// 
///     g_mutex_lock (&amp;mutex);
///     ret_val = current_number = calc_next_number (current_number);
///     g_mutex_unlock (&amp;mutex);
/// 
///     return ret_val;
///   }
/// </code>
/// Its placement in static storage ensures that it will be initialised
/// to all-zeros, which is appropriate.
/// </para>
/// <para>
/// If a #GMutex is placed in other contexts (eg: embedded in a struct)
/// then it must be explicitly initialised using g_mutex_init().
/// </para>
/// <para>
/// A #GMutex should only be accessed via g_mutex_ functions.
/// </para>
/// </summary>

public struct GMutex
{
	
public IntPtr p;
	
[MarshalAs(UnmanagedType.ByValArray)] public uint[] i;
/// <summary>
/// <para>
/// Allocates and initializes a new #GMutex.
/// </para>
/// </summary>

/// <return>
/// a newly allocated #GMutex. Use g_mutex_free() to free
/// </return>

	public static MentorLake.GLib.GMutexHandle New()
	{
		return GMutexExterns.g_mutex_new();
	}

}
