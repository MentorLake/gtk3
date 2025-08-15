namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A `GTimeZone` represents a time zone, at no particular point in time.
/// </para>
/// <para>
/// The `GTimeZone` struct is refcounted and immutable.
/// </para>
/// <para>
/// Each time zone has an identifier (for example, ‘Europe/London’) which is
/// platform dependent. See [ctor@GLib.TimeZone.new] for information on the
/// identifier formats. The identifier of a time zone can be retrieved using
/// [method@GLib.TimeZone.get_identifier].
/// </para>
/// <para>
/// A time zone contains a number of intervals. Each interval has an abbreviation
/// to describe it (for example, ‘PDT’), an offset to UTC and a flag indicating
/// if the daylight savings time is in effect during that interval. A time zone
/// always has at least one interval — interval 0. Note that interval abbreviations
/// are not the same as time zone identifiers (apart from ‘UTC’), and cannot be
/// passed to [ctor@GLib.TimeZone.new].
/// </para>
/// <para>
/// Every UTC time is contained within exactly one interval, but a given
/// local time may be contained within zero, one or two intervals (due to
/// incontinuities associated with daylight savings time).
/// </para>
/// <para>
/// An interval may refer to a specific period of time (eg: the duration
/// of daylight savings time during 2010) or it may refer to many periods
/// of time that share the same properties (eg: all periods of daylight
/// savings time).  It is also possible (usually for political reasons)
/// that some properties (like the abbreviation) change between intervals
/// without other properties changing.
/// </para>
/// </summary>

public class GTimeZoneHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// A version of g_time_zone_new_identifier() which returns the UTC time zone
/// if @identifier could not be parsed or loaded.
/// </para>
/// <para>
/// If you need to check whether @identifier was loaded successfully, use
/// g_time_zone_new_identifier().
/// </para>
/// </summary>

/// <param name="identifier">
/// a timezone identifier
/// </param>
/// <return>
/// the requested timezone
/// </return>

	public static MentorLake.GLib.GTimeZoneHandle New(string identifier)
	{
		return GTimeZoneExterns.g_time_zone_new(identifier);
	}

/// <summary>
/// <para>
/// Creates a #GTimeZone corresponding to @identifier. If @identifier cannot be
/// parsed or loaded, %NULL is returned.
/// </para>
/// <para>
/// @identifier can either be an RFC3339/ISO 8601 time offset or
/// something that would pass as a valid value for the `TZ` environment
/// variable (including %NULL).
/// </para>
/// <para>
/// In Windows, @identifier can also be the unlocalized name of a time
/// zone for standard time, for example &quot;Pacific Standard Time&quot;.
/// </para>
/// <para>
/// Valid RFC3339 time offsets are `&quot;Z&quot;` (for UTC) or
/// `&quot;±hh:mm&quot;`.  ISO 8601 additionally specifies
/// `&quot;±hhmm&quot;` and `&quot;±hh&quot;`.  Offsets are
/// time values to be added to Coordinated Universal Time (UTC) to get
/// the local time.
/// </para>
/// <para>
/// In UNIX, the `TZ` environment variable typically corresponds
/// to the name of a file in the zoneinfo database, an absolute path to a file
/// somewhere else, or a string in
/// &quot;std offset [dst [offset],start[/time],end[/time]]&quot; (POSIX) format.
/// There  are  no spaces in the specification. The name of standard
/// and daylight savings time zone must be three or more alphabetic
/// characters. Offsets are time values to be added to local time to
/// get Coordinated Universal Time (UTC) and should be
/// `&quot;[±]hh[[:]mm[:ss]]&quot;`.  Dates are either
/// `&quot;Jn&quot;` (Julian day with n between 1 and 365, leap
/// years not counted), `&quot;n&quot;` (zero-based Julian day
/// with n between 0 and 365) or `&quot;Mm.w.d&quot;` (day d
/// (0 &amp;lt;= d &amp;lt;= 6) of week w (1 &amp;lt;= w &amp;lt;= 5) of month m (1 &amp;lt;= m &amp;lt;= 12), day
/// 0 is a Sunday).  Times are in local wall clock time, the default is
/// 02:00:00.
/// </para>
/// <para>
/// In Windows, the &quot;tzn[+|–]hh[:mm[:ss]][dzn]&quot; format is used, but also
/// accepts POSIX format.  The Windows format uses US rules for all time
/// zones; daylight savings time is 60 minutes behind the standard time
/// with date and time of change taken from Pacific Standard Time.
/// Offsets are time values to be added to the local time to get
/// Coordinated Universal Time (UTC).
/// </para>
/// <para>
/// g_time_zone_new_local() calls this function with the value of the
/// `TZ` environment variable. This function itself is independent of
/// the value of `TZ`, but if @identifier is %NULL then `/etc/localtime`
/// will be consulted to discover the correct time zone on UNIX and the
/// registry will be consulted or GetTimeZoneInformation() will be used
/// to get the local time zone on Windows.
/// </para>
/// <para>
/// If intervals are not available, only time zone rules from `TZ`
/// environment variable or other means, then they will be computed
/// from year 1900 to 2037.  If the maximum year for the rules is
/// available and it is greater than 2037, then it will followed
/// instead.
/// </para>
/// <para>
/// See
/// [RFC3339 §5.6](http://tools.ietf.org/html/rfc3339#section-5.6)
/// for a precise definition of valid RFC3339 time offsets
/// (the `time-offset` expansion) and ISO 8601 for the
/// full list of valid time offsets.  See
/// [The GNU C Library manual](http://www.gnu.org/s/libc/manual/html_node/TZ-Variable.html)
/// for an explanation of the possible
/// values of the `TZ` environment variable. See
/// [Microsoft Time Zone Index Values](http://msdn.microsoft.com/en-us/library/ms912391%28v=winembedded.11%29.aspx)
/// for the list of time zones on Windows.
/// </para>
/// <para>
/// You should release the return value by calling g_time_zone_unref()
/// when you are done with it.
/// </para>
/// </summary>

