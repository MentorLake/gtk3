namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The GRWLock struct is an opaque data structure to represent a
/// reader-writer lock. It is similar to a #GMutex in that it allows
/// multiple threads to coordinate access to a shared resource.
/// </para>
/// <para>
/// The difference to a mutex is that a reader-writer lock discriminates
/// between read-only ('reader') and full ('writer') access. While only
/// one thread at a time is allowed write access (by holding the 'writer'
/// lock via g_rw_lock_writer_lock()), multiple threads can gain
/// simultaneous read-only access (by holding the 'reader' lock via
/// g_rw_lock_reader_lock()).
/// </para>
/// <para>
/// It is unspecified whether readers or writers have priority in acquiring the
/// lock when a reader already holds the lock and a writer is queued to acquire
/// it.
/// </para>
/// <para>
/// Here is an example for an array with access functions:
/// |[<!-- language="C" -->
///   GRWLock lock;
///   GPtrArray *array;
/// </para>
/// <para>
///   gpointer
///   my_array_get (guint index)
///   {
///     gpointer retval = NULL;
/// </para>
/// <para>
///     if (!array)
///       return NULL;
/// </para>
/// <para>
///     g_rw_lock_reader_lock (&lock);
///     if (index < array->len)
///       retval = g_ptr_array_index (array, index);
///     g_rw_lock_reader_unlock (&lock);
/// </para>
/// <para>
///     return retval;
///   }
/// </para>
/// <para>
///   void
///   my_array_set (guint index, gpointer data)
///   {
///     g_rw_lock_writer_lock (&lock);
/// </para>
/// <para>
///     if (!array)
///       array = g_ptr_array_new ();
/// </para>
/// <para>
///     if (index >= array->len)
///       g_ptr_array_set_size (array, index+1);
///     g_ptr_array_index (array, index) = data;
/// </para>
/// <para>
///     g_rw_lock_writer_unlock (&lock);
///   }
///  ]|
/// This example shows an array which can be accessed by many readers
/// (the my_array_get() function) simultaneously, whereas the writers
/// (the my_array_set() function) will only be allowed one at a time
/// and only if no readers currently access the array. This is because
/// of the potentially dangerous resizing of the array. Using these
/// functions is fully multi-thread safe now.
/// </para>
/// <para>
/// If a #GRWLock is allocated in static storage then it can be used
/// without initialisation.  Otherwise, you should call
/// g_rw_lock_init() on it and g_rw_lock_clear() when done.
/// </para>
/// <para>
/// A GRWLock should only be accessed with the g_rw_lock_ functions.
/// </para>
/// </summary>

public class GRWLockHandle : BaseSafeHandle
{
}


public static class GRWLockExtensions
{
/// <summary>
/// <para>
/// Frees the resources allocated to a lock with g_rw_lock_init().
/// </para>
/// <para>
/// This function should not be used with a #GRWLock that has been
/// statically allocated.
/// </para>
/// <para>
/// Calling g_rw_lock_clear() when any thread holds the lock
/// leads to undefined behaviour.
/// </para>
/// </summary>

/// <param name="rw_lock">
/// an initialized #GRWLock
/// </param>

