namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of the @value_destroy_func and @key_destroy_func
/// functions passed to g_cache_new(). The functions are passed a
/// pointer to the #GCache key or #GCache value and should free any
/// memory and other resources associated with it.
/// </para>
/// </summary>

/// <param name="value">
/// the #GCache value to destroy
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GCacheDestroyFunc(IntPtr value);
