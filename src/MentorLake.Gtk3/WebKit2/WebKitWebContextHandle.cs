namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Manages aspects common to all #WebKitWebView&amp;lt;!-- --&amp;gt;s
/// </para>
/// <para>
/// The #WebKitWebContext manages all aspects common to all
/// #WebKitWebView&amp;lt;!-- --&amp;gt;s.
/// </para>
/// <para>
/// You can define the #WebKitCacheModel with
/// webkit_web_context_set_cache_model(), depending on the needs of
/// your application. You can access the #WebKitSecurityManager to specify
/// the behaviour of your application regarding security using
/// webkit_web_context_get_security_manager().
/// </para>
/// <para>
/// It is also possible to change your preferred language or enable
/// spell checking, using webkit_web_context_set_preferred_languages(),
/// webkit_web_context_set_spell_checking_languages() and
/// webkit_web_context_set_spell_checking_enabled().
/// </para>
/// <para>
/// You can use webkit_web_context_register_uri_scheme() to register
/// custom URI schemes, and manage several other settings.
/// </para>
/// <para>
/// TLS certificate validation failure is now treated as a transport
/// error by default. To handle TLS failures differently, you can
/// connect to #WebKitWebView::load-failed-with-tls-errors.
/// Alternatively, you can use webkit_web_context_set_tls_errors_policy()
/// to set the policy %WEBKIT_TLS_ERRORS_POLICY_IGNORE; however, this is
/// not appropriate for Internet applications.
/// </para>
/// </summary>

public class WebKitWebContextHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new #WebKitWebContext.
/// </para>
/// </summary>

/// <return>
/// a newly created #WebKitWebContext
/// </return>

	public static MentorLake.WebKit2.WebKitWebContextHandle New()
	{
		return WebKitWebContextHandleExterns.webkit_web_context_new();
	}

/// <summary>
/// <para>
/// Create a new ephemeral #WebKitWebContext.
/// </para>
/// <para>
/// An ephemeral #WebKitWebContext is a context
/// created with an ephemeral #WebKitWebsiteDataManager. This is just a convenient method
/// to create ephemeral contexts without having to create your own #WebKitWebsiteDataManager.
/// All #WebKitWebView&amp;lt;!-- --&amp;gt;s associated with this context will also be ephemeral. Websites will
/// not store any data in the client storage.
/// This is normally used to implement private instances.
/// </para>
/// </summary>

/// <return>
/// a new ephemeral #WebKitWebContext.
/// </return>

	public static MentorLake.WebKit2.WebKitWebContextHandle NewEphemeral()
	{
		return WebKitWebContextHandleExterns.webkit_web_context_new_ephemeral();
	}

/// <summary>
/// <para>
/// Create a new #WebKitWebContext with a #WebKitWebsiteDataManager.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitWebsiteDataManager
/// </param>
/// <return>
/// a newly created #WebKitWebContext
/// </return>

	public static MentorLake.WebKit2.WebKitWebContextHandle NewWithWebsiteDataManager(MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager)
	{
		return WebKitWebContextHandleExterns.webkit_web_context_new_with_website_data_manager(manager);
	}

/// <summary>
/// <para>
/// Gets the default web context.
/// </para>
/// </summary>