/// <param name="identifier">
/// a timezone identifier
/// </param>
/// <return>
/// the requested timezone, or %NULL on
///     failure
/// </return>

	public static MentorLake.GLib.GTimeZoneHandle NewIdentifier(string identifier)
	{
		return GTimeZoneExterns.g_time_zone_new_identifier(identifier);
	}

/// <summary>
/// <para>
/// Creates a #GTimeZone corresponding to local time.  The local time
/// zone may change between invocations to this function; for example,
/// if the system administrator changes it.
/// </para>
/// <para>
/// This is equivalent to calling g_time_zone_new() with the value of
/// the `TZ` environment variable (including the possibility of %NULL).
/// </para>
/// <para>
/// You should release the return value by calling g_time_zone_unref()
/// when you are done with it.
/// </para>
/// </summary>

/// <return>
/// the local timezone
/// </return>

	public static MentorLake.GLib.GTimeZoneHandle NewLocal()
	{
		return GTimeZoneExterns.g_time_zone_new_local();
	}

/// <summary>
/// <para>
/// Creates a #GTimeZone corresponding to the given constant offset from UTC,
/// in seconds.
/// </para>
/// <para>
/// This is equivalent to calling g_time_zone_new() with a string in the form
/// `[+|-]hh[:mm[:ss]]`.
/// </para>
/// <para>
/// It is possible for this function to fail if @seconds is too big (greater than
/// 24 hours), in which case this function will return the UTC timezone for
/// backwards compatibility. To detect failures like this, use
/// g_time_zone_new_identifier() directly.
/// </para>
/// </summary>

/// <param name="seconds">
/// offset to UTC, in seconds
/// </param>
/// <return>
/// a timezone at the given offset from UTC, or UTC on
///   failure
/// </return>

	public static MentorLake.GLib.GTimeZoneHandle NewOffset(int seconds)
	{
		return GTimeZoneExterns.g_time_zone_new_offset(seconds);
	}

/// <summary>
/// <para>
/// Creates a #GTimeZone corresponding to UTC.
/// </para>
/// <para>
/// This is equivalent to calling g_time_zone_new() with a value like
/// &quot;Z&quot;, &quot;UTC&quot;, &quot;+00&quot;, etc.
/// </para>
/// <para>
/// You should release the return value by calling g_time_zone_unref()
/// when you are done with it.
/// </para>
/// </summary>

/// <return>
/// the universal timezone
/// </return>

	public static MentorLake.GLib.GTimeZoneHandle NewUtc()
	{
		return GTimeZoneExterns.g_time_zone_new_utc();
	}

}


