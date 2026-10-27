namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Manages data stored locally by web sites.
/// </para>
/// <para>
/// You can use WebKitWebsiteDataManager to configure the local directories
/// where website data will be stored. Use #WebKitWebsiteDataManager:base-data-directory
/// and #WebKitWebsiteDataManager:base-cache-directory set a common base directory for all
/// website data and caches.
/// </para>
/// <para>
/// A WebKitWebsiteDataManager can be ephemeral, in which case all the directory configuration
/// is not needed because website data will never persist. You can create an ephemeral WebKitWebsiteDataManager
/// with webkit_website_data_manager_new_ephemeral().
/// </para>
/// <para>
/// WebKitWebsiteDataManager can also be used to fetch website data, remove data
/// stored by particular websites, or clear data for all websites modified since a given
/// period of time.
/// </para>
/// </summary>

public class WebKitWebsiteDataManagerHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #WebKitWebsiteDataManager with the given options.
/// </para>
/// <para>
/// It must be passed as construction parameter of a #WebKitWebContext.
/// </para>
/// </summary>

/// <param name="first_option_name">
/// name of the first option to set
/// </param>
/// <param name="@__arglist">
/// value of first option, followed by more options, %NULL-terminated
/// </param>
/// <return>
/// the newly created #WebKitWebsiteDataManager
/// </return>

	public static MentorLake.WebKit2.WebKitWebsiteDataManagerHandle New(string first_option_name, IntPtr @__arglist)
	{
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_new(first_option_name, @__arglist);
	}

/// <summary>
/// <para>
/// Creates an ephemeral #WebKitWebsiteDataManager.
/// </para>
/// <para>
/// See #WebKitWebsiteDataManager:is-ephemeral for more details.
/// </para>
/// </summary>

/// <return>
/// a new ephemeral #WebKitWebsiteDataManager.
/// </return>

	public static MentorLake.WebKit2.WebKitWebsiteDataManagerHandle NewEphemeral()
	{
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_new_ephemeral();
	}

/// <summary>
/// <para>
/// Sets @settings as the #WebKitMemoryPressureSettings.
/// </para>
/// <para>
/// Sets @settings as the #WebKitMemoryPressureSettings to be used by all the network
/// processes created by any instance of #WebKitWebsiteDataManager after this function
/// is called.
/// </para>
/// <para>
/// Be sure to call this function before creating any #WebKitWebsiteDataManager, as network
/// processes of existing instances are not guaranteed to receive the passed settings.
/// </para>
/// <para>
/// The periodic check for used memory is disabled by default on network processes. This will
/// be enabled only if custom settings have been set using this function. After that, in order
/// to remove the custom settings and disable the periodic check, this function must be called
/// passing %NULL as the value of @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a WebKitMemoryPressureSettings.
/// </param>

	public static void SetMemoryPressureSettings(MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings)
	{
		WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_set_memory_pressure_settings(settings);
	}

}

public static class WebKitWebsiteDataManagerHandleExtensions
{
/// <summary>
/// <para>
/// Asynchronously clear the website data of the given @types modified in the past @timespan.
/// </para>
/// <para>
/// If @timespan is 0, all website data will be removed.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_website_data_manager_clear_finish() to get the result of the operation.
/// </para>
/// <para>
/// Due to implementation limitations, this function does not currently delete
/// any stored cookies if @timespan is nonzero. This behavior may change in the
/// future.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <param name="types">
/// #WebKitWebsiteDataTypes
/// </param>
/// <param name="timespan">
/// a #GTimeSpan
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

