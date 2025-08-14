namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Enumeration representing a day of the week; %G_DATE_MONDAY,
/// %G_DATE_TUESDAY, etc. %G_DATE_BAD_WEEKDAY is an invalid weekday.
/// </para>
/// </summary>

[Flags]
public enum GDateWeekday
{
/// <summary>
/// <para>
/// invalid value
/// </para>
/// </summary>

	G_DATE_BAD_WEEKDAY = 0,
/// <summary>
/// <para>
/// Monday
/// </para>
/// </summary>

	G_DATE_MONDAY = 1,
/// <summary>
/// <para>
/// Tuesday
/// </para>
/// </summary>

	G_DATE_TUESDAY = 2,
/// <summary>
/// <para>
/// Wednesday
/// </para>
/// </summary>

	G_DATE_WEDNESDAY = 3,
/// <summary>
/// <para>
/// Thursday
/// </para>
/// </summary>

	G_DATE_THURSDAY = 4,
/// <summary>
/// <para>
/// Friday
/// </para>
/// </summary>

	G_DATE_FRIDAY = 5,
/// <summary>
/// <para>
/// Saturday
/// </para>
/// </summary>

	G_DATE_SATURDAY = 6,
/// <summary>
/// <para>
/// Sunday
/// </para>
/// </summary>

	G_DATE_SUNDAY = 7
}
