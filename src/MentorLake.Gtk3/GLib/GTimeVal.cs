namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Represents a precise time, with seconds and microseconds.
/// </para>
/// <para>
/// Similar to the struct timeval returned by the `gettimeofday()`
/// UNIX system call.
/// </para>
/// <para>
/// GLib is attempting to unify around the use of 64-bit integers to
/// represent microsecond-precision time. As such, this type will be
/// removed from a future version of GLib. A consequence of using `glong` for
/// `tv_sec` is that on 32-bit systems `GTimeVal` is subject to the year 2038
/// problem.
/// </para>
/// </summary>

public class GTimeValHandle : BaseSafeHandle
{
}


public static class GTimeValExtensions
{
/// <summary>
/// <para>
/// Adds the given number of microseconds to @time_. @microseconds can
/// also be negative to decrease the value of @time_.
/// </para>
/// </summary>

/// <param name="time_">
/// a #GTimeVal
/// </param>
/// <param name="microseconds">
/// number of microseconds to add to @time
/// </param>

	public static void Add(this MentorLake.GLib.GTimeValHandle time_, long microseconds)
	{
		if (time_.IsInvalid) throw new Exception("Invalid handle (GTimeVal)");
		GTimeValExterns.g_time_val_add(time_, microseconds);
	}

/// <summary>
/// <para>
/// Converts @time_ into an RFC 3339 encoded string, relative to the
/// Coordinated Universal Time (UTC). This is one of the many formats
/// allowed by ISO 8601.
/// </para>
/// <para>
/// ISO 8601 allows a large number of date/time formats, with or without
/// punctuation and optional elements. The format returned by this function
/// is a complete date and time, with optional punctuation included, the
/// UTC time zone represented as "Z", and the @tv_usec part included if
/// and only if it is nonzero, i.e. either
/// "YYYY-MM-DDTHH:MM:SSZ" or "YYYY-MM-DDTHH:MM:SS.fffffZ".
/// </para>
/// <para>
/// This corresponds to the Internet date/time format defined by
/// [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt),
/// and to either of the two most-precise formats defined by
/// the W3C Note
/// [Date and Time Formats](http://www.w3.org/TR/NOTE-datetime-19980827).
/// Both of these documents are profiles of ISO 8601.
/// </para>
/// <para>
/// Use g_date_time_format() or g_strdup_printf() if a different
/// variation of ISO 8601 format is required.
/// </para>
/// <para>
/// If @time_ represents a date which is too large to fit into a `struct tm`,
/// %NULL will be returned. This is platform dependent. Note also that since
/// `GTimeVal` stores the number of seconds as a `glong`, on 32-bit systems it
/// is subject to the year 2038 problem. Accordingly, since GLib 2.62, this
/// function has been deprecated. Equivalent functionality is available using:
/// |[
/// GDateTime *dt = g_date_time_new_from_unix_utc (time_val);
/// iso8601_string = g_date_time_format_iso8601 (dt);
/// g_date_time_unref (dt);
/// ]|
/// </para>
/// <para>
/// The return value of g_time_val_to_iso8601() has been nullable since GLib
/// 2.54; before then, GLib would crash under the same conditions.
/// </para>
/// </summary>

/// <param name="time_">
/// a #GTimeVal
/// </param>
/// <return>
/// a newly allocated string containing an ISO 8601 date,
///    or %NULL if @time_ was too large
/// </return>

	public static string ToIso8601(this MentorLake.GLib.GTimeValHandle time_)
	{
		if (time_.IsInvalid) throw new Exception("Invalid handle (GTimeVal)");
		return GTimeValExterns.g_time_val_to_iso8601(time_);
	}


	public static GTimeVal Dereference(this GTimeValHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTimeVal>(x.DangerousGetHandle());
}
internal class GTimeValExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_time_val_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle time_, long microseconds);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_time_val_to_iso8601([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle time_);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_time_val_from_iso8601(string iso_date, out MentorLake.GLib.GTimeVal time_);

}

/// <summary>
/// <para>
/// Represents a precise time, with seconds and microseconds.
/// </para>
/// <para>
/// Similar to the struct timeval returned by the `gettimeofday()`
/// UNIX system call.
/// </para>
/// <para>
/// GLib is attempting to unify around the use of 64-bit integers to
/// represent microsecond-precision time. As such, this type will be
/// removed from a future version of GLib. A consequence of using `glong` for
/// `tv_sec` is that on 32-bit systems `GTimeVal` is subject to the year 2038
/// problem.
/// </para>
/// </summary>

public struct GTimeVal
{
	/// <summary>
/// <para>
/// seconds
/// </para>
/// </summary>

public long tv_sec;
	/// <summary>
/// <para>
/// microseconds
/// </para>
/// </summary>

public long tv_usec;
/// <summary>
/// <para>
/// Converts a string containing an ISO 8601 encoded date and time
/// to a #GTimeVal and puts it into @time_.
/// </para>
/// <para>
/// @iso_date must include year, month, day, hours, minutes, and
/// seconds. It can optionally include fractions of a second and a time
/// zone indicator. (In the absence of any time zone indication, the
/// timestamp is assumed to be in local time.)
/// </para>
/// <para>
/// Any leading or trailing space in @iso_date is ignored.
/// </para>
/// <para>
/// This function was deprecated, along with #GTimeVal itself, in GLib 2.62.
/// Equivalent functionality is available using code like:
/// |[
/// GDateTime *dt = g_date_time_new_from_iso8601 (iso8601_string, NULL);
/// gint64 time_val = g_date_time_to_unix (dt);
/// g_date_time_unref (dt);
/// ]|
/// </para>
/// </summary>

/// <param name="iso_date">
/// an ISO 8601 encoded date string
/// </param>
/// <param name="time_">
/// a #GTimeVal
/// </param>
/// <return>
/// %TRUE if the conversion was successful.
/// </return>

	public static bool FromIso8601(string iso_date, out MentorLake.GLib.GTimeVal time_)
	{
		return GTimeValExterns.g_time_val_from_iso8601(iso_date, out time_);
	}

}
