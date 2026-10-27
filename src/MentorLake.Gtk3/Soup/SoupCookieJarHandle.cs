namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Automatic cookie handling for SoupSession.
/// </para>
/// <para>
/// A [class@CookieJar] stores [struct@Cookie]s and arrange for them to be sent with
/// the appropriate [class@Message]s. [class@CookieJar] implements
/// [iface@SessionFeature], so you can add a cookie jar to a session with
/// [method@Session.add_feature] or [method@Session.add_feature_by_type].
/// </para>
/// <para>
/// Note that the base [class@CookieJar] class does not support any form
/// of long-term cookie persistence.
/// </para>
/// </summary>

public class SoupCookieJarHandle : GObjectHandle, SoupSessionFeatureHandle
{
/// <summary>
/// <para>
/// Creates a new [class@CookieJar].
/// </para>
/// <para>
/// The base [class@CookieJar] class does not support persistent storage of cookies;
/// use a subclass for that.
/// </para>
/// </summary>

/// <return>
/// a new #SoupCookieJar
/// </return>

	public static MentorLake.Soup.SoupCookieJarHandle New()
	{
		return SoupCookieJarHandleExterns.soup_cookie_jar_new();
	}

}
public static class SoupCookieJarHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when @jar changes.
/// </para>
/// <para>
/// If a cookie has been added,
/// @new_cookie will contain the newly-added cookie and
/// @old_cookie will be %NULL. If a cookie has been deleted,
/// @old_cookie will contain the to-be-deleted cookie and
/// @new_cookie will be %NULL. If a cookie has been changed,
/// @old_cookie will contain its old value, and @new_cookie its
/// new value.
/// </para>
/// </summary>

	public static IObservable<SoupCookieJarHandleSignalStructs.ChangedSignal> Signal_Changed(this SoupCookieJarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupCookieJarHandleSignalStructs.ChangedSignal> obs) =>
		{
			SoupCookieJarHandleSignalDelegates.changed handler = ( MentorLake.Soup.SoupCookieJarHandle self,  MentorLake.Soup.SoupCookieHandle old_cookie,  MentorLake.Soup.SoupCookieHandle new_cookie,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupCookieJarHandleSignalStructs.ChangedSignal()
				{
					Self = self, OldCookie = old_cookie, NewCookie = new_cookie, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class SoupCookieJarHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Soup.SoupCookieJarHandle Self;
/// <summary>
/// <para>
/// the old #SoupCookie value
/// </para>
/// </summary>

	public MentorLake.Soup.SoupCookieHandle OldCookie;
/// <summary>
/// <para>
/// the new #SoupCookie value
/// </para>
/// </summary>

	public MentorLake.Soup.SoupCookieHandle NewCookie;

	public IntPtr UserData;
}
}

public static class SoupCookieJarHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when @jar changes.
/// </para>
/// <para>
/// If a cookie has been added,
/// @new_cookie will contain the newly-added cookie and
/// @old_cookie will be %NULL. If a cookie has been deleted,
/// @old_cookie will contain the to-be-deleted cookie and
/// @new_cookie will be %NULL. If a cookie has been changed,
/// @old_cookie will contain its old value, and @new_cookie its
/// new value.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="old_cookie">
/// the old #SoupCookie value
/// </param>
/// <param name="new_cookie">
/// the new #SoupCookie value
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle old_cookie, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle new_cookie, IntPtr user_data);

}


public static class SoupCookieJarHandleExtensions
{
/// <summary>
/// <para>
/// Adds @cookie to @jar.
/// </para>
/// <para>
/// Emits the [signal@CookieJar::changed] signal if we are modifying
/// an existing cookie or adding a valid new cookie (&apos;valid&apos; means
/// that the cookie&apos;s expire date is not in the past).
/// </para>
/// <para>
/// @cookie will be &apos;stolen&apos; by the jar, so don&apos;t free it afterwards.
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <param name="cookie">
/// a #SoupCookie
/// </param>

	public static T AddCookie<T>(this T jar, MentorLake.Soup.SoupCookieHandle cookie) where T : SoupCookieJarHandle
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		SoupCookieJarHandleExterns.soup_cookie_jar_add_cookie(jar, cookie);
		return jar;
	}