public static class GTimeZoneExtensions
{
/// <summary>
/// <para>
/// Finds an interval within @tz that corresponds to the given @time_,
/// possibly adjusting @time_ if required to fit into an interval.
/// The meaning of @time_ depends on @type.
/// </para>
/// <para>
/// This function is similar to g_time_zone_find_interval(), with the
/// difference that it always succeeds (by making the adjustments
/// described below).
/// </para>
/// <para>
/// In any of the cases where g_time_zone_find_interval() succeeds then
/// this function returns the same value, without modifying @time_.
/// </para>
/// <para>
/// This function may, however, modify @time_ in order to deal with
/// non-existent times.  If the non-existent local @time_ of 02:30 were
/// requested on March 14th 2010 in Toronto then this function would
/// adjust @time_ to be 03:00 and return the interval containing the
/// adjusted time.
/// </para>
/// </summary>

/// <param name="tz">
/// a #GTimeZone
/// </param>
/// <param name="type">
/// the #GTimeType of @time_
/// </param>
/// <param name="time_">
/// a pointer to a number of seconds since January 1, 1970
/// </param>
/// <return>
/// the interval containing @time_, never -1
/// </return>

	public static int AdjustTime(this MentorLake.GLib.GTimeZoneHandle tz, MentorLake.GLib.GTimeType type, ref long time_)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_adjust_time(tz, type, ref time_);
	}

/// <summary>
/// <para>
/// Finds an interval within @tz that corresponds to the given @time_.
/// The meaning of @time_ depends on @type.
/// </para>
/// <para>
/// If @type is %G_TIME_TYPE_UNIVERSAL then this function will always
/// succeed (since universal time is monotonic and continuous).
/// </para>
/// <para>
/// Otherwise @time_ is treated as local time.  The distinction between
/// %G_TIME_TYPE_STANDARD and %G_TIME_TYPE_DAYLIGHT is ignored except in
/// the case that the given @time_ is ambiguous.  In Toronto, for example,
/// 01:30 on November 7th 2010 occurred twice (once inside of daylight
/// savings time and the next, an hour later, outside of daylight savings
/// time).  In this case, the different value of @type would result in a
/// different interval being returned.
/// </para>
/// <para>
/// It is still possible for this function to fail.  In Toronto, for
/// example, 02:00 on March 14th 2010 does not exist (due to the leap
/// forward to begin daylight savings time).  -1 is returned in that
/// case.
/// </para>
/// </summary>

/// <param name="tz">
/// a #GTimeZone
/// </param>
/// <param name="type">
/// the #GTimeType of @time_
/// </param>
/// <param name="time_">
/// a number of seconds since January 1, 1970
/// </param>
/// <return>
/// the interval containing @time_, or -1 in case of failure
/// </return>

	public static int FindInterval(this MentorLake.GLib.GTimeZoneHandle tz, MentorLake.GLib.GTimeType type, long time_)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_find_interval(tz, type, time_);
	}

/// <summary>
/// <para>
/// Determines the time zone abbreviation to be used during a particular
/// @interval of time in the time zone @tz.
/// </para>
/// <para>
/// For example, in Toronto this is currently &quot;EST&quot; during the winter
/// months and &quot;EDT&quot; during the summer months when daylight savings time
/// is in effect.
/// </para>
/// </summary>

/// <param name="tz">
/// a #GTimeZone
/// </param>
/// <param name="interval">
/// an interval within the timezone
/// </param>
/// <return>
/// the time zone abbreviation, which belongs to @tz
/// </return>

	public static string GetAbbreviation(this MentorLake.GLib.GTimeZoneHandle tz, int interval)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_get_abbreviation(tz, interval);
	}

/// <summary>
/// <para>
/// Get the identifier of this #GTimeZone, as passed to g_time_zone_new().
/// If the identifier passed at construction time was not recognised, `UTC` will
/// be returned. If it was %NULL, the identifier of the local timezone at
/// construction time will be returned.
/// </para>
/// <para>
/// The identifier will be returned in the same format as provided at
/// construction time: if provided as a time offset, that will be returned by
/// this function.
/// </para>
/// </summary>

/// <param name="tz">
/// a #GTimeZone
/// </param>
/// <return>
/// identifier for this timezone
/// </return>

	public static string GetIdentifier(this MentorLake.GLib.GTimeZoneHandle tz)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_get_identifier(tz);
	}

