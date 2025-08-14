namespace MentorLake.Gio;

/// <summary>
/// <para>
/// This function type is used by g_vfs_register_uri_scheme() to make it
/// possible for a client to associate a URI scheme to a different #GFile
/// implementation.
/// </para>
/// <para>
/// The client should return a reference to the new file that has been
/// created for @uri, or %NULL to continue with the default implementation.
/// </para>
/// </summary>

/// <param name="vfs">
/// a #GVfs
/// </param>
/// <param name="identifier">
/// the identifier to look up a #GFile for. This can either
///     be a URI or a parse name as returned by g_file_get_parse_name()
/// </param>
/// <param name="user_data">
/// user data passed to the function, or %NULL
/// </param>
/// <return>
/// a #GFile for @identifier.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gio.GFileHandle GVfsFileLookupFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVfsHandle>))] MentorLake.Gio.GVfsHandle vfs, string identifier, IntPtr user_data);
