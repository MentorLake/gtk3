namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GStaticRWLock struct represents a read-write lock. A read-write
/// lock can be used for protecting data that some portions of code only
/// read from, while others also write. In such situations it is
/// desirable that several readers can read at once, whereas of course
/// only one writer may write at a time.
/// </para>
/// <para>
/// Take a look at the following example:
/// <code>
///   GStaticRWLock rwlock = G_STATIC_RW_LOCK_INIT;
///   GStaticRWLock rwlock = G_STATIC_RW_LOCK_INIT;
///   GPtrArray *array;
/// 
///   gpointer
///   my_array_get (guint index)
///   {
///     gpointer retval = NULL;
/// 
///     if (!array)
///       return NULL;
/// 
///     g_static_rw_lock_reader_lock (&amp;rwlock);
///     if (index &amp;lt; array-&amp;gt;len)
///       retval = g_ptr_array_index (array, index);
///     g_static_rw_lock_reader_unlock (&amp;rwlock);
/// 
///     return retval;
///   }
/// 
///   void
///   my_array_set (guint index, gpointer data)
///   {
///     g_static_rw_lock_writer_lock (&amp;rwlock);
/// 
///     if (!array)
///       array = g_ptr_array_new ();
/// 
///     if (index &amp;gt;= array-&amp;gt;len)
///       g_ptr_array_set_size (array, index + 1);
///     g_ptr_array_index (array, index) = data;
/// 
///     g_static_rw_lock_writer_unlock (&amp;rwlock);
///   }
/// </code>
/// This example shows an array which can be accessed by many readers
/// (the my_array_get() function) simultaneously, whereas the writers
/// (the my_array_set() function) will only be allowed once at a time
/// and only if no readers currently access the array. This is because
/// of the potentially dangerous resizing of the array. Using these
/// functions is fully multi-thread safe now.
/// </para>
/// <para>
/// Most of the time, writers should have precedence over readers. That
/// means, for this implementation, that as soon as a writer wants to
/// lock the data, no other reader is allowed to lock the data, whereas,
/// of course, the readers that already have locked the data are allowed
/// to finish their operation. As soon as the last reader unlocks the
/// data, the writer will lock it.
/// </para>
/// <para>
/// Even though #GStaticRWLock is not opaque, it should only be used
/// with the following functions.
/// </para>
/// <para>
/// All of the g_static_rw_lock_* functions can be used even if
/// g_thread_init() has not been called. Then they do nothing, apart
/// from g_static_rw_lock_*_trylock, which does nothing but returning %TRUE.
/// </para>
/// <para>
/// A read-write lock has a higher overhead than a mutex. For example, both
/// g_static_rw_lock_reader_lock() and g_static_rw_lock_reader_unlock() have
/// to lock and unlock a #GStaticMutex, so it takes at least twice the time
/// to lock and unlock a #GStaticRWLock that it does to lock and unlock a
/// #GStaticMutex. So only data structures that are accessed by multiple
/// readers, and which keep the lock for a considerable time justify a
/// #GStaticRWLock. The above example most probably would fare better with a
/// #GStaticMutex.
/// </para>
/// </summary>

public class GStaticRWLockHandle : BaseSafeHandle
{
}


public static class GStaticRWLockExtensions
{
/// <summary>
/// <para>
/// Releases all resources allocated to @lock.
/// </para>
/// <para>
/// You don&apos;t have to call this functions for a #GStaticRWLock with an
/// unbounded lifetime, i.e. objects declared &apos;static&apos;, but if you have
/// a #GStaticRWLock as a member of a structure, and the structure is
/// freed, you should also free the #GStaticRWLock.
/// </para>
/// </summary>

/// <param name="@lock">
/// a #GStaticRWLock to be freed.
/// </param>