/// <summary>
/// <para>
/// Determines the offset to UTC in effect during a particular @interval
/// of time in the time zone @tz.
/// </para>
/// <para>
/// The offset is the number of seconds that you add to UTC time to
/// arrive at local time for @tz (ie: negative numbers for time zones
/// west of GMT, positive numbers for east).
/// </para>
/// </summary>

/// <param name="tz">
/// a #GTimeZone
/// </param>
/// <param name="interval">
/// an interval within the timezone
/// </param>
/// <return>
/// the number of seconds that should be added to UTC to get the
///          local time in @tz
/// </return>

	public static int GetOffset(this MentorLake.GLib.GTimeZoneHandle tz, int interval)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_get_offset(tz, interval);
	}

/// <summary>
/// <para>
/// Determines if daylight savings time is in effect during a particular
/// @interval of time in the time zone @tz.
/// </para>
/// </summary>

/// <param name="tz">
/// a #GTimeZone
/// </param>
/// <param name="interval">
/// an interval within the timezone
/// </param>
/// <return>
/// %TRUE if daylight savings time is in effect
/// </return>

	public static bool IsDst(this MentorLake.GLib.GTimeZoneHandle tz, int interval)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_is_dst(tz, interval);
	}

/// <summary>
/// <para>
/// Increases the reference count on @tz.
/// </para>
/// </summary>

/// <param name="tz">
/// a #GTimeZone
/// </param>
/// <return>
/// a new reference to @tz.
/// </return>

	public static MentorLake.GLib.GTimeZoneHandle Ref(this MentorLake.GLib.GTimeZoneHandle tz)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_ref(tz);
	}

/// <summary>
/// <para>
/// Decreases the reference count on @tz.
/// </para>
/// </summary>

/// <param name="tz">
/// a #GTimeZone
/// </param>

	public static void Unref(this MentorLake.GLib.GTimeZoneHandle tz)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		GTimeZoneExterns.g_time_zone_unref(tz);
	}


	public static GTimeZone Dereference(this GTimeZoneHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTimeZone>(x.DangerousGetHandle());
}
internal class GTimeZoneExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_time_zone_new(string identifier);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_time_zone_new_identifier(string identifier);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_time_zone_new_local();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_time_zone_new_offset(int seconds);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_time_zone_new_utc();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_time_zone_adjust_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz, MentorLake.GLib.GTimeType type, ref long time_);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_time_zone_find_interval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz, MentorLake.GLib.GTimeType type, long time_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_time_zone_get_abbreviation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz, int interval);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_time_zone_get_identifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_time_zone_get_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz, int interval);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_time_zone_is_dst([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz, int interval);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_time_zone_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_time_zone_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz);

}

/// <summary>
/// <para>
/// A `GTimeZone` represents a time zone, at no particular point in time.
/// </para>
/// <para>
/// The `GTimeZone` struct is refcounted and immutable.
/// </para>
/// <para>
/// Each time zone has an identifier (for example, ‘Europe/London’) which is
/// platform dependent. See [ctor@GLib.TimeZone.new] for information on the
/// identifier formats. The identifier of a time zone can be retrieved using
/// [method@GLib.TimeZone.get_identifier].
/// </para>
/// <para>
/// A time zone contains a number of intervals. Each interval has an abbreviation
/// to describe it (for example, ‘PDT’), an offset to UTC and a flag indicating
/// if the daylight savings time is in effect during that interval. A time zone
/// always has at least one interval — interval 0. Note that interval abbreviations
/// are not the same as time zone identifiers (apart from ‘UTC’), and cannot be
/// passed to [ctor@GLib.TimeZone.new].
/// </para>
/// <para>
/// Every UTC time is contained within exactly one interval, but a given
/// local time may be contained within zero, one or two intervals (due to
/// incontinuities associated with daylight savings time).
/// </para>
/// <para>
/// An interval may refer to a specific period of time (eg: the duration
/// of daylight savings time during 2010) or it may refer to many periods
/// of time that share the same properties (eg: all periods of daylight
/// savings time).  It is also possible (usually for political reasons)
/// that some properties (like the abbreviation) change between intervals
/// without other properties changing.
/// </para>
/// </summary>

public struct GTimeZone
{
}