	public static T Clear<T>(this T manager, MentorLake.WebKit2.WebKitWebsiteDataTypes types, MentorLake.GLib.GTimeSpan timespan, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebsiteDataManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_clear(manager, types, timespan, cancellable, callback, user_data);
		return manager;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_website_data_manager_clear()
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if website data was successfully cleared, or %FALSE otherwise.
/// </return>

	public static bool ClearFinish(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		var externCallResult = WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_clear_finish(manager, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously get the list of #WebKitWebsiteData for the given @types.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_website_data_manager_fetch_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <param name="types">
/// #WebKitWebsiteDataTypes
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

	public static T Fetch<T>(this T manager, MentorLake.WebKit2.WebKitWebsiteDataTypes types, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebsiteDataManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_fetch(manager, types, cancellable, callback, user_data);
		return manager;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_website_data_manager_fetch().
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GList of #WebKitWebsiteData. You must free the #GList with
///    g_list_free() and unref the #WebKitWebsiteData&amp;lt;!-- --&amp;gt;s with webkit_website_data_unref() when you&apos;re done with them.
/// </return>

	public static MentorLake.GLib.GListHandle FetchFinish(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		var externCallResult = WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_fetch_finish(manager, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager:base-cache-directory property.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// the base directory for caches, or %NULL if
///    #WebKitWebsiteDataManager:base-cache-directory was not provided or @manager is ephemeral.
/// </return>

	public static string GetBaseCacheDirectory(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_base_cache_directory(manager);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager:base-data-directory property.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// the base directory for website data, or %NULL if
///    #WebKitWebsiteDataManager:base-data-directory was not provided or @manager is ephemeral.
/// </return>

	public static string GetBaseDataDirectory(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_base_data_directory(manager);
	}

/// <summary>
/// <para>
/// Get the #WebKitCookieManager of @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// a #WebKitCookieManager
/// </return>

	public static MentorLake.WebKit2.WebKitCookieManagerHandle GetCookieManager(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_cookie_manager(manager);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager:disk-cache-directory property.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// the directory where HTTP disk cache is stored or %NULL if @manager is ephemeral.
/// </return>

	public static string GetDiskCacheDirectory(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_disk_cache_directory(manager);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager:dom-cache-directory property.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// the directory where DOM cache is stored or %NULL if @manager is ephemeral.
/// </return>

	public static string GetDomCacheDirectory(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_dom_cache_directory(manager);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager:hsts-cache-directory property.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// the directory where the HSTS cache is stored or %NULL if @manager is ephemeral.
/// </return>

	public static string GetHstsCacheDirectory(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_hsts_cache_directory(manager);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager:indexeddb-directory property.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// the directory where IndexedDB databases are stored or %NULL if @manager is ephemeral.
/// </return>

	public static string GetIndexeddbDirectory(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_indexeddb_directory(manager);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager:itp-directory property.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// the directory where Intelligent Tracking Prevention data is stored or %NULL if @manager is ephemeral.
/// </return>

	public static string GetItpDirectory(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_itp_directory(manager);
	}

/// <summary>
/// <para>
/// Get whether Intelligent Tracking Prevention (ITP) is enabled or not.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// %TRUE if ITP is enabled, or %FALSE otherwise.
/// </return>

	public static bool GetItpEnabled(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_itp_enabled(manager);
	}

/// <summary>
/// <para>
/// Asynchronously get the list of #WebKitITPThirdParty seen for @manager.
/// </para>
/// <para>
/// Every #WebKitITPThirdParty
/// contains the list of #WebKitITPFirstParty under which it has been seen.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_website_data_manager_get_itp_summary_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
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

	public static T GetItpSummary<T>(this T manager, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebsiteDataManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_itp_summary(manager, cancellable, callback, user_data);
		return manager;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_website_data_manager_get_itp_summary().
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GList of #WebKitITPThirdParty.
///    You must free the #GList with g_list_free() and unref the #WebKitITPThirdParty&amp;lt;!-- --&amp;gt;s with
///    webkit_itp_third_party_unref() when you&apos;re done with them.
/// </return>

	public static MentorLake.GLib.GListHandle GetItpSummaryFinish(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		var externCallResult = WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_itp_summary_finish(manager, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager:local-storage-directory property.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// the directory where local storage data is stored or %NULL if @manager is ephemeral.
/// </return>

	public static string GetLocalStorageDirectory(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_local_storage_directory(manager);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager:offline-application-cache-directory property.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// the directory where offline web application cache is stored or %NULL if @manager is ephemeral.
/// </return>

	public static string GetOfflineApplicationCacheDirectory(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_offline_application_cache_directory(manager);
	}

/// <summary>
/// <para>
/// Get whether persistent credential storage is enabled or not.
/// </para>
/// <para>
/// See also webkit_website_data_manager_set_persistent_credential_storage_enabled().
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// %TRUE if persistent credential storage is enabled, or %FALSE otherwise.
/// </return>

	public static bool GetPersistentCredentialStorageEnabled(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_persistent_credential_storage_enabled(manager);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager:service-worker-registrations-directory property.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// the directory where service worker registrations are stored or %NULL if @manager is ephemeral.
/// </return>

	public static string GetServiceWorkerRegistrationsDirectory(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_service_worker_registrations_directory(manager);
	}

/// <summary>
/// <para>
/// Get the TLS errors policy of @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// a #WebKitTLSErrorsPolicy
/// </return>

	public static MentorLake.WebKit2.WebKitTLSErrorsPolicy GetTlsErrorsPolicy(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_tls_errors_policy(manager);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager:websql-directory property.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// the directory where WebSQL databases are stored or %NULL if @manager is ephemeral.
/// </return>

	public static string GetWebsqlDirectory(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_get_websql_directory(manager);
	}

/// <summary>
/// <para>
/// Get whether a #WebKitWebsiteDataManager is ephemeral.
/// </para>
/// <para>
/// See #WebKitWebsiteDataManager:is-ephemeral for more details.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// %TRUE if @manager is ephemeral or %FALSE otherwise.
/// </return>

	public static bool IsEphemeral(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		return WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_is_ephemeral(manager);
	}

/// <summary>
/// <para>
/// Asynchronously removes the website data in the given @website_data list.
/// </para>
/// <para>
/// Asynchronously removes the website data of the given @types for websites in the given @website_data list.
/// Use webkit_website_data_manager_clear() if you want to remove the website data for all sites.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_website_data_manager_remove_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <param name="types">
/// #WebKitWebsiteDataTypes
/// </param>
/// <param name="website_data">
/// a #GList of #WebKitWebsiteData
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

	public static T Remove<T>(this T manager, MentorLake.WebKit2.WebKitWebsiteDataTypes types, MentorLake.GLib.GListHandle website_data, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebsiteDataManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_remove(manager, types, website_data, cancellable, callback, user_data);
		return manager;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_website_data_manager_remove().
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if website data resources were successfully removed, or %FALSE otherwise.
/// </return>

	public static bool RemoveFinish(this MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		var externCallResult = WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_remove_finish(manager, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Enable or disable Intelligent Tracking Prevention (ITP).
/// </para>
/// <para>
/// When ITP is enabled resource load statistics
/// are collected and used to decide whether to allow or block third-party cookies and prevent user tracking.
/// Note that while ITP is enabled the accept policy %WEBKIT_COOKIE_POLICY_ACCEPT_NO_THIRD_PARTY is ignored and
/// %WEBKIT_COOKIE_POLICY_ACCEPT_ALWAYS is used instead. See also webkit_cookie_manager_set_accept_policy().
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <param name="enabled">
/// value to set
/// </param>

	public static T SetItpEnabled<T>(this T manager, bool enabled) where T : WebKitWebsiteDataManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_set_itp_enabled(manager, enabled);
		return manager;
	}

/// <summary>
/// <para>
/// Set the network proxy settings to be used by connections started in @manager session.
/// </para>
/// <para>
/// By default %WEBKIT_NETWORK_PROXY_MODE_DEFAULT is used, which means that the
/// system settings will be used (g_proxy_resolver_get_default()).
/// If you want to override the system default settings, you can either use
/// %WEBKIT_NETWORK_PROXY_MODE_NO_PROXY to make sure no proxies are used at all,
/// or %WEBKIT_NETWORK_PROXY_MODE_CUSTOM to provide your own proxy settings.
/// When @proxy_mode is %WEBKIT_NETWORK_PROXY_MODE_CUSTOM @proxy_settings must be
/// a valid #WebKitNetworkProxySettings; otherwise, @proxy_settings must be %NULL.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <param name="proxy_mode">
/// a #WebKitNetworkProxyMode
/// </param>
/// <param name="proxy_settings">
/// a #WebKitNetworkProxySettings, or %NULL
/// </param>

	public static T SetNetworkProxySettings<T>(this T manager, MentorLake.WebKit2.WebKitNetworkProxyMode proxy_mode, MentorLake.WebKit2.WebKitNetworkProxySettingsHandle proxy_settings) where T : WebKitWebsiteDataManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_set_network_proxy_settings(manager, proxy_mode, proxy_settings);
		return manager;
	}

/// <summary>
/// <para>
/// Enable or disable persistent credential storage.
/// </para>
/// <para>
/// When enabled, which is the default for
/// non-ephemeral sessions, the network process will try to read and write HTTP authentiacation
/// credentials from persistent storage.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <param name="enabled">
/// value to set
/// </param>

	public static T SetPersistentCredentialStorageEnabled<T>(this T manager, bool enabled) where T : WebKitWebsiteDataManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_set_persistent_credential_storage_enabled(manager, enabled);
		return manager;
	}

/// <summary>
/// <para>
/// Set the TLS errors policy of @manager as @policy.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <param name="policy">
/// a #WebKitTLSErrorsPolicy
/// </param>

	public static T SetTlsErrorsPolicy<T>(this T manager, MentorLake.WebKit2.WebKitTLSErrorsPolicy policy) where T : WebKitWebsiteDataManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataManagerHandle)");
		WebKitWebsiteDataManagerHandleExterns.webkit_website_data_manager_set_tls_errors_policy(manager, policy);
		return manager;
	}

}

internal class WebKitWebsiteDataManagerHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebsiteDataManagerHandle webkit_website_data_manager_new(string first_option_name, IntPtr @__arglist);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebsiteDataManagerHandle webkit_website_data_manager_new_ephemeral();

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_website_data_manager_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, MentorLake.WebKit2.WebKitWebsiteDataTypes types, MentorLake.GLib.GTimeSpan timespan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_website_data_manager_clear_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_website_data_manager_fetch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, MentorLake.WebKit2.WebKitWebsiteDataTypes types, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle webkit_website_data_manager_fetch_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_manager_get_base_cache_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_manager_get_base_data_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))]
	internal static extern MentorLake.WebKit2.WebKitCookieManagerHandle webkit_website_data_manager_get_cookie_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_manager_get_disk_cache_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_manager_get_dom_cache_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_manager_get_hsts_cache_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_manager_get_indexeddb_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_manager_get_itp_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_website_data_manager_get_itp_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_website_data_manager_get_itp_summary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle webkit_website_data_manager_get_itp_summary_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_manager_get_local_storage_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_manager_get_offline_application_cache_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_website_data_manager_get_persistent_credential_storage_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_manager_get_service_worker_registrations_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitTLSErrorsPolicy webkit_website_data_manager_get_tls_errors_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_manager_get_websql_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_website_data_manager_is_ephemeral([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_website_data_manager_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, MentorLake.WebKit2.WebKitWebsiteDataTypes types, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle website_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_website_data_manager_remove_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_website_data_manager_set_itp_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_website_data_manager_set_network_proxy_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, MentorLake.WebKit2.WebKitNetworkProxyMode proxy_mode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNetworkProxySettingsHandle>))] MentorLake.WebKit2.WebKitNetworkProxySettingsHandle proxy_settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_website_data_manager_set_persistent_credential_storage_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_website_data_manager_set_tls_errors_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager, MentorLake.WebKit2.WebKitTLSErrorsPolicy policy);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_website_data_manager_set_memory_pressure_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings);

}
