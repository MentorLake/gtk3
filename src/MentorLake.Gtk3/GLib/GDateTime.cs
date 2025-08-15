namespace MentorLake.GLib;

/// <summary>
/// <para>
/// `GDateTime` is a structure that combines a Gregorian date and time
/// into a single structure.
/// </para>
/// <para>
/// `GDateTime` provides many conversion and methods to manipulate dates and times.
/// Time precision is provided down to microseconds and the time can range
/// (proleptically) from 0001-01-01 00:00:00 to 9999-12-31 23:59:59.999999.
/// `GDateTime` follows POSIX time in the sense that it is oblivious to leap
/// seconds.
/// </para>
/// <para>
/// `GDateTime` is an immutable object; once it has been created it cannot
/// be modified further. All modifiers will create a new `GDateTime`.
/// Nearly all such functions can fail due to the date or time going out
/// of range, in which case %NULL will be returned.
/// </para>
/// <para>
/// `GDateTime` is reference counted: the reference count is increased by calling
/// [method@GLib.DateTime.ref] and decreased by calling [method@GLib.DateTime.unref].
/// When the reference count drops to 0, the resources allocated by the `GDateTime`
/// structure are released.
/// </para>
/// <para>
/// Many parts of the API may produce non-obvious results. As an
/// example, adding two months to January 31st will yield March 31st
/// whereas adding one month and then one month again will yield either
/// March 28th or March 29th.  Also note that adding 24 hours is not
/// always the same as adding one day (since days containing daylight
/// savings time transitions are either 23 or 25 hours in length).
/// </para>
/// </summary>

public class GDateTimeHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GDateTime corresponding to the given date and time in
/// the time zone @tz.
/// </para>
/// <para>
/// The @year must be between 1 and 9999, @month between 1 and 12 and @day
/// between 1 and 28, 29, 30 or 31 depending on the month and the year.
/// </para>
/// <para>
/// @hour must be between 0 and 23 and @minute must be between 0 and 59.
/// </para>
/// <para>
/// @seconds must be at least 0.0 and must be strictly less than 60.0.
/// It will be rounded down to the nearest microsecond.
/// </para>
/// <para>
/// If the given time is not representable in the given time zone (for
/// example, 02:30 on March 14th 2010 in Toronto, due to daylight savings
/// time) then the time will be rounded up to the nearest existing time
/// (in this case, 03:00).  If this matters to you then you should verify
/// the return value for containing the same as the numbers you gave.
/// </para>
/// <para>
/// In the case that the given time is ambiguous in the given time zone
/// (for example, 01:30 on November 7th 2010 in Toronto, due to daylight
/// savings time) then the time falling within standard (ie:
/// non-daylight) time is taken.
/// </para>
/// <para>
/// It not considered a programmer error for the values to this function
/// to be out of range, but in the case that they are, the function will
/// return %NULL.
/// </para>
/// <para>
/// You should release the return value by calling g_date_time_unref()
/// when you are done with it.
/// </para>
/// </summary>

/// <param name="tz">
/// a #GTimeZone
/// </param>
/// <param name="year">
/// the year component of the date
/// </param>
/// <param name="month">
/// the month component of the date
/// </param>
/// <param name="day">
/// the day component of the date
/// </param>
/// <param name="hour">
/// the hour component of the date
/// </param>
/// <param name="minute">
/// the minute component of the date
/// </param>
/// <param name="seconds">
/// the number of seconds past the minute
/// </param>
/// <return>
/// a new #GDateTime, or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle New(MentorLake.GLib.GTimeZoneHandle tz, int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new(tz, year, month, day, hour, minute, seconds);
	}

/// <summary>
/// <para>
/// Creates a #GDateTime corresponding to the given
/// [ISO 8601 formatted string](https://en.wikipedia.org/wiki/ISO_8601)
/// @text. ISO 8601 strings of the form `&amp;lt;date&amp;gt;&amp;lt;sep&amp;gt;&amp;lt;time&amp;gt;&amp;lt;tz&amp;gt;` are supported, with
/// some extensions from [RFC 3339](https://tools.ietf.org/html/rfc3339) as
/// mentioned below.
/// </para>
/// <para>
/// Note that as #GDateTime &quot;is oblivious to leap seconds&quot;, leap seconds information
/// in an ISO-8601 string will be ignored, so a `23:59:60` time would be parsed as
/// `23:59:59`.
/// </para>
/// <para>
/// `&amp;lt;sep&amp;gt;` is the separator and can be either &apos;T&apos;, &apos;t&apos; or &apos; &apos;. The latter two
/// separators are an extension from
/// [RFC 3339](https://tools.ietf.org/html/rfc3339#section-5.6).
/// </para>
/// <para>
/// `&amp;lt;date&amp;gt;` is in the form:
/// </para>
/// <para>
/// - `YYYY-MM-DD` - Year/month/day, e.g. 2016-08-24.
/// - `YYYYMMDD` - Same as above without dividers.
/// - `YYYY-DDD` - Ordinal day where DDD is from 001 to 366, e.g. 2016-237.
/// - `YYYYDDD` - Same as above without dividers.
/// - `YYYY-Www-D` - Week day where ww is from 01 to 52 and D from 1-7,
///   e.g. 2016-W34-3.
/// - `YYYYWwwD` - Same as above without dividers.
/// </para>
/// <para>
/// `&amp;lt;time&amp;gt;` is in the form:
/// </para>
/// <para>
/// - `hh:mm:ss(.sss)` - Hours, minutes, seconds (subseconds), e.g. 22:10:42.123.
/// - `hhmmss(.sss)` - Same as above without dividers.
/// </para>
/// <para>
/// `&amp;lt;tz&amp;gt;` is an optional timezone suffix of the form:
/// </para>
/// <para>
/// - `Z` - UTC.
/// - `+hh:mm` or `-hh:mm` - Offset from UTC in hours and minutes, e.g. +12:00.
/// - `+hh` or `-hh` - Offset from UTC in hours, e.g. +12.
/// </para>
/// <para>
/// If the timezone is not provided in @text it must be provided in @default_tz
/// (this field is otherwise ignored).
/// </para>
/// <para>
/// This call can fail (returning %NULL) if @text is not a valid ISO 8601
/// formatted string.
/// </para>
/// <para>
/// You should release the return value by calling g_date_time_unref()
/// when you are done with it.
/// </para>
/// </summary>

