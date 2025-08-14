namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The type of functions that are used to 'duplicate' an object.
/// What this means depends on the context, it could just be
/// incrementing the reference count, if @data is a ref-counted
/// object.
/// </para>
/// </summary>

/// <param name="data">
/// the data to duplicate
/// </param>
/// <param name="user_data">
/// user data that was specified in
///             g_datalist_id_dup_data()
/// </param>
/// <return>
/// a duplicate of data
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GDuplicateFunc(IntPtr data, IntPtr user_data);
