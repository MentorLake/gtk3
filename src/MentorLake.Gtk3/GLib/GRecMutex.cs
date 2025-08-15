namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The GRecMutex struct is an opaque data structure to represent a
/// recursive mutex. It is similar to a #GMutex with the difference
/// that it is possible to lock a GRecMutex multiple times in the same
/// thread without deadlock. When doing so, care has to be taken to
/// unlock the recursive mutex as often as it has been locked.
/// </para>
/// <para>
/// If a #GRecMutex is allocated in static storage then it can be used
/// without initialisation.  Otherwise, you should call
/// g_rec_mutex_init() on it and g_rec_mutex_clear() when done.
/// </para>
/// <para>
/// A GRecMutex should only be accessed with the
/// g_rec_mutex_ functions.
/// </para>
/// </summary>

public class GRecMutexHandle : BaseSafeHandle
{
}


public static class GRecMutexExtensions
{
/// <summary>
/// <para>
/// Frees the resources allocated to a recursive mutex with
/// g_rec_mutex_init().
/// </para>
/// <para>
/// This function should not be used with a #GRecMutex that has been
/// statically allocated.
/// </para>
/// <para>
/// Calling g_rec_mutex_clear() on a locked recursive mutex leads
/// to undefined behaviour.
/// </para>
/// </summary>

/// <param name="rec_mutex">
/// an initialized #GRecMutex
/// </param>

	public static void Clear(this MentorLake.GLib.GRecMutexHandle rec_mutex)
	{
		if (rec_mutex.IsInvalid) throw new Exception("Invalid handle (GRecMutex)");
		GRecMutexExterns.g_rec_mutex_clear(rec_mutex);
	}

/// <summary>
/// <para>
/// Initializes a #GRecMutex so that it can be used.
/// </para>
/// <para>
/// This function is useful to initialize a recursive mutex
/// that has been allocated on the stack, or as part of a larger
/// structure.
/// </para>
/// <para>
/// It is not necessary to initialise a recursive mutex that has been
/// statically allocated.
/// </para>
/// <code>
///   typedef struct {
///   typedef struct {
///     GRecMutex m;
///     ...
///   } Blob;
/// 
/// Blob *b;
/// 
/// b = g_new (Blob, 1);
/// g_rec_mutex_init (&amp;b-&amp;gt;m);
/// </code>
/// <para>
/// Calling g_rec_mutex_init() on an already initialized #GRecMutex
/// leads to undefined behaviour.
/// </para>
/// <para>
/// To undo the effect of g_rec_mutex_init() when a recursive mutex
/// is no longer needed, use g_rec_mutex_clear().
/// </para>
/// </summary>

/// <param name="rec_mutex">
/// an uninitialized #GRecMutex
/// </param>

	public static void Init(this MentorLake.GLib.GRecMutexHandle rec_mutex)
	{
		if (rec_mutex.IsInvalid) throw new Exception("Invalid handle (GRecMutex)");
		GRecMutexExterns.g_rec_mutex_init(rec_mutex);
	}

/// <summary>
/// <para>
/// Locks @rec_mutex. If @rec_mutex is already locked by another
/// thread, the current thread will block until @rec_mutex is
/// unlocked by the other thread. If @rec_mutex is already locked
/// by the current thread, the &apos;lock count&apos; of @rec_mutex is increased.
/// The mutex will only become available again when it is unlocked
/// as many times as it has been locked.
/// </para>
/// </summary>

/// <param name="rec_mutex">
/// a #GRecMutex
/// </param>

	public static void Lock(this MentorLake.GLib.GRecMutexHandle rec_mutex)
	{
		if (rec_mutex.IsInvalid) throw new Exception("Invalid handle (GRecMutex)");
		GRecMutexExterns.g_rec_mutex_lock(rec_mutex);
	}

/// <summary>
/// <para>
/// Tries to lock @rec_mutex. If @rec_mutex is already locked
/// by another thread, it immediately returns %FALSE. Otherwise
/// it locks @rec_mutex and returns %TRUE.
/// </para>
/// </summary>

/// <param name="rec_mutex">
/// a #GRecMutex
/// </param>
/// <return>
/// %TRUE if @rec_mutex could be locked
/// </return>

	public static bool Trylock(this MentorLake.GLib.GRecMutexHandle rec_mutex)
	{
		if (rec_mutex.IsInvalid) throw new Exception("Invalid handle (GRecMutex)");
		return GRecMutexExterns.g_rec_mutex_trylock(rec_mutex);
	}

/// <summary>
/// <para>
/// Unlocks @rec_mutex. If another thread is blocked in a
/// g_rec_mutex_lock() call for @rec_mutex, it will become unblocked
/// and can lock @rec_mutex itself.
/// </para>
/// <para>
/// Calling g_rec_mutex_unlock() on a recursive mutex that is not
/// locked by the current thread leads to undefined behaviour.
/// </para>
/// </summary>

/// <param name="rec_mutex">
/// a #GRecMutex
/// </param>

	public static void Unlock(this MentorLake.GLib.GRecMutexHandle rec_mutex)
	{
		if (rec_mutex.IsInvalid) throw new Exception("Invalid handle (GRecMutex)");
		GRecMutexExterns.g_rec_mutex_unlock(rec_mutex);
	}


	public static GRecMutex Dereference(this GRecMutexHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRecMutex>(x.DangerousGetHandle());
}
internal class GRecMutexExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rec_mutex_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRecMutexHandle>))] MentorLake.GLib.GRecMutexHandle rec_mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rec_mutex_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRecMutexHandle>))] MentorLake.GLib.GRecMutexHandle rec_mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rec_mutex_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRecMutexHandle>))] MentorLake.GLib.GRecMutexHandle rec_mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_rec_mutex_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRecMutexHandle>))] MentorLake.GLib.GRecMutexHandle rec_mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rec_mutex_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRecMutexHandle>))] MentorLake.GLib.GRecMutexHandle rec_mutex);

}

/// <summary>
/// <para>
/// The GRecMutex struct is an opaque data structure to represent a
/// recursive mutex. It is similar to a #GMutex with the difference
/// that it is possible to lock a GRecMutex multiple times in the same
/// thread without deadlock. When doing so, care has to be taken to
/// unlock the recursive mutex as often as it has been locked.
/// </para>
/// <para>
/// If a #GRecMutex is allocated in static storage then it can be used
/// without initialisation.  Otherwise, you should call
/// g_rec_mutex_init() on it and g_rec_mutex_clear() when done.
/// </para>
/// <para>
/// A GRecMutex should only be accessed with the
/// g_rec_mutex_ functions.
/// </para>
/// </summary>

public struct GRecMutex
{
}