/// <param name="text">
/// an ISO 8601 formatted time string.
/// </param>
/// <param name="default_tz">
/// a #GTimeZone to use if the text doesn&apos;t contain a
///                          timezone, or %NULL.
/// </param>
/// <return>
/// a new #GDateTime, or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle NewFromIso8601(string text, MentorLake.GLib.GTimeZoneHandle default_tz)
	{
		return GDateTimeExterns.g_date_time_new_from_iso8601(text, default_tz);
	}

/// <summary>
/// <para>
/// Creates a #GDateTime corresponding to the given #GTimeVal @tv in the
/// local time zone.
/// </para>
/// <para>
/// The time contained in a #GTimeVal is always stored in the form of
/// seconds elapsed since 1970-01-01 00:00:00 UTC, regardless of the
/// local time offset.
/// </para>
/// <para>
/// This call can fail (returning %NULL) if @tv represents a time outside
/// of the supported range of #GDateTime.
/// </para>
/// <para>
/// You should release the return value by calling g_date_time_unref()
/// when you are done with it.
/// </para>
/// </summary>

/// <param name="tv">
/// a #GTimeVal
/// </param>
/// <return>
/// a new #GDateTime, or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle NewFromTimevalLocal(MentorLake.GLib.GTimeValHandle tv)
	{
		return GDateTimeExterns.g_date_time_new_from_timeval_local(tv);
	}

/// <summary>
/// <para>
/// Creates a #GDateTime corresponding to the given #GTimeVal @tv in UTC.
/// </para>
/// <para>
/// The time contained in a #GTimeVal is always stored in the form of
/// seconds elapsed since 1970-01-01 00:00:00 UTC.
/// </para>
/// <para>
/// This call can fail (returning %NULL) if @tv represents a time outside
/// of the supported range of #GDateTime.
/// </para>
/// <para>
/// You should release the return value by calling g_date_time_unref()
/// when you are done with it.
/// </para>
/// </summary>

/// <param name="tv">
/// a #GTimeVal
/// </param>
/// <return>
/// a new #GDateTime, or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle NewFromTimevalUtc(MentorLake.GLib.GTimeValHandle tv)
	{
		return GDateTimeExterns.g_date_time_new_from_timeval_utc(tv);
	}

/// <summary>
/// <para>
/// Creates a #GDateTime corresponding to the given Unix time @t in the
/// local time zone.
/// </para>
/// <para>
/// Unix time is the number of seconds that have elapsed since 1970-01-01
/// 00:00:00 UTC, regardless of the local time offset.
/// </para>
/// <para>
/// This call can fail (returning %NULL) if @t represents a time outside
/// of the supported range of #GDateTime.
/// </para>
/// <para>
/// You should release the return value by calling g_date_time_unref()
/// when you are done with it.
/// </para>
/// </summary>

/// <param name="t">
/// the Unix time
/// </param>
/// <return>
/// a new #GDateTime, or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle NewFromUnixLocal(long t)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_local(t);
	}

/// <summary>
/// <para>
/// Creates a [struct@GLib.DateTime] corresponding to the given Unix time @t in the
/// local time zone.
/// </para>
/// <para>
/// Unix time is the number of microseconds that have elapsed since 1970-01-01
/// 00:00:00 UTC, regardless of the local time offset.
/// </para>
/// <para>
/// This call can fail (returning `NULL`) if @t represents a time outside
/// of the supported range of #GDateTime.
/// </para>
/// <para>
/// You should release the return value by calling [method@GLib.DateTime.unref]
/// when you are done with it.
/// </para>
/// </summary>

/// <param name="usecs">
/// the Unix time in microseconds
/// </param>
/// <return>
/// a new [struct@GLib.DateTime], or `NULL`
/// </return>

	public static MentorLake.GLib.GDateTimeHandle NewFromUnixLocalUsec(long usecs)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_local_usec(usecs);
	}

/// <summary>
/// <para>
/// Creates a #GDateTime corresponding to the given Unix time @t in UTC.
/// </para>
/// <para>
/// Unix time is the number of seconds that have elapsed since 1970-01-01
/// 00:00:00 UTC.
/// </para>
/// <para>
/// This call can fail (returning %NULL) if @t represents a time outside
/// of the supported range of #GDateTime.
/// </para>
/// <para>
/// You should release the return value by calling g_date_time_unref()
/// when you are done with it.
/// </para>
/// </summary>

/// <param name="t">
/// the Unix time
/// </param>
/// <return>
/// a new #GDateTime, or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle NewFromUnixUtc(long t)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_utc(t);
	}

