namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Text-file-based (&quot;cookies.txt&quot;) Cookie Jar
/// </para>
/// <para>
/// [class@CookieJarText] is a [class@CookieJar] that reads cookies from and writes
/// them to a text file in format similar to Mozilla&apos;s &quot;cookies.txt&quot;.
/// </para>
/// </summary>

public class SoupCookieJarTextHandle : SoupCookieJarHandle, SoupSessionFeatureHandle
{
/// <summary>
/// <para>
/// Creates a [class@CookieJarText].
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
/// the filename to read to/write from
/// </param>
/// <param name="read_only">
/// %TRUE if @filename is read-only
/// </param>
/// <return>
/// the new #SoupCookieJar
/// </return>

	public static MentorLake.Soup.SoupCookieJarTextHandle New(string filename, bool read_only)
	{
		return SoupCookieJarTextHandleExterns.soup_cookie_jar_text_new(filename, read_only);
	}

}

public static class SoupCookieJarTextHandleExtensions
{
}

internal class SoupCookieJarTextHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarTextHandle>))]
	internal static extern MentorLake.Soup.SoupCookieJarTextHandle soup_cookie_jar_text_new(string filename, bool read_only);

}
