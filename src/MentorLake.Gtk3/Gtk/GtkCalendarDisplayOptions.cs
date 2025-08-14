namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// These options can be used to influence the display and behaviour of a #GtkCalendar.
/// </para>
/// </summary>

[Flags]
public enum GtkCalendarDisplayOptions : uint
{
/// <summary>
/// <para>
/// Specifies that the month and year should be displayed.
/// </para>
/// </summary>

	GTK_CALENDAR_SHOW_HEADING = 1,
/// <summary>
/// <para>
/// Specifies that three letter day descriptions should be present.
/// </para>
/// </summary>

	GTK_CALENDAR_SHOW_DAY_NAMES = 2,
/// <summary>
/// <para>
/// Prevents the user from switching months with the calendar.
/// </para>
/// </summary>

	GTK_CALENDAR_NO_MONTH_CHANGE = 4,
/// <summary>
/// <para>
/// Displays each week numbers of the current year, down the
/// left side of the calendar.
/// </para>
/// </summary>

	GTK_CALENDAR_SHOW_WEEK_NUMBERS = 8,
/// <summary>
/// <para>
/// Just show an indicator, not the full details
/// text when details are provided. See gtk_calendar_set_detail_func().
/// </para>
/// </summary>

	GTK_CALENDAR_SHOW_DETAILS = 32
}
