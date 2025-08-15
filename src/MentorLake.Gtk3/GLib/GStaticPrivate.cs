namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A #GStaticPrivate works almost like a #GPrivate, but it has one
/// significant advantage. It doesn&apos;t need to be created at run-time
/// like a #GPrivate, but can be defined at compile-time. This is
/// similar to the difference between #GMutex and #GStaticMutex.
/// </para>
/// <para>
/// Now look at our give_me_next_number() example with #GStaticPrivate:
/// <code>
///   int
///   int
///   give_me_next_number ()
///   {
///     static GStaticPrivate current_number_key = G_STATIC_PRIVATE_INIT;
///     int *current_number = g_static_private_get (&amp;current_number_key);
/// 
///     if (!current_number)
///       {
///         current_number = g_new (int, 1);
///         *current_number = 0;
///         g_static_private_set (&amp;current_number_key, current_number, g_free);
///       }
/// 
///     *current_number = calc_next_number (*current_number);
/// 
///     return *current_number;
///   }
/// </code>
/// </para>
/// </summary>

public class GStaticPrivateHandle : BaseSafeHandle
{
}


public static class GStaticPrivateExtensions
{
/// <summary>
/// <para>
/// Releases all resources allocated to @private_key.
/// </para>
/// <para>
/// You don&apos;t have to call this functions for a #GStaticPrivate with an
/// unbounded lifetime, i.e. objects declared &apos;static&apos;, but if you have
/// a #GStaticPrivate as a member of a structure and the structure is
/// freed, you should also free the #GStaticPrivate.
/// </para>
/// </summary>

/// <param name="private_key">
/// a #GStaticPrivate to be freed
/// </param>

	public static void Free(this MentorLake.GLib.GStaticPrivateHandle private_key)
	{
		if (private_key.IsInvalid) throw new Exception("Invalid handle (GStaticPrivate)");
		GStaticPrivateExterns.g_static_private_free(private_key);
	}

/// <summary>
/// <para>
/// Works like g_private_get() only for a #GStaticPrivate.
/// </para>
/// <para>
/// This function works even if g_thread_init() has not yet been called.
/// </para>
/// </summary>

/// <param name="private_key">
/// a #GStaticPrivate
/// </param>
/// <return>
/// the corresponding pointer
/// </return>

	public static IntPtr Get(this MentorLake.GLib.GStaticPrivateHandle private_key)
	{
		if (private_key.IsInvalid) throw new Exception("Invalid handle (GStaticPrivate)");
		return GStaticPrivateExterns.g_static_private_get(private_key);
	}

/// <summary>
/// <para>
/// Initializes @private_key. Alternatively you can initialize it with
/// %G_STATIC_PRIVATE_INIT.
/// </para>
/// </summary>

/// <param name="private_key">
/// a #GStaticPrivate to be initialized
/// </param>

	public static void Init(this MentorLake.GLib.GStaticPrivateHandle private_key)
	{
		if (private_key.IsInvalid) throw new Exception("Invalid handle (GStaticPrivate)");
		GStaticPrivateExterns.g_static_private_init(private_key);
	}

/// <summary>
/// <para>
/// Sets the pointer keyed to @private_key for the current thread and
/// the function @notify to be called with that pointer (%NULL or
/// non-%NULL), whenever the pointer is set again or whenever the
/// current thread ends.
/// </para>
/// <para>
/// This function works even if g_thread_init() has not yet been called.
/// If g_thread_init() is called later, the @data keyed to @private_key
/// will be inherited only by the main thread, i.e. the one that called
/// g_thread_init().
/// </para>
/// <para>
/// @notify is used quite differently from @destructor in g_private_new().
/// </para>
/// </summary>

/// <param name="private_key">
/// a #GStaticPrivate
/// </param>
/// <param name="data">
/// the new pointer
/// </param>
/// <param name="notify">
/// a function to be called with the pointer whenever the
///     current thread ends or sets this pointer again
/// </param>

	public static void Set(this MentorLake.GLib.GStaticPrivateHandle private_key, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		if (private_key.IsInvalid) throw new Exception("Invalid handle (GStaticPrivate)");
		GStaticPrivateExterns.g_static_private_set(private_key, data, notify);
	}


	public static GStaticPrivate Dereference(this GStaticPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStaticPrivate>(x.DangerousGetHandle());
}
internal class GStaticPrivateExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_private_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticPrivateHandle>))] MentorLake.GLib.GStaticPrivateHandle private_key);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_static_private_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticPrivateHandle>))] MentorLake.GLib.GStaticPrivateHandle private_key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_private_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticPrivateHandle>))] MentorLake.GLib.GStaticPrivateHandle private_key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_private_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticPrivateHandle>))] MentorLake.GLib.GStaticPrivateHandle private_key, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

}

/// <summary>
/// <para>
/// A #GStaticPrivate works almost like a #GPrivate, but it has one
/// significant advantage. It doesn&apos;t need to be created at run-time
/// like a #GPrivate, but can be defined at compile-time. This is
/// similar to the difference between #GMutex and #GStaticMutex.
/// </para>
/// <para>
/// Now look at our give_me_next_number() example with #GStaticPrivate:
/// <code>
///   int
///   int
///   give_me_next_number ()
///   {
///     static GStaticPrivate current_number_key = G_STATIC_PRIVATE_INIT;
///     int *current_number = g_static_private_get (&amp;current_number_key);
/// 
///     if (!current_number)
///       {
///         current_number = g_new (int, 1);
///         *current_number = 0;
///         g_static_private_set (&amp;current_number_key, current_number, g_free);
///       }
/// 
///     *current_number = calc_next_number (*current_number);
/// 
///     return *current_number;
///   }
/// </code>
/// </para>
/// </summary>

public struct GStaticPrivate
{
}
