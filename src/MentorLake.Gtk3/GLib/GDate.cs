namespace MentorLake.GLib;

/// <summary>
/// <para>
/// `GDate` is a struct for calendrical calculations.
/// </para>
/// <para>
/// The `GDate` data structure represents a day between January 1, Year 1,
/// and sometime a few thousand years in the future (right now it will go
/// to the year 65535 or so, but [method@GLib.Date.set_parse] only parses up to the
/// year 8000 or so - just count on &quot;a few thousand&quot;). `GDate` is meant to
/// represent everyday dates, not astronomical dates or historical dates
/// or ISO timestamps or the like. It extrapolates the current Gregorian
/// calendar forward and backward in time; there is no attempt to change
/// the calendar to match time periods or locations. `GDate` does not store
/// time information; it represents a day.
/// </para>
/// <para>
/// The `GDate` implementation has several nice features; it is only a
/// 64-bit struct, so storing large numbers of dates is very efficient. It
/// can keep both a Julian and day-month-year representation of the date,
/// since some calculations are much easier with one representation or the
/// other. A Julian representation is simply a count of days since some
/// fixed day in the past; for #GDate the fixed day is January 1, 1 AD.
/// (&quot;Julian&quot; dates in the #GDate API aren&apos;t really Julian dates in the
/// technical sense; technically, Julian dates count from the start of the
/// Julian period, Jan 1, 4713 BC).
/// </para>
/// <para>
/// `GDate` is simple to use. First you need a &quot;blank&quot; date; you can get a
/// dynamically allocated date from [ctor@GLib.Date.new], or you can declare an
/// automatic variable or array and initialize it by calling [method@GLib.Date.clear].
/// A cleared date is safe; it&apos;s safe to call [method@GLib.Date.set_dmy] and the other
/// mutator functions to initialize the value of a cleared date. However, a cleared date
/// is initially invalid, meaning that it doesn&apos;t represent a day that exists.
/// It is undefined to call any of the date calculation routines on an invalid date.
/// If you obtain a date from a user or other unpredictable source, you should check
/// its validity with the [method@GLib.Date.valid] predicate. [method@GLib.Date.valid]
/// is also used to check for errors with [method@GLib.Date.set_parse] and other functions
/// that can fail. Dates can be invalidated by calling [method@GLib.Date.clear] again.
/// </para>
/// <para>
/// It is very important to use the API to access the `GDate` struct. Often only the
/// day-month-year or only the Julian representation is valid. Sometimes neither is valid.
/// Use the API.
/// </para>
/// <para>
/// GLib also features `GDateTime` which represents a precise time.
/// </para>
/// </summary>

public class GDateHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a #GDate and initializes
/// it to a safe state. The new date will
/// be cleared (as if you&apos;d called g_date_clear()) but invalid (it won&apos;t
/// represent an existing day). Free the return value with g_date_free().
/// </para>
/// </summary>

/// <return>
/// a newly-allocated #GDate
/// </return>

	public static MentorLake.GLib.GDateHandle New()
	{
		return GDateExterns.g_date_new();
	}

/// <summary>
/// <para>
/// Create a new #GDate representing the given day-month-year triplet.
/// </para>
/// <para>
/// The triplet you pass in must represent a valid date. Use g_date_valid_dmy()
/// if needed to validate it. The returned #GDate is guaranteed to be non-%NULL
/// and valid.
/// </para>
/// </summary>

/// <param name="day">
/// day of the month
/// </param>
/// <param name="month">
/// month of the year
/// </param>
/// <param name="year">
/// year
/// </param>
/// <return>
/// a newly-allocated #GDate
///   initialized with @day, @month, and @year
/// </return>

	public static MentorLake.GLib.GDateHandle NewDmy(MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_new_dmy(day, month, year);
	}

/// <summary>
/// <para>
/// Create a new #GDate representing the given Julian date.
/// </para>
/// <para>
/// The @julian_day you pass in must be valid. Use g_date_valid_julian() if
/// needed to validate it. The returned #GDate is guaranteed to be non-%NULL and
/// valid.
/// </para>
/// </summary>

