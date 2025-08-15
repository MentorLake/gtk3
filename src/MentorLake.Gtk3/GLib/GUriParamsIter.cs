namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Many URI schemes include one or more attribute/value pairs as part of the URI
/// value. For example `scheme://server/path?query=string&amp;is=there` has two
/// attributes – `query=string` and `is=there` – in its query part.
/// </para>
/// <para>
/// A #GUriParamsIter structure represents an iterator that can be used to
/// iterate over the attribute/value pairs of a URI query string. #GUriParamsIter
/// structures are typically allocated on the stack and then initialized with
/// g_uri_params_iter_init(). See the documentation for g_uri_params_iter_init()
/// for a usage example.
/// </para>
/// </summary>

public class GUriParamsIterHandle : BaseSafeHandle
{
}


public static class GUriParamsIterExtensions
{
/// <summary>
/// <para>
/// Initializes an attribute/value pair iterator.
/// </para>
/// <para>
/// The iterator keeps pointers to the @params and @separators arguments, those
/// variables must thus outlive the iterator and not be modified during the
/// iteration.
/// </para>
/// <para>
/// If %G_URI_PARAMS_WWW_FORM is passed in @flags, `+` characters in the param
/// string will be replaced with spaces in the output. For example, `foo=bar+baz`
/// will give attribute `foo` with value `bar baz`. This is commonly used on the
/// web (the `https` and `http` schemes only), but is deprecated in favour of
/// the equivalent of encoding spaces as `%20`.
/// </para>
/// <para>
/// Unlike with g_uri_parse_params(), %G_URI_PARAMS_CASE_INSENSITIVE has no
/// effect if passed to @flags for g_uri_params_iter_init(). The caller is
/// responsible for doing their own case-insensitive comparisons.
/// </para>
/// <code>
/// GUriParamsIter iter;
/// GUriParamsIter iter;
/// GError *error = NULL;
/// gchar *unowned_attr, *unowned_value;
/// 
/// g_uri_params_iter_init (&amp;iter, &quot;foo=bar&amp;baz=bar&amp;Foo=frob&amp;baz=bar2&quot;, -1, &quot;&amp;&quot;, G_URI_PARAMS_NONE);
/// while (g_uri_params_iter_next (&amp;iter, &amp;unowned_attr, &amp;unowned_value, &amp;error))
///   {
///     g_autofree gchar *attr = g_steal_pointer (&amp;unowned_attr);
///     g_autofree gchar *value = g_steal_pointer (&amp;unowned_value);
///     // do something with attr and value; this code will be called 4 times
///     // for the params string in this example: once with attr=foo and value=bar,
///     // then with baz/bar, then Foo/frob, then baz/bar2.
///   }
/// if (error)
///   // handle parsing error
/// </code>
/// </summary>

/// <param name="iter">
/// an uninitialized #GUriParamsIter
/// </param>
/// <param name="@params">
/// a `%`-encoded string containing `attribute=value`
///   parameters
/// </param>
/// <param name="length">
/// the length of @params, or `-1` if it is nul-terminated
/// </param>
/// <param name="separators">
/// the separator byte character set between parameters. (usually
///   `&amp;`, but sometimes `;` or both `&amp;;`). Note that this function works on
///   bytes not characters, so it can&apos;t be used to delimit UTF-8 strings for
///   anything but ASCII characters. You may pass an empty set, in which case
///   no splitting will occur.
/// </param>
/// <param name="flags">
/// flags to modify the way the parameters are handled.
/// </param>

	public static void Init(this MentorLake.GLib.GUriParamsIterHandle iter, string @params, UIntPtr length, string separators, MentorLake.GLib.GUriParamsFlags flags)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GUriParamsIter)");
		GUriParamsIterExterns.g_uri_params_iter_init(iter, @params, length, separators, flags);
	}

/// <summary>
/// <para>
/// Advances @iter and retrieves the next attribute/value. %FALSE is returned if
/// an error has occurred (in which case @error is set), or if the end of the
/// iteration is reached (in which case @attribute and @value are set to %NULL
/// and the iterator becomes invalid). If %TRUE is returned,
/// g_uri_params_iter_next() may be called again to receive another
/// attribute/value pair.
/// </para>
/// <para>
/// Note that the same @attribute may be returned multiple times, since URIs
/// allow repeated attributes.
/// </para>
/// </summary>

/// <param name="iter">
/// an initialized #GUriParamsIter
/// </param>
/// <param name="attribute">
/// on return, contains
///     the attribute, or %NULL.
/// </param>
/// <param name="value">
/// on return, contains
///     the value, or %NULL.
/// </param>
/// <return>
/// %FALSE if the end of the parameters has been reached or an error was
///     encountered. %TRUE otherwise.
/// </return>

	public static bool Next(this MentorLake.GLib.GUriParamsIterHandle iter, out string attribute, out string value)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GUriParamsIter)");
		var externCallResult = GUriParamsIterExterns.g_uri_params_iter_next(iter, out attribute, out value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}


	public static GUriParamsIter Dereference(this GUriParamsIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUriParamsIter>(x.DangerousGetHandle());
}
internal class GUriParamsIterExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_uri_params_iter_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriParamsIterHandle>))] MentorLake.GLib.GUriParamsIterHandle iter, string @params, UIntPtr length, string separators, MentorLake.GLib.GUriParamsFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_params_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriParamsIterHandle>))] MentorLake.GLib.GUriParamsIterHandle iter, out string attribute, out string value, out MentorLake.GLib.GErrorHandle error);

}

/// <summary>
/// <para>
/// Many URI schemes include one or more attribute/value pairs as part of the URI
/// value. For example `scheme://server/path?query=string&amp;is=there` has two
/// attributes – `query=string` and `is=there` – in its query part.
/// </para>
/// <para>
/// A #GUriParamsIter structure represents an iterator that can be used to
/// iterate over the attribute/value pairs of a URI query string. #GUriParamsIter
/// structures are typically allocated on the stack and then initialized with
/// g_uri_params_iter_init(). See the documentation for g_uri_params_iter_init()
/// for a usage example.
/// </para>
/// </summary>

public struct GUriParamsIter
{
}
