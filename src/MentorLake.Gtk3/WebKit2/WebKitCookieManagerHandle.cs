namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Defines how to handle cookies in a #WebKitWebContext.
/// </para>
/// <para>
/// The WebKitCookieManager defines how to set up and handle cookies.
/// You can get it from a #WebKitWebsiteDataManager with
/// webkit_website_data_manager_get_cookie_manager(), and use it to set where to
/// store cookies with webkit_cookie_manager_set_persistent_storage(),
/// or to set the acceptance policy, with webkit_cookie_manager_get_accept_policy().
/// </para>
/// </summary>

public class WebKitCookieManagerHandle : GObjectHandle
{
}
public static class WebKitCookieManagerHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when cookies are added, removed or modified.
/// </para>
/// </summary>

	public static IObservable<WebKitCookieManagerHandleSignalStructs.ChangedSignal> Signal_Changed(this WebKitCookieManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitCookieManagerHandleSignalStructs.ChangedSignal> obs) =>
		{
			WebKitCookieManagerHandleSignalDelegates.changed handler = ( MentorLake.WebKit2.WebKitCookieManagerHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitCookieManagerHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
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

public static class WebKitCookieManagerHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.WebKit2.WebKitCookieManagerHandle Self;

	public IntPtr UserData;
}
}

public static class WebKitCookieManagerHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when cookies are added, removed or modified.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle self, IntPtr user_data);

}