	public static void Clear(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		GRWLockExterns.g_rw_lock_clear(rw_lock);
	}

/// <summary>
/// <para>
/// Initializes a #GRWLock so that it can be used.
/// </para>
/// <para>
/// This function is useful to initialize a lock that has been
/// allocated on the stack, or as part of a larger structure.  It is not
/// necessary to initialise a reader-writer lock that has been statically
/// allocated.
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   typedef struct {
///     GRWLock l;
///     ...
///   } Blob;
/// </para>
/// <para>
/// Blob *b;
/// </para>
/// <para>
/// b = g_new (Blob, 1);
/// g_rw_lock_init (&b->l);
/// ]|
/// </para>
/// <para>
/// To undo the effect of g_rw_lock_init() when a lock is no longer
/// needed, use g_rw_lock_clear().
/// </para>
/// <para>
/// Calling g_rw_lock_init() on an already initialized #GRWLock leads
/// to undefined behaviour.
/// </para>
/// </summary>

/// <param name="rw_lock">
/// an uninitialized #GRWLock
/// </param>

	public static void Init(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		GRWLockExterns.g_rw_lock_init(rw_lock);
	}

/// <summary>
/// <para>
/// Obtain a read lock on @rw_lock. If another thread currently holds
/// the write lock on @rw_lock, the current thread will block until the
/// write lock was (held and) released. If another thread does not hold
/// the write lock, but is waiting for it, it is implementation defined
/// whether the reader or writer will block. Read locks can be taken
/// recursively.
/// </para>
/// <para>
/// Calling g_rw_lock_reader_lock() while the current thread already
/// owns a write lock leads to undefined behaviour. Read locks however
/// can be taken recursively, in which case you need to make sure to
/// call g_rw_lock_reader_unlock() the same amount of times.
/// </para>
/// <para>
/// It is implementation-defined how many read locks are allowed to be
/// held on the same lock simultaneously. If the limit is hit,
/// or if a deadlock is detected, a critical warning will be emitted.
/// </para>
/// </summary>

/// <param name="rw_lock">
/// a #GRWLock
/// </param>

	public static void ReaderLock(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		GRWLockExterns.g_rw_lock_reader_lock(rw_lock);
	}

/// <summary>
/// <para>
/// Tries to obtain a read lock on @rw_lock and returns %TRUE if
/// the read lock was successfully obtained. Otherwise it
/// returns %FALSE.
/// </para>
/// </summary>

/// <param name="rw_lock">
/// a #GRWLock
/// </param>
/// <return>
/// %TRUE if @rw_lock could be locked
/// </return>

	public static bool ReaderTrylock(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		return GRWLockExterns.g_rw_lock_reader_trylock(rw_lock);
	}

/// <summary>
/// <para>
/// Release a read lock on @rw_lock.
/// </para>
/// <para>
/// Calling g_rw_lock_reader_unlock() on a lock that is not held
/// by the current thread leads to undefined behaviour.
/// </para>
/// </summary>

/// <param name="rw_lock">
/// a #GRWLock
/// </param>

	public static void ReaderUnlock(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		GRWLockExterns.g_rw_lock_reader_unlock(rw_lock);
	}

/// <summary>
/// <para>
/// Obtain a write lock on @rw_lock. If another thread currently holds
/// a read or write lock on @rw_lock, the current thread will block
/// until all other threads have dropped their locks on @rw_lock.
/// </para>
/// <para>
/// Calling g_rw_lock_writer_lock() while the current thread already
/// owns a read or write lock on @rw_lock leads to undefined behaviour.
/// </para>
/// </summary>

/// <param name="rw_lock">
/// a #GRWLock
/// </param>

	public static void WriterLock(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		GRWLockExterns.g_rw_lock_writer_lock(rw_lock);
	}

/// <summary>
/// <para>
/// Tries to obtain a write lock on @rw_lock. If another thread
/// currently holds a read or write lock on @rw_lock, it immediately
/// returns %FALSE.
/// Otherwise it locks @rw_lock and returns %TRUE.
/// </para>
/// </summary>

/// <param name="rw_lock">
/// a #GRWLock
/// </param>
/// <return>
/// %TRUE if @rw_lock could be locked
/// </return>

	public static bool WriterTrylock(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		return GRWLockExterns.g_rw_lock_writer_trylock(rw_lock);
	}

/// <summary>
/// <para>
/// Release a write lock on @rw_lock.
/// </para>
/// <para>
/// Calling g_rw_lock_writer_unlock() on a lock that is not held
/// by the current thread leads to undefined behaviour.
/// </para>
/// </summary>

/// <param name="rw_lock">
/// a #GRWLock
/// </param>

	public static void WriterUnlock(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		GRWLockExterns.g_rw_lock_writer_unlock(rw_lock);
	}


	public static GRWLock Dereference(this GRWLockHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRWLock>(x.DangerousGetHandle());
}
internal class GRWLockExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rw_lock_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rw_lock_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rw_lock_reader_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_rw_lock_reader_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rw_lock_reader_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rw_lock_writer_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_rw_lock_writer_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rw_lock_writer_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

}

/// <summary>
/// <para>
/// The GRWLock struct is an opaque data structure to represent a
/// reader-writer lock. It is similar to a #GMutex in that it allows
/// multiple threads to coordinate access to a shared resource.
/// </para>
/// <para>
/// The difference to a mutex is that a reader-writer lock discriminates
/// between read-only ('reader') and full ('writer') access. While only
/// one thread at a time is allowed write access (by holding the 'writer'
/// lock via g_rw_lock_writer_lock()), multiple threads can gain
/// simultaneous read-only access (by holding the 'reader' lock via
/// g_rw_lock_reader_lock()).
/// </para>
/// <para>
/// It is unspecified whether readers or writers have priority in acquiring the
/// lock when a reader already holds the lock and a writer is queued to acquire
/// it.
/// </para>
/// <para>
/// Here is an example for an array with access functions:
/// |[<!-- language="C" -->
///   GRWLock lock;
///   GPtrArray *array;
/// </para>
/// <para>
///   gpointer
///   my_array_get (guint index)
///   {
///     gpointer retval = NULL;
/// </para>
/// <para>
///     if (!array)
///       return NULL;
/// </para>
/// <para>
///     g_rw_lock_reader_lock (&lock);
///     if (index < array->len)
///       retval = g_ptr_array_index (array, index);
///     g_rw_lock_reader_unlock (&lock);
/// </para>
/// <para>
///     return retval;
///   }
/// </para>
/// <para>
///   void
///   my_array_set (guint index, gpointer data)
///   {
///     g_rw_lock_writer_lock (&lock);
/// </para>
/// <para>
///     if (!array)
///       array = g_ptr_array_new ();
/// </para>
/// <para>
///     if (index >= array->len)
///       g_ptr_array_set_size (array, index+1);
///     g_ptr_array_index (array, index) = data;
/// </para>
/// <para>
///     g_rw_lock_writer_unlock (&lock);
///   }
///  ]|
/// This example shows an array which can be accessed by many readers
/// (the my_array_get() function) simultaneously, whereas the writers
/// (the my_array_set() function) will only be allowed one at a time
/// and only if no readers currently access the array. This is because
/// of the potentially dangerous resizing of the array. Using these
/// functions is fully multi-thread safe now.
/// </para>
/// <para>
/// If a #GRWLock is allocated in static storage then it can be used
/// without initialisation.  Otherwise, you should call
/// g_rw_lock_init() on it and g_rw_lock_clear() when done.
/// </para>
/// <para>
/// A GRWLock should only be accessed with the g_rw_lock_ functions.
/// </para>
/// </summary>

public struct GRWLock
{
}
