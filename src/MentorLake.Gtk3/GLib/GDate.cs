namespace MentorLake.GLib;

public class GDateHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GDateHandle New()
	{
		return GDateExterns.g_date_new();
	}

	public static MentorLake.GLib.GDateHandle NewDmy(MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_new_dmy(day, month, year);
	}

	public static MentorLake.GLib.GDateHandle NewJulian(uint julian_day)
	{
		return GDateExterns.g_date_new_julian(julian_day);
	}

}


public static class GDateExtensions
{
	public static void AddDays(this MentorLake.GLib.GDateHandle date, uint n_days)
	{
		GDateExterns.g_date_add_days(date, n_days);
	}

	public static void AddMonths(this MentorLake.GLib.GDateHandle date, uint n_months)
	{
		GDateExterns.g_date_add_months(date, n_months);
	}

	public static void AddYears(this MentorLake.GLib.GDateHandle date, uint n_years)
	{
		GDateExterns.g_date_add_years(date, n_years);
	}

	public static void Clamp(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateHandle min_date, MentorLake.GLib.GDateHandle max_date)
	{
		GDateExterns.g_date_clamp(date, min_date, max_date);
	}

	public static void Clear(this MentorLake.GLib.GDateHandle date, uint n_dates)
	{
		GDateExterns.g_date_clear(date, n_dates);
	}

	public static int Compare(this MentorLake.GLib.GDateHandle lhs, MentorLake.GLib.GDateHandle rhs)
	{
		return GDateExterns.g_date_compare(lhs, rhs);
	}

	public static MentorLake.GLib.GDateHandle Copy(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_copy(date);
	}

	public static int DaysBetween(this MentorLake.GLib.GDateHandle date1, MentorLake.GLib.GDateHandle date2)
	{
		return GDateExterns.g_date_days_between(date1, date2);
	}

	public static void Free(this MentorLake.GLib.GDateHandle date)
	{
		GDateExterns.g_date_free(date);
	}

	public static MentorLake.GLib.GDateDay GetDay(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_get_day(date);
	}

	public static uint GetDayOfYear(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_get_day_of_year(date);
	}

	public static uint GetIso8601WeekOfYear(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_get_iso8601_week_of_year(date);
	}

	public static uint GetJulian(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_get_julian(date);
	}

	public static uint GetMondayWeekOfYear(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_get_monday_week_of_year(date);
	}

	public static MentorLake.GLib.GDateMonth GetMonth(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_get_month(date);
	}

	public static uint GetSundayWeekOfYear(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_get_sunday_week_of_year(date);
	}

	public static MentorLake.GLib.GDateWeekday GetWeekday(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_get_weekday(date);
	}

	public static MentorLake.GLib.GDateYear GetYear(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_get_year(date);
	}

	public static bool IsFirstOfMonth(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_is_first_of_month(date);
	}

	public static bool IsLastOfMonth(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_is_last_of_month(date);
	}

	public static void Order(this MentorLake.GLib.GDateHandle date1, MentorLake.GLib.GDateHandle date2)
	{
		GDateExterns.g_date_order(date1, date2);
	}

	public static void SetDay(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateDay day)
	{
		GDateExterns.g_date_set_day(date, day);
	}

	public static void SetDmy(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear y)
	{
		GDateExterns.g_date_set_dmy(date, day, month, y);
	}

	public static void SetJulian(this MentorLake.GLib.GDateHandle date, uint julian_date)
	{
		GDateExterns.g_date_set_julian(date, julian_date);
	}

	public static void SetMonth(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateMonth month)
	{
		GDateExterns.g_date_set_month(date, month);
	}

	public static void SetParse(this MentorLake.GLib.GDateHandle date, string str)
	{
		GDateExterns.g_date_set_parse(date, str);
	}

	public static void SetTime(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GTime time_)
	{
		GDateExterns.g_date_set_time(date, time_);
	}

	public static void SetTimeT(this MentorLake.GLib.GDateHandle date, long timet)
	{
		GDateExterns.g_date_set_time_t(date, timet);
	}

