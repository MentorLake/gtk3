namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Database-based Cookie Jar.
/// </para>
/// <para>
/// [class@CookieJarDB] is a [class@CookieJar] that reads cookies from and writes
/// them to a sqlite database in the new Mozilla format.
/// </para>
/// <para>
/// (This is identical to `SoupCookieJarSqlite` in
/// libsoup-gnome; it has just been moved into libsoup proper, and
/// renamed to avoid conflicting.)
/// </para>
/// </summary>

public class SoupCookieJarDBHandle : SoupCookieJarHandle, SoupSessionFeatureHandle
{
/// <summary>
/// <para>
/// Creates a [class@CookieJarDB].
/// </para>
/// <para>
/// @filename will be read in at startup to create an initial set of cookies. If
/// @read_only is %FALSE, then the non-session cookies will be written to
/// @filename when the [signal@CookieJar::changed] signal is emitted from the
/// jar. (If @read_only is %TRUE, then the cookie jar will only be used for this
/// session, and changes made to it will be lost when the jar is destroyed.)
/// </para>
/// </summary>

/// <param name="filename">
/// the filename to read to/write from, or %NULL
/// </param>
/// <param name="read_only">
/// %TRUE if @filename is read-only
/// </param>
/// <return>
/// the new #SoupCookieJar
/// </return>

	public static MentorLake.Soup.SoupCookieJarDBHandle New(string filename, bool read_only)
	{
		return SoupCookieJarDBHandleExterns.soup_cookie_jar_db_new(filename, read_only);
	}

}

public static class SoupCookieJarDBHandleExtensions
{
}

internal class SoupCookieJarDBHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarDBHandle>))]
	internal static extern MentorLake.Soup.SoupCookieJarDBHandle soup_cookie_jar_db_new(string filename, bool read_only);

}
