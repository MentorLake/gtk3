namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Represents an authentication request.
/// </para>
/// <para>
/// Whenever a client attempts to load a page protected by HTTP
/// authentication, credentials will need to be provided to authorize access.
/// To allow the client to decide how it wishes to handle authentication,
/// WebKit will fire a #WebKitWebView::authenticate signal with a
/// WebKitAuthenticationRequest object to provide client side
/// authentication support. Credentials are exposed through the
/// #WebKitCredential object.
/// </para>
/// <para>
/// In case the client application does not wish
/// to handle this signal WebKit will provide a default handler. To handle
/// authentication asynchronously, simply increase the reference count of the
/// WebKitAuthenticationRequest object.
/// </para>
/// </summary>

public class WebKitAuthenticationRequestHandle : GObjectHandle
{
}
public static class WebKitAuthenticationRequestHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the user authentication request succeeded.
/// Applications handling their own credential storage should connect to
/// this signal to save the credentials.
/// </para>
/// </summary>

	public static IObservable<WebKitAuthenticationRequestHandleSignalStructs.AuthenticatedSignal> Signal_Authenticated(this WebKitAuthenticationRequestHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitAuthenticationRequestHandleSignalStructs.AuthenticatedSignal> obs) =>
		{
			WebKitAuthenticationRequestHandleSignalDelegates.authenticated handler = ( MentorLake.WebKit2.WebKitAuthenticationRequestHandle self,  MentorLake.WebKit2.WebKitCredentialHandle credential,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitAuthenticationRequestHandleSignalStructs.AuthenticatedSignal()
				{
					Self = self, Credential = credential, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "authenticated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the user authentication request is
/// cancelled. It allows the application to dismiss its authentication
/// dialog in case of page load failure for example.
/// </para>
/// </summary>

	public static IObservable<WebKitAuthenticationRequestHandleSignalStructs.CancelledSignal> Signal_Cancelled(this WebKitAuthenticationRequestHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitAuthenticationRequestHandleSignalStructs.CancelledSignal> obs) =>
		{
			WebKitAuthenticationRequestHandleSignalDelegates.cancelled handler = ( MentorLake.WebKit2.WebKitAuthenticationRequestHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitAuthenticationRequestHandleSignalStructs.CancelledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cancelled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitAuthenticationRequestHandleSignalStructs
{

public class AuthenticatedSignal
{

	public MentorLake.WebKit2.WebKitAuthenticationRequestHandle Self;
/// <summary>
/// <para>
/// the #WebKitCredential accepted
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitCredentialHandle Credential;

	public IntPtr UserData;
}

public class CancelledSignal
{

	public MentorLake.WebKit2.WebKitAuthenticationRequestHandle Self;

	public IntPtr UserData;
}
}

public static class WebKitAuthenticationRequestHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the user authentication request succeeded.
/// Applications handling their own credential storage should connect to
/// this signal to save the credentials.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="credential">
/// the #WebKitCredential accepted
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void authenticated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))] MentorLake.WebKit2.WebKitCredentialHandle credential, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the user authentication request is
/// cancelled. It allows the application to dismiss its authentication
/// dialog in case of page load failure for example.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle self, IntPtr user_data);

}


public static class WebKitAuthenticationRequestHandleExtensions
{
/// <summary>
/// <para>
/// Authenticate the #WebKitAuthenticationRequest.
/// </para>
/// <para>
/// Authenticate the #WebKitAuthenticationRequest using the #WebKitCredential
/// supplied. To continue without credentials, pass %NULL as @credential.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <param name="credential">
/// A #WebKitCredential, or %NULL
/// </param>

	public static T Authenticate<T>(this T request, MentorLake.WebKit2.WebKitCredentialHandle credential) where T : WebKitAuthenticationRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_authenticate(request, credential);
		return request;
	}

/// <summary>
/// <para>
/// Determine whether this #WebKitAuthenticationRequest should allow the storage of credentials.
/// </para>
/// <para>
/// Determine whether the authentication method associated with this
/// #WebKitAuthenticationRequest should allow the storage of credentials.
/// This will return %FALSE if WebKit doesn&apos;t support credential storing,
/// if private browsing is enabled, or if persistent credential storage has been
/// disabled in #WebKitWebsiteDataManager, unless credentials saving has been
/// explicitly enabled with webkit_authentication_request_set_can_save_credentials().
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <return>
/// %TRUE if WebKit can store credentials or %FALSE otherwise.
/// </return>

	public static bool CanSaveCredentials(this MentorLake.WebKit2.WebKitAuthenticationRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		return WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_can_save_credentials(request);
	}

/// <summary>
/// <para>
/// Cancel the authentication challenge.
/// </para>
/// <para>
/// This will also cancel the page loading and result in a
/// #WebKitWebView::load-failed signal with a #WebKitNetworkError of type %WEBKIT_NETWORK_ERROR_CANCELLED being emitted.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>

	public static T Cancel<T>(this T request) where T : WebKitAuthenticationRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_cancel(request);
		return request;
	}

/// <summary>
/// <para>
/// Get the #GTlsPasswordFlags of the %WEBKIT_AUTHENTICATION_SCHEME_CLIENT_CERTIFICATE_PIN_REQUESTED authentication challenge.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <return>
/// a #GTlsPasswordFlags
/// </return>

	public static MentorLake.Gio.GTlsPasswordFlags GetCertificatePinFlags(this MentorLake.WebKit2.WebKitAuthenticationRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		return WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_get_certificate_pin_flags(request);
	}