/// <summary>
/// <para>
/// Creates a [struct@GLib.DateTime] corresponding to the given Unix time @t in UTC.
/// </para>
/// <para>
/// Unix time is the number of microseconds that have elapsed since 1970-01-01
/// 00:00:00 UTC.
/// </para>
/// <para>
/// This call can fail (returning `NULL`) if @t represents a time outside
/// of the supported range of #GDateTime.
/// </para>
/// <para>
/// You should release the return value by calling [method@GLib.DateTime.unref]
/// when you are done with it.
/// </para>
/// </summary>

/// <param name="usecs">
/// the Unix time in microseconds
/// </param>
/// <return>
/// a new [struct@GLib.DateTime], or `NULL`
/// </return>

	public static MentorLake.GLib.GDateTimeHandle NewFromUnixUtcUsec(long usecs)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_utc_usec(usecs);
	}

/// <summary>
/// <para>
/// Creates a new #GDateTime corresponding to the given date and time in
/// the local time zone.
/// </para>
/// <para>
/// This call is equivalent to calling g_date_time_new() with the time
/// zone returned by g_time_zone_new_local().
/// </para>
/// </summary>

/// <param name="year">
/// the year component of the date
/// </param>
/// <param name="month">
/// the month component of the date
/// </param>
/// <param name="day">
/// the day component of the date
/// </param>
/// <param name="hour">
/// the hour component of the date
/// </param>
/// <param name="minute">
/// the minute component of the date
/// </param>
/// <param name="seconds">
/// the number of seconds past the minute
/// </param>
/// <return>
/// a #GDateTime, or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle NewLocal(int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new_local(year, month, day, hour, minute, seconds);
	}

/// <summary>
/// <para>
/// Creates a #GDateTime corresponding to this exact instant in the given
/// time zone @tz.  The time is as accurate as the system allows, to a
/// maximum accuracy of 1 microsecond.
/// </para>
/// <para>
/// This function will always succeed unless GLib is still being used after the
/// year 9999.
/// </para>
/// <para>
/// You should release the return value by calling g_date_time_unref()
/// when you are done with it.
/// </para>
/// </summary>

/// <param name="tz">
/// a #GTimeZone
/// </param>
/// <return>
/// a new #GDateTime, or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle NewNow(MentorLake.GLib.GTimeZoneHandle tz)
	{
		return GDateTimeExterns.g_date_time_new_now(tz);
	}

/// <summary>
/// <para>
/// Creates a #GDateTime corresponding to this exact instant in the local
/// time zone.
/// </para>
/// <para>
/// This is equivalent to calling g_date_time_new_now() with the time
/// zone returned by g_time_zone_new_local().
/// </para>
/// </summary>

/// <return>
/// a new #GDateTime, or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle NewNowLocal()
	{
		return GDateTimeExterns.g_date_time_new_now_local();
	}

/// <summary>
/// <para>
/// Creates a #GDateTime corresponding to this exact instant in UTC.
/// </para>
/// <para>
/// This is equivalent to calling g_date_time_new_now() with the time
/// zone returned by g_time_zone_new_utc().
/// </para>
/// </summary>

/// <return>
/// a new #GDateTime, or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle NewNowUtc()
	{
		return GDateTimeExterns.g_date_time_new_now_utc();
	}

/// <summary>
/// <para>
/// Creates a new #GDateTime corresponding to the given date and time in
/// UTC.
/// </para>
/// <para>
/// This call is equivalent to calling g_date_time_new() with the time
/// zone returned by g_time_zone_new_utc().
/// </para>
/// </summary>

/// <param name="year">
/// the year component of the date
/// </param>
/// <param name="month">
/// the month component of the date
/// </param>
/// <param name="day">
/// the day component of the date
/// </param>
/// <param name="hour">
/// the hour component of the date
/// </param>
/// <param name="minute">
/// the minute component of the date
/// </param>
/// <param name="seconds">
/// the number of seconds past the minute
/// </param>
/// <return>
/// a #GDateTime, or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle NewUtc(int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new_utc(year, month, day, hour, minute, seconds);
	}

}


public static class GDateTimeExtensions
{
/// <summary>
/// <para>
/// Creates a copy of @datetime and adds the specified timespan to the copy.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <param name="timespan">
/// a #GTimeSpan
/// </param>
/// <return>
/// the newly created #GDateTime which
///   should be freed with g_date_time_unref(), or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle Add(this MentorLake.GLib.GDateTimeHandle datetime, MentorLake.GLib.GTimeSpan timespan)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add(datetime, timespan);
	}

/// <summary>
/// <para>
/// Creates a copy of @datetime and adds the specified number of days to the
/// copy. Add negative values to subtract days.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <param name="days">
/// the number of days
/// </param>
/// <return>
/// the newly created #GDateTime which
///   should be freed with g_date_time_unref(), or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle AddDays(this MentorLake.GLib.GDateTimeHandle datetime, int days)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_days(datetime, days);
	}

/// <summary>
/// <para>
/// Creates a new #GDateTime adding the specified values to the current date and
/// time in @datetime. Add negative values to subtract.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <param name="years">
/// the number of years to add
/// </param>
/// <param name="months">
/// the number of months to add
/// </param>
/// <param name="days">
/// the number of days to add
/// </param>
/// <param name="hours">
/// the number of hours to add
/// </param>
/// <param name="minutes">
/// the number of minutes to add
/// </param>
/// <param name="seconds">
/// the number of seconds to add
/// </param>
/// <return>
/// the newly created #GDateTime which
///   should be freed with g_date_time_unref(), or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle AddFull(this MentorLake.GLib.GDateTimeHandle datetime, int years, int months, int days, int hours, int minutes, double seconds)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_full(datetime, years, months, days, hours, minutes, seconds);
	}