/// <return>
/// a #WebKitWebContext
/// </return>

	public static MentorLake.WebKit2.WebKitWebContextHandle GetDefault()
	{
		return WebKitWebContextHandleExterns.webkit_web_context_get_default();
	}

}
public static class WebKitWebContextHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when a new automation request is made.
/// Note that it will never be emitted if automation is not enabled in @context,
/// see webkit_web_context_set_automation_allowed() for more details.
/// </para>
/// </summary>

	public static IObservable<WebKitWebContextHandleSignalStructs.AutomationStartedSignal> Signal_AutomationStarted(this WebKitWebContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebContextHandleSignalStructs.AutomationStartedSignal> obs) =>
		{
			WebKitWebContextHandleSignalDelegates.automation_started handler = ( MentorLake.WebKit2.WebKitWebContextHandle self,  MentorLake.WebKit2.WebKitAutomationSessionHandle session,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebContextHandleSignalStructs.AutomationStartedSignal()
				{
					Self = self, Session = session, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "automation-started", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted when a new download request is made.
/// </para>
/// </summary>

	public static IObservable<WebKitWebContextHandleSignalStructs.DownloadStartedSignal> Signal_DownloadStarted(this WebKitWebContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebContextHandleSignalStructs.DownloadStartedSignal> obs) =>
		{
			WebKitWebContextHandleSignalDelegates.download_started handler = ( MentorLake.WebKit2.WebKitWebContextHandle self,  MentorLake.WebKit2.WebKitDownloadHandle download,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebContextHandleSignalStructs.DownloadStartedSignal()
				{
					Self = self, Download = download, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "download-started", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted when a #WebKitWebContext needs to set
/// initial notification permissions for a web process. It is emitted
/// when a new web process is about to be launched, and signals the
/// most appropriate moment to use
/// webkit_web_context_initialize_notification_permissions(). If no
/// notification permissions have changed since the last time this
/// signal was emitted, then there is no need to call
/// webkit_web_context_initialize_notification_permissions() again.
/// </para>
/// </summary>

	public static IObservable<WebKitWebContextHandleSignalStructs.InitializeNotificationPermissionsSignal> Signal_InitializeNotificationPermissions(this WebKitWebContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebContextHandleSignalStructs.InitializeNotificationPermissionsSignal> obs) =>
		{
			WebKitWebContextHandleSignalDelegates.initialize_notification_permissions handler = ( MentorLake.WebKit2.WebKitWebContextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebContextHandleSignalStructs.InitializeNotificationPermissionsSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "initialize-notification-permissions", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted when a new web process is about to be
/// launched. It signals the most appropriate moment to use
/// webkit_web_context_set_web_extensions_initialization_user_data()
/// and webkit_web_context_set_web_extensions_directory().
/// </para>
/// </summary>

	public static IObservable<WebKitWebContextHandleSignalStructs.InitializeWebExtensionsSignal> Signal_InitializeWebExtensions(this WebKitWebContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebContextHandleSignalStructs.InitializeWebExtensionsSignal> obs) =>
		{
			WebKitWebContextHandleSignalDelegates.initialize_web_extensions handler = ( MentorLake.WebKit2.WebKitWebContextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebContextHandleSignalStructs.InitializeWebExtensionsSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "initialize-web-extensions", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted when a #WebKitUserMessage is received from a
/// web process extension. You can reply to the message using
/// webkit_user_message_send_reply().
/// </para>
/// <para>
/// You can handle the user message asynchronously by calling g_object_ref() on
/// @message and returning %TRUE.
/// </para>
/// </summary>

	public static IObservable<WebKitWebContextHandleSignalStructs.UserMessageReceivedSignal> Signal_UserMessageReceived(this WebKitWebContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebContextHandleSignalStructs.UserMessageReceivedSignal> obs) =>
		{
			WebKitWebContextHandleSignalDelegates.user_message_received handler = ( MentorLake.WebKit2.WebKitWebContextHandle self,  MentorLake.WebKit2.WebKitUserMessageHandle message,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebContextHandleSignalStructs.UserMessageReceivedSignal()
				{
					Self = self, Message = message, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "user-message-received", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitWebContextHandleSignalStructs
{

public class AutomationStartedSignal
{

	public MentorLake.WebKit2.WebKitWebContextHandle Self;
/// <summary>
/// <para>
/// the #WebKitAutomationSession associated with this event
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitAutomationSessionHandle Session;

	public IntPtr UserData;
}

public class DownloadStartedSignal
{

	public MentorLake.WebKit2.WebKitWebContextHandle Self;
/// <summary>
/// <para>
/// the #WebKitDownload associated with this event
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitDownloadHandle Download;

	public IntPtr UserData;
}

public class InitializeNotificationPermissionsSignal
{

	public MentorLake.WebKit2.WebKitWebContextHandle Self;

	public IntPtr UserData;
}

public class InitializeWebExtensionsSignal
{

	public MentorLake.WebKit2.WebKitWebContextHandle Self;

	public IntPtr UserData;
}

public class UserMessageReceivedSignal
{

	public MentorLake.WebKit2.WebKitWebContextHandle Self;
/// <summary>
/// <para>
/// the #WebKitUserMessage received
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitUserMessageHandle Message;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the message was handled, or %FALSE otherwise.
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class WebKitWebContextHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when a new automation request is made.
/// Note that it will never be emitted if automation is not enabled in @context,
/// see webkit_web_context_set_automation_allowed() for more details.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="session">
/// the #WebKitAutomationSession associated with this event
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void automation_started([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAutomationSessionHandle>))] MentorLake.WebKit2.WebKitAutomationSessionHandle session, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a new download request is made.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="download">
/// the #WebKitDownload associated with this event
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void download_started([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle download, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a #WebKitWebContext needs to set
/// initial notification permissions for a web process. It is emitted
/// when a new web process is about to be launched, and signals the
/// most appropriate moment to use
/// webkit_web_context_initialize_notification_permissions(). If no
/// notification permissions have changed since the last time this
/// signal was emitted, then there is no need to call
/// webkit_web_context_initialize_notification_permissions() again.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void initialize_notification_permissions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a new web process is about to be
/// launched. It signals the most appropriate moment to use
/// webkit_web_context_set_web_extensions_initialization_user_data()
/// and webkit_web_context_set_web_extensions_directory().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void initialize_web_extensions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a #WebKitUserMessage is received from a
/// web process extension. You can reply to the message using
/// webkit_user_message_send_reply().
/// </para>
/// <para>
/// You can handle the user message asynchronously by calling g_object_ref() on
/// @message and returning %TRUE.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="message">
/// the #WebKitUserMessage received
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the message was handled, or %FALSE otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool user_message_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMessageHandle>))] MentorLake.WebKit2.WebKitUserMessageHandle message, IntPtr user_data);

}


public static class WebKitWebContextHandleExtensions
{
/// <summary>
/// <para>
/// Adds a path to be mounted in the sandbox.
/// </para>
/// <para>
/// @path must exist before any web process has been created. It is a fatal error
/// to add paths after a web process has been spawned.
/// </para>
/// <para>
/// Paths under `/sys`, `/proc`, and `/dev` are invalid. Attempting to
/// add all of `/` is not valid. Since 2.40, adding the user&apos;s entire
/// home directory or /home is also not valid.
/// </para>
/// <para>
/// See also webkit_web_context_set_sandbox_enabled()
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="path">
/// an absolute path to mount in the sandbox
/// </param>
/// <param name="read_only">
/// if %TRUE the path will be read-only
/// </param>

	public static T AddPathToSandbox<T>(this T context, string path, bool read_only) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_add_path_to_sandbox(context, path, read_only);
		return context;
	}

/// <summary>
/// <para>
/// Ignore further TLS errors on the @host for the certificate present in @info.
/// </para>
/// <para>
/// If @host is an IPv6 address, it should not be surrounded by brackets. This
/// expectation matches g_uri_get_host().
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="certificate">
/// a #GTlsCertificate
/// </param>
/// <param name="host">
/// the host for which a certificate is to be allowed
/// </param>

	public static T AllowTlsCertificateForHost<T>(this T context, MentorLake.Gio.GTlsCertificateHandle certificate, string host) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_allow_tls_certificate_for_host(context, certificate, host);
		return context;
	}

/// <summary>
/// <para>
/// Clears all resources currently cached.
/// </para>
/// <para>
/// See also webkit_web_context_set_cache_model().
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>

	public static T ClearCache<T>(this T context) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_clear_cache(context);
		return context;
	}

/// <summary>
/// <para>
/// Requests downloading of the specified URI string.
/// </para>
/// <para>
/// The download operation will not be associated to any #WebKitWebView,
/// if you are interested in starting a download from a particular #WebKitWebView use
/// webkit_web_view_download_uri() instead.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="uri">
/// the URI to download
/// </param>
/// <return>
/// a new #WebKitDownload representing
///    the download operation.
/// </return>

	public static MentorLake.WebKit2.WebKitDownloadHandle DownloadUri(this MentorLake.WebKit2.WebKitWebContextHandle context, string uri)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_download_uri(context, uri);
	}

/// <summary>
/// <para>
/// Returns the current cache model.
/// </para>
/// <para>
/// For more information about this
/// value check the documentation of the function
/// webkit_web_context_set_cache_model().
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext
/// </param>
/// <return>
/// the current #WebKitCacheModel
/// </return>

	public static MentorLake.WebKit2.WebKitCacheModel GetCacheModel(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_cache_model(context);
	}

/// <summary>
/// <para>
/// Get the #WebKitCookieManager of the @context&apos;s #WebKitWebsiteDataManager.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <return>
/// the #WebKitCookieManager of @context.
/// </return>

	public static MentorLake.WebKit2.WebKitCookieManagerHandle GetCookieManager(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_cookie_manager(context);
	}

/// <summary>
/// <para>
/// Get the #WebKitFaviconDatabase associated with @context.
/// </para>
/// <para>
/// To initialize the database you need to call
/// webkit_web_context_set_favicon_database_directory().
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <return>
/// the #WebKitFaviconDatabase of @context.
/// </return>

	public static MentorLake.WebKit2.WebKitFaviconDatabaseHandle GetFaviconDatabase(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_favicon_database(context);
	}

/// <summary>
/// <para>
/// Get the directory path to store the favicons database.
/// </para>
/// <para>
/// Get the directory path being used to store the favicons database
/// for @context, or %NULL if
/// webkit_web_context_set_favicon_database_directory() hasn&apos;t been
/// called yet.
/// </para>
/// <para>
/// This function will always return the same path after having called
/// webkit_web_context_set_favicon_database_directory() for the first
/// time.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <return>
/// the path of the directory of the favicons
/// database associated with @context, or %NULL.
/// </return>

	public static string GetFaviconDatabaseDirectory(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_favicon_database_directory(context);
	}

/// <summary>
/// <para>
/// Get the #WebKitGeolocationManager of @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <return>
/// the #WebKitGeolocationManager of @context.
/// </return>

	public static MentorLake.WebKit2.WebKitGeolocationManagerHandle GetGeolocationManager(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_geolocation_manager(context);
	}

/// <summary>
/// <para>
/// Asynchronously get the list of installed plugins.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_web_context_get_plugins_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
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

	public static T GetPlugins<T>(this T context, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_get_plugins(context, cancellable, callback, user_data);
		return context;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_web_context_get_plugins.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GList of #WebKitPlugin. You must free the #GList with
///    g_list_free() and unref the #WebKitPlugin&amp;lt;!-- --&amp;gt;s with g_object_unref() when you&apos;re done with them.
/// </return>

	public static MentorLake.GLib.GListHandle GetPluginsFinish(this MentorLake.WebKit2.WebKitWebContextHandle context, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		var externCallResult = WebKitWebContextHandleExterns.webkit_web_context_get_plugins_finish(context, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns %WEBKIT_PROCESS_MODEL_MULTIPLE_SECONDARY_PROCESSES.
/// </para>
/// <para>
/// For more information about why this function is deprecated,
/// see webkit_web_context_set_process_model().
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext
/// </param>
/// <return>
/// %WEBKIT_PROCESS_MODEL_MULTIPLE_SECONDARY_PROCESSES
/// </return>

	public static MentorLake.WebKit2.WebKitProcessModel GetProcessModel(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_process_model(context);
	}

/// <summary>
/// <para>
/// Get whether sandboxing is currently enabled.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <return>
/// %TRUE if sandboxing is enabled, or %FALSE otherwise.
/// </return>

	public static bool GetSandboxEnabled(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_sandbox_enabled(context);
	}

/// <summary>
/// <para>
/// Get the #WebKitSecurityManager of @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <return>
/// the #WebKitSecurityManager of @context.
/// </return>

	public static MentorLake.WebKit2.WebKitSecurityManagerHandle GetSecurityManager(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_security_manager(context);
	}

/// <summary>
/// <para>
/// Get whether spell checking feature is currently enabled.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <return>
/// %TRUE If spell checking is enabled, or %FALSE otherwise.
/// </return>

	public static bool GetSpellCheckingEnabled(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_spell_checking_enabled(context);
	}

/// <summary>
/// <para>
/// Get the the list of spell checking languages.
/// </para>
/// <para>
/// Get the the list of spell checking languages associated with
/// @context, or %NULL if no languages have been previously set.
/// </para>
/// <para>
/// See webkit_web_context_set_spell_checking_languages() for more
/// details on the format of the languages in the list.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <return>
/// A %NULL-terminated
///    array of languages if available, or %NULL otherwise.
/// </return>

	public static string[] GetSpellCheckingLanguages(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_spell_checking_languages(context);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebContext:time-zone-override property.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>

	public static string GetTimeZoneOverride(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_time_zone_override(context);
	}

/// <summary>
/// <para>
/// Get the TLS errors policy of @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <return>
/// a #WebKitTLSErrorsPolicy
/// </return>

	public static MentorLake.WebKit2.WebKitTLSErrorsPolicy GetTlsErrorsPolicy(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_tls_errors_policy(context);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebContext:use-system-appearance-for-scrollbars property.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <return>
/// %TRUE if scrollbars are rendering using the system appearance, or %FALSE otherwise
/// </return>

	public static bool GetUseSystemAppearanceForScrollbars(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_use_system_appearance_for_scrollbars(context);
	}

/// <summary>
/// <para>
/// Gets the maximum number of web processes that can be created at the same time for the @context.
/// </para>
/// <para>
/// This function is now deprecated and always returns 0 (no limit). See also webkit_web_context_set_web_process_count_limit().
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext
/// </param>
/// <return>
/// the maximum limit of web processes, or 0 if there isn&apos;t a limit.
/// </return>

	public static uint GetWebProcessCountLimit(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_web_process_count_limit(context);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager of @context.
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext
/// </param>
/// <return>
/// a #WebKitWebsiteDataManager
/// </return>

	public static MentorLake.WebKit2.WebKitWebsiteDataManagerHandle GetWebsiteDataManager(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_get_website_data_manager(context);
	}

/// <summary>
/// <para>
/// Sets initial desktop notification permissions for the @context.
/// </para>
/// <para>
/// @allowed_origins and @disallowed_origins must each be #GList of
/// #WebKitSecurityOrigin objects representing origins that will,
/// respectively, either always or never have permission to show desktop
/// notifications. No #WebKitNotificationPermissionRequest will ever be
/// generated for any of the security origins represented in
/// @allowed_origins or @disallowed_origins. This function is necessary
/// because some webpages proactively check whether they have permission
/// to display notifications without ever creating a permission request.
/// </para>
/// <para>
/// This function only affects web processes that have not already been
/// created. The best time to call it is when handling
/// #WebKitWebContext::initialize-notification-permissions so as to
/// ensure that new web processes receive the most recent set of
/// permissions.
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext
/// </param>
/// <param name="allowed_origins">
/// a #GList of security origins
/// </param>
/// <param name="disallowed_origins">
/// a #GList of security origins
/// </param>

	public static T InitializeNotificationPermissions<T>(this T context, MentorLake.GLib.GListHandle allowed_origins, MentorLake.GLib.GListHandle disallowed_origins) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_initialize_notification_permissions(context, allowed_origins, disallowed_origins);
		return context;
	}

/// <summary>
/// <para>
/// Get whether automation is allowed in @context.
/// </para>
/// <para>
/// See also webkit_web_context_set_automation_allowed().
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext
/// </param>
/// <return>
/// %TRUE if automation is allowed or %FALSE otherwise.
/// </return>

	public static bool IsAutomationAllowed(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_is_automation_allowed(context);
	}

/// <summary>
/// <para>
/// Get whether a #WebKitWebContext is ephemeral.
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext
/// </param>
/// <return>
/// %TRUE if @context is ephemeral or %FALSE otherwise.
/// </return>

	public static bool IsEphemeral(this MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		return WebKitWebContextHandleExterns.webkit_web_context_is_ephemeral(context);
	}

/// <summary>
/// <para>
/// Resolve the domain name of the given @hostname in advance.
/// </para>
/// <para>
/// Resolve the domain name of the given @hostname in advance, so that if a URI
/// of @hostname is requested the load will be performed more quickly.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="hostname">
/// a hostname to be resolved
/// </param>

	public static T PrefetchDns<T>(this T context, string hostname) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_prefetch_dns(context, hostname);
		return context;
	}

/// <summary>
/// <para>
/// Register @scheme in @context.
/// </para>
/// <para>
/// Register @scheme in @context, so that when an URI request with @scheme is made in the
/// #WebKitWebContext, the #WebKitURISchemeRequestCallback registered will be called with a
/// #WebKitURISchemeRequest.
/// It is possible to handle URI scheme requests asynchronously, by calling g_object_ref() on the
/// #WebKitURISchemeRequest and calling webkit_uri_scheme_request_finish() later
/// when the data of the request is available or
/// webkit_uri_scheme_request_finish_error() in case of error.
/// </para>
/// <para>
/// ```c
/// static void
/// about_uri_scheme_request_cb (WebKitURISchemeRequest *request,
///                              gpointer                user_data)
/// {
///     GInputStream *stream;
///     gsize         stream_length;
///     const gchar  *path = webkit_uri_scheme_request_get_path (request);
/// </para>
/// <para>
///     if (!g_strcmp0 (path, &quot;memory&quot;)) {
///         // Create a GInputStream with the contents of memory about page, and set its length to stream_length
///     } else if (!g_strcmp0 (path, &quot;applications&quot;)) {
///         // Create a GInputStream with the contents of applications about page, and set its length to stream_length
///     } else if (!g_strcmp0 (path, &quot;example&quot;)) {
///         gchar *contents = g_strdup_printf (&quot;&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;p&amp;gt;Example about page&amp;lt;/p&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;&quot;);
///         stream_length = strlen (contents);
///         stream = g_memory_input_stream_new_from_data (contents, stream_length, g_free);
///     } else {
///         GError *error = g_error_new (ABOUT_HANDLER_ERROR, ABOUT_HANDLER_ERROR_INVALID, &quot;Invalid about:%s page.&quot;, path);
///         webkit_uri_scheme_request_finish_error (request, error);
///         g_error_free (error);
///         return;
///     }
///     webkit_uri_scheme_request_finish (request, stream, stream_length, &quot;text/html&quot;);
///     g_object_unref (stream);
/// }
/// ```
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="scheme">
/// the network scheme to register
/// </param>
/// <param name="callback">
/// a #WebKitURISchemeRequestCallback
/// </param>
/// <param name="user_data">
/// data to pass to callback function
/// </param>
/// <param name="user_data_destroy_func">
/// destroy notify for @user_data
/// </param>

	public static T RegisterUriScheme<T>(this T context, string scheme, MentorLake.WebKit2.WebKitURISchemeRequestCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_destroy_func) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_register_uri_scheme(context, scheme, callback, user_data, user_data_destroy_func);
		return context;
	}

/// <summary>
/// <para>
/// Send @message to all web process extensions associated to @context.
/// </para>
/// <para>
/// If @message is floating, it&apos;s consumed.
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext
/// </param>
/// <param name="message">
/// a #WebKitUserMessage
/// </param>

	public static T SendMessageToAllExtensions<T>(this T context, MentorLake.WebKit2.WebKitUserMessageHandle message) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_send_message_to_all_extensions(context, message);
		return context;
	}

/// <summary>
/// <para>
/// Set an additional directory where WebKit will look for plugins.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="directory">
/// the directory to add
/// </param>

	public static T SetAdditionalPluginsDirectory<T>(this T context, string directory) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_additional_plugins_directory(context, directory);
		return context;
	}

/// <summary>
/// <para>
/// Set whether automation is allowed in @context.
/// </para>
/// <para>
/// When automation is enabled the browser could
/// be controlled by another process by requesting an automation session. When a new automation
/// session is requested the signal #WebKitWebContext::automation-started is emitted.
/// Automation is disabled by default, so you need to explicitly call this method passing %TRUE
/// to enable it.
/// </para>
/// <para>
/// Note that only one #WebKitWebContext can have automation enabled, so this will do nothing
/// if there&apos;s another #WebKitWebContext with automation already enabled.
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext
/// </param>
/// <param name="allowed">
/// value to set
/// </param>

	public static T SetAutomationAllowed<T>(this T context, bool allowed) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_automation_allowed(context, allowed);
		return context;
	}

/// <summary>
/// <para>
/// Specifies a usage model for WebViews.
/// </para>
/// <para>
/// Specifies a usage model for WebViews, which WebKit will use to
/// determine its caching behavior. All web views follow the cache
/// model. This cache model determines the RAM and disk space to use
/// for caching previously viewed content .
/// </para>
/// <para>
/// Research indicates that users tend to browse within clusters of
/// documents that hold resources in common, and to revisit previously
/// visited documents. WebKit and the frameworks below it include
/// built-in caches that take advantage of these patterns,
/// substantially improving document load speed in browsing
/// situations. The WebKit cache model controls the behaviors of all of
/// these caches, including various WebCore caches.
/// </para>
/// <para>
/// Browsers can improve document load speed substantially by
/// specifying %WEBKIT_CACHE_MODEL_WEB_BROWSER. Applications without a
/// browsing interface can reduce memory usage substantially by
/// specifying %WEBKIT_CACHE_MODEL_DOCUMENT_VIEWER. The default value is
/// %WEBKIT_CACHE_MODEL_WEB_BROWSER.
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext
/// </param>
/// <param name="cache_model">
/// a #WebKitCacheModel
/// </param>

	public static T SetCacheModel<T>(this T context, MentorLake.WebKit2.WebKitCacheModel cache_model) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_cache_model(context, cache_model);
		return context;
	}

/// <summary>
/// <para>
/// Set the directory where disk cache files will be stored.
/// </para>
/// <para>
/// This method must be called before loading anything in this context, otherwise
/// it will not have any effect.
/// </para>
/// <para>
/// Note that this method overrides the directory set in the #WebKitWebsiteDataManager,
/// but it doesn&apos;t change the value returned by webkit_website_data_manager_get_disk_cache_directory()
/// since the #WebKitWebsiteDataManager is immutable.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="directory">
/// the directory to set
/// </param>

	public static T SetDiskCacheDirectory<T>(this T context, string directory) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_disk_cache_directory(context, directory);
		return context;
	}

/// <summary>
/// <para>
/// Set the directory path to store the favicons database.
/// </para>
/// <para>
/// Set the directory path to be used to store the favicons database
/// for @context on disk. Passing %NULL as @path means using the
/// default directory for the platform (see g_get_user_cache_dir()).
/// </para>
/// <para>
/// Calling this method also means enabling the favicons database for
/// its use from the applications, so that&apos;s why it&apos;s expected to be
/// called only once. Further calls for the same instance of
/// #WebKitWebContext won&apos;t cause any effect.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="path">
/// an absolute path to the icon database
/// directory or %NULL to use the defaults
/// </param>

	public static T SetFaviconDatabaseDirectory<T>(this T context, string path) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_favicon_database_directory(context, path);
		return context;
	}

/// <summary>
/// <para>
/// Set the network proxy settings to be used by connections started in @context.
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

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="proxy_mode">
/// a #WebKitNetworkProxyMode
/// </param>
/// <param name="proxy_settings">
/// a #WebKitNetworkProxySettings, or %NULL
/// </param>

	public static T SetNetworkProxySettings<T>(this T context, MentorLake.WebKit2.WebKitNetworkProxyMode proxy_mode, MentorLake.WebKit2.WebKitNetworkProxySettingsHandle proxy_settings) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_network_proxy_settings(context, proxy_mode, proxy_settings);
		return context;
	}

/// <summary>
/// <para>
/// Set the list of preferred languages.
/// </para>
/// <para>
/// Set the list of preferred languages, sorted from most desirable
/// to least desirable. The list will be used in the following ways:
/// </para>
/// <para>
/// - Determining how to build the `Accept-Language` HTTP header that will be
///   included in the network requests started by the #WebKitWebContext.
/// - Setting the values of `navigator.language` and `navigator.languages`.
/// - The first item in the list sets the default locale for JavaScript
///   `Intl` functions.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="languages">
/// a %NULL-terminated list of language identifiers
/// </param>

	public static T SetPreferredLanguages<T>(this T context, string[] languages) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_preferred_languages(context, languages);
		return context;
	}

/// <summary>
/// <para>
/// This function previously allowed specifying the process model to use.
/// However, since 2.26, the only allowed process model is
/// %WEBKIT_PROCESS_MODEL_MULTIPLE_SECONDARY_PROCESSES, so this function
/// does nothing.
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext
/// </param>
/// <param name="process_model">
/// a #WebKitProcessModel
/// </param>

	public static T SetProcessModel<T>(this T context, MentorLake.WebKit2.WebKitProcessModel process_model) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_process_model(context, process_model);
		return context;
	}

/// <summary>
/// <para>
/// Set whether WebKit subprocesses will be sandboxed.
/// </para>
/// <para>
/// Set whether WebKit subprocesses will be sandboxed, limiting access to the system.
/// This method **must be called before any web process has been created**,
/// as early as possible in your application. Calling it later is a fatal error.
/// </para>
/// <para>
/// This is only implemented on Linux and is a no-op otherwise.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="enabled">
/// if %TRUE enable sandboxing
/// </param>

	public static T SetSandboxEnabled<T>(this T context, bool enabled) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_sandbox_enabled(context, enabled);
		return context;
	}

/// <summary>
/// <para>
/// Enable or disable the spell checking feature.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetSpellCheckingEnabled<T>(this T context, bool enabled) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_spell_checking_enabled(context, enabled);
		return context;
	}