/// <param name="julian_day">
/// days since January 1, Year 1
/// </param>
/// <return>
/// a newly-allocated #GDate initialized
///   with @julian_day
/// </return>

	public static MentorLake.GLib.GDateHandle NewJulian(uint julian_day)
	{
		return GDateExterns.g_date_new_julian(julian_day);
	}

}


public static class GDateExtensions
{
/// <summary>
/// <para>
/// Increments a date some number of days.
/// To move forward by weeks, add weeks*7 days.
/// The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to increment
/// </param>
/// <param name="n_days">
/// number of days to move the date forward
/// </param>

	public static void AddDays(this MentorLake.GLib.GDateHandle date, uint n_days)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_add_days(date, n_days);
	}

/// <summary>
/// <para>
/// Increments a date by some number of months.
/// If the day of the month is greater than 28,
/// this routine may change the day of the month
/// (because the destination month may not have
/// the current day in it). The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to increment
/// </param>
/// <param name="n_months">
/// number of months to move forward
/// </param>

	public static void AddMonths(this MentorLake.GLib.GDateHandle date, uint n_months)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_add_months(date, n_months);
	}

/// <summary>
/// <para>
/// Increments a date by some number of years.
/// If the date is February 29, and the destination
/// year is not a leap year, the date will be changed
/// to February 28. The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to increment
/// </param>
/// <param name="n_years">
/// number of years to move forward
/// </param>

	public static void AddYears(this MentorLake.GLib.GDateHandle date, uint n_years)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_add_years(date, n_years);
	}

/// <summary>
/// <para>
/// If @date is prior to @min_date, sets @date equal to @min_date.
/// If @date falls after @max_date, sets @date equal to @max_date.
/// Otherwise, @date is unchanged.
/// Either of @min_date and @max_date may be %NULL.
/// All non-%NULL dates must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to clamp
/// </param>
/// <param name="min_date">
/// minimum accepted value for @date
/// </param>
/// <param name="max_date">
/// maximum accepted value for @date
/// </param>

	public static void Clamp(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateHandle min_date, MentorLake.GLib.GDateHandle max_date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_clamp(date, min_date, max_date);
	}

/// <summary>
/// <para>
/// Initializes one or more #GDate structs to a safe but invalid
/// state. The cleared dates will not represent an existing date, but will
/// not contain garbage. Useful to init a date declared on the stack.
/// Validity can be tested with g_date_valid().
/// </para>
/// </summary>

/// <param name="date">
/// pointer to one or more dates to clear
/// </param>
/// <param name="n_dates">
/// number of dates to clear
/// </param>

	public static void Clear(this MentorLake.GLib.GDateHandle date, uint n_dates)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_clear(date, n_dates);
	}

/// <summary>
/// <para>
/// qsort()-style comparison function for dates.
/// Both dates must be valid.
/// </para>
/// </summary>

