namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of the function passed to g_hash_table_foreach().
/// It is called with each key/value pair, together with the @user_data
/// parameter which is passed to g_hash_table_foreach().
/// </para>
/// </summary>

/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// the value corresponding to the key
/// </param>
/// <param name="user_data">
/// user data passed to g_hash_table_foreach()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GHFunc(IntPtr key, IntPtr value, IntPtr user_data);