/// <summary>
/// <para>
/// Set the list of spell checking languages to be used for spell
/// checking.
/// </para>
/// <para>
/// The locale string typically is in the form lang_COUNTRY, where lang
/// is an ISO-639 language code, and COUNTRY is an ISO-3166 country code.
/// For instance, sv_FI for Swedish as written in Finland or pt_BR
/// for Portuguese as written in Brazil.
/// </para>
/// <para>
/// You need to call this function with a valid list of languages at
/// least once in order to properly enable the spell checking feature
/// in WebKit.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="languages">
/// a %NULL-terminated list of spell checking languages
/// </param>

	public static T SetSpellCheckingLanguages<T>(this T context, string[] languages) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_spell_checking_languages(context, languages);
		return context;
	}

/// <summary>
/// <para>
/// Set the TLS errors policy of @context as @policy.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="policy">
/// a #WebKitTLSErrorsPolicy
/// </param>

	public static T SetTlsErrorsPolicy<T>(this T context, MentorLake.WebKit2.WebKitTLSErrorsPolicy policy) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_tls_errors_policy(context, policy);
		return context;
	}

/// <summary>
/// <para>
/// Set the #WebKitWebContext:use-system-appearance-for-scrollbars property.
/// </para>
/// <para>
/// This is now deprecated and when WebKit is built with Skia this method does nothing.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="enabled">
/// value to set
/// </param>

	public static T SetUseSystemAppearanceForScrollbars<T>(this T context, bool enabled) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_use_system_appearance_for_scrollbars(context, enabled);
		return context;
	}

