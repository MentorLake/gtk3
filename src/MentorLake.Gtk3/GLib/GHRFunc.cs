namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of the function passed to
/// [func@GLib.HashTable.find], [func@GLib.HashTable.foreach_remove], and
/// [func@GLib.HashTable.foreach_steal].
/// </para>
/// <para>
/// The function is called with each key/value pair, together with
/// the @user_data parameter passed to the calling function.
/// </para>
/// <para>
/// The function should return true if the key/value pair should be
/// selected, meaning it has been found or it should be removed from the
/// [struct@GLib.HashTable], depending on the calling function.
/// </para>
/// </summary>

/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// the value associated with the key
/// </param>
/// <param name="user_data">
/// user data passed to the calling function
/// </param>
/// <return>
/// true if the key/value pair should be selected, and
///   false otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GHRFunc(IntPtr key, IntPtr value, IntPtr user_data);