/// <param name="lhs">
/// first date to compare
/// </param>
/// <param name="rhs">
/// second date to compare
/// </param>
/// <return>
/// 0 for equal, less than zero if @lhs is less than @rhs,
///     greater than zero if @lhs is greater than @rhs
/// </return>

	public static int Compare(this MentorLake.GLib.GDateHandle lhs, MentorLake.GLib.GDateHandle rhs)
	{
		if (lhs.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_compare(lhs, rhs);
	}

/// <summary>
/// <para>
/// Copies a GDate to a newly-allocated GDate. If the input was invalid
/// (as determined by g_date_valid()), the invalid state will be copied
/// as is into the new object.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to copy
/// </param>
/// <return>
/// a newly-allocated #GDate initialized from @date
/// </return>

	public static MentorLake.GLib.GDateHandle Copy(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_copy(date);
	}

/// <summary>
/// <para>
/// Computes the number of days between two dates.
/// If @date2 is prior to @date1, the returned value is negative.
/// Both dates must be valid.
/// </para>
/// </summary>

/// <param name="date1">
/// the first date
/// </param>
/// <param name="date2">
/// the second date
/// </param>
/// <return>
/// the number of days between @date1 and @date2
/// </return>

	public static int DaysBetween(this MentorLake.GLib.GDateHandle date1, MentorLake.GLib.GDateHandle date2)
	{
		if (date1.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_days_between(date1, date2);
	}

/// <summary>
/// <para>
/// Frees a #GDate returned from g_date_new().
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to free
/// </param>

	public static void Free(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_free(date);
	}

/// <summary>
/// <para>
/// Returns the day of the month. The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to extract the day of the month from
/// </param>
/// <return>
/// day of the month
/// </return>

	public static MentorLake.GLib.GDateDay GetDay(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_get_day(date);
	}

/// <summary>
/// <para>
/// Returns the day of the year, where Jan 1 is the first day of the
/// year. The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to extract day of year from
/// </param>
/// <return>
/// day of the year
/// </return>

	public static uint GetDayOfYear(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_get_day_of_year(date);
	}

/// <summary>
/// <para>
/// Returns the week of the year, where weeks are interpreted according
/// to ISO 8601.
/// </para>
/// </summary>

/// <param name="date">
/// a valid #GDate
/// </param>
/// <return>
/// ISO 8601 week number of the year.
/// </return>

	public static uint GetIso8601WeekOfYear(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_get_iso8601_week_of_year(date);
	}

/// <summary>
/// <para>
/// Returns the Julian day or &quot;serial number&quot; of the #GDate. The
/// Julian day is simply the number of days since January 1, Year 1; i.e.,
/// January 1, Year 1 is Julian day 1; January 2, Year 1 is Julian day 2,
/// etc. The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to extract the Julian day from
/// </param>
/// <return>
/// Julian day
/// </return>

	public static uint GetJulian(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_get_julian(date);
	}

/// <summary>
/// <para>
/// Returns the week of the year, where weeks are understood to start on
/// Monday. If the date is before the first Monday of the year, return 0.
/// The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate
/// </param>
/// <return>
/// week of the year
/// </return>

	public static uint GetMondayWeekOfYear(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_get_monday_week_of_year(date);
	}

/// <summary>
/// <para>
/// Returns the month of the year. The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to get the month from
/// </param>
/// <return>
/// month of the year as a #GDateMonth
/// </return>

	public static MentorLake.GLib.GDateMonth GetMonth(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_get_month(date);
	}

/// <summary>
/// <para>
/// Returns the week of the year during which this date falls, if
/// weeks are understood to begin on Sunday. The date must be valid.
/// Can return 0 if the day is before the first Sunday of the year.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate
/// </param>
/// <return>
/// week number
/// </return>

	public static uint GetSundayWeekOfYear(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_get_sunday_week_of_year(date);
	}

/// <summary>
/// <para>
/// Returns the day of the week for a #GDate. The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate
/// </param>
/// <return>
/// day of the week as a #GDateWeekday.
/// </return>

	public static MentorLake.GLib.GDateWeekday GetWeekday(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_get_weekday(date);
	}

/// <summary>
/// <para>
/// Returns the year of a #GDate. The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate
/// </param>
/// <return>
/// year in which the date falls
/// </return>

	public static MentorLake.GLib.GDateYear GetYear(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_get_year(date);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the date is on the first of a month.
/// The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to check
/// </param>
/// <return>
/// %TRUE if the date is the first of the month
/// </return>

	public static bool IsFirstOfMonth(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_is_first_of_month(date);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the date is the last day of the month.
/// The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to check
/// </param>
/// <return>
/// %TRUE if the date is the last day of the month
/// </return>

	public static bool IsLastOfMonth(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_is_last_of_month(date);
	}

/// <summary>
/// <para>
/// Checks if @date1 is less than or equal to @date2,
/// and swap the values if this is not the case.
/// </para>
/// </summary>

/// <param name="date1">
/// the first date
/// </param>
/// <param name="date2">
/// the second date
/// </param>

	public static void Order(this MentorLake.GLib.GDateHandle date1, MentorLake.GLib.GDateHandle date2)
	{
		if (date1.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_order(date1, date2);
	}

/// <summary>
/// <para>
/// Sets the day of the month for a #GDate. If the resulting
/// day-month-year triplet is invalid, the date will be invalid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate
/// </param>
/// <param name="day">
/// day to set
/// </param>

	public static void SetDay(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateDay day)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_set_day(date, day);
	}

/// <summary>
/// <para>
/// Sets the value of a #GDate from a day, month, and year.
/// The day-month-year triplet must be valid; if you aren&apos;t
/// sure it is, call g_date_valid_dmy() to check before you
/// set it.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate
/// </param>
/// <param name="day">
/// day
/// </param>
/// <param name="month">
/// month
/// </param>
/// <param name="y">
/// year
/// </param>

	public static void SetDmy(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear y)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_set_dmy(date, day, month, y);
	}

/// <summary>
/// <para>
/// Sets the value of a #GDate from a Julian day number.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate
/// </param>
/// <param name="julian_date">
/// Julian day number (days since January 1, Year 1)
/// </param>

	public static void SetJulian(this MentorLake.GLib.GDateHandle date, uint julian_date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_set_julian(date, julian_date);
	}

/// <summary>
/// <para>
/// Sets the month of the year for a #GDate.  If the resulting
/// day-month-year triplet is invalid, the date will be invalid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate
/// </param>
/// <param name="month">
/// month to set
/// </param>

	public static void SetMonth(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateMonth month)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_set_month(date, month);
	}

/// <summary>
/// <para>
/// Parses a user-inputted string @str, and try to figure out what date it
/// represents, taking the [current locale][setlocale] into account. If the
/// string is successfully parsed, the date will be valid after the call.
/// Otherwise, it will be invalid. You should check using g_date_valid()
/// to see whether the parsing succeeded.
/// </para>
/// <para>
/// This function is not appropriate for file formats and the like; it
/// isn&apos;t very precise, and its exact behavior varies with the locale.
/// It&apos;s intended to be a heuristic routine that guesses what the user
/// means by a given string (and it does work pretty well in that
/// capacity).
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to fill in
/// </param>
/// <param name="str">
/// string to parse
/// </param>

	public static void SetParse(this MentorLake.GLib.GDateHandle date, string str)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_set_parse(date, str);
	}

/// <summary>
/// <para>
/// Sets the value of a date from a #GTime value.
/// The time to date conversion is done using the user&apos;s current timezone.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate.
/// </param>
/// <param name="time_">
/// #GTime value to set.
/// </param>

	public static void SetTime(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GTime time_)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_set_time(date, time_);
	}