/// <summary>
/// <para>
/// Set the directory where WebKit will look for web process extensions.
/// </para>
/// <para>
/// This method must be called before loading anything in this context,
/// otherwise it will not have any effect. You can connect to
/// #WebKitWebContext::initialize-web-extensions to call this method
/// before anything is loaded.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="directory">
/// the directory to add
/// </param>

	public static T SetWebExtensionsDirectory<T>(this T context, string directory) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_web_extensions_directory(context, directory);
		return context;
	}

/// <summary>
/// <para>
/// Set user data to be passed to web process extensions on initialization.
/// </para>
/// <para>
/// The data will be passed to the
/// #WebKitWebExtensionInitializeWithUserDataFunction.
/// This method must be called before loading anything in this context,
/// otherwise it will not have any effect. You can connect to
/// #WebKitWebContext::initialize-web-extensions to call this method
/// before anything is loaded.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitWebContext
/// </param>
/// <param name="user_data">
/// a #GVariant
/// </param>

	public static T SetWebExtensionsInitializationUserData<T>(this T context, MentorLake.GLib.GVariantHandle user_data) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_web_extensions_initialization_user_data(context, user_data);
		return context;
	}

/// <summary>
/// <para>
/// Sets the maximum number of web processes.
/// </para>
/// <para>
/// Sets the maximum number of web processes that can be created at the same time for the @context.
/// The default value is 0 and means no limit.
/// </para>
/// <para>
/// This function is now deprecated and does nothing for security reasons.
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext
/// </param>
/// <param name="limit">
/// the maximum number of web processes
/// </param>

	public static T SetWebProcessCountLimit<T>(this T context, uint limit) where T : WebKitWebContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitWebContextHandle)");
		WebKitWebContextHandleExterns.webkit_web_context_set_web_process_count_limit(context, limit);
		return context;
	}

}