/// <summary>
/// <para>
/// Adds @cookie to @jar.
/// </para>
/// <para>
/// Emits the [signal@CookieJar::changed] signal if we are modifying an existing
/// cookie or adding a valid new cookie (&apos;valid&apos; means that the cookie&apos;s expire
/// date is not in the past).
/// </para>
/// <para>
/// @first_party will be used to reject cookies coming from third party
/// resources in case such a security policy is set in the @jar.
/// </para>
/// <para>
/// @uri will be used to reject setting or overwriting secure cookies
/// from insecure origins. %NULL is treated as secure.
/// </para>
/// <para>
/// @cookie will be &apos;stolen&apos; by the jar, so don&apos;t free it afterwards.
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <param name="uri">
/// the URI setting the cookie
/// </param>
/// <param name="first_party">
/// the URI for the main document
/// </param>

	public static T AddCookieFull<T>(this T jar, MentorLake.Soup.SoupCookieHandle cookie, MentorLake.GLib.GUriHandle uri, MentorLake.GLib.GUriHandle first_party) where T : SoupCookieJarHandle
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		SoupCookieJarHandleExterns.soup_cookie_jar_add_cookie_full(jar, cookie, uri, first_party);
		return jar;
	}

/// <summary>
/// <para>
/// Adds @cookie to @jar.
/// </para>
/// <para>
/// Emits the [signal@CookieJar::changed] signal if we are modifying
/// an existing cookie or adding a valid new cookie (&apos;valid&apos; means
/// that the cookie&apos;s expire date is not in the past).
/// </para>
/// <para>
/// @first_party will be used to reject cookies coming from third party
/// resources in case such a security policy is set in the @jar.
/// </para>
/// <para>
/// @cookie will be &apos;stolen&apos; by the jar, so don&apos;t free it afterwards.
/// </para>
/// <para>
/// For secure cookies to work properly you may want to use
/// [method@CookieJar.add_cookie_full].
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <param name="first_party">
/// the URI for the main document
/// </param>
/// <param name="cookie">
/// a #SoupCookie
/// </param>

	public static T AddCookieWithFirstParty<T>(this T jar, MentorLake.GLib.GUriHandle first_party, MentorLake.Soup.SoupCookieHandle cookie) where T : SoupCookieJarHandle
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		SoupCookieJarHandleExterns.soup_cookie_jar_add_cookie_with_first_party(jar, first_party, cookie);
		return jar;
	}

/// <summary>
/// <para>
/// Constructs a [struct@GLib.List] with every cookie inside the @jar.
/// </para>
/// <para>
/// The cookies in the list are a copy of the original, so
/// you have to free them when you are done with them.
/// </para>
/// <para>
/// For historical reasons this list is in reverse order.
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <return>
/// a #GSList
///   with all the cookies in the @jar.
/// </return>

	public static MentorLake.GLib.GSListHandle AllCookies(this MentorLake.Soup.SoupCookieJarHandle jar)
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		return SoupCookieJarHandleExterns.soup_cookie_jar_all_cookies(jar);
	}

/// <summary>
/// <para>
/// Deletes @cookie from @jar.
/// </para>
/// <para>
/// Emits the [signal@CookieJar::changed] signal.
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <param name="cookie">
/// a #SoupCookie
/// </param>

	public static T DeleteCookie<T>(this T jar, MentorLake.Soup.SoupCookieHandle cookie) where T : SoupCookieJarHandle
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		SoupCookieJarHandleExterns.soup_cookie_jar_delete_cookie(jar, cookie);
		return jar;
	}

/// <summary>
/// <para>
/// Gets @jar&apos;s [enum@CookieJarAcceptPolicy].
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <return>
/// the #SoupCookieJarAcceptPolicy set in the @jar
/// </return>

	public static MentorLake.Soup.SoupCookieJarAcceptPolicy GetAcceptPolicy(this MentorLake.Soup.SoupCookieJarHandle jar)
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		return SoupCookieJarHandleExterns.soup_cookie_jar_get_accept_policy(jar);
	}

