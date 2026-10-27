namespace MentorLake.Soup;

/// <summary>
/// <para>
/// HTTP-based GSS-Negotiate authentication, as defined by
/// [RFC 4559](https://datatracker.ietf.org/doc/html/rfc4559).
/// </para>
/// <para>
/// [class@Session]s do not support this type by default; if you want to
/// enable support for it, call [method@Session.add_feature_by_type],
/// passing %SOUP_TYPE_AUTH_NEGOTIATE.
/// </para>
/// <para>
/// This auth type will only work if libsoup was compiled with GSSAPI
/// support; you can check [func@AuthNegotiate.supported] to see if it
/// was.
/// </para>
/// </summary>

public class SoupAuthNegotiateHandle : SoupAuthHandle
{
/// <summary>
/// <para>
/// Indicates whether libsoup was built with GSSAPI support.
/// </para>
/// <para>
/// If this is %FALSE, %SOUP_TYPE_AUTH_NEGOTIATE will still be defined and can
/// still be added to a [class@Session], but libsoup will never attempt to
/// actually use this auth type.
/// </para>
/// </summary>

/// <return>
/// %TRUE if supported otherwise %FALSE
/// </return>

	public static bool Supported()
	{
		return SoupAuthNegotiateHandleExterns.soup_auth_negotiate_supported();
	}

}

public static class SoupAuthNegotiateHandleExtensions
{
}

internal class SoupAuthNegotiateHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_auth_negotiate_supported();

}