	public static void SetTimeVal(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GTimeValHandle timeval)
	{
		GDateExterns.g_date_set_time_val(date, timeval);
	}

	public static void SetYear(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateYear year)
	{
		GDateExterns.g_date_set_year(date, year);
	}

	public static void SubtractDays(this MentorLake.GLib.GDateHandle date, uint n_days)
	{
		GDateExterns.g_date_subtract_days(date, n_days);
	}

	public static void SubtractMonths(this MentorLake.GLib.GDateHandle date, uint n_months)
	{
		GDateExterns.g_date_subtract_months(date, n_months);
	}

	public static void SubtractYears(this MentorLake.GLib.GDateHandle date, uint n_years)
	{
		GDateExterns.g_date_subtract_years(date, n_years);
	}

	public static void ToStructTm(this MentorLake.GLib.GDateHandle date, IntPtr tm)
	{
		GDateExterns.g_date_to_struct_tm(date, tm);
	}

	public static bool Valid(this MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_valid(date);
	}


	public static GDate Dereference(this GDateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDate>(x.DangerousGetHandle());
}
internal class GDateExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateHandle g_date_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateHandle g_date_new_dmy(MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateHandle g_date_new_julian(uint julian_day);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_add_days([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, uint n_days);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_add_months([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, uint n_months);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_add_years([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, uint n_years);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_clamp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle min_date, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle max_date);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, uint n_dates);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle lhs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle rhs);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateHandle g_date_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_days_between([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date2);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateDay g_date_get_day([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_date_get_day_of_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_date_get_iso8601_week_of_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_date_get_julian([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_date_get_monday_week_of_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateMonth g_date_get_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_date_get_sunday_week_of_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateWeekday g_date_get_weekday([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateYear g_date_get_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_is_first_of_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_is_last_of_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date2);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_set_day([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateDay day);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_set_dmy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear y);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_set_julian([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, uint julian_date);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_set_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateMonth month);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_set_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, string str);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_set_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, MentorLake.GLib.GTime time_);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_set_time_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, long timet);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_set_time_val([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle timeval);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_set_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_subtract_days([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, uint n_days);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_subtract_months([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, uint n_months);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_subtract_years([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, uint n_years);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_to_struct_tm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date, IntPtr tm);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_date_get_days_in_month(MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_date_get_monday_weeks_in_year(MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_date_get_sunday_weeks_in_year(MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_is_leap_year(MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_date_strftime(string s, UIntPtr slen, string format, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_day(MentorLake.GLib.GDateDay day);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_dmy(MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_julian(uint julian_date);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_month(MentorLake.GLib.GDateMonth month);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_weekday(MentorLake.GLib.GDateWeekday weekday);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_year(MentorLake.GLib.GDateYear year);

}

public struct GDate
{
	public uint julian_days;
	public uint julian;
	public uint dmy;
	public uint day;
	public uint month;
	public uint year;
	public static byte GetDaysInMonth(MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_get_days_in_month(month, year);
	}

	public static byte GetMondayWeeksInYear(MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_get_monday_weeks_in_year(year);
	}

	public static byte GetSundayWeeksInYear(MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_get_sunday_weeks_in_year(year);
	}

	public static bool IsLeapYear(MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_is_leap_year(year);
	}

	public static UIntPtr Strftime(string s, UIntPtr slen, string format, MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_strftime(s, slen, format, date);
	}

	public static bool ValidDay(MentorLake.GLib.GDateDay day)
	{
		return GDateExterns.g_date_valid_day(day);
	}

	public static bool ValidDmy(MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_valid_dmy(day, month, year);
	}

	public static bool ValidJulian(uint julian_date)
	{
		return GDateExterns.g_date_valid_julian(julian_date);
	}

	public static bool ValidMonth(MentorLake.GLib.GDateMonth month)
	{
		return GDateExterns.g_date_valid_month(month);
	}

	public static bool ValidWeekday(MentorLake.GLib.GDateWeekday weekday)
	{
		return GDateExterns.g_date_valid_weekday(weekday);
	}

	public static bool ValidYear(MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_valid_year(year);
	}

}