/// <summary>
/// <para>
/// Creates a copy of @datetime and adds the specified number of hours.
/// Add negative values to subtract hours.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <param name="hours">
/// the number of hours to add
/// </param>
/// <return>
/// the newly created #GDateTime which
///   should be freed with g_date_time_unref(), or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle AddHours(this MentorLake.GLib.GDateTimeHandle datetime, int hours)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_hours(datetime, hours);
	}

/// <summary>
/// <para>
/// Creates a copy of @datetime adding the specified number of minutes.
/// Add negative values to subtract minutes.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <param name="minutes">
/// the number of minutes to add
/// </param>
/// <return>
/// the newly created #GDateTime which
///   should be freed with g_date_time_unref(), or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle AddMinutes(this MentorLake.GLib.GDateTimeHandle datetime, int minutes)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_minutes(datetime, minutes);
	}

/// <summary>
/// <para>
/// Creates a copy of @datetime and adds the specified number of months to the
/// copy. Add negative values to subtract months.
/// </para>
/// <para>
/// The day of the month of the resulting #GDateTime is clamped to the number
/// of days in the updated calendar month. For example, if adding 1 month to
/// 31st January 2018, the result would be 28th February 2018. In 2020 (a leap
/// year), the result would be 29th February.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <param name="months">
/// the number of months
/// </param>
/// <return>
/// the newly created #GDateTime which
///   should be freed with g_date_time_unref(), or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle AddMonths(this MentorLake.GLib.GDateTimeHandle datetime, int months)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_months(datetime, months);
	}

/// <summary>
/// <para>
/// Creates a copy of @datetime and adds the specified number of seconds.
/// Add negative values to subtract seconds.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <param name="seconds">
/// the number of seconds to add
/// </param>
/// <return>
/// the newly created #GDateTime which
///   should be freed with g_date_time_unref(), or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle AddSeconds(this MentorLake.GLib.GDateTimeHandle datetime, double seconds)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_seconds(datetime, seconds);
	}

/// <summary>
/// <para>
/// Creates a copy of @datetime and adds the specified number of weeks to the
/// copy. Add negative values to subtract weeks.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <param name="weeks">
/// the number of weeks
/// </param>
/// <return>
/// the newly created #GDateTime which
///   should be freed with g_date_time_unref(), or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle AddWeeks(this MentorLake.GLib.GDateTimeHandle datetime, int weeks)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_weeks(datetime, weeks);
	}

/// <summary>
/// <para>
/// Creates a copy of @datetime and adds the specified number of years to the
/// copy. Add negative values to subtract years.
/// </para>
/// <para>
/// As with g_date_time_add_months(), if the resulting date would be 29th
/// February on a non-leap year, the day will be clamped to 28th February.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <param name="years">
/// the number of years
/// </param>
/// <return>
/// the newly created #GDateTime which
///   should be freed with g_date_time_unref(), or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle AddYears(this MentorLake.GLib.GDateTimeHandle datetime, int years)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_add_years(datetime, years);
	}

/// <summary>
/// <para>
/// A comparison function for #GDateTimes that is suitable
/// as a #GCompareFunc. Both #GDateTimes must be non-%NULL.
/// </para>
/// </summary>