	public static void Free(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		GStaticRWLockExterns.g_static_rw_lock_free(@lock);
	}

/// <summary>
/// <para>
/// A #GStaticRWLock must be initialized with this function before it
/// can be used. Alternatively you can initialize it with
/// %G_STATIC_RW_LOCK_INIT.
/// </para>
/// </summary>

/// <param name="@lock">
/// a #GStaticRWLock to be initialized.
/// </param>

	public static void Init(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		GStaticRWLockExterns.g_static_rw_lock_init(@lock);
	}

/// <summary>
/// <para>
/// Locks @lock for reading. There may be unlimited concurrent locks for
/// reading of a #GStaticRWLock at the same time.  If @lock is already
/// locked for writing by another thread or if another thread is already
/// waiting to lock @lock for writing, this function will block until
/// @lock is unlocked by the other writing thread and no other writing
/// threads want to lock @lock. This lock has to be unlocked by
/// g_static_rw_lock_reader_unlock().
/// </para>
/// <para>
/// #GStaticRWLock is not recursive. It might seem to be possible to
/// recursively lock for reading, but that can result in a deadlock, due
/// to writer preference.
/// </para>
/// </summary>

/// <param name="@lock">
/// a #GStaticRWLock to lock for reading.
/// </param>

	public static void ReaderLock(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		GStaticRWLockExterns.g_static_rw_lock_reader_lock(@lock);
	}

/// <summary>
/// <para>
/// Tries to lock @lock for reading. If @lock is already locked for
/// writing by another thread or if another thread is already waiting to
/// lock @lock for writing, immediately returns %FALSE. Otherwise locks
/// @lock for reading and returns %TRUE. This lock has to be unlocked by
/// g_static_rw_lock_reader_unlock().
/// </para>
/// </summary>

/// <param name="@lock">
/// a #GStaticRWLock to lock for reading
/// </param>
/// <return>
/// %TRUE, if @lock could be locked for reading
/// </return>

	public static bool ReaderTrylock(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		return GStaticRWLockExterns.g_static_rw_lock_reader_trylock(@lock);
	}

/// <summary>
/// <para>
/// Unlocks @lock. If a thread waits to lock @lock for writing and all
/// locks for reading have been unlocked, the waiting thread is woken up
/// and can lock @lock for writing.
/// </para>
/// </summary>

/// <param name="@lock">
/// a #GStaticRWLock to unlock after reading
/// </param>

	public static void ReaderUnlock(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		GStaticRWLockExterns.g_static_rw_lock_reader_unlock(@lock);
	}

/// <summary>
/// <para>
/// Locks @lock for writing. If @lock is already locked for writing or
/// reading by other threads, this function will block until @lock is
/// completely unlocked and then lock @lock for writing. While this
/// functions waits to lock @lock, no other thread can lock @lock for
/// reading. When @lock is locked for writing, no other thread can lock
/// @lock (neither for reading nor writing). This lock has to be
/// unlocked by g_static_rw_lock_writer_unlock().
/// </para>
/// </summary>

/// <param name="@lock">
/// a #GStaticRWLock to lock for writing
/// </param>

	public static void WriterLock(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		GStaticRWLockExterns.g_static_rw_lock_writer_lock(@lock);
	}

/// <summary>
/// <para>
/// Tries to lock @lock for writing. If @lock is already locked (for
/// either reading or writing) by another thread, it immediately returns
/// %FALSE. Otherwise it locks @lock for writing and returns %TRUE. This
/// lock has to be unlocked by g_static_rw_lock_writer_unlock().
/// </para>
/// </summary>

/// <param name="@lock">
/// a #GStaticRWLock to lock for writing
/// </param>
/// <return>
/// %TRUE, if @lock could be locked for writing
/// </return>

	public static bool WriterTrylock(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		return GStaticRWLockExterns.g_static_rw_lock_writer_trylock(@lock);
	}

/// <summary>
/// <para>
/// Unlocks @lock. If a thread is waiting to lock @lock for writing and
/// all locks for reading have been unlocked, the waiting thread is
/// woken up and can lock @lock for writing. If no thread is waiting to
/// lock @lock for writing, and some thread or threads are waiting to
/// lock @lock for reading, the waiting threads are woken up and can
/// lock @lock for reading.
/// </para>
/// </summary>

/// <param name="@lock">
/// a #GStaticRWLock to unlock after writing.
/// </param>

