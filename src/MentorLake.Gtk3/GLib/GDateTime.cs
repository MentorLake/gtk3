namespace MentorLake.GLib;

public class GDateTimeHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GDateTimeHandle New(MentorLake.GLib.GTimeZoneHandle tz, int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new(tz, year, month, day, hour, minute, seconds);
	}

	public static MentorLake.GLib.GDateTimeHandle NewFromIso8601(string text, MentorLake.GLib.GTimeZoneHandle default_tz)
	{
		return GDateTimeExterns.g_date_time_new_from_iso8601(text, default_tz);
	}

	public static MentorLake.GLib.GDateTimeHandle NewFromTimevalLocal(MentorLake.GLib.GTimeValHandle tv)
	{
		return GDateTimeExterns.g_date_time_new_from_timeval_local(tv);
	}

	public static MentorLake.GLib.GDateTimeHandle NewFromTimevalUtc(MentorLake.GLib.GTimeValHandle tv)
	{
		return GDateTimeExterns.g_date_time_new_from_timeval_utc(tv);
	}

	public static MentorLake.GLib.GDateTimeHandle NewFromUnixLocal(long t)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_local(t);
	}

	public static MentorLake.GLib.GDateTimeHandle NewFromUnixLocalUsec(long usecs)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_local_usec(usecs);
	}

	public static MentorLake.GLib.GDateTimeHandle NewFromUnixUtc(long t)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_utc(t);
	}

	public static MentorLake.GLib.GDateTimeHandle NewFromUnixUtcUsec(long usecs)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_utc_usec(usecs);
	}

	public static MentorLake.GLib.GDateTimeHandle NewLocal(int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new_local(year, month, day, hour, minute, seconds);
	}

	public static MentorLake.GLib.GDateTimeHandle NewNow(MentorLake.GLib.GTimeZoneHandle tz)
	{
		return GDateTimeExterns.g_date_time_new_now(tz);
	}

	public static MentorLake.GLib.GDateTimeHandle NewNowLocal()
	{
		return GDateTimeExterns.g_date_time_new_now_local();
	}

	public static MentorLake.GLib.GDateTimeHandle NewNowUtc()
	{
		return GDateTimeExterns.g_date_time_new_now_utc();
	}

	public static MentorLake.GLib.GDateTimeHandle NewUtc(int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new_utc(year, month, day, hour, minute, seconds);
	}

}


