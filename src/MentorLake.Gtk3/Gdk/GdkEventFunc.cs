namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies the type of function passed to gdk_event_handler_set() to
/// handle all GDK events.
/// </para>
/// </summary>

/// <param name="@event">
/// the #GdkEvent to process.
/// </param>
/// <param name="data">
/// user data set when the event handler was installed with
///   gdk_event_handler_set().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkEventFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr data);
