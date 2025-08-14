namespace MentorLake.Gio;

/// <summary>
/// <para>
/// This is the function type of the callback used for the #GSource
/// returned by g_datagram_based_create_source().
/// </para>
/// </summary>

/// <param name="datagram_based">
/// the #GDatagramBased
/// </param>
/// <param name="condition">
/// the current condition at the source fired
/// </param>
/// <param name="data">
/// data passed in by the user
/// </param>
/// <return>
/// %G_SOURCE_REMOVE if the source should be removed,
///   %G_SOURCE_CONTINUE otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GDatagramBasedSourceFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle datagram_based, MentorLake.GLib.GIOCondition condition, IntPtr data);