/// <summary>
/// <para>
/// Retrieves the list of cookies that would be sent with a request to @uri
/// as a [struct@GLib.List] of [struct@Cookie] objects.
/// </para>
/// <para>
/// If @for_http is %TRUE, the return value will include cookies marked
/// &quot;HttpOnly&quot; (that is, cookies that the server wishes to keep hidden
/// from client-side scripting operations such as the JavaScript
/// document.cookies property). Since [class@CookieJar] sets the Cookie
/// header itself when making the actual HTTP request, you should
/// almost certainly be setting @for_http to %FALSE if you are calling
/// this.
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <param name="uri">
/// a #GUri
/// </param>
/// <param name="for_http">
/// whether or not the return value is being passed directly
///   to an HTTP operation
/// </param>
/// <return>
/// a #GSList
///   with the cookies in the @jar that would be sent with a request to @uri.
/// </return>

	public static MentorLake.GLib.GSListHandle GetCookieList(this MentorLake.Soup.SoupCookieJarHandle jar, MentorLake.GLib.GUriHandle uri, bool for_http)
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		return SoupCookieJarHandleExterns.soup_cookie_jar_get_cookie_list(jar, uri, for_http);
	}

/// <summary>
/// <para>
/// This is an extended version of [method@CookieJar.get_cookie_list] that
/// provides more information required to use SameSite cookies.
/// </para>
/// <para>
/// See the [SameSite cookies
/// spec](https://tools.ietf.org/html/draft-ietf-httpbis-cookie-same-site-00) for
/// more detailed information.
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <param name="uri">
/// a #GUri
/// </param>
/// <param name="top_level">
/// a #GUri for the top level document
/// </param>
/// <param name="site_for_cookies">
/// a #GUri indicating the origin to get cookies for
/// </param>
/// <param name="for_http">
/// whether or not the return value is being passed directly
///   to an HTTP operation
/// </param>
/// <param name="is_safe_method">
/// if the HTTP method is safe, as defined by RFC 7231, ignored when @for_http is %FALSE
/// </param>
/// <param name="is_top_level_navigation">
/// whether or not the HTTP request is part of
///   top level navigation
/// </param>
/// <return>
/// a #GSList
///   with the cookies in the @jar that would be sent with a request to @uri.
/// </return>

	public static MentorLake.GLib.GSListHandle GetCookieListWithSameSiteInfo(this MentorLake.Soup.SoupCookieJarHandle jar, MentorLake.GLib.GUriHandle uri, MentorLake.GLib.GUriHandle top_level, MentorLake.GLib.GUriHandle site_for_cookies, bool for_http, bool is_safe_method, bool is_top_level_navigation)
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		return SoupCookieJarHandleExterns.soup_cookie_jar_get_cookie_list_with_same_site_info(jar, uri, top_level, site_for_cookies, for_http, is_safe_method, is_top_level_navigation);
	}

/// <summary>
/// <para>
/// Retrieves (in Cookie-header form) the list of cookies that would
/// be sent with a request to @uri.
/// </para>
/// <para>
/// If @for_http is %TRUE, the return value will include cookies marked
/// &quot;HttpOnly&quot; (that is, cookies that the server wishes to keep hidden
/// from client-side scripting operations such as the JavaScript
/// document.cookies property). Since [class@CookieJar] sets the Cookie
/// header itself when making the actual HTTP request, you should
/// almost certainly be setting @for_http to %FALSE if you are calling
/// this.
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <param name="uri">
/// a #GUri
/// </param>
/// <param name="for_http">
/// whether or not the return value is being passed directly
///   to an HTTP operation
/// </param>
/// <return>
/// the cookies, in string form, or %NULL if
///   there are no cookies for @uri.
/// </return>

	public static string GetCookies(this MentorLake.Soup.SoupCookieJarHandle jar, MentorLake.GLib.GUriHandle uri, bool for_http)
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		return SoupCookieJarHandleExterns.soup_cookie_jar_get_cookies(jar, uri, for_http);
	}

