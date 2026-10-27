namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Date formats that [func@date_time_to_string] can use.
/// </para>
/// <para>
/// @SOUP_DATE_HTTP and @SOUP_DATE_COOKIE always coerce the time to
/// UTC.
/// </para>
/// <para>
/// This enum may be extended with more values in future releases.
/// </para>
/// </summary>

[Flags]
public enum SoupDateFormat
{
/// <summary>
/// <para>
/// RFC 1123 format, used by the HTTP &quot;Date&quot; header. Eg
///   &quot;Sun, 06 Nov 1994 08:49:37 GMT&quot;.
/// </para>
/// </summary>

	SOUP_DATE_HTTP = 1,
/// <summary>
/// <para>
/// The format for the &quot;Expires&quot; timestamp in the
///   Netscape cookie specification. Eg, &quot;Sun, 06-Nov-1994 08:49:37 GMT&quot;.
/// </para>
/// </summary>

	SOUP_DATE_COOKIE = 2
}