/// <summary>
/// <para>
/// Sets the value of a date to the date corresponding to a time
/// specified as a time_t. The time to date conversion is done using
/// the user&apos;s current timezone.
/// </para>
/// <para>
/// To set the value of a date to the current day, you could write:
/// <code>
///  time_t now = time (NULL);
///  time_t now = time (NULL);
///  if (now == (time_t) -1)
///    // handle the error
///  g_date_set_time_t (date, now);
/// </code>
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate
/// </param>
/// <param name="timet">
/// time_t value to set
/// </param>

	public static void SetTimeT(this MentorLake.GLib.GDateHandle date, long timet)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_set_time_t(date, timet);
	}

/// <summary>
/// <para>
/// Sets the value of a date from a #GTimeVal value.  Note that the
/// @tv_usec member is ignored, because #GDate can&apos;t make use of the
/// additional precision.
/// </para>
/// <para>
/// The time to date conversion is done using the user&apos;s current timezone.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate
/// </param>
/// <param name="timeval">
/// #GTimeVal value to set
/// </param>

	public static void SetTimeVal(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GTimeValHandle timeval)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_set_time_val(date, timeval);
	}

/// <summary>
/// <para>
/// Sets the year for a #GDate. If the resulting day-month-year
/// triplet is invalid, the date will be invalid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate
/// </param>
/// <param name="year">
/// year to set
/// </param>

	public static void SetYear(this MentorLake.GLib.GDateHandle date, MentorLake.GLib.GDateYear year)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_set_year(date, year);
	}