/// <summary>
/// <para>
/// Get the host that this authentication challenge is applicable to.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <return>
/// The host of @request.
/// </return>

	public static string GetHost(this MentorLake.WebKit2.WebKitAuthenticationRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		return WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_get_host(request);
	}

/// <summary>
/// <para>
/// Get the port that this authentication challenge is applicable to.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <return>
/// The port of @request.
/// </return>

	public static uint GetPort(this MentorLake.WebKit2.WebKitAuthenticationRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		return WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_get_port(request);
	}

/// <summary>
/// <para>
/// Get the #WebKitCredential of the proposed authentication challenge.
/// </para>
/// <para>
/// Get the #WebKitCredential of the proposed authentication challenge that was
/// stored from a previous session. The client can use this directly for
/// authentication or construct their own #WebKitCredential.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <return>
/// A #WebKitCredential encapsulating credential details
/// or %NULL if there is no stored credential.
/// </return>

	public static MentorLake.WebKit2.WebKitCredentialHandle GetProposedCredential(this MentorLake.WebKit2.WebKitAuthenticationRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		return WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_get_proposed_credential(request);
	}

/// <summary>
/// <para>
/// Get the realm that this authentication challenge is applicable to.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <return>
/// The realm of @request.
/// </return>

	public static string GetRealm(this MentorLake.WebKit2.WebKitAuthenticationRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		return WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_get_realm(request);
	}

/// <summary>
/// <para>
/// Get the authentication scheme of the authentication challenge.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <return>
/// The #WebKitAuthenticationScheme of @request.
/// </return>

	public static MentorLake.WebKit2.WebKitAuthenticationScheme GetScheme(this MentorLake.WebKit2.WebKitAuthenticationRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		return WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_get_scheme(request);
	}

/// <summary>
/// <para>
/// Get the #WebKitSecurityOrigin that this authentication challenge is applicable to.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <return>
/// a newly created #WebKitSecurityOrigin.
/// </return>

	public static MentorLake.WebKit2.WebKitSecurityOriginHandle GetSecurityOrigin(this MentorLake.WebKit2.WebKitAuthenticationRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		return WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_get_security_origin(request);
	}

/// <summary>
/// <para>
/// Determine whether the authentication challenge is associated with a proxy server.
/// </para>
/// <para>
/// Determine whether the authentication challenge is associated with a proxy server rather than an &quot;origin&quot; server.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <return>
/// %TRUE if authentication is for a proxy or %FALSE otherwise.
/// </return>

	public static bool IsForProxy(this MentorLake.WebKit2.WebKitAuthenticationRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		return WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_is_for_proxy(request);
	}

/// <summary>
/// <para>
/// Determine whether this this is a first attempt or a retry for this authentication challenge.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <return>
/// %TRUE if authentication attempt is a retry or %FALSE otherwise.
/// </return>

	public static bool IsRetry(this MentorLake.WebKit2.WebKitAuthenticationRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		return WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_is_retry(request);
	}

/// <summary>
/// <para>
/// Set whether the authentication method associated with @request
/// should allow the storage of credentials.
/// </para>
/// <para>
/// Set whether the authentication method associated with @request
/// should allow the storage of credentials.
/// This should be used by applications handling their own credentials
/// storage to indicate that it should be supported even when internal
/// credential storage is disabled or unsupported.
/// Note that storing of credentials will not be allowed on ephemeral
/// sessions in any case.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <param name="enabled">
/// value to set
/// </param>

	public static T SetCanSaveCredentials<T>(this T request, bool enabled) where T : WebKitAuthenticationRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_set_can_save_credentials(request, enabled);
		return request;
	}

/// <summary>
/// <para>
/// Set the #WebKitCredential of the proposed authentication challenge.
/// </para>
/// <para>
/// Set the #WebKitCredential of the proposed authentication challenge that was
/// stored from a previous session. This should only be used by applications handling
/// their own credential storage. (When using the default WebKit credential storage,
/// webkit_authentication_request_get_proposed_credential() already contains previously-stored
/// credentials.)
/// Passing a %NULL @credential will clear the proposed credential.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <param name="credential">
/// a #WebKitCredential, or %NULL
/// </param>

	public static T SetProposedCredential<T>(this T request, MentorLake.WebKit2.WebKitCredentialHandle credential) where T : WebKitAuthenticationRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitAuthenticationRequestHandle)");
		WebKitAuthenticationRequestHandleExterns.webkit_authentication_request_set_proposed_credential(request, credential);
		return request;
	}

}

internal class WebKitAuthenticationRequestHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_authentication_request_authenticate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))] MentorLake.WebKit2.WebKitCredentialHandle credential);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_authentication_request_can_save_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_authentication_request_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.Gio.GTlsPasswordFlags webkit_authentication_request_get_certificate_pin_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_authentication_request_get_host([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_authentication_request_get_port([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))]
	internal static extern MentorLake.WebKit2.WebKitCredentialHandle webkit_authentication_request_get_proposed_credential([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_authentication_request_get_realm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitAuthenticationScheme webkit_authentication_request_get_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))]
	internal static extern MentorLake.WebKit2.WebKitSecurityOriginHandle webkit_authentication_request_get_security_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_authentication_request_is_for_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_authentication_request_is_retry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_authentication_request_set_can_save_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_authentication_request_set_proposed_credential([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))] MentorLake.WebKit2.WebKitCredentialHandle credential);

}
