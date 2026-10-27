namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Server-side authentication.
/// </para>
/// <para>
/// A [class@AuthDomain] manages authentication for all or part of a
/// [class@Server]. To make a server require authentication, first create
/// an appropriate subclass of [class@AuthDomain], and then add it to the
/// server with [method@Server.add_auth_domain].
/// </para>
/// <para>
/// In order for an auth domain to have any effect, you must add one or more
/// paths to it (via [method@AuthDomain.add_path]). To require authentication for
/// all ordinary requests, add the path `&quot;/&quot;`. (Note that this does not include
/// the special `&quot;*&quot;` URI (eg, &quot;OPTIONS *&quot;), which must be added as a separate
/// path if you want to cover it.)
/// </para>
/// <para>
/// If you need greater control over which requests should and shouldn&apos;t be
/// authenticated, add paths covering everything you *might* want authenticated,
/// and then use a filter ([method@AuthDomain.set_filter] to bypass
/// authentication for those requests that don&apos;t need it.
/// </para>
/// </summary>

public class SoupAuthDomainHandle : GObjectHandle
{
}

public static class SoupAuthDomainHandleExtensions
{
/// <summary>
/// <para>
/// Checks if @msg contains appropriate authorization for @domain to
/// accept it.
/// </para>
/// <para>
/// Mirroring [method@AuthDomain.covers], this does not check whether or not
/// @domain *cares* if @msg is authorized.
/// </para>
/// <para>
/// This is used by [class@Server] internally and is probably of no use to
/// anyone else.
/// </para>
/// </summary>

/// <param name="domain">
/// a #SoupAuthDomain
/// </param>
/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// the username that @msg has authenticated
///   as, if in fact it has authenticated. %NULL otherwise.
/// </return>

	public static string Accepts(this MentorLake.Soup.SoupAuthDomainHandle domain, MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (domain.IsInvalid) throw new Exception("Invalid handle (SoupAuthDomainHandle)");
		return SoupAuthDomainHandleExterns.soup_auth_domain_accepts(domain, msg);
	}

/// <summary>
/// <para>
/// Adds @path to @domain.
/// </para>
/// <para>
/// Requests under @path on @domain&apos;s server will require authentication (unless
/// overridden by [method@AuthDomain.remove_path] or
/// [method@AuthDomain.set_filter]).
/// </para>
/// </summary>

/// <param name="domain">
/// a #SoupAuthDomain
/// </param>
/// <param name="path">
/// the path to add to @domain
/// </param>

	public static T AddPath<T>(this T domain, string path) where T : SoupAuthDomainHandle
	{
		if (domain.IsInvalid) throw new Exception("Invalid handle (SoupAuthDomainHandle)");
		SoupAuthDomainHandleExterns.soup_auth_domain_add_path(domain, path);
		return domain;
	}

/// <summary>
/// <para>
/// Adds a &quot;WWW-Authenticate&quot; or &quot;Proxy-Authenticate&quot; header to @msg.
/// </para>
/// <para>
/// It requests that the client authenticate, and sets @msg&apos;s status accordingly.
/// </para>
/// <para>
/// This is used by [class@Server] internally and is probably of no use to
/// anyone else.
/// </para>
/// </summary>

/// <param name="domain">
/// a #SoupAuthDomain
/// </param>
/// <param name="msg">
/// a #SoupServerMessage
/// </param>

	public static T Challenge<T>(this T domain, MentorLake.Soup.SoupServerMessageHandle msg) where T : SoupAuthDomainHandle
	{
		if (domain.IsInvalid) throw new Exception("Invalid handle (SoupAuthDomainHandle)");
		SoupAuthDomainHandleExterns.soup_auth_domain_challenge(domain, msg);
		return domain;
	}

/// <summary>
/// <para>
/// Checks if @msg authenticates to @domain via @username and
/// @password.
/// </para>
/// <para>
/// This would normally be called from a
/// [callback@AuthDomainGenericAuthCallback].
/// </para>
/// </summary>

/// <param name="domain">
/// a #SoupAuthDomain
/// </param>
/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <param name="username">
/// a username
/// </param>
/// <param name="password">
/// a password
/// </param>
/// <return>
/// whether or not the message is authenticated
/// </return>

	public static bool CheckPassword(this MentorLake.Soup.SoupAuthDomainHandle domain, MentorLake.Soup.SoupServerMessageHandle msg, string username, string password)
	{
		if (domain.IsInvalid) throw new Exception("Invalid handle (SoupAuthDomainHandle)");
		return SoupAuthDomainHandleExterns.soup_auth_domain_check_password(domain, msg, username, password);
	}

/// <summary>
/// <para>
/// Checks if @domain requires @msg to be authenticated (according to
/// its paths and filter function).
/// </para>
/// <para>
/// This does not actually look at whether @msg *is* authenticated, merely
/// whether or not it needs to be.
/// </para>
/// <para>
/// This is used by [class@Server] internally and is probably of no use to
/// anyone else.
/// </para>
/// </summary>

/// <param name="domain">
/// a #SoupAuthDomain
/// </param>
/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// %TRUE if @domain requires @msg to be authenticated
/// </return>

	public static bool Covers(this MentorLake.Soup.SoupAuthDomainHandle domain, MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (domain.IsInvalid) throw new Exception("Invalid handle (SoupAuthDomainHandle)");
		return SoupAuthDomainHandleExterns.soup_auth_domain_covers(domain, msg);
	}

/// <summary>
/// <para>
/// Gets the realm name associated with @domain.
/// </para>
/// </summary>

/// <param name="domain">
/// a #SoupAuthDomain
/// </param>
/// <return>
/// @domain&apos;s realm
/// </return>

