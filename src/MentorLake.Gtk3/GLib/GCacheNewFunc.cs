namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of the @value_new_func function passed to
/// g_cache_new(). It is passed a #GCache key and should create the
/// value corresponding to the key.
/// </para>
/// </summary>

/// <param name="key">
/// a #GCache key
/// </param>
/// <return>
/// a new #GCache value corresponding to the key.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GCacheNewFunc(IntPtr key);
