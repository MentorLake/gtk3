namespace MentorLake.GLib;

/// <summary>
/// <para>
/// This enumeration isn&apos;t used in the API, but may be useful if you need
/// to mark a number as a day, month, or year.
/// </para>
/// </summary>

[Flags]
public enum GDateDMY
{
/// <summary>
/// <para>
/// a day
/// </para>
/// </summary>

	G_DATE_DAY = 0,
/// <summary>
/// <para>
/// a month
/// </para>
/// </summary>

	G_DATE_MONTH = 1,
/// <summary>
/// <para>
/// a year
/// </para>
/// </summary>

	G_DATE_YEAR = 2
}
