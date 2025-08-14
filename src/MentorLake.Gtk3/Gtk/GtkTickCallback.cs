namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Callback type for adding a function to update animations. See gtk_widget_add_tick_callback().
/// </para>
/// </summary>

/// <param name="widget">
/// the widget
/// </param>
/// <param name="frame_clock">
/// the frame clock for the widget (same as calling gtk_widget_get_frame_clock())
/// </param>
/// <param name="user_data">
/// user data passed to gtk_widget_add_tick_callback().
/// </param>
/// <return>
/// %G_SOURCE_CONTINUE if the tick callback should continue to be called,
///  %G_SOURCE_REMOVE if the tick callback should be removed.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkTickCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle frame_clock, IntPtr user_data);
