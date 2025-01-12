namespace MentorLake.Gtk3.GLib;

public class GDateHandle : BaseSafeHandle
{
	public static GDateHandle New()
	{
		return GDateExterns.g_date_new();
	}

	public static GDateHandle NewDmy(GDateDay day, GDateMonth month, GDateYear year)
	{
		return GDateExterns.g_date_new_dmy(day, month, year);
	}

	public static GDateHandle NewJulian(uint julian_day)
	{
		return GDateExterns.g_date_new_julian(julian_day);
	}

}


public static class GDateHandleExtensions
{
	public static T AddDays<T>(this T date, uint n_days) where T : GDateHandle
	{
		GDateExterns.g_date_add_days(date, n_days);
		return date;
	}

	public static T AddMonths<T>(this T date, uint n_months) where T : GDateHandle
	{
		GDateExterns.g_date_add_months(date, n_months);
		return date;
	}

	public static T AddYears<T>(this T date, uint n_years) where T : GDateHandle
	{
		GDateExterns.g_date_add_years(date, n_years);
		return date;
	}

	public static T Clamp<T>(this T date, GDateHandle min_date, GDateHandle max_date) where T : GDateHandle
	{
		GDateExterns.g_date_clamp(date, min_date, max_date);
		return date;
	}

	public static T Clear<T>(this T date, uint n_dates) where T : GDateHandle
	{
		GDateExterns.g_date_clear(date, n_dates);
		return date;
	}

	public static int Compare(this GDateHandle lhs, GDateHandle rhs)
	{
		return GDateExterns.g_date_compare(lhs, rhs);
	}

	public static GDateHandle Copy(this GDateHandle date)
	{
		return GDateExterns.g_date_copy(date);
	}

	public static int DaysBetween(this GDateHandle date1, GDateHandle date2)
	{
		return GDateExterns.g_date_days_between(date1, date2);
	}

	public static T Free<T>(this T date) where T : GDateHandle
	{
		GDateExterns.g_date_free(date);
		return date;
	}

	public static GDateDay GetDay(this GDateHandle date)
	{
		return GDateExterns.g_date_get_day(date);
	}

	public static uint GetDayOfYear(this GDateHandle date)
	{
		return GDateExterns.g_date_get_day_of_year(date);
	}

	public static uint GetIso8601WeekOfYear(this GDateHandle date)
	{
		return GDateExterns.g_date_get_iso8601_week_of_year(date);
	}

	public static uint GetJulian(this GDateHandle date)
	{
		return GDateExterns.g_date_get_julian(date);
	}

	public static uint GetMondayWeekOfYear(this GDateHandle date)
	{
		return GDateExterns.g_date_get_monday_week_of_year(date);
	}

	public static GDateMonth GetMonth(this GDateHandle date)
	{
		return GDateExterns.g_date_get_month(date);
	}

	public static uint GetSundayWeekOfYear(this GDateHandle date)
	{
		return GDateExterns.g_date_get_sunday_week_of_year(date);
	}

	public static GDateWeekday GetWeekday(this GDateHandle date)
	{
		return GDateExterns.g_date_get_weekday(date);
	}

	public static GDateYear GetYear(this GDateHandle date)
	{
		return GDateExterns.g_date_get_year(date);
	}

	public static bool IsFirstOfMonth(this GDateHandle date)
	{
		return GDateExterns.g_date_is_first_of_month(date);
	}

	public static bool IsLastOfMonth(this GDateHandle date)
	{
		return GDateExterns.g_date_is_last_of_month(date);
	}

	public static T Order<T>(this T date1, GDateHandle date2) where T : GDateHandle
	{
		GDateExterns.g_date_order(date1, date2);
		return date1;
	}

	public static T SetDay<T>(this T date, GDateDay day) where T : GDateHandle
	{
		GDateExterns.g_date_set_day(date, day);
		return date;
	}

	public static T SetDmy<T>(this T date, GDateDay day, GDateMonth month, GDateYear y) where T : GDateHandle
	{
		GDateExterns.g_date_set_dmy(date, day, month, y);
		return date;
	}

	public static T SetJulian<T>(this T date, uint julian_date) where T : GDateHandle
	{
		GDateExterns.g_date_set_julian(date, julian_date);
		return date;
	}

	public static T SetMonth<T>(this T date, GDateMonth month) where T : GDateHandle
	{
		GDateExterns.g_date_set_month(date, month);
		return date;
	}

	public static T SetParse<T>(this T date, string str) where T : GDateHandle
	{
		GDateExterns.g_date_set_parse(date, str);
		return date;
	}

	public static T SetTime<T>(this T date, GTime time_) where T : GDateHandle
	{
		GDateExterns.g_date_set_time(date, time_);
		return date;
	}

	public static T SetTimeT<T>(this T date, long timet) where T : GDateHandle
	{
		GDateExterns.g_date_set_time_t(date, timet);
		return date;
	}

	public static T SetTimeVal<T>(this T date, GTimeValHandle timeval) where T : GDateHandle
	{
		GDateExterns.g_date_set_time_val(date, timeval);
		return date;
	}

	public static T SetYear<T>(this T date, GDateYear year) where T : GDateHandle
	{
		GDateExterns.g_date_set_year(date, year);
		return date;
	}