/// <param name="dt1">
/// first #GDateTime to compare
/// </param>
/// <param name="dt2">
/// second #GDateTime to compare
/// </param>
/// <return>
/// -1, 0 or 1 if @dt1 is less than, equal to or greater
///   than @dt2.
/// </return>

	public static int Compare(this MentorLake.GLib.GDateTimeHandle dt1, MentorLake.GLib.GDateTimeHandle dt2)
	{
		if (dt1.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_compare(dt1, dt2);
	}

/// <summary>
/// <para>
/// Calculates the difference in time between @end and @begin.  The
/// #GTimeSpan that is returned is effectively @end - @begin (ie:
/// positive if the first parameter is larger).
/// </para>
/// </summary>

/// <param name="end">
/// a #GDateTime
/// </param>
/// <param name="begin">
/// a #GDateTime
/// </param>
/// <return>
/// the difference between the two #GDateTime, as a time
///   span expressed in microseconds.
/// </return>

	public static MentorLake.GLib.GTimeSpan Difference(this MentorLake.GLib.GDateTimeHandle end, MentorLake.GLib.GDateTimeHandle begin)
	{
		if (end.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_difference(end, begin);
	}

/// <summary>
/// <para>
/// Checks to see if @dt1 and @dt2 are equal.
/// </para>
/// <para>
/// Equal here means that they represent the same moment after converting
/// them to the same time zone.
/// </para>
/// </summary>

/// <param name="dt1">
/// a #GDateTime
/// </param>
/// <param name="dt2">
/// a #GDateTime
/// </param>
/// <return>
/// %TRUE if @dt1 and @dt2 are equal
/// </return>

	public static bool Equal(this MentorLake.GLib.GDateTimeHandle dt1, MentorLake.GLib.GDateTimeHandle dt2)
	{
		if (dt1.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_equal(dt1, dt2);
	}

/// <summary>
/// <para>
/// Creates a newly allocated string representing the requested @format.
/// </para>
/// <para>
/// The format strings understood by this function are a subset of the
/// `strftime()` format language as specified by C99.  The `%D`, `%U` and `%W`
/// conversions are not supported, nor is the `E` modifier.  The GNU
/// extensions `%k`, `%l`, `%s` and `%P` are supported, however, as are the
/// `0`, `_` and `-` modifiers. The Python extension `%f` is also supported.
/// </para>
/// <para>
/// In contrast to `strftime()`, this function always produces a UTF-8
/// string, regardless of the current locale.  Note that the rendering of
/// many formats is locale-dependent and may not match the `strftime()`
/// output exactly.
/// </para>
/// <para>
/// The following format specifiers are supported:
/// </para>
/// <para>
/// - `%a`: the abbreviated weekday name according to the current locale
/// - `%A`: the full weekday name according to the current locale
/// - `%b`: the abbreviated month name according to the current locale
/// - `%B`: the full month name according to the current locale
/// - `%c`: the preferred date and time representation for the current locale
/// - `%C`: the century number (year/100) as a 2-digit integer (00-99)
/// - `%d`: the day of the month as a decimal number (range 01 to 31)
/// - `%e`: the day of the month as a decimal number (range 1 to 31);
///   single digits are preceded by a figure space (U+2007)
/// - `%F`: equivalent to `%Y-%m-%d` (the ISO 8601 date format)
/// - `%g`: the last two digits of the ISO 8601 week-based year as a
///   decimal number (00-99). This works well with `%V` and `%u`.
/// - `%G`: the ISO 8601 week-based year as a decimal number. This works
///   well with `%V` and `%u`.
/// - `%h`: equivalent to `%b`
/// - `%H`: the hour as a decimal number using a 24-hour clock (range 00 to 23)
/// - `%I`: the hour as a decimal number using a 12-hour clock (range 01 to 12)
/// - `%j`: the day of the year as a decimal number (range 001 to 366)
/// - `%k`: the hour (24-hour clock) as a decimal number (range 0 to 23);
///   single digits are preceded by a figure space (U+2007)
/// - `%l`: the hour (12-hour clock) as a decimal number (range 1 to 12);
///   single digits are preceded by a figure space (U+2007)
/// - `%m`: the month as a decimal number (range 01 to 12)
/// - `%M`: the minute as a decimal number (range 00 to 59)
/// - `%f`: the microsecond as a decimal number (range 000000 to 999999)
/// - `%p`: either ‘AM’ or ‘PM’ according to the given time value, or the
///   corresponding  strings for the current locale.  Noon is treated as
///   ‘PM’ and midnight as ‘AM’. Use of this format specifier is discouraged, as
///   many locales have no concept of AM/PM formatting. Use `%c` or `%X` instead.
/// - `%P`: like `%p` but lowercase: ‘am’ or ‘pm’ or a corresponding string for
///   the current locale. Use of this format specifier is discouraged, as
///   many locales have no concept of AM/PM formatting. Use `%c` or `%X` instead.
/// - `%r`: the time in a.m. or p.m. notation. Use of this format specifier is
///   discouraged, as many locales have no concept of AM/PM formatting. Use `%c`
///   or `%X` instead.
/// - `%R`: the time in 24-hour notation (`%H:%M`)
/// - `%s`: the number of seconds since the Epoch, that is, since 1970-01-01
///   00:00:00 UTC
/// - `%S`: the second as a decimal number (range 00 to 60)
/// - `%t`: a tab character
/// - `%T`: the time in 24-hour notation with seconds (`%H:%M:%S`)
/// - `%u`: the ISO 8601 standard day of the week as a decimal, range 1 to 7,
///    Monday being 1. This works well with `%G` and `%V`.
/// - `%V`: the ISO 8601 standard week number of the current year as a decimal
///   number, range 01 to 53, where week 1 is the first week that has at
///   least 4 days in the new year. See g_date_time_get_week_of_year().
///   This works well with `%G` and `%u`.
/// - `%w`: the day of the week as a decimal, range 0 to 6, Sunday being 0.
///   This is not the ISO 8601 standard format — use `%u` instead.
/// - `%x`: the preferred date representation for the current locale without
///   the time
/// - `%X`: the preferred time representation for the current locale without
///   the date
/// - `%y`: the year as a decimal number without the century
/// - `%Y`: the year as a decimal number including the century
/// - `%z`: the time zone as an offset from UTC (`+hhmm`)
/// - `%:z`: the time zone as an offset from UTC (`+hh:mm`).
///   This is a gnulib `strftime()` extension. Since: 2.38
/// - `%::z`: the time zone as an offset from UTC (`+hh:mm:ss`). This is a
///   gnulib `strftime()` extension. Since: 2.38
/// - `%:::z`: the time zone as an offset from UTC, with `:` to necessary
///   precision (e.g., `-04`, `+05:30`). This is a gnulib `strftime()` extension. Since: 2.38
/// - `%Z`: the time zone or name or abbreviation
/// - `%%`: a literal `%` character
/// </para>
/// <para>
/// Some conversion specifications can be modified by preceding the
/// conversion specifier by one or more modifier characters.
/// </para>
/// <para>
/// The following modifiers are supported for many of the numeric
/// conversions:
/// </para>
/// <para>
/// - `O`: Use alternative numeric symbols, if the current locale supports those.
/// - `_`: Pad a numeric result with spaces. This overrides the default padding
///   for the specifier.
/// - `-`: Do not pad a numeric result. This overrides the default padding
///   for the specifier.
/// - `0`: Pad a numeric result with zeros. This overrides the default padding
///   for the specifier.
/// </para>
/// <para>
/// The following modifiers are supported for many of the alphabetic conversions:
/// </para>
/// <para>
/// - `^`: Use upper case if possible. This is a gnulib `strftime()` extension.
///   Since: 2.80
/// - `#`: Use opposite case if possible. This is a gnulib `strftime()`
///   extension. Since: 2.80
/// </para>
/// <para>
/// Additionally, when `O` is used with `B`, `b`, or `h`, it produces the alternative
/// form of a month name. The alternative form should be used when the month
/// name is used without a day number (e.g., standalone). It is required in
/// some languages (Baltic, Slavic, Greek, and more) due to their grammatical
/// rules. For other languages there is no difference. `%OB` is a GNU and BSD
/// `strftime()` extension expected to be added to the future POSIX specification,
/// `%Ob` and `%Oh` are GNU `strftime()` extensions. Since: 2.56
/// </para>
/// <para>
/// Since GLib 2.80, when `E` is used with `%c`, `%C`, `%x`, `%X`, `%y` or `%Y`,
/// the date is formatted using an alternate era representation specific to the
/// locale. This is typically used for the Thai solar calendar or Japanese era
/// names, for example.
/// </para>
/// <para>
/// - `%Ec`: the preferred date and time representation for the current locale,
///   using the alternate era representation
/// - `%EC`: the name of the era
/// - `%Ex`: the preferred date representation for the current locale without
///   the time, using the alternate era representation
/// - `%EX`: the preferred time representation for the current locale without
///   the date, using the alternate era representation
/// - `%Ey`: the year since the beginning of the era denoted by the `%EC`
///   specifier
/// - `%EY`: the full alternative year representation
/// </para>
/// </summary>

/// <param name="datetime">
/// A #GDateTime
/// </param>
/// <param name="format">
/// a valid UTF-8 string, containing the format for the
///          #GDateTime
/// </param>
/// <return>
/// a newly allocated string formatted to
///    the requested format or %NULL in the case that there was an error (such
///    as a format specifier not being supported in the current locale). The
///    string should be freed with g_free().
/// </return>

	public static string Format(this MentorLake.GLib.GDateTimeHandle datetime, string format)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_format(datetime, format);
	}

/// <summary>
/// <para>
/// Format @datetime in [ISO 8601 format](https://en.wikipedia.org/wiki/ISO_8601),
/// including the date, time and time zone, and return that as a UTF-8 encoded
/// string.
/// </para>
/// <para>
/// Since GLib 2.66, this will output to sub-second precision if needed.
/// </para>
/// </summary>

/// <param name="datetime">
/// A #GDateTime
/// </param>
/// <return>
/// a newly allocated string formatted in
///   ISO 8601 format or %NULL in the case that there was an error. The string
///   should be freed with g_free().
/// </return>

	public static string FormatIso8601(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_format_iso8601(datetime);
	}

/// <summary>
/// <para>
/// Retrieves the day of the month represented by @datetime in the gregorian
/// calendar.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the day of the month
/// </return>

	public static int GetDayOfMonth(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_day_of_month(datetime);
	}

/// <summary>
/// <para>
/// Retrieves the ISO 8601 day of the week on which @datetime falls (1 is
/// Monday, 2 is Tuesday... 7 is Sunday).
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the day of the week
/// </return>

	public static int GetDayOfWeek(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_day_of_week(datetime);
	}

/// <summary>
/// <para>
/// Retrieves the day of the year represented by @datetime in the Gregorian
/// calendar.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the day of the year
/// </return>

	public static int GetDayOfYear(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_day_of_year(datetime);
	}

/// <summary>
/// <para>
/// Retrieves the hour of the day represented by @datetime
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the hour of the day
/// </return>

	public static int GetHour(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_hour(datetime);
	}

/// <summary>
/// <para>
/// Retrieves the microsecond of the date represented by @datetime
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the microsecond of the second
/// </return>

	public static int GetMicrosecond(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_microsecond(datetime);
	}

/// <summary>
/// <para>
/// Retrieves the minute of the hour represented by @datetime
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the minute of the hour
/// </return>

	public static int GetMinute(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_minute(datetime);
	}

/// <summary>
/// <para>
/// Retrieves the month of the year represented by @datetime in the Gregorian
/// calendar.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the month represented by @datetime
/// </return>

	public static int GetMonth(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_month(datetime);
	}

/// <summary>
/// <para>
/// Retrieves the second of the minute represented by @datetime
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the second represented by @datetime
/// </return>

	public static int GetSecond(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_second(datetime);
	}

/// <summary>
/// <para>
/// Retrieves the number of seconds since the start of the last minute,
/// including the fractional part.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the number of seconds
/// </return>

	public static double GetSeconds(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_seconds(datetime);
	}

/// <summary>
/// <para>
/// Get the time zone for this @datetime.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the time zone
/// </return>

	public static MentorLake.GLib.GTimeZoneHandle GetTimezone(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_timezone(datetime);
	}

/// <summary>
/// <para>
/// Determines the time zone abbreviation to be used at the time and in
/// the time zone of @datetime.
/// </para>
/// <para>
/// For example, in Toronto this is currently &quot;EST&quot; during the winter
/// months and &quot;EDT&quot; during the summer months when daylight savings
/// time is in effect.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the time zone abbreviation. The returned
///          string is owned by the #GDateTime and it should not be
///          modified or freed
/// </return>

	public static string GetTimezoneAbbreviation(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_timezone_abbreviation(datetime);
	}

/// <summary>
/// <para>
/// Determines the offset to UTC in effect at the time and in the time
/// zone of @datetime.
/// </para>
/// <para>
/// The offset is the number of microseconds that you add to UTC time to
/// arrive at local time for the time zone (ie: negative numbers for time
/// zones west of GMT, positive numbers for east).
/// </para>
/// <para>
/// If @datetime represents UTC time, then the offset is always zero.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the number of microseconds that should be added to UTC to
///          get the local time
/// </return>

	public static MentorLake.GLib.GTimeSpan GetUtcOffset(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_utc_offset(datetime);
	}

/// <summary>
/// <para>
/// Returns the ISO 8601 week-numbering year in which the week containing
/// @datetime falls.
/// </para>
/// <para>
/// This function, taken together with g_date_time_get_week_of_year() and
/// g_date_time_get_day_of_week() can be used to determine the full ISO
/// week date on which @datetime falls.
/// </para>
/// <para>
/// This is usually equal to the normal Gregorian year (as returned by
/// g_date_time_get_year()), except as detailed below:
/// </para>
/// <para>
/// For Thursday, the week-numbering year is always equal to the usual
/// calendar year.  For other days, the number is such that every day
/// within a complete week (Monday to Sunday) is contained within the
/// same week-numbering year.
/// </para>
/// <para>
/// For Monday, Tuesday and Wednesday occurring near the end of the year,
/// this may mean that the week-numbering year is one greater than the
/// calendar year (so that these days have the same week-numbering year
/// as the Thursday occurring early in the next year).
/// </para>
/// <para>
/// For Friday, Saturday and Sunday occurring near the start of the year,
/// this may mean that the week-numbering year is one less than the
/// calendar year (so that these days have the same week-numbering year
/// as the Thursday occurring late in the previous year).
/// </para>
/// <para>
/// An equivalent description is that the week-numbering year is equal to
/// the calendar year containing the majority of the days in the current
/// week (Monday to Sunday).
/// </para>
/// <para>
/// Note that January 1 0001 in the proleptic Gregorian calendar is a
/// Monday, so this function never returns 0.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the ISO 8601 week-numbering year for @datetime
/// </return>

	public static int GetWeekNumberingYear(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_week_numbering_year(datetime);
	}

/// <summary>
/// <para>
/// Returns the ISO 8601 week number for the week containing @datetime.
/// The ISO 8601 week number is the same for every day of the week (from
/// Moday through Sunday).  That can produce some unusual results
/// (described below).
/// </para>
/// <para>
/// The first week of the year is week 1.  This is the week that contains
/// the first Thursday of the year.  Equivalently, this is the first week
/// that has more than 4 of its days falling within the calendar year.
/// </para>
/// <para>
/// The value 0 is never returned by this function.  Days contained
/// within a year but occurring before the first ISO 8601 week of that
/// year are considered as being contained in the last week of the
/// previous year.  Similarly, the final days of a calendar year may be
/// considered as being part of the first ISO 8601 week of the next year
/// if 4 or more days of that week are contained within the new year.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the ISO 8601 week number for @datetime.
/// </return>

	public static int GetWeekOfYear(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_week_of_year(datetime);
	}

/// <summary>
/// <para>
/// Retrieves the year represented by @datetime in the Gregorian calendar.
/// </para>
/// </summary>

/// <param name="datetime">
/// A #GDateTime
/// </param>
/// <return>
/// the year represented by @datetime
/// </return>

	public static int GetYear(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_get_year(datetime);
	}

/// <summary>
/// <para>
/// Retrieves the Gregorian day, month, and year of a given #GDateTime.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime.
/// </param>
/// <param name="year">
/// the return location for the gregorian year, or %NULL.
/// </param>
/// <param name="month">
/// the return location for the month of the year, or %NULL.
/// </param>
/// <param name="day">
/// the return location for the day of the month, or %NULL.
/// </param>

	public static void GetYmd(this MentorLake.GLib.GDateTimeHandle datetime, out int year, out int month, out int day)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		GDateTimeExterns.g_date_time_get_ymd(datetime, out year, out month, out day);
	}

/// <summary>
/// <para>
/// Hashes @datetime into a #guint, suitable for use within #GHashTable.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// a #guint containing the hash
/// </return>

	public static uint Hash(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_hash(datetime);
	}

/// <summary>
/// <para>
/// Determines if daylight savings time is in effect at the time and in
/// the time zone of @datetime.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// %TRUE if daylight savings time is in effect
/// </return>

	public static bool IsDaylightSavings(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_is_daylight_savings(datetime);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @datetime by one.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the #GDateTime with the reference count increased
/// </return>

	public static MentorLake.GLib.GDateTimeHandle Ref(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_ref(datetime);
	}

/// <summary>
/// <para>
/// Creates a new #GDateTime corresponding to the same instant in time as
/// @datetime, but in the local time zone.
/// </para>
/// <para>
/// This call is equivalent to calling g_date_time_to_timezone() with the
/// time zone returned by g_time_zone_new_local().
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the newly created #GDateTime which
///   should be freed with g_date_time_unref(), or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle ToLocal(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_to_local(datetime);
	}

/// <summary>
/// <para>
/// Stores the instant in time that @datetime represents into @tv.
/// </para>
/// <para>
/// The time contained in a #GTimeVal is always stored in the form of
/// seconds elapsed since 1970-01-01 00:00:00 UTC, regardless of the time
/// zone associated with @datetime.
/// </para>
/// <para>
/// On systems where &apos;long&apos; is 32bit (ie: all 32bit systems and all
/// Windows systems), a #GTimeVal is incapable of storing the entire
/// range of values that #GDateTime is capable of expressing.  On those
/// systems, this function returns %FALSE to indicate that the time is
/// out of range.
/// </para>
/// <para>
/// On systems where &apos;long&apos; is 64bit, this function never fails.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <param name="tv">
/// a #GTimeVal to modify
/// </param>
/// <return>
/// %TRUE if successful, else %FALSE
/// </return>

	public static bool ToTimeval(this MentorLake.GLib.GDateTimeHandle datetime, MentorLake.GLib.GTimeValHandle tv)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_to_timeval(datetime, tv);
	}

