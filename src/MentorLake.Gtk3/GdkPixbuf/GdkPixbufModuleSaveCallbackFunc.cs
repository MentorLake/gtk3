namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Saves a `GdkPixbuf` by calling the provided function.
/// </para>
/// <para>
/// The optional `option_keys` and `option_values` arrays contain the keys and
/// values (in the same order) for attributes to be saved alongside the image
/// data.
/// </para>
/// </summary>

/// <param name="save_func">
/// the function to call when saving
/// </param>
/// <param name="user_data">
/// the data to pass to @save_func
/// </param>
/// <param name="pixbuf">
/// the `GdkPixbuf` to save
/// </param>
/// <param name="option_keys">
/// an array of option names
/// </param>
/// <param name="option_values">
/// an array of option values
/// </param>
/// <return>
/// `TRUE` on success; in case of failure, `FALSE` is returned and
///   the `error` is set
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkPixbufModuleSaveCallbackFunc(MentorLake.GdkPixbuf.GdkPixbufSaveFunc save_func, IntPtr user_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string[] option_keys, string[] option_values);
