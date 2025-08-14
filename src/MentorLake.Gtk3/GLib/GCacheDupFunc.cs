namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of the @key_dup_func function passed to
/// g_cache_new(). The function is passed a key
/// (__not__ a value as the prototype implies) and
/// should return a duplicate of the key.
/// </para>
/// </summary>

/// <param name="value">
/// the #GCache key to destroy (__not__ a
///         #GCache value as it seems)
/// </param>
/// <return>
/// a copy of the #GCache key
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GCacheDupFunc(IntPtr value);