public static class GDateTimeExtensions
{
	public static MentorLake.GLib.GDateTimeHandle Add(this MentorLake.GLib.GDateTimeHandle datetime, MentorLake.GLib.GTimeSpan timespan)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add(datetime, timespan);
	}

	public static MentorLake.GLib.GDateTimeHandle AddDays(this MentorLake.GLib.GDateTimeHandle datetime, int days)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_days(datetime, days);
	}

	public static MentorLake.GLib.GDateTimeHandle AddFull(this MentorLake.GLib.GDateTimeHandle datetime, int years, int months, int days, int hours, int minutes, double seconds)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_full(datetime, years, months, days, hours, minutes, seconds);
	}

	public static MentorLake.GLib.GDateTimeHandle AddHours(this MentorLake.GLib.GDateTimeHandle datetime, int hours)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_hours(datetime, hours);
	}

	public static MentorLake.GLib.GDateTimeHandle AddMinutes(this MentorLake.GLib.GDateTimeHandle datetime, int minutes)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_minutes(datetime, minutes);
	}

	public static MentorLake.GLib.GDateTimeHandle AddMonths(this MentorLake.GLib.GDateTimeHandle datetime, int months)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_months(datetime, months);
	}

	public static MentorLake.GLib.GDateTimeHandle AddSeconds(this MentorLake.GLib.GDateTimeHandle datetime, double seconds)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_seconds(datetime, seconds);
	}

	public static MentorLake.GLib.GDateTimeHandle AddWeeks(this MentorLake.GLib.GDateTimeHandle datetime, int weeks)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_weeks(datetime, weeks);
	}

	public static MentorLake.GLib.GDateTimeHandle AddYears(this MentorLake.GLib.GDateTimeHandle datetime, int years)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_years(datetime, years);
	}

	public static int Compare(this MentorLake.GLib.GDateTimeHandle dt1, MentorLake.GLib.GDateTimeHandle dt2)
	{
		if (dt1.IsInvalid || dt1.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_compare(dt1, dt2);
	}

	public static MentorLake.GLib.GTimeSpan Difference(this MentorLake.GLib.GDateTimeHandle end, MentorLake.GLib.GDateTimeHandle begin)
	{
		if (end.IsInvalid || end.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_difference(end, begin);
	}

	public static bool Equal(this MentorLake.GLib.GDateTimeHandle dt1, MentorLake.GLib.GDateTimeHandle dt2)
	{
		if (dt1.IsInvalid || dt1.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_equal(dt1, dt2);
	}

	public static string Format(this MentorLake.GLib.GDateTimeHandle datetime, string format)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_format(datetime, format);
	}

	public static string FormatIso8601(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_format_iso8601(datetime);
	}

	public static int GetDayOfMonth(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_day_of_month(datetime);
	}

	public static int GetDayOfWeek(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_day_of_week(datetime);
	}

	public static int GetDayOfYear(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_day_of_year(datetime);
	}

	public static int GetHour(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_hour(datetime);
	}

	public static int GetMicrosecond(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_microsecond(datetime);
	}

	public static int GetMinute(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_minute(datetime);
	}

	public static int GetMonth(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_month(datetime);
	}

	public static int GetSecond(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_second(datetime);
	}

	public static double GetSeconds(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_seconds(datetime);
	}

	public static MentorLake.GLib.GTimeZoneHandle GetTimezone(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_timezone(datetime);
	}

	public static string GetTimezoneAbbreviation(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_timezone_abbreviation(datetime);
	}

	public static MentorLake.GLib.GTimeSpan GetUtcOffset(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_utc_offset(datetime);
	}

	public static int GetWeekNumberingYear(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_week_numbering_year(datetime);
	}

	public static int GetWeekOfYear(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_week_of_year(datetime);
	}

	public static int GetYear(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_year(datetime);
	}

	public static void GetYmd(this MentorLake.GLib.GDateTimeHandle datetime, out int year, out int month, out int day)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		GDateTimeExterns.g_date_time_get_ymd(datetime, out year, out month, out day);
	}

	public static uint Hash(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_hash(datetime);
	}

	public static bool IsDaylightSavings(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_is_daylight_savings(datetime);
	}

	public static MentorLake.GLib.GDateTimeHandle Ref(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_ref(datetime);
	}

	public static MentorLake.GLib.GDateTimeHandle ToLocal(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_to_local(datetime);
	}

	public static bool ToTimeval(this MentorLake.GLib.GDateTimeHandle datetime, MentorLake.GLib.GTimeValHandle tv)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_to_timeval(datetime, tv);
	}

	public static MentorLake.GLib.GDateTimeHandle ToTimezone(this MentorLake.GLib.GDateTimeHandle datetime, MentorLake.GLib.GTimeZoneHandle tz)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_to_timezone(datetime, tz);
	}

	public static long ToUnix(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_to_unix(datetime);
	}

	public static long ToUnixUsec(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_to_unix_usec(datetime);
	}

	public static MentorLake.GLib.GDateTimeHandle ToUtc(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		return GDateTimeExterns.g_date_time_to_utc(datetime);
	}

	public static void Unref(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid || datetime.IsClosed) throw new Exception("Invalid or closed handle (GDateTime)");
		GDateTimeExterns.g_date_time_unref(datetime);
	}


	public static GDateTime Dereference(this GDateTimeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDateTime>(x.DangerousGetHandle());
}
internal class GDateTimeExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz, int year, int month, int day, int hour, int minute, double seconds);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_iso8601(string text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle default_tz);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_timeval_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle tv);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_timeval_utc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle tv);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_unix_local(long t);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_unix_local_usec(long usecs);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_unix_utc(long t);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_unix_utc_usec(long usecs);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_local(int year, int month, int day, int hour, int minute, double seconds);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_now([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_now_local();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_now_utc();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_utc(int year, int month, int day, int hour, int minute, double seconds);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, MentorLake.GLib.GTimeSpan timespan);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_days([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int days);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int years, int months, int days, int hours, int minutes, double seconds);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_hours([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int hours);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_minutes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int minutes);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_months([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int months);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_seconds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, double seconds);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_weeks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int weeks);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_years([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int years);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_time_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle dt1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle dt2);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTimeSpan g_date_time_difference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle end, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle begin);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_time_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle dt1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle dt2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_date_time_format([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, string format);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_date_time_format_iso8601([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_time_get_day_of_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_time_get_day_of_week([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_time_get_day_of_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_time_get_hour([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_time_get_microsecond([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_time_get_minute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_time_get_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_time_get_second([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_date_time_get_seconds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_date_time_get_timezone([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_date_time_get_timezone_abbreviation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTimeSpan g_date_time_get_utc_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_time_get_week_numbering_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_time_get_week_of_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_date_time_get_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_time_get_ymd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, out int year, out int month, out int day);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_date_time_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_time_is_daylight_savings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_to_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_time_to_timeval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle tv);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_to_timezone([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_date_time_to_unix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_date_time_to_unix_usec([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_to_utc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_time_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

}

public struct GDateTime
{
}