/// <summary>
/// <para>
/// Moves a date some number of days into the past.
/// To move by weeks, just move by weeks*7 days.
/// The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to decrement
/// </param>
/// <param name="n_days">
/// number of days to move
/// </param>

	public static void SubtractDays(this MentorLake.GLib.GDateHandle date, uint n_days)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_subtract_days(date, n_days);
	}

/// <summary>
/// <para>
/// Moves a date some number of months into the past.
/// If the current day of the month doesn&apos;t exist in
/// the destination month, the day of the month
/// may change. The date must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to decrement
/// </param>
/// <param name="n_months">
/// number of months to move
/// </param>

	public static void SubtractMonths(this MentorLake.GLib.GDateHandle date, uint n_months)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_subtract_months(date, n_months);
	}

/// <summary>
/// <para>
/// Moves a date some number of years into the past.
/// If the current day doesn&apos;t exist in the destination
/// year (i.e. it&apos;s February 29 and you move to a non-leap-year)
/// then the day is changed to February 29. The date
/// must be valid.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to decrement
/// </param>
/// <param name="n_years">
/// number of years to move
/// </param>

	public static void SubtractYears(this MentorLake.GLib.GDateHandle date, uint n_years)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_subtract_years(date, n_years);
	}

/// <summary>
/// <para>
/// Fills in the date-related bits of a struct tm using the @date value.
/// Initializes the non-date parts with something safe but meaningless.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to set the struct tm from
/// </param>
/// <param name="tm">
/// struct tm to fill
/// </param>

	public static void ToStructTm(this MentorLake.GLib.GDateHandle date, IntPtr tm)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		GDateExterns.g_date_to_struct_tm(date, tm);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the #GDate represents an existing day. The date must not
/// contain garbage; it should have been initialized with g_date_clear()
/// if it wasn&apos;t allocated by one of the g_date_new() variants.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDate to check
/// </param>
/// <return>
/// Whether the date is valid
/// </return>

	public static bool Valid(this MentorLake.GLib.GDateHandle date)
	{
		if (date.IsInvalid) throw new Exception("Invalid handle (GDate)");
		return GDateExterns.g_date_valid(date);
	}


	public static GDate Dereference(this GDateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDate>(x.DangerousGetHandle());
}
internal class GDateExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))]
	internal static extern MentorLake.GLib.GDateHandle g_date_new();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))]
	internal static extern MentorLake.GLib.GDateHandle g_date_new_dmy(MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))]
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

