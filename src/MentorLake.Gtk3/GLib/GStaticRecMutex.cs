namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A #GStaticRecMutex works like a #GStaticMutex, but it can be locked
/// multiple times by one thread. If you enter it n times, you have to
/// unlock it n times again to let other threads lock it. An exception
/// is the function g_static_rec_mutex_unlock_full(): that allows you to
/// unlock a #GStaticRecMutex completely returning the depth, (i.e. the
/// number of times this mutex was locked). The depth can later be used
/// to restore the state of the #GStaticRecMutex by calling
/// g_static_rec_mutex_lock_full(). In GLib 2.32, #GStaticRecMutex has
/// been deprecated in favor of #GRecMutex.
/// </para>
/// <para>
/// Even though #GStaticRecMutex is not opaque, it should only be used
/// with the following functions.
/// </para>
/// <para>
/// All of the g_static_rec_mutex_* functions can be used even if
/// g_thread_init() has not been called. Then they do nothing, apart
/// from g_static_rec_mutex_trylock(), which does nothing but returning
/// %TRUE.
/// </para>
/// </summary>

public class GStaticRecMutexHandle : BaseSafeHandle
{
}


public static class GStaticRecMutexExtensions
{
/// <summary>
/// <para>
/// Releases all resources allocated to a #GStaticRecMutex.
/// </para>
/// <para>
/// You don't have to call this functions for a #GStaticRecMutex with an
/// unbounded lifetime, i.e. objects declared 'static', but if you have
/// a #GStaticRecMutex as a member of a structure and the structure is
/// freed, you should also free the #GStaticRecMutex.
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GStaticRecMutex to be freed.
/// </param>

	public static void Free(this MentorLake.GLib.GStaticRecMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticRecMutex)");
		GStaticRecMutexExterns.g_static_rec_mutex_free(mutex);
	}

/// <summary>
/// <para>
/// A #GStaticRecMutex must be initialized with this function before it
/// can be used. Alternatively you can initialize it with
/// %G_STATIC_REC_MUTEX_INIT.
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GStaticRecMutex to be initialized.
/// </param>

	public static void Init(this MentorLake.GLib.GStaticRecMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticRecMutex)");
		GStaticRecMutexExterns.g_static_rec_mutex_init(mutex);
	}

/// <summary>
/// <para>
/// Locks @mutex. If @mutex is already locked by another thread, the
/// current thread will block until @mutex is unlocked by the other
/// thread. If @mutex is already locked by the calling thread, this
/// functions increases the depth of @mutex and returns immediately.
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GStaticRecMutex to lock.
/// </param>

	public static void Lock(this MentorLake.GLib.GStaticRecMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticRecMutex)");
		GStaticRecMutexExterns.g_static_rec_mutex_lock(mutex);
	}

/// <summary>
/// <para>
/// Works like calling g_static_rec_mutex_lock() for @mutex @depth times.
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GStaticRecMutex to lock.
/// </param>
/// <param name="depth">
/// number of times this mutex has to be unlocked to be
///         completely unlocked.
/// </param>

	public static void LockFull(this MentorLake.GLib.GStaticRecMutexHandle mutex, uint depth)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticRecMutex)");
		GStaticRecMutexExterns.g_static_rec_mutex_lock_full(mutex, depth);
	}

/// <summary>
/// <para>
/// Tries to lock @mutex. If @mutex is already locked by another thread,
/// it immediately returns %FALSE. Otherwise it locks @mutex and returns
/// %TRUE. If @mutex is already locked by the calling thread, this
/// functions increases the depth of @mutex and immediately returns
/// %TRUE.
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GStaticRecMutex to lock.
/// </param>
/// <return>
/// %TRUE, if @mutex could be locked.
/// </return>

	public static bool Trylock(this MentorLake.GLib.GStaticRecMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticRecMutex)");
		return GStaticRecMutexExterns.g_static_rec_mutex_trylock(mutex);
	}

/// <summary>
/// <para>
/// Unlocks @mutex. Another thread will be allowed to lock @mutex only
/// when it has been unlocked as many times as it had been locked
/// before. If @mutex is completely unlocked and another thread is
/// blocked in a g_static_rec_mutex_lock() call for @mutex, it will be
/// woken and can lock @mutex itself.
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GStaticRecMutex to unlock.
/// </param>

	public static void Unlock(this MentorLake.GLib.GStaticRecMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticRecMutex)");
		GStaticRecMutexExterns.g_static_rec_mutex_unlock(mutex);
	}

/// <summary>
/// <para>
/// Completely unlocks @mutex. If another thread is blocked in a
/// g_static_rec_mutex_lock() call for @mutex, it will be woken and can
/// lock @mutex itself. This function returns the number of times that
/// @mutex has been locked by the current thread. To restore the state
/// before the call to g_static_rec_mutex_unlock_full() you can call
/// g_static_rec_mutex_lock_full() with the depth returned by this
/// function.
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GStaticRecMutex to completely unlock.
/// </param>
/// <return>
/// number of times @mutex has been locked by the current
///          thread.
/// </return>

	public static uint UnlockFull(this MentorLake.GLib.GStaticRecMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticRecMutex)");
		return GStaticRecMutexExterns.g_static_rec_mutex_unlock_full(mutex);
	}


	public static GStaticRecMutex Dereference(this GStaticRecMutexHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStaticRecMutex>(x.DangerousGetHandle());
}
internal class GStaticRecMutexExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rec_mutex_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rec_mutex_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rec_mutex_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rec_mutex_lock_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex, uint depth);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_static_rec_mutex_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rec_mutex_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_static_rec_mutex_unlock_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex);

}

/// <summary>
/// <para>
/// A #GStaticRecMutex works like a #GStaticMutex, but it can be locked
/// multiple times by one thread. If you enter it n times, you have to
/// unlock it n times again to let other threads lock it. An exception
/// is the function g_static_rec_mutex_unlock_full(): that allows you to
/// unlock a #GStaticRecMutex completely returning the depth, (i.e. the
/// number of times this mutex was locked). The depth can later be used
/// to restore the state of the #GStaticRecMutex by calling
/// g_static_rec_mutex_lock_full(). In GLib 2.32, #GStaticRecMutex has
/// been deprecated in favor of #GRecMutex.
/// </para>
/// <para>
/// Even though #GStaticRecMutex is not opaque, it should only be used
/// with the following functions.
/// </para>
/// <para>
/// All of the g_static_rec_mutex_* functions can be used even if
/// g_thread_init() has not been called. Then they do nothing, apart
/// from g_static_rec_mutex_trylock(), which does nothing but returning
/// %TRUE.
/// </para>
/// </summary>

public struct GStaticRecMutex
{
}