/// <summary>
/// <para>
/// Gets whether @jar stores cookies persistenly.
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <return>
/// %TRUE if @jar storage is persistent or %FALSE otherwise.
/// </return>

	public static bool IsPersistent(this MentorLake.Soup.SoupCookieJarHandle jar)
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		return SoupCookieJarHandleExterns.soup_cookie_jar_is_persistent(jar);
	}

/// <summary>
/// <para>
/// Sets @policy as the cookie acceptance policy for @jar.
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <param name="policy">
/// a #SoupCookieJarAcceptPolicy
/// </param>

	public static T SetAcceptPolicy<T>(this T jar, MentorLake.Soup.SoupCookieJarAcceptPolicy policy) where T : SoupCookieJarHandle
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		SoupCookieJarHandleExterns.soup_cookie_jar_set_accept_policy(jar, policy);
		return jar;
	}

/// <summary>
/// <para>
/// Adds @cookie to @jar, exactly as though it had appeared in a
/// Set-Cookie header returned from a request to @uri.
/// </para>
/// <para>
/// Keep in mind that if the [enum@CookieJarAcceptPolicy] set is either
/// %SOUP_COOKIE_JAR_ACCEPT_NO_THIRD_PARTY or
/// %SOUP_COOKIE_JAR_ACCEPT_GRANDFATHERED_THIRD_PARTY you&apos;ll need to use
/// [method@CookieJar.set_cookie_with_first_party], otherwise the jar
/// will have no way of knowing if the cookie is being set by a third
/// party or not.
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <param name="uri">
/// the URI setting the cookie
/// </param>
/// <param name="cookie">
/// the stringified cookie to set
/// </param>

	public static T SetCookie<T>(this T jar, MentorLake.GLib.GUriHandle uri, string cookie) where T : SoupCookieJarHandle
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		SoupCookieJarHandleExterns.soup_cookie_jar_set_cookie(jar, uri, cookie);
		return jar;
	}

/// <summary>
/// <para>
/// Adds @cookie to @jar, exactly as though it had appeared in a
/// Set-Cookie header returned from a request to @uri.
/// </para>
/// <para>
/// @first_party will be used to reject cookies coming from third party resources
/// in case such a security policy is set in the @jar.
/// </para>
/// </summary>

/// <param name="jar">
/// a #SoupCookieJar
/// </param>
/// <param name="uri">
/// the URI setting the cookie
/// </param>
/// <param name="first_party">
/// the URI for the main document
/// </param>
/// <param name="cookie">
/// the stringified cookie to set
/// </param>

	public static T SetCookieWithFirstParty<T>(this T jar, MentorLake.GLib.GUriHandle uri, MentorLake.GLib.GUriHandle first_party, string cookie) where T : SoupCookieJarHandle
	{
		if (jar.IsInvalid) throw new Exception("Invalid handle (SoupCookieJarHandle)");
		SoupCookieJarHandleExterns.soup_cookie_jar_set_cookie_with_first_party(jar, uri, first_party, cookie);
		return jar;
	}

}

internal class SoupCookieJarHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))]
	internal static extern MentorLake.Soup.SoupCookieJarHandle soup_cookie_jar_new();

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_jar_add_cookie([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_jar_add_cookie_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle first_party);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_jar_add_cookie_with_first_party([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle first_party, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle soup_cookie_jar_all_cookies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_jar_delete_cookie([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Soup.SoupCookieJarAcceptPolicy soup_cookie_jar_get_accept_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle soup_cookie_jar_get_cookie_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri, bool for_http);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle soup_cookie_jar_get_cookie_list_with_same_site_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle top_level, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle site_for_cookies, bool for_http, bool is_safe_method, bool is_top_level_navigation);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_cookie_jar_get_cookies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri, bool for_http);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_cookie_jar_is_persistent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_jar_set_accept_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar, MentorLake.Soup.SoupCookieJarAcceptPolicy policy);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_jar_set_cookie([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri, string cookie);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_jar_set_cookie_with_first_party([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieJarHandle>))] MentorLake.Soup.SoupCookieJarHandle jar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle first_party, string cookie);

}
