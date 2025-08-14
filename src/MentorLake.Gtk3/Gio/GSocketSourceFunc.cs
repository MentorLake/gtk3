namespace MentorLake.Gio;

/// <summary>
/// <para>
/// This is the function type of the callback used for the #GSource
/// returned by g_socket_create_source().
/// </para>
/// </summary>

/// <param name="socket">
/// the #GSocket
/// </param>
/// <param name="condition">
/// the current condition at the source fired.
/// </param>
/// <param name="data">
/// data passed in by the user.
/// </param>
/// <return>
/// it should return %FALSE if the source should be removed.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSocketSourceFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition, IntPtr data);
