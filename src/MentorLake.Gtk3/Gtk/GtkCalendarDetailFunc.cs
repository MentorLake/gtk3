namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// This kind of functions provide Pango markup with detail information for the
/// specified day. Examples for such details are holidays or appointments. The
/// function returns %NULL when no information is available.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar.
/// </param>
/// <param name="year">
/// the year for which details are needed.
/// </param>
/// <param name="month">
/// the month for which details are needed.
/// </param>
/// <param name="day">
/// the day of @month for which details are needed.
/// </param>
/// <param name="user_data">
/// the data passed with gtk_calendar_set_detail_func().
/// </param>
/// <return>
/// Newly allocated string with Pango markup
///     with details for the specified day or %NULL.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GtkCalendarDetailFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar, uint year, uint month, uint day, IntPtr user_data);
