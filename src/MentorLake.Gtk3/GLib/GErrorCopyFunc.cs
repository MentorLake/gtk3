namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of function which is called when an extended
/// error instance is copied. It is passed the pointer to the
/// destination error and source error, and should copy only the fields
/// of the private data from @src_error to @dest_error.
/// </para>
/// <para>
/// Normally, it is better to use G_DEFINE_EXTENDED_ERROR(), as it
/// already takes care of getting the private data from @src_error and
/// @dest_error.
/// </para>
/// </summary>

/// <param name="src_error">
/// source extended error
/// </param>
/// <param name="dest_error">
/// destination extended error
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GErrorCopyFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle src_error, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle dest_error);