/// <summary>
/// <para>
/// `GDate` is a struct for calendrical calculations.
/// </para>
/// <para>
/// The `GDate` data structure represents a day between January 1, Year 1,
/// and sometime a few thousand years in the future (right now it will go
/// to the year 65535 or so, but [method@GLib.Date.set_parse] only parses up to the
/// year 8000 or so - just count on &quot;a few thousand&quot;). `GDate` is meant to
/// represent everyday dates, not astronomical dates or historical dates
/// or ISO timestamps or the like. It extrapolates the current Gregorian
/// calendar forward and backward in time; there is no attempt to change
/// the calendar to match time periods or locations. `GDate` does not store
/// time information; it represents a day.
/// </para>
/// <para>
/// The `GDate` implementation has several nice features; it is only a
/// 64-bit struct, so storing large numbers of dates is very efficient. It
/// can keep both a Julian and day-month-year representation of the date,
/// since some calculations are much easier with one representation or the
/// other. A Julian representation is simply a count of days since some
/// fixed day in the past; for #GDate the fixed day is January 1, 1 AD.
/// (&quot;Julian&quot; dates in the #GDate API aren&apos;t really Julian dates in the
/// technical sense; technically, Julian dates count from the start of the
/// Julian period, Jan 1, 4713 BC).
/// </para>
/// <para>
/// `GDate` is simple to use. First you need a &quot;blank&quot; date; you can get a
/// dynamically allocated date from [ctor@GLib.Date.new], or you can declare an
/// automatic variable or array and initialize it by calling [method@GLib.Date.clear].
/// A cleared date is safe; it&apos;s safe to call [method@GLib.Date.set_dmy] and the other
/// mutator functions to initialize the value of a cleared date. However, a cleared date
/// is initially invalid, meaning that it doesn&apos;t represent a day that exists.
/// It is undefined to call any of the date calculation routines on an invalid date.
/// If you obtain a date from a user or other unpredictable source, you should check
/// its validity with the [method@GLib.Date.valid] predicate. [method@GLib.Date.valid]
/// is also used to check for errors with [method@GLib.Date.set_parse] and other functions
/// that can fail. Dates can be invalidated by calling [method@GLib.Date.clear] again.
/// </para>
/// <para>
/// It is very important to use the API to access the `GDate` struct. Often only the
/// day-month-year or only the Julian representation is valid. Sometimes neither is valid.
/// Use the API.
/// </para>
/// <para>
/// GLib also features `GDateTime` which represents a precise time.
/// </para>
/// </summary>

public struct GDate
{
	/// <summary>
/// <para>
/// the Julian representation of the date
/// </para>
/// </summary>

public uint julian_days;
	/// <summary>
/// <para>
/// this bit is set if @julian_days is valid
/// </para>
/// </summary>

public uint julian;
	/// <summary>
/// <para>
/// this is set if @day, @month and @year are valid
/// </para>
/// </summary>

public uint dmy;
	/// <summary>
/// <para>
/// the day of the day-month-year representation of the date,
///   as a number between 1 and 31
/// </para>
/// </summary>

public uint day;
	/// <summary>
/// <para>
/// the month of the day-month-year representation of the date,
///   as a number between 1 and 12
/// </para>
/// </summary>

public uint month;
	/// <summary>
/// <para>
/// the year of the day-month-year representation of the date
/// </para>
/// </summary>

public uint year;
/// <summary>
/// <para>
/// Returns the number of days in a month, taking leap
/// years into account.
/// </para>
/// </summary>

/// <param name="month">
/// month
/// </param>
/// <param name="year">
/// year
/// </param>
/// <return>
/// number of days in @month during the @year
/// </return>

	public static byte GetDaysInMonth(MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_get_days_in_month(month, year);
	}

/// <summary>
/// <para>
/// Returns the number of weeks in the year, where weeks
/// are taken to start on Monday. Will be 52 or 53. The
/// date must be valid. (Years always have 52 7-day periods,
/// plus 1 or 2 extra days depending on whether it&apos;s a leap
/// year. This function is basically telling you how many
/// Mondays are in the year, i.e. there are 53 Mondays if
/// one of the extra days happens to be a Monday.)
/// </para>
/// </summary>

/// <param name="year">
/// a year
/// </param>
/// <return>
/// number of Mondays in the year
/// </return>

	public static byte GetMondayWeeksInYear(MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_get_monday_weeks_in_year(year);
	}

/// <summary>
/// <para>
/// Returns the number of weeks in the year, where weeks
/// are taken to start on Sunday. Will be 52 or 53. The
/// date must be valid. (Years always have 52 7-day periods,
/// plus 1 or 2 extra days depending on whether it&apos;s a leap
/// year. This function is basically telling you how many
/// Sundays are in the year, i.e. there are 53 Sundays if
/// one of the extra days happens to be a Sunday.)
/// </para>
/// </summary>

/// <param name="year">
/// year to count weeks in
/// </param>
/// <return>
/// the number of weeks in @year
/// </return>

