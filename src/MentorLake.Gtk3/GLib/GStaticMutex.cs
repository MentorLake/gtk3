namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A #GStaticMutex works like a #GMutex.
/// </para>
/// <para>
/// Prior to GLib 2.32, GStaticMutex had the significant advantage
/// that it doesn&apos;t need to be created at run-time, but can be defined
/// at compile-time. Since 2.32, #GMutex can be statically allocated
/// as well, and GStaticMutex has been deprecated.
/// </para>
/// <para>
/// Here is a version of our give_me_next_number() example using
/// a GStaticMutex:
/// <code>
///   int
///   int
///   give_me_next_number (void)
///   {
///     static int current_number = 0;
///     int ret_val;
///     static GStaticMutex mutex = G_STATIC_MUTEX_INIT;
/// 
///     g_static_mutex_lock (&amp;mutex);
///     ret_val = current_number = calc_next_number (current_number);
///     g_static_mutex_unlock (&amp;mutex);
/// 
///     return ret_val;
///   }
/// </code>
/// Sometimes you would like to dynamically create a mutex. If you don&apos;t
/// want to require prior calling to g_thread_init(), because your code
/// should also be usable in non-threaded programs, you are not able to
/// use g_mutex_new() and thus #GMutex, as that requires a prior call to
/// g_thread_init(). In these cases you can also use a #GStaticMutex.
/// It must be initialized with g_static_mutex_init() before using it
/// and freed with with g_static_mutex_free() when not needed anymore to
/// free up any allocated resources.
/// </para>
/// <para>
/// Even though #GStaticMutex is not opaque, it should only be used with
/// the following functions, as it is defined differently on different
/// platforms.
/// </para>
/// <para>
/// All of the g_static_mutex_* functions apart from
/// g_static_mutex_get_mutex() can also be used even if g_thread_init()
/// has not yet been called. Then they do nothing, apart from
/// g_static_mutex_trylock() which does nothing but returning %TRUE.
/// </para>
/// <para>
/// All of the g_static_mutex_* functions are actually macros. Apart from
/// taking their addresses, you can however use them as if they were
/// functions.
/// </para>
/// </summary>

public class GStaticMutexHandle : BaseSafeHandle
{
}


public static class GStaticMutexExtensions
{
/// <summary>
/// <para>
/// Releases all resources allocated to @mutex.
/// </para>
/// <para>
/// You don&apos;t have to call this functions for a #GStaticMutex with an
/// unbounded lifetime, i.e. objects declared &apos;static&apos;, but if you have
/// a #GStaticMutex as a member of a structure and the structure is
/// freed, you should also free the #GStaticMutex.
/// </para>
/// <para>
/// Calling g_static_mutex_free() on a locked mutex may result in
/// undefined behaviour.
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GStaticMutex to be freed.
/// </param>

	public static void Free(this MentorLake.GLib.GStaticMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticMutex)");
		GStaticMutexExterns.g_static_mutex_free(mutex);
	}


/// <param name="mutex">
/// </param>

	public static MentorLake.GLib.GMutexHandle GetMutexImpl(this MentorLake.GLib.GStaticMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticMutex)");
		return GStaticMutexExterns.g_static_mutex_get_mutex_impl(mutex);
	}

/// <summary>
/// <para>
/// Initializes @mutex.
/// Alternatively you can initialize it with %G_STATIC_MUTEX_INIT.
/// </para>
/// </summary>

/// <param name="mutex">
/// a #GStaticMutex to be initialized.
/// </param>

	public static void Init(this MentorLake.GLib.GStaticMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticMutex)");
		GStaticMutexExterns.g_static_mutex_init(mutex);
	}


	public static GStaticMutex Dereference(this GStaticMutexHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStaticMutex>(x.DangerousGetHandle());
}
internal class GStaticMutexExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_mutex_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticMutexHandle>))] MentorLake.GLib.GStaticMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))]
	internal static extern MentorLake.GLib.GMutexHandle g_static_mutex_get_mutex_impl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticMutexHandle>))] MentorLake.GLib.GStaticMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_mutex_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticMutexHandle>))] MentorLake.GLib.GStaticMutexHandle mutex);

}

/// <summary>
/// <para>
/// A #GStaticMutex works like a #GMutex.
/// </para>
/// <para>
/// Prior to GLib 2.32, GStaticMutex had the significant advantage
/// that it doesn&apos;t need to be created at run-time, but can be defined
/// at compile-time. Since 2.32, #GMutex can be statically allocated
/// as well, and GStaticMutex has been deprecated.
/// </para>
/// <para>
/// Here is a version of our give_me_next_number() example using
/// a GStaticMutex:
/// <code>
///   int
///   int
///   give_me_next_number (void)
///   {
///     static int current_number = 0;
///     int ret_val;
///     static GStaticMutex mutex = G_STATIC_MUTEX_INIT;
/// 
///     g_static_mutex_lock (&amp;mutex);
///     ret_val = current_number = calc_next_number (current_number);
///     g_static_mutex_unlock (&amp;mutex);
/// 
///     return ret_val;
///   }
/// </code>
/// Sometimes you would like to dynamically create a mutex. If you don&apos;t
/// want to require prior calling to g_thread_init(), because your code
/// should also be usable in non-threaded programs, you are not able to
/// use g_mutex_new() and thus #GMutex, as that requires a prior call to
/// g_thread_init(). In these cases you can also use a #GStaticMutex.
/// It must be initialized with g_static_mutex_init() before using it
/// and freed with with g_static_mutex_free() when not needed anymore to
/// free up any allocated resources.
/// </para>
/// <para>
/// Even though #GStaticMutex is not opaque, it should only be used with
/// the following functions, as it is defined differently on different
/// platforms.
/// </para>
/// <para>
/// All of the g_static_mutex_* functions apart from
/// g_static_mutex_get_mutex() can also be used even if g_thread_init()
/// has not yet been called. Then they do nothing, apart from
/// g_static_mutex_trylock() which does nothing but returning %TRUE.
/// </para>
/// <para>
/// All of the g_static_mutex_* functions are actually macros. Apart from
/// taking their addresses, you can however use them as if they were
/// functions.
/// </para>
/// </summary>

public struct GStaticMutex
{
	
public IntPtr mutex;
}