internal class WebKitWebContextHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebContextHandle webkit_web_context_new();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebContextHandle webkit_web_context_new_ephemeral();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebContextHandle webkit_web_context_new_with_website_data_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))] MentorLake.WebKit2.WebKitWebsiteDataManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_add_path_to_sandbox([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, string path, bool read_only);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_allow_tls_certificate_for_host([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, string host);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_clear_cache([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))]
	internal static extern MentorLake.WebKit2.WebKitDownloadHandle webkit_web_context_download_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, string uri);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitCacheModel webkit_web_context_get_cache_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCookieManagerHandle>))]
	internal static extern MentorLake.WebKit2.WebKitCookieManagerHandle webkit_web_context_get_cookie_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFaviconDatabaseHandle>))]
	internal static extern MentorLake.WebKit2.WebKitFaviconDatabaseHandle webkit_web_context_get_favicon_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_web_context_get_favicon_database_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationManagerHandle>))]
	internal static extern MentorLake.WebKit2.WebKitGeolocationManagerHandle webkit_web_context_get_geolocation_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_get_plugins([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle webkit_web_context_get_plugins_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitProcessModel webkit_web_context_get_process_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_context_get_sandbox_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))]
	internal static extern MentorLake.WebKit2.WebKitSecurityManagerHandle webkit_web_context_get_security_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_context_get_spell_checking_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] webkit_web_context_get_spell_checking_languages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_web_context_get_time_zone_override([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitTLSErrorsPolicy webkit_web_context_get_tls_errors_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_context_get_use_system_appearance_for_scrollbars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_web_context_get_web_process_count_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebsiteDataManagerHandle webkit_web_context_get_website_data_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_initialize_notification_permissions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle allowed_origins, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle disallowed_origins);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_context_is_automation_allowed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_context_is_ephemeral([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_prefetch_dns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, string hostname);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_register_uri_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, string scheme, MentorLake.WebKit2.WebKitURISchemeRequestCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_destroy_func);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_send_message_to_all_extensions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMessageHandle>))] MentorLake.WebKit2.WebKitUserMessageHandle message);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_additional_plugins_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, string directory);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_automation_allowed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, bool allowed);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_cache_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, MentorLake.WebKit2.WebKitCacheModel cache_model);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_disk_cache_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, string directory);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_favicon_database_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, string path);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_network_proxy_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, MentorLake.WebKit2.WebKitNetworkProxyMode proxy_mode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNetworkProxySettingsHandle>))] MentorLake.WebKit2.WebKitNetworkProxySettingsHandle proxy_settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_preferred_languages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, string[] languages);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_process_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, MentorLake.WebKit2.WebKitProcessModel process_model);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_sandbox_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_spell_checking_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_spell_checking_languages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, string[] languages);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_tls_errors_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, MentorLake.WebKit2.WebKitTLSErrorsPolicy policy);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_use_system_appearance_for_scrollbars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_web_extensions_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, string directory);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_web_extensions_initialization_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle user_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_context_set_web_process_count_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context, uint limit);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebContextHandle webkit_web_context_get_default();

}
