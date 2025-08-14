namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Saves a `GdkPixbuf` into a standard C file stream.
/// </para>
/// <para>
/// The optional `param_keys` and `param_values` arrays contain the keys and
/// values (in the same order) for attributes to be saved alongside the image
/// data.
/// </para>
/// </summary>

/// <param name="f">
/// the file stream into which the image should be saved
/// </param>
/// <param name="pixbuf">
/// the image to save
/// </param>
/// <param name="param_keys">
/// parameter keys to save
/// </param>
/// <param name="param_values">
/// parameter values to save
/// </param>
/// <return>
/// `TRUE` on success; in case of failure, `FALSE` is returned and
///   the `error` is set
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkPixbufModuleSaveFunc(IntPtr f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string[] param_keys, string[] param_values);