	public static byte GetSundayWeeksInYear(MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_get_sunday_weeks_in_year(year);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the year is a leap year.
/// </para>
/// <para>
/// For the purposes of this function, leap year is every year
/// divisible by 4 unless that year is divisible by 100. If it
/// is divisible by 100 it would be a leap year only if that year
/// is also divisible by 400.
/// </para>
/// </summary>

/// <param name="year">
/// year to check
/// </param>
/// <return>
/// %TRUE if the year is a leap year
/// </return>

	public static bool IsLeapYear(MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_is_leap_year(year);
	}

/// <summary>
/// <para>
/// Generates a printed representation of the date, in a
/// [locale][setlocale]-specific way.
/// Works just like the platform&apos;s C library strftime() function,
/// but only accepts date-related formats; time-related formats
/// give undefined results. Date must be valid. Unlike strftime()
/// (which uses the locale encoding), works on a UTF-8 format
/// string and stores a UTF-8 result.
/// </para>
/// <para>
/// This function does not provide any conversion specifiers in
/// addition to those implemented by the platform&apos;s C library.
/// For example, don&apos;t expect that using g_date_strftime() would
/// make the \%F provided by the C99 strftime() work on Windows
/// where the C library only complies to C89.
/// </para>
/// </summary>

/// <param name="s">
/// destination buffer
/// </param>
/// <param name="slen">
/// buffer size
/// </param>
/// <param name="format">
/// format string
/// </param>
/// <param name="date">
/// valid #GDate
/// </param>
/// <return>
/// number of characters written to the buffer, or `0` if the buffer was too small
/// </return>

	public static UIntPtr Strftime(string s, UIntPtr slen, string format, MentorLake.GLib.GDateHandle date)
	{
		return GDateExterns.g_date_strftime(s, slen, format, date);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the day of the month is valid (a day is valid if it&apos;s
/// between 1 and 31 inclusive).
/// </para>
/// </summary>

/// <param name="day">
/// day to check
/// </param>
/// <return>
/// %TRUE if the day is valid
/// </return>

	public static bool ValidDay(MentorLake.GLib.GDateDay day)
	{
		return GDateExterns.g_date_valid_day(day);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the day-month-year triplet forms a valid, existing day
/// in the range of days #GDate understands (Year 1 or later, no more than
/// a few thousand years in the future).
/// </para>
/// </summary>

/// <param name="day">
/// day
/// </param>
/// <param name="month">
/// month
/// </param>
/// <param name="year">
/// year
/// </param>
/// <return>
/// %TRUE if the date is a valid one
/// </return>

	public static bool ValidDmy(MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_valid_dmy(day, month, year);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the Julian day is valid. Anything greater than zero
/// is basically a valid Julian, though there is a 32-bit limit.
/// </para>
/// </summary>

/// <param name="julian_date">
/// Julian day to check
/// </param>
/// <return>
/// %TRUE if the Julian day is valid
/// </return>

	public static bool ValidJulian(uint julian_date)
	{
		return GDateExterns.g_date_valid_julian(julian_date);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the month value is valid. The 12 #GDateMonth
/// enumeration values are the only valid months.
/// </para>
/// </summary>

/// <param name="month">
/// month
/// </param>
/// <return>
/// %TRUE if the month is valid
/// </return>

	public static bool ValidMonth(MentorLake.GLib.GDateMonth month)
	{
		return GDateExterns.g_date_valid_month(month);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the weekday is valid. The seven #GDateWeekday enumeration
/// values are the only valid weekdays.
/// </para>
/// </summary>

/// <param name="weekday">
/// weekday
/// </param>
/// <return>
/// %TRUE if the weekday is valid
/// </return>

	public static bool ValidWeekday(MentorLake.GLib.GDateWeekday weekday)
	{
		return GDateExterns.g_date_valid_weekday(weekday);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the year is valid. Any year greater than 0 is valid,
/// though there is a 16-bit limit to what #GDate will understand.
/// </para>
/// </summary>

/// <param name="year">
/// year
/// </param>
/// <return>
/// %TRUE if the year is valid
/// </return>

	public static bool ValidYear(MentorLake.GLib.GDateYear year)
	{
		return GDateExterns.g_date_valid_year(year);
	}

}
