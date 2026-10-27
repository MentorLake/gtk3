namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Server-side &quot;Basic&quot; authentication.
/// </para>
/// <para>
/// [class@AuthDomainBasic] handles the server side of HTTP &quot;Basic&quot; (ie,
/// cleartext password) authentication.
/// </para>
/// </summary>

public class SoupAuthDomainBasicHandle : SoupAuthDomainHandle
{
/// <summary>
/// <para>
/// Creates a [class@AuthDomainBasic].
/// </para>
/// <para>
/// You must set the [property@AuthDomain:realm] property, to indicate the realm
/// name to be returned with the authentication challenge to the client. Other
/// parameters are optional.
/// </para>
/// </summary>

/// <param name="optname1">
/// name of first option, or %NULL
/// </param>
/// <param name="@__arglist">
/// option name/value pairs
/// </param>
/// <return>
/// the new #SoupAuthDomain
/// </return>

	public static MentorLake.Soup.SoupAuthDomainBasicHandle New(string optname1, IntPtr @__arglist)
	{
		return SoupAuthDomainBasicHandleExterns.soup_auth_domain_basic_new(optname1, @__arglist);
	}

}

public static class SoupAuthDomainBasicHandleExtensions
{
/// <summary>
/// <para>
/// Sets the callback that @domain will use to authenticate incoming
/// requests.
/// </para>
/// <para>
/// For each request containing authorization, @domain will invoke the callback,
/// and then either accept or reject the request based on @callback&apos;s return
/// value.
/// </para>
/// <para>
/// You can also set the auth callback by setting the
/// [property@AuthDomainBasic:auth-callback] and
/// [property@AuthDomainBasic:auth-data] properties, which can also be used to
/// set the callback at construct time.
/// </para>
/// </summary>

/// <param name="domain">
/// the domain
/// </param>
/// <param name="callback">
/// the callback
/// </param>
/// <param name="user_data">
/// data to pass to @auth_callback
/// </param>
/// <param name="dnotify">
/// destroy notifier to free @user_data when @domain
///   is destroyed
/// </param>

	public static T SetAuthCallback<T>(this T domain, MentorLake.Soup.SoupAuthDomainBasicAuthCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify dnotify) where T : SoupAuthDomainBasicHandle
	{
		if (domain.IsInvalid) throw new Exception("Invalid handle (SoupAuthDomainBasicHandle)");
		SoupAuthDomainBasicHandleExterns.soup_auth_domain_basic_set_auth_callback(domain, callback, user_data, dnotify);
		return domain;
	}

}

internal class SoupAuthDomainBasicHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainBasicHandle>))]
	internal static extern MentorLake.Soup.SoupAuthDomainBasicHandle soup_auth_domain_basic_new(string optname1, IntPtr @__arglist);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_auth_domain_basic_set_auth_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, MentorLake.Soup.SoupAuthDomainBasicAuthCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify dnotify);

}
