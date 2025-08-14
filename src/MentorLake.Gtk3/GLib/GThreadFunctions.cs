namespace MentorLake.GLib;

/// <summary>
/// <para>
/// This function table is no longer used by g_thread_init()
/// to initialize the thread system.
/// </para>
/// </summary>

public class GThreadFunctionsHandle : BaseSafeHandle
{
}


public static class GThreadFunctionsExtensions
{

	public static GThreadFunctions Dereference(this GThreadFunctionsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GThreadFunctions>(x.DangerousGetHandle());
}
internal class GThreadFunctionsExterns
{
}

/// <summary>
/// <para>
/// This function table is no longer used by g_thread_init()
/// to initialize the thread system.
/// </para>
/// </summary>

public struct GThreadFunctions
{
	/// <summary>
/// <para>
/// virtual function pointer for g_mutex_new()
/// </para>
/// </summary>

public IntPtr mutex_new;
	/// <summary>
/// <para>
/// virtual function pointer for g_mutex_lock()
/// </para>
/// </summary>

public IntPtr mutex_lock;
	/// <summary>
/// <para>
/// virtual function pointer for g_mutex_trylock()
/// </para>
/// </summary>

public IntPtr mutex_trylock;
	/// <summary>
/// <para>
/// virtual function pointer for g_mutex_unlock()
/// </para>
/// </summary>

public IntPtr mutex_unlock;
	/// <summary>
/// <para>
/// virtual function pointer for g_mutex_free()
/// </para>
/// </summary>

public IntPtr mutex_free;
	/// <summary>
/// <para>
/// virtual function pointer for g_cond_new()
/// </para>
/// </summary>

public IntPtr cond_new;
	/// <summary>
/// <para>
/// virtual function pointer for g_cond_signal()
/// </para>
/// </summary>

public IntPtr cond_signal;
	/// <summary>
/// <para>
/// virtual function pointer for g_cond_broadcast()
/// </para>
/// </summary>

public IntPtr cond_broadcast;
	/// <summary>
/// <para>
/// virtual function pointer for g_cond_wait()
/// </para>
/// </summary>

public IntPtr cond_wait;
	/// <summary>
/// <para>
/// virtual function pointer for g_cond_timed_wait()
/// </para>
/// </summary>

public IntPtr cond_timed_wait;
	/// <summary>
/// <para>
/// virtual function pointer for g_cond_free()
/// </para>
/// </summary>

public IntPtr cond_free;
	/// <summary>
/// <para>
/// virtual function pointer for g_private_new()
/// </para>
/// </summary>

public IntPtr private_new;
	/// <summary>
/// <para>
/// virtual function pointer for g_private_get()
/// </para>
/// </summary>

public IntPtr private_get;
	/// <summary>
/// <para>
/// virtual function pointer for g_private_set()
/// </para>
/// </summary>

public IntPtr private_set;
	/// <summary>
/// <para>
/// virtual function pointer for g_thread_create()
/// </para>
/// </summary>

public IntPtr thread_create;
	/// <summary>
/// <para>
/// virtual function pointer for g_thread_yield()
/// </para>
/// </summary>

public IntPtr thread_yield;
	/// <summary>
/// <para>
/// virtual function pointer for g_thread_join()
/// </para>
/// </summary>

public IntPtr thread_join;
	/// <summary>
/// <para>
/// virtual function pointer for g_thread_exit()
/// </para>
/// </summary>

public IntPtr thread_exit;
	/// <summary>
/// <para>
/// virtual function pointer for
///                       g_thread_set_priority()
/// </para>
/// </summary>

public IntPtr thread_set_priority;
	/// <summary>
/// <para>
/// virtual function pointer for g_thread_self()
/// </para>
/// </summary>

public IntPtr thread_self;
	/// <summary>
/// <para>
/// used internally by recursive mutex locks and by some
///                assertion checks
/// </para>
/// </summary>

public IntPtr thread_equal;
}