public static class WebKitCookieManagerHandleExtensions
{
/// <summary>
/// <para>
/// Asynchronously add a #SoupCookie to the underlying storage.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_cookie_manager_add_cookie_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="cookie">
/// the #SoupCookie to be added
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T AddCookie<T>(this T cookie_manager, MentorLake.Soup.SoupCookieHandle cookie, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitCookieManagerHandle
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		WebKitCookieManagerHandleExterns.webkit_cookie_manager_add_cookie(cookie_manager, cookie, cancellable, callback, user_data);
		return cookie_manager;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_cookie_manager_add_cookie().
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the cookie was added or %FALSE in case of error.
/// </return>

	public static bool AddCookieFinish(this MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		var externCallResult = WebKitCookieManagerHandleExterns.webkit_cookie_manager_add_cookie_finish(cookie_manager, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Delete all cookies of @cookie_manager.
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>

	public static T DeleteAllCookies<T>(this T cookie_manager) where T : WebKitCookieManagerHandle
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		WebKitCookieManagerHandleExterns.webkit_cookie_manager_delete_all_cookies(cookie_manager);
		return cookie_manager;
	}

/// <summary>
/// <para>
/// Asynchronously delete a #SoupCookie from the current session.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_cookie_manager_delete_cookie_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="cookie">
/// the #SoupCookie to be deleted
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T DeleteCookie<T>(this T cookie_manager, MentorLake.Soup.SoupCookieHandle cookie, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitCookieManagerHandle
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		WebKitCookieManagerHandleExterns.webkit_cookie_manager_delete_cookie(cookie_manager, cookie, cancellable, callback, user_data);
		return cookie_manager;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_cookie_manager_delete_cookie().
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the cookie was deleted or %FALSE in case of error.
/// </return>

	public static bool DeleteCookieFinish(this MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		var externCallResult = WebKitCookieManagerHandleExterns.webkit_cookie_manager_delete_cookie_finish(cookie_manager, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Remove all cookies of @cookie_manager for the given @domain.
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="domain">
/// a domain name
/// </param>

	public static T DeleteCookiesForDomain<T>(this T cookie_manager, string domain) where T : WebKitCookieManagerHandle
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		WebKitCookieManagerHandleExterns.webkit_cookie_manager_delete_cookies_for_domain(cookie_manager, domain);
		return cookie_manager;
	}

/// <summary>
/// <para>
/// Asynchronously get the cookie acceptance policy of @cookie_manager.
/// </para>
/// <para>
/// Note that when policy was set to %WEBKIT_COOKIE_POLICY_ACCEPT_NO_THIRD_PARTY and
/// ITP is enabled, this will return %WEBKIT_COOKIE_POLICY_ACCEPT_ALWAYS.
/// See also webkit_website_data_manager_set_itp_enabled().
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_cookie_manager_get_accept_policy_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T GetAcceptPolicy<T>(this T cookie_manager, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitCookieManagerHandle
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		WebKitCookieManagerHandleExterns.webkit_cookie_manager_get_accept_policy(cookie_manager, cancellable, callback, user_data);
		return cookie_manager;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_cookie_manager_get_accept_policy().
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// the cookie acceptance policy of @cookie_manager as a #WebKitCookieAcceptPolicy.
/// </return>

	public static MentorLake.WebKit2.WebKitCookieAcceptPolicy GetAcceptPolicyFinish(this MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		var externCallResult = WebKitCookieManagerHandleExterns.webkit_cookie_manager_get_accept_policy_finish(cookie_manager, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously get a list of #SoupCookie from @cookie_manager.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_cookie_manager_get_all_cookies_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// (closure user_data): a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T GetAllCookies<T>(this T cookie_manager, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitCookieManagerHandle
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		WebKitCookieManagerHandleExterns.webkit_cookie_manager_get_all_cookies(cookie_manager, cancellable, callback, user_data);
		return cookie_manager;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_cookie_manager_get_all_cookies().
/// </para>
/// <para>
/// The return value is a #GList of #SoupCookie instances which should be released
/// with g_list_free_full() and soup_cookie_free().
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// A #GList of #SoupCookie instances.
/// </return>

	public static MentorLake.GLib.GListHandle GetAllCookiesFinish(this MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		var externCallResult = WebKitCookieManagerHandleExterns.webkit_cookie_manager_get_all_cookies_finish(cookie_manager, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously get a list of #SoupCookie from @cookie_manager.
/// </para>
/// <para>
/// Asynchronously get a list of #SoupCookie from @cookie_manager associated with @uri, which
/// must be either an HTTP or an HTTPS URL.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_cookie_manager_get_cookies_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="uri">
/// the URI associated to the cookies to be retrieved
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T GetCookies<T>(this T cookie_manager, string uri, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitCookieManagerHandle
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		WebKitCookieManagerHandleExterns.webkit_cookie_manager_get_cookies(cookie_manager, uri, cancellable, callback, user_data);
		return cookie_manager;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_cookie_manager_get_cookies().
/// </para>
/// <para>
/// The return value is a #GList of #SoupCookie instances which should be released
/// with g_list_free_full() and soup_cookie_free().
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// A #GList of #SoupCookie instances.
/// </return>

	public static MentorLake.GLib.GListHandle GetCookiesFinish(this MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		var externCallResult = WebKitCookieManagerHandleExterns.webkit_cookie_manager_get_cookies_finish(cookie_manager, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously get the list of domains for which @cookie_manager contains cookies.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_cookie_manager_get_domains_with_cookies_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T GetDomainsWithCookies<T>(this T cookie_manager, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitCookieManagerHandle
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		WebKitCookieManagerHandleExterns.webkit_cookie_manager_get_domains_with_cookies(cookie_manager, cancellable, callback, user_data);
		return cookie_manager;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_cookie_manager_get_domains_with_cookies().
/// </para>
/// <para>
/// The return value is a %NULL terminated list of strings which should
/// be released with g_strfreev().
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// A %NULL terminated array of domain names
///    or %NULL in case of error.
/// </return>

	public static string[] GetDomainsWithCookiesFinish(this MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		var externCallResult = WebKitCookieManagerHandleExterns.webkit_cookie_manager_get_domains_with_cookies_finish(cookie_manager, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously replace all cookies in @cookie_manager with the given list of @cookies.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_cookie_manager_replace_cookies_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="cookies">
/// a #GList of #SoupCookie to be added
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// (closure user_data): a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T ReplaceCookies<T>(this T cookie_manager, MentorLake.GLib.GListHandle cookies, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitCookieManagerHandle
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		WebKitCookieManagerHandleExterns.webkit_cookie_manager_replace_cookies(cookie_manager, cookies, cancellable, callback, user_data);
		return cookie_manager;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_cookie_manager_replace_cookies().
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the cookies were added or %FALSE in case of error.
/// </return>

	public static bool ReplaceCookiesFinish(this MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		var externCallResult = WebKitCookieManagerHandleExterns.webkit_cookie_manager_replace_cookies_finish(cookie_manager, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Set the cookie acceptance policy of @cookie_manager as @policy.
/// </para>
/// <para>
/// Note that ITP has its own way to handle third-party cookies, so when it&apos;s enabled,
/// and @policy is set to %WEBKIT_COOKIE_POLICY_ACCEPT_NO_THIRD_PARTY, %WEBKIT_COOKIE_POLICY_ACCEPT_ALWAYS
/// will be used instead. Once disabled, the policy will be set back to %WEBKIT_COOKIE_POLICY_ACCEPT_NO_THIRD_PARTY.
/// See also webkit_website_data_manager_set_itp_enabled().
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="policy">
/// a #WebKitCookieAcceptPolicy
/// </param>

	public static T SetAcceptPolicy<T>(this T cookie_manager, MentorLake.WebKit2.WebKitCookieAcceptPolicy policy) where T : WebKitCookieManagerHandle
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		WebKitCookieManagerHandleExterns.webkit_cookie_manager_set_accept_policy(cookie_manager, policy);
		return cookie_manager;
	}

/// <summary>
/// <para>
/// Set non-session cookies.
/// </para>
/// <para>
/// Set the @filename where non-session cookies are stored persistently using
/// @storage as the format to read/write the cookies.
/// Cookies are initially read from @filename to create an initial set of cookies.
/// Then, non-session cookies will be written to @filename when the WebKitCookieManager::changed
/// signal is emitted.
/// By default, @cookie_manager doesn&apos;t store the cookies persistently, so you need to call this
/// method to keep cookies saved across sessions.
/// </para>
/// <para>
/// This method should never be called on a #WebKitCookieManager associated to an ephemeral #WebKitWebsiteDataManager.
/// </para>
/// </summary>

/// <param name="cookie_manager">
/// a #WebKitCookieManager
/// </param>
/// <param name="filename">
/// the filename to read to/write from
/// </param>
/// <param name="storage">
/// a #WebKitCookiePersistentStorage
/// </param>

	public static T SetPersistentStorage<T>(this T cookie_manager, string filename, MentorLake.WebKit2.WebKitCookiePersistentStorage storage) where T : WebKitCookieManagerHandle
	{
		if (cookie_manager.IsInvalid) throw new Exception("Invalid handle (WebKitCookieManagerHandle)");
		WebKitCookieManagerHandleExterns.webkit_cookie_manager_set_persistent_storage(cookie_manager, filename, storage);
		return cookie_manager;
	}

}

internal class WebKitCookieManagerHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_cookie_manager_add_cookie([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_cookie_manager_add_cookie_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_cookie_manager_delete_all_cookies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_cookie_manager_delete_cookie([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_cookie_manager_delete_cookie_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_cookie_manager_delete_cookies_for_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, string domain);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_cookie_manager_get_accept_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitCookieAcceptPolicy webkit_cookie_manager_get_accept_policy_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_cookie_manager_get_all_cookies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle webkit_cookie_manager_get_all_cookies_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_cookie_manager_get_cookies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle webkit_cookie_manager_get_cookies_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_cookie_manager_get_domains_with_cookies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] webkit_cookie_manager_get_domains_with_cookies_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_cookie_manager_replace_cookies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle cookies, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_cookie_manager_replace_cookies_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_cookie_manager_set_accept_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, MentorLake.WebKit2.WebKitCookieAcceptPolicy policy);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_cookie_manager_set_persistent_storage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))] MentorLake.WebKit2.WebKitCookieManagerHandle cookie_manager, string filename, MentorLake.WebKit2.WebKitCookiePersistentStorage storage);

}
