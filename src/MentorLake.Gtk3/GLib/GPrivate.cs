namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GPrivate struct is an opaque data structure to represent a
/// thread-local data key. It is approximately equivalent to the
/// pthread_setspecific()/pthread_getspecific() APIs on POSIX and to
/// TlsSetValue()/TlsGetValue() on Windows.
/// </para>
/// <para>
/// If you don't already know why you might want this functionality,
/// then you probably don't need it.
/// </para>
/// <para>
/// #GPrivate is a very limited resource (as far as 128 per program,
/// shared between all libraries). It is also not possible to destroy a
/// #GPrivate after it has been used. As such, it is only ever acceptable
/// to use #GPrivate in static scope, and even then sparingly so.
/// </para>
/// <para>
/// See G_PRIVATE_INIT() for a couple of examples.
/// </para>
/// <para>
/// The #GPrivate structure should be considered opaque.  It should only
/// be accessed via the g_private_ functions.
/// </para>
/// </summary>

public class GPrivateHandle : BaseSafeHandle
{
}


public static class GPrivateExtensions
{
/// <summary>
/// <para>
/// Returns the current value of the thread local variable @key.
/// </para>
/// <para>
/// If the value has not yet been set in this thread, %NULL is returned.
/// Values are never copied between threads (when a new thread is
/// created, for example).
/// </para>
/// </summary>

/// <param name="key">
/// a #GPrivate
/// </param>
/// <return>
/// the thread-local value
/// </return>

	public static IntPtr Get(this MentorLake.GLib.GPrivateHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GPrivate)");
		return GPrivateExterns.g_private_get(key);
	}

/// <summary>
/// <para>
/// Sets the thread local variable @key to have the value @value in the
/// current thread.
/// </para>
/// <para>
/// This function differs from g_private_set() in the following way: if
/// the previous value was non-%NULL then the #GDestroyNotify handler for
/// @key is run on it.
/// </para>
/// </summary>

/// <param name="key">
/// a #GPrivate
/// </param>
/// <param name="value">
/// the new value
/// </param>

	public static void Replace(this MentorLake.GLib.GPrivateHandle key, IntPtr value)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GPrivate)");
		GPrivateExterns.g_private_replace(key, value);
	}

/// <summary>
/// <para>
/// Sets the thread local variable @key to have the value @value in the
/// current thread.
/// </para>
/// <para>
/// This function differs from g_private_replace() in the following way:
/// the #GDestroyNotify for @key is not called on the old value.
/// </para>
/// </summary>

/// <param name="key">
/// a #GPrivate
/// </param>
/// <param name="value">
/// the new value
/// </param>

	public static void Set(this MentorLake.GLib.GPrivateHandle key, IntPtr value)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GPrivate)");
		GPrivateExterns.g_private_set(key, value);
	}


	public static GPrivate Dereference(this GPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPrivate>(x.DangerousGetHandle());
}
internal class GPrivateExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_private_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPrivateHandle>))] MentorLake.GLib.GPrivateHandle key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_private_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPrivateHandle>))] MentorLake.GLib.GPrivateHandle key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_private_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPrivateHandle>))] MentorLake.GLib.GPrivateHandle key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPrivateHandle>))]
	internal static extern MentorLake.GLib.GPrivateHandle g_private_new(MentorLake.GLib.GDestroyNotify notify);

}

/// <summary>
/// <para>
/// The #GPrivate struct is an opaque data structure to represent a
/// thread-local data key. It is approximately equivalent to the
/// pthread_setspecific()/pthread_getspecific() APIs on POSIX and to
/// TlsSetValue()/TlsGetValue() on Windows.
/// </para>
/// <para>
/// If you don't already know why you might want this functionality,
/// then you probably don't need it.
/// </para>
/// <para>
/// #GPrivate is a very limited resource (as far as 128 per program,
/// shared between all libraries). It is also not possible to destroy a
/// #GPrivate after it has been used. As such, it is only ever acceptable
/// to use #GPrivate in static scope, and even then sparingly so.
/// </para>
/// <para>
/// See G_PRIVATE_INIT() for a couple of examples.
/// </para>
/// <para>
/// The #GPrivate structure should be considered opaque.  It should only
/// be accessed via the g_private_ functions.
/// </para>
/// </summary>

public struct GPrivate
{
/// <summary>
/// <para>
/// Creates a new #GPrivate.
/// </para>
/// </summary>

/// <param name="notify">
/// a #GDestroyNotify
/// </param>
/// <return>
/// a newly allocated #GPrivate (which can never be destroyed)
/// </return>

	public static MentorLake.GLib.GPrivateHandle New(MentorLake.GLib.GDestroyNotify notify)
	{
		return GPrivateExterns.g_private_new(notify);
	}

}