/// <summary>
/// <para>
/// Create a new #GDateTime corresponding to the same instant in time as
/// @datetime, but in the time zone @tz.
/// </para>
/// <para>
/// This call can fail in the case that the time goes out of bounds.  For
/// example, converting 0001-01-01 00:00:00 UTC to a time zone west of
/// Greenwich will fail (due to the year 0 being out of range).
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <param name="tz">
/// the new #GTimeZone
/// </param>
/// <return>
/// the newly created #GDateTime which
///   should be freed with g_date_time_unref(), or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle ToTimezone(this MentorLake.GLib.GDateTimeHandle datetime, MentorLake.GLib.GTimeZoneHandle tz)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_to_timezone(datetime, tz);
	}

/// <summary>
/// <para>
/// Gives the Unix time corresponding to @datetime, rounding down to the
/// nearest second.
/// </para>
/// <para>
/// Unix time is the number of seconds that have elapsed since 1970-01-01
/// 00:00:00 UTC, regardless of the time zone associated with @datetime.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the Unix time corresponding to @datetime
/// </return>

	public static long ToUnix(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_to_unix(datetime);
	}

/// <summary>
/// <para>
/// Gives the Unix time corresponding to @datetime, in microseconds.
/// </para>
/// <para>
/// Unix time is the number of microseconds that have elapsed since 1970-01-01
/// 00:00:00 UTC, regardless of the time zone associated with @datetime.
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the Unix time corresponding to @datetime
/// </return>

	public static long ToUnixUsec(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_to_unix_usec(datetime);
	}