	public static void WriterUnlock(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		GStaticRWLockExterns.g_static_rw_lock_writer_unlock(@lock);
	}


	public static GStaticRWLock Dereference(this GStaticRWLockHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStaticRWLock>(x.DangerousGetHandle());
}
internal class GStaticRWLockExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rw_lock_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rw_lock_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rw_lock_reader_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_static_rw_lock_reader_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rw_lock_reader_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rw_lock_writer_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_static_rw_lock_writer_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rw_lock_writer_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

}

/// <summary>
/// <para>
/// The #GStaticRWLock struct represents a read-write lock. A read-write
/// lock can be used for protecting data that some portions of code only
/// read from, while others also write. In such situations it is
/// desirable that several readers can read at once, whereas of course
/// only one writer may write at a time.
/// </para>
/// <para>
/// Take a look at the following example:
/// <code>
///   GStaticRWLock rwlock = G_STATIC_RW_LOCK_INIT;
///   GStaticRWLock rwlock = G_STATIC_RW_LOCK_INIT;
///   GPtrArray *array;
/// 
///   gpointer
///   my_array_get (guint index)
///   {
///     gpointer retval = NULL;
/// 
///     if (!array)
///       return NULL;
/// 
///     g_static_rw_lock_reader_lock (&amp;rwlock);
///     if (index &amp;lt; array-&amp;gt;len)
///       retval = g_ptr_array_index (array, index);
///     g_static_rw_lock_reader_unlock (&amp;rwlock);
/// 
///     return retval;
///   }
/// 
///   void
///   my_array_set (guint index, gpointer data)
///   {
///     g_static_rw_lock_writer_lock (&amp;rwlock);
/// 
///     if (!array)
///       array = g_ptr_array_new ();
/// 
///     if (index &amp;gt;= array-&amp;gt;len)
///       g_ptr_array_set_size (array, index + 1);
///     g_ptr_array_index (array, index) = data;
/// 
///     g_static_rw_lock_writer_unlock (&amp;rwlock);
///   }
/// </code>
/// This example shows an array which can be accessed by many readers
/// (the my_array_get() function) simultaneously, whereas the writers
/// (the my_array_set() function) will only be allowed once at a time
/// and only if no readers currently access the array. This is because
/// of the potentially dangerous resizing of the array. Using these
/// functions is fully multi-thread safe now.
/// </para>
/// <para>
/// Most of the time, writers should have precedence over readers. That
/// means, for this implementation, that as soon as a writer wants to
/// lock the data, no other reader is allowed to lock the data, whereas,
/// of course, the readers that already have locked the data are allowed
/// to finish their operation. As soon as the last reader unlocks the
/// data, the writer will lock it.
/// </para>
/// <para>
/// Even though #GStaticRWLock is not opaque, it should only be used
/// with the following functions.
/// </para>
/// <para>
/// All of the g_static_rw_lock_* functions can be used even if
/// g_thread_init() has not been called. Then they do nothing, apart
/// from g_static_rw_lock_*_trylock, which does nothing but returning %TRUE.
/// </para>
/// <para>
/// A read-write lock has a higher overhead than a mutex. For example, both
/// g_static_rw_lock_reader_lock() and g_static_rw_lock_reader_unlock() have
/// to lock and unlock a #GStaticMutex, so it takes at least twice the time
/// to lock and unlock a #GStaticRWLock that it does to lock and unlock a
/// #GStaticMutex. So only data structures that are accessed by multiple
/// readers, and which keep the lock for a considerable time justify a
/// #GStaticRWLock. The above example most probably would fare better with a
/// #GStaticMutex.
/// </para>
/// </summary>

public struct GStaticRWLock
{
}
