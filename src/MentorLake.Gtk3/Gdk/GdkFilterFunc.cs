namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies the type of function used to filter native events before they are
/// converted to GDK events.
/// </para>
/// <para>
/// When a filter is called, @event is unpopulated, except for
/// `event->window`. The filter may translate the native
/// event to a GDK event and store the result in @event, or handle it without
/// translation. If the filter translates the event and processing should
/// continue, it should return %GDK_FILTER_TRANSLATE.
/// </para>
/// </summary>

/// <param name="xevent">
/// the native event to filter.
/// </param>
/// <param name="@event">
/// the GDK event to which the X event will be translated.
/// </param>
/// <param name="data">
/// user data set when the filter was installed.
/// </param>
/// <return>
/// a #GdkFilterReturn value.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gdk.GdkFilterReturn GdkFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkXEventHandle>))] MentorLake.Gdk.GdkXEventHandle xevent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr data);
