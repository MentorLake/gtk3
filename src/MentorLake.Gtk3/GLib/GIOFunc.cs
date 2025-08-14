namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of function passed to g_io_add_watch() or
/// g_io_add_watch_full(), which is called when the requested condition
/// on a #GIOChannel is satisfied.
/// </para>
/// </summary>

/// <param name="source">
/// the #GIOChannel event source
/// </param>
/// <param name="condition">
/// the condition which has been satisfied
/// </param>
/// <param name="data">
/// user data set in g_io_add_watch() or g_io_add_watch_full()
/// </param>
/// <return>
/// the function should return %FALSE if the event source
///          should be removed
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GIOFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle source, MentorLake.GLib.GIOCondition condition, IntPtr data);
