namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Enumeration representing a month; values are %G_DATE_JANUARY,
/// %G_DATE_FEBRUARY, etc. %G_DATE_BAD_MONTH is the invalid value.
/// </para>
/// </summary>

[Flags]
public enum GDateMonth
{
/// <summary>
/// <para>
/// invalid value
/// </para>
/// </summary>

	G_DATE_BAD_MONTH = 0,
/// <summary>
/// <para>
/// January
/// </para>
/// </summary>

	G_DATE_JANUARY = 1,
/// <summary>
/// <para>
/// February
/// </para>
/// </summary>

	G_DATE_FEBRUARY = 2,
/// <summary>
/// <para>
/// March
/// </para>
/// </summary>

	G_DATE_MARCH = 3,
/// <summary>
/// <para>
/// April
/// </para>
/// </summary>

	G_DATE_APRIL = 4,
/// <summary>
/// <para>
/// May
/// </para>
/// </summary>

	G_DATE_MAY = 5,
/// <summary>
/// <para>
/// June
/// </para>
/// </summary>

	G_DATE_JUNE = 6,
/// <summary>
/// <para>
/// July
/// </para>
/// </summary>

	G_DATE_JULY = 7,
/// <summary>
/// <para>
/// August
/// </para>
/// </summary>

	G_DATE_AUGUST = 8,
/// <summary>
/// <para>
/// September
/// </para>
/// </summary>

	G_DATE_SEPTEMBER = 9,
/// <summary>
/// <para>
/// October
/// </para>
/// </summary>

	G_DATE_OCTOBER = 10,
/// <summary>
/// <para>
/// November
/// </para>
/// </summary>

	G_DATE_NOVEMBER = 11,
/// <summary>
/// <para>
/// December
/// </para>
/// </summary>

	G_DATE_DECEMBER = 12
}