	public static string GetRealm(this MentorLake.Soup.SoupAuthDomainHandle domain)
	{
		if (domain.IsInvalid) throw new Exception("Invalid handle (SoupAuthDomainHandle)");
		return SoupAuthDomainHandleExterns.soup_auth_domain_get_realm(domain);
	}

/// <summary>
/// <para>
/// Removes @path from @domain.
/// </para>
/// <para>
/// Requests under @path on @domain&apos;s server will NOT require
/// authentication.
/// </para>
/// <para>
/// This is not simply an undo-er for [method@AuthDomain.add_path]; it
/// can be used to &quot;carve out&quot; a subtree that does not require
/// authentication inside a hierarchy that does. Note also that unlike
/// with [method@AuthDomain.add_path], this cannot be overridden by
/// adding a filter, as filters can only bypass authentication that
/// would otherwise be required, not require it where it would
/// otherwise be unnecessary.
/// </para>
/// </summary>

/// <param name="domain">
/// a #SoupAuthDomain
/// </param>
/// <param name="path">
/// the path to remove from @domain
/// </param>

	public static T RemovePath<T>(this T domain, string path) where T : SoupAuthDomainHandle
	{
		if (domain.IsInvalid) throw new Exception("Invalid handle (SoupAuthDomainHandle)");
		SoupAuthDomainHandleExterns.soup_auth_domain_remove_path(domain, path);
		return domain;
	}

/// <summary>
/// <para>
/// Adds @filter as an authentication filter to @domain.
/// </para>
/// <para>
/// The filter gets a chance to bypass authentication for certain requests that
/// would otherwise require it. Eg, it might check the message&apos;s path in some way
/// that is too complicated to do via the other methods, or it might check the
/// message&apos;s method, and allow GETs but not PUTs.
/// </para>
/// <para>
/// The filter function returns %TRUE if the request should still
/// require authentication, or %FALSE if authentication is unnecessary
/// for this request.
/// </para>
/// <para>
/// To help prevent security holes, your filter should return %TRUE by
/// default, and only return %FALSE under specifically-tested
/// circumstances, rather than the other way around. Eg, in the example
/// above, where you want to authenticate PUTs but not GETs, you should
/// check if the method is GET and return %FALSE in that case, and then
/// return %TRUE for all other methods (rather than returning %TRUE for
/// PUT and %FALSE for all other methods). This way if it turned out
/// (now or later) that some paths supported additional methods besides
/// GET and PUT, those methods would default to being NOT allowed for
/// unauthenticated users.
/// </para>
/// <para>
/// You can also set the filter by setting the SoupAuthDomain:filter
/// and [property@AuthDomain:filter-data properties], which can also be
/// used to set the filter at construct time.
/// </para>
/// </summary>

/// <param name="domain">
/// a #SoupAuthDomain
/// </param>
/// <param name="filter">
/// the auth filter for @domain
/// </param>
/// <param name="filter_data">
/// data to pass to @filter
/// </param>
/// <param name="dnotify">
/// destroy notifier to free @filter_data when @domain
///   is destroyed
/// </param>

	public static T SetFilter<T>(this T domain, MentorLake.Soup.SoupAuthDomainFilter filter, IntPtr filter_data, MentorLake.GLib.GDestroyNotify dnotify) where T : SoupAuthDomainHandle
	{
		if (domain.IsInvalid) throw new Exception("Invalid handle (SoupAuthDomainHandle)");
		SoupAuthDomainHandleExterns.soup_auth_domain_set_filter(domain, filter, filter_data, dnotify);
		return domain;
	}

/// <summary>
/// <para>
/// Sets @auth_callback as an authentication-handling callback for @domain.
/// </para>
/// <para>
/// Whenever a request comes in to @domain which cannot be authenticated via a
/// domain-specific auth callback (eg, [callback@AuthDomainDigestAuthCallback]),
/// the generic auth callback will be invoked. See
/// [callback@AuthDomainGenericAuthCallback] for information on what the callback
/// should do.
/// </para>
/// </summary>

/// <param name="domain">
/// a #SoupAuthDomain
/// </param>
/// <param name="auth_callback">
/// the auth callback
/// </param>
/// <param name="auth_data">
/// data to pass to @auth_callback
/// </param>
/// <param name="dnotify">
/// destroy notifier to free @auth_data when @domain
///   is destroyed
/// </param>

	public static T SetGenericAuthCallback<T>(this T domain, MentorLake.Soup.SoupAuthDomainGenericAuthCallback auth_callback, IntPtr auth_data, MentorLake.GLib.GDestroyNotify dnotify) where T : SoupAuthDomainHandle
	{
		if (domain.IsInvalid) throw new Exception("Invalid handle (SoupAuthDomainHandle)");
		SoupAuthDomainHandleExterns.soup_auth_domain_set_generic_auth_callback(domain, auth_callback, auth_data, dnotify);
		return domain;
	}

}

internal class SoupAuthDomainHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_auth_domain_accepts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_auth_domain_add_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, string path);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_auth_domain_challenge([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_auth_domain_check_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, string username, string password);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_auth_domain_covers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_auth_domain_get_realm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_auth_domain_remove_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, string path);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_auth_domain_set_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, MentorLake.Soup.SoupAuthDomainFilter filter, IntPtr filter_data, MentorLake.GLib.GDestroyNotify dnotify);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_auth_domain_set_generic_auth_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, MentorLake.Soup.SoupAuthDomainGenericAuthCallback auth_callback, IntPtr auth_data, MentorLake.GLib.GDestroyNotify dnotify);

}