/// <summary>
/// <para>
/// Creates a new #GDateTime corresponding to the same instant in time as
/// @datetime, but in UTC.
/// </para>
/// <para>
/// This call is equivalent to calling g_date_time_to_timezone() with the
/// time zone returned by g_time_zone_new_utc().
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>
/// <return>
/// the newly created #GDateTime which
///   should be freed with g_date_time_unref(), or %NULL
/// </return>

	public static MentorLake.GLib.GDateTimeHandle ToUtc(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		return GDateTimeExterns.g_date_time_to_utc(datetime);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @datetime by one.
/// </para>
/// <para>
/// When the reference count reaches zero, the resources allocated by
/// @datetime are freed
/// </para>
/// </summary>

/// <param name="datetime">
/// a #GDateTime
/// </param>

	public static void Unref(this MentorLake.GLib.GDateTimeHandle datetime)
	{
		if (datetime.IsInvalid) throw new Exception("Invalid handle (GDateTime)");
		GDateTimeExterns.g_date_time_unref(datetime);
	}


	public static GDateTime Dereference(this GDateTimeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDateTime>(x.DangerousGetHandle());
}
internal class GDateTimeExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz, int year, int month, int day, int hour, int minute, double seconds);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_iso8601(string text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle default_tz);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_timeval_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle tv);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_timeval_utc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle tv);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_unix_local(long t);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_unix_local_usec(long usecs);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_unix_utc(long t);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_from_unix_utc_usec(long usecs);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_local(int year, int month, int day, int hour, int minute, double seconds);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_now([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_now_local();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_now_utc();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_new_utc(int year, int month, int day, int hour, int minute, double seconds);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, MentorLake.GLib.GTimeSpan timespan);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_days([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int days);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int years, int months, int days, int hours, int minutes, double seconds);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_hours([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int hours);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_minutes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int minutes);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_months([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int months);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_seconds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, double seconds);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_add_weeks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, int weeks);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_to_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_time_to_timeval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle tv);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_to_timezone([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_date_time_to_unix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_date_time_to_unix_usec([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_date_time_to_utc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_date_time_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle datetime);

}

/// <summary>
/// <para>
/// `GDateTime` is a structure that combines a Gregorian date and time
/// into a single structure.
/// </para>
/// <para>
/// `GDateTime` provides many conversion and methods to manipulate dates and times.
/// Time precision is provided down to microseconds and the time can range
/// (proleptically) from 0001-01-01 00:00:00 to 9999-12-31 23:59:59.999999.
/// `GDateTime` follows POSIX time in the sense that it is oblivious to leap
/// seconds.
/// </para>
/// <para>
/// `GDateTime` is an immutable object; once it has been created it cannot
/// be modified further. All modifiers will create a new `GDateTime`.
/// Nearly all such functions can fail due to the date or time going out
/// of range, in which case %NULL will be returned.
/// </para>
/// <para>
/// `GDateTime` is reference counted: the reference count is increased by calling
/// [method@GLib.DateTime.ref] and decreased by calling [method@GLib.DateTime.unref].
/// When the reference count drops to 0, the resources allocated by the `GDateTime`
/// structure are released.
/// </para>
/// <para>
/// Many parts of the API may produce non-obvious results. As an
/// example, adding two months to January 31st will yield March 31st
/// whereas adding one month and then one month again will yield either
/// March 28th or March 29th.  Also note that adding 24 hours is not
/// always the same as adding one day (since days containing daylight
/// savings time transitions are either 23 or 25 hours in length).
/// </para>
/// </summary>

public struct GDateTime
{
}