	public static T SubtractDays<T>(this T date, uint n_days) where T : GDateHandle
	{
		GDateExterns.g_date_subtract_days(date, n_days);
		return date;
	}

	public static T SubtractMonths<T>(this T date, uint n_months) where T : GDateHandle
	{
		GDateExterns.g_date_subtract_months(date, n_months);
		return date;
	}

	public static T SubtractYears<T>(this T date, uint n_years) where T : GDateHandle
	{
		GDateExterns.g_date_subtract_years(date, n_years);
		return date;
	}

	public static T ToStructTm<T>(this T date, IntPtr tm) where T : GDateHandle
	{
		GDateExterns.g_date_to_struct_tm(date, tm);
		return date;
	}

	public static bool Valid(this GDateHandle date)
	{
		return GDateExterns.g_date_valid(date);
	}

	public static byte GetDaysInMonth(GDateMonth month, GDateYear year)
	{
		return GDateExterns.g_date_get_days_in_month(month, year);
	}

	public static byte GetMondayWeeksInYear(GDateYear year)
	{
		return GDateExterns.g_date_get_monday_weeks_in_year(year);
	}

	public static byte GetSundayWeeksInYear(GDateYear year)
	{
		return GDateExterns.g_date_get_sunday_weeks_in_year(year);
	}

	public static bool IsLeapYear(GDateYear year)
	{
		return GDateExterns.g_date_is_leap_year(year);
	}

	public static UIntPtr Strftime(string s, UIntPtr slen, string format, GDateHandle date)
	{
		return GDateExterns.g_date_strftime(s, slen, format, date);
	}

	public static bool ValidDay(GDateDay day)
	{
		return GDateExterns.g_date_valid_day(day);
	}

	public static bool ValidDmy(GDateDay day, GDateMonth month, GDateYear year)
	{
		return GDateExterns.g_date_valid_dmy(day, month, year);
	}

	public static bool ValidJulian(uint julian_date)
	{
		return GDateExterns.g_date_valid_julian(julian_date);
	}

	public static bool ValidMonth(GDateMonth month)
	{
		return GDateExterns.g_date_valid_month(month);
	}

	public static bool ValidWeekday(GDateWeekday weekday)
	{
		return GDateExterns.g_date_valid_weekday(weekday);
	}

	public static bool ValidYear(GDateYear year)
	{
		return GDateExterns.g_date_valid_year(year);
	}

}
internal class GDateExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GDateHandle g_date_new();

	[DllImport(Libraries.GLib)]
	internal static extern GDateHandle g_date_new_dmy(GDateDay day, GDateMonth month, GDateYear year);

	[DllImport(Libraries.GLib)]
	internal static extern GDateHandle g_date_new_julian(uint julian_day);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_add_days(GDateHandle date, uint n_days);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_add_months(GDateHandle date, uint n_months);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_add_years(GDateHandle date, uint n_years);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_clamp(GDateHandle date, GDateHandle min_date, GDateHandle max_date);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_clear(GDateHandle date, uint n_dates);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_compare(GDateHandle lhs, GDateHandle rhs);

	[DllImport(Libraries.GLib)]
	internal static extern GDateHandle g_date_copy(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_days_between(GDateHandle date1, GDateHandle date2);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_free(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern GDateDay g_date_get_day(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_date_get_day_of_year(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_date_get_iso8601_week_of_year(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_date_get_julian(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_date_get_monday_week_of_year(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern GDateMonth g_date_get_month(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_date_get_sunday_week_of_year(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern GDateWeekday g_date_get_weekday(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern GDateYear g_date_get_year(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_is_first_of_month(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_is_last_of_month(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_order(GDateHandle date1, GDateHandle date2);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_set_day(GDateHandle date, GDateDay day);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_set_dmy(GDateHandle date, GDateDay day, GDateMonth month, GDateYear y);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_set_julian(GDateHandle date, uint julian_date);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_set_month(GDateHandle date, GDateMonth month);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_set_parse(GDateHandle date, string str);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_set_time(GDateHandle date, GTime time_);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_set_time_t(GDateHandle date, long timet);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_set_time_val(GDateHandle date, GTimeValHandle timeval);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_set_year(GDateHandle date, GDateYear year);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_subtract_days(GDateHandle date, uint n_days);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_subtract_months(GDateHandle date, uint n_months);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_subtract_years(GDateHandle date, uint n_years);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_to_struct_tm(GDateHandle date, IntPtr tm);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_valid(GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern byte g_date_get_days_in_month(GDateMonth month, GDateYear year);

	[DllImport(Libraries.GLib)]
	internal static extern byte g_date_get_monday_weeks_in_year(GDateYear year);

	[DllImport(Libraries.GLib)]
	internal static extern byte g_date_get_sunday_weeks_in_year(GDateYear year);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_is_leap_year(GDateYear year);

	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_date_strftime(string s, UIntPtr slen, string format, GDateHandle date);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_valid_day(GDateDay day);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_valid_dmy(GDateDay day, GDateMonth month, GDateYear year);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_valid_julian(uint julian_date);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_valid_month(GDateMonth month);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_valid_weekday(GDateWeekday weekday);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_valid_year(GDateYear year);

}

public struct GDate
{
	public uint julian_days;
	public uint julian;
	public uint dmy;
	public uint day;
	public uint month;
	public uint year;
}
