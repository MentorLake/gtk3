namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GTlsInteraction` provides a mechanism for the TLS connection and database
/// code to interact with the user. It can be used to ask the user for passwords.
/// </para>
/// <para>
/// To use a `GTlsInteraction` with a TLS connection use
/// [method@Gio.TlsConnection.set_interaction].
/// </para>
/// <para>
/// Callers should instantiate a derived class that implements the various
/// interaction methods to show the required dialogs.
/// </para>
/// <para>
/// Callers should use the &apos;invoke&apos; functions like
/// [method@Gio.TlsInteraction.invoke_ask_password] to run interaction methods.
/// These functions make sure that the interaction is invoked in the main loop
/// and not in the current thread, if the current thread is not running the
/// main loop.
/// </para>
/// <para>
/// Derived classes can choose to implement whichever interactions methods they’d
/// like to support by overriding those virtual methods in their class
/// initialization function. Any interactions not implemented will return
/// `G_TLS_INTERACTION_UNHANDLED`. If a derived class implements an async method,
/// it must also implement the corresponding finish method.
/// </para>
/// </summary>

public class GTlsInteractionHandle : GObjectHandle
{
}

public static class GTlsInteractionHandleExtensions
{
/// <summary>
/// <para>
/// Run synchronous interaction to ask the user for a password. In general,
/// g_tls_interaction_invoke_ask_password() should be used instead of this
/// function.
/// </para>
/// <para>
/// Derived subclasses usually implement a password prompt, although they may
/// also choose to provide a password from elsewhere. The @password value will
/// be filled in and then @callback will be called. Alternatively the user may
/// abort this password request, which will usually abort the TLS connection.
/// </para>
/// <para>
/// If the interaction is cancelled by the cancellation object, or by the
/// user then %G_TLS_INTERACTION_FAILED will be returned with an error that
/// contains a %G_IO_ERROR_CANCELLED error code. Certain implementations may
/// not support immediate cancellation.
/// </para>
/// </summary>

/// <param name="interaction">
/// a #GTlsInteraction object
/// </param>
/// <param name="password">
/// a #GTlsPassword object
/// </param>
/// <param name="cancellable">
/// an optional #GCancellable cancellation object
/// </param>
/// <return>
/// The status of the ask password interaction.
/// </return>

	public static MentorLake.Gio.GTlsInteractionResult AskPassword(this MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsPasswordHandle password, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (interaction.IsInvalid) throw new Exception("Invalid handle (GTlsInteractionHandle)");
		var externCallResult = GTlsInteractionHandleExterns.g_tls_interaction_ask_password(interaction, password, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Run asynchronous interaction to ask the user for a password. In general,
/// g_tls_interaction_invoke_ask_password() should be used instead of this
/// function.
/// </para>
/// <para>
/// Derived subclasses usually implement a password prompt, although they may
/// also choose to provide a password from elsewhere. The @password value will
/// be filled in and then @callback will be called. Alternatively the user may
/// abort this password request, which will usually abort the TLS connection.
/// </para>
/// <para>
/// If the interaction is cancelled by the cancellation object, or by the
/// user then %G_TLS_INTERACTION_FAILED will be returned with an error that
/// contains a %G_IO_ERROR_CANCELLED error code. Certain implementations may
/// not support immediate cancellation.
/// </para>
/// <para>
/// Certain implementations may not support immediate cancellation.
/// </para>
/// </summary>

/// <param name="interaction">
/// a #GTlsInteraction object
/// </param>
/// <param name="password">
/// a #GTlsPassword object
/// </param>
/// <param name="cancellable">
/// an optional #GCancellable cancellation object
/// </param>
/// <param name="callback">
/// will be called when the interaction completes
/// </param>
/// <param name="user_data">
/// data to pass to the @callback
/// </param>

	public static T AskPasswordAsync<T>(this T interaction, MentorLake.Gio.GTlsPasswordHandle password, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsInteractionHandle
	{
		if (interaction.IsInvalid) throw new Exception("Invalid handle (GTlsInteractionHandle)");
		GTlsInteractionHandleExterns.g_tls_interaction_ask_password_async(interaction, password, cancellable, callback, user_data);
		return interaction;
	}

/// <summary>
/// <para>
/// Complete an ask password user interaction request. This should be once
/// the g_tls_interaction_ask_password_async() completion callback is called.
/// </para>
/// <para>
/// If %G_TLS_INTERACTION_HANDLED is returned, then the #GTlsPassword passed
/// to g_tls_interaction_ask_password() will have its password filled in.
/// </para>
/// <para>
/// If the interaction is cancelled by the cancellation object, or by the
/// user then %G_TLS_INTERACTION_FAILED will be returned with an error that
/// contains a %G_IO_ERROR_CANCELLED error code.
/// </para>
/// </summary>

/// <param name="interaction">
/// a #GTlsInteraction object
/// </param>
/// <param name="result">
/// the result passed to the callback
/// </param>
/// <return>
/// The status of the ask password interaction.
/// </return>

	public static MentorLake.Gio.GTlsInteractionResult AskPasswordFinish(this MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (interaction.IsInvalid) throw new Exception("Invalid handle (GTlsInteractionHandle)");
		var externCallResult = GTlsInteractionHandleExterns.g_tls_interaction_ask_password_finish(interaction, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Invoke the interaction to ask the user for a password. It invokes this
/// interaction in the main loop, specifically the #GMainContext returned by
/// g_main_context_get_thread_default() when the interaction is created. This
/// is called by called by #GTlsConnection or #GTlsDatabase to ask the user
/// for a password.
/// </para>
/// <para>
/// Derived subclasses usually implement a password prompt, although they may
/// also choose to provide a password from elsewhere. The @password value will
/// be filled in and then @callback will be called. Alternatively the user may
/// abort this password request, which will usually abort the TLS connection.
/// </para>
/// <para>
/// The implementation can either be a synchronous (eg: modal dialog) or an
/// asynchronous one (eg: modeless dialog). This function will take care of
/// calling which ever one correctly.
/// </para>
/// <para>
/// If the interaction is cancelled by the cancellation object, or by the
/// user then %G_TLS_INTERACTION_FAILED will be returned with an error that
/// contains a %G_IO_ERROR_CANCELLED error code. Certain implementations may
/// not support immediate cancellation.
/// </para>
/// </summary>

/// <param name="interaction">
/// a #GTlsInteraction object
/// </param>
/// <param name="password">
/// a #GTlsPassword object
/// </param>
/// <param name="cancellable">
/// an optional #GCancellable cancellation object
/// </param>
/// <return>
/// The status of the ask password interaction.
/// </return>

	public static MentorLake.Gio.GTlsInteractionResult InvokeAskPassword(this MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsPasswordHandle password, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (interaction.IsInvalid) throw new Exception("Invalid handle (GTlsInteractionHandle)");
		var externCallResult = GTlsInteractionHandleExterns.g_tls_interaction_invoke_ask_password(interaction, password, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Invoke the interaction to ask the user to choose a certificate to
/// use with the connection. It invokes this interaction in the main
/// loop, specifically the #GMainContext returned by
/// g_main_context_get_thread_default() when the interaction is
/// created. This is called by called by #GTlsConnection when the peer
/// requests a certificate during the handshake.
/// </para>
/// <para>
/// Derived subclasses usually implement a certificate selector,
/// although they may also choose to provide a certificate from
/// elsewhere. Alternatively the user may abort this certificate
/// request, which may or may not abort the TLS connection.
/// </para>
/// <para>
/// The implementation can either be a synchronous (eg: modal dialog) or an
/// asynchronous one (eg: modeless dialog). This function will take care of
/// calling which ever one correctly.
/// </para>
/// <para>
/// If the interaction is cancelled by the cancellation object, or by the
/// user then %G_TLS_INTERACTION_FAILED will be returned with an error that
/// contains a %G_IO_ERROR_CANCELLED error code. Certain implementations may
/// not support immediate cancellation.
/// </para>
/// </summary>

/// <param name="interaction">
/// a #GTlsInteraction object
/// </param>
/// <param name="connection">
/// a #GTlsConnection object
/// </param>
/// <param name="flags">
/// flags providing more information about the request
/// </param>
/// <param name="cancellable">
/// an optional #GCancellable cancellation object
/// </param>
/// <return>
/// The status of the certificate request interaction.
/// </return>

	public static MentorLake.Gio.GTlsInteractionResult InvokeRequestCertificate(this MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsConnectionHandle connection, MentorLake.Gio.GTlsCertificateRequestFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (interaction.IsInvalid) throw new Exception("Invalid handle (GTlsInteractionHandle)");
		var externCallResult = GTlsInteractionHandleExterns.g_tls_interaction_invoke_request_certificate(interaction, connection, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Run synchronous interaction to ask the user to choose a certificate to use
/// with the connection. In general, g_tls_interaction_invoke_request_certificate()
/// should be used instead of this function.
/// </para>
/// <para>
/// Derived subclasses usually implement a certificate selector, although they may
/// also choose to provide a certificate from elsewhere. Alternatively the user may
/// abort this certificate request, which will usually abort the TLS connection.
/// </para>
/// <para>
/// If %G_TLS_INTERACTION_HANDLED is returned, then the #GTlsConnection
/// passed to g_tls_interaction_request_certificate() will have had its
/// #GTlsConnection:certificate filled in.
/// </para>
/// <para>
/// If the interaction is cancelled by the cancellation object, or by the
/// user then %G_TLS_INTERACTION_FAILED will be returned with an error that
/// contains a %G_IO_ERROR_CANCELLED error code. Certain implementations may
/// not support immediate cancellation.
/// </para>
/// </summary>

/// <param name="interaction">
/// a #GTlsInteraction object
/// </param>
/// <param name="connection">
/// a #GTlsConnection object
/// </param>
/// <param name="flags">
/// flags providing more information about the request
/// </param>
/// <param name="cancellable">
/// an optional #GCancellable cancellation object
/// </param>
/// <return>
/// The status of the request certificate interaction.
/// </return>

	public static MentorLake.Gio.GTlsInteractionResult RequestCertificate(this MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsConnectionHandle connection, MentorLake.Gio.GTlsCertificateRequestFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (interaction.IsInvalid) throw new Exception("Invalid handle (GTlsInteractionHandle)");
		var externCallResult = GTlsInteractionHandleExterns.g_tls_interaction_request_certificate(interaction, connection, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Run asynchronous interaction to ask the user for a certificate to use with
/// the connection. In general, g_tls_interaction_invoke_request_certificate() should
/// be used instead of this function.
/// </para>
/// <para>
/// Derived subclasses usually implement a certificate selector, although they may
/// also choose to provide a certificate from elsewhere. @callback will be called
/// when the operation completes. Alternatively the user may abort this certificate
/// request, which will usually abort the TLS connection.
/// </para>
/// </summary>

/// <param name="interaction">
/// a #GTlsInteraction object
/// </param>
/// <param name="connection">
/// a #GTlsConnection object
/// </param>
/// <param name="flags">
/// flags providing more information about the request
/// </param>
/// <param name="cancellable">
/// an optional #GCancellable cancellation object
/// </param>
/// <param name="callback">
/// will be called when the interaction completes
/// </param>
/// <param name="user_data">
/// data to pass to the @callback
/// </param>

	public static T RequestCertificateAsync<T>(this T interaction, MentorLake.Gio.GTlsConnectionHandle connection, MentorLake.Gio.GTlsCertificateRequestFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsInteractionHandle
	{
		if (interaction.IsInvalid) throw new Exception("Invalid handle (GTlsInteractionHandle)");
		GTlsInteractionHandleExterns.g_tls_interaction_request_certificate_async(interaction, connection, flags, cancellable, callback, user_data);
		return interaction;
	}

/// <summary>
/// <para>
/// Complete a request certificate user interaction request. This should be once
/// the g_tls_interaction_request_certificate_async() completion callback is called.
/// </para>
/// <para>
/// If %G_TLS_INTERACTION_HANDLED is returned, then the #GTlsConnection
/// passed to g_tls_interaction_request_certificate_async() will have had its
/// #GTlsConnection:certificate filled in.
/// </para>
/// <para>
/// If the interaction is cancelled by the cancellation object, or by the
/// user then %G_TLS_INTERACTION_FAILED will be returned with an error that
/// contains a %G_IO_ERROR_CANCELLED error code.
/// </para>
/// </summary>

/// <param name="interaction">
/// a #GTlsInteraction object
/// </param>
/// <param name="result">
/// the result passed to the callback
/// </param>
/// <return>
/// The status of the request certificate interaction.
/// </return>

	public static MentorLake.Gio.GTlsInteractionResult RequestCertificateFinish(this MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (interaction.IsInvalid) throw new Exception("Invalid handle (GTlsInteractionHandle)");
		var externCallResult = GTlsInteractionHandleExterns.g_tls_interaction_request_certificate_finish(interaction, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GTlsInteractionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionResult g_tls_interaction_ask_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_interaction_ask_password_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionResult g_tls_interaction_ask_password_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionResult g_tls_interaction_invoke_ask_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionResult g_tls_interaction_invoke_request_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle connection, MentorLake.Gio.GTlsCertificateRequestFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionResult g_tls_interaction_request_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle connection, MentorLake.Gio.GTlsCertificateRequestFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_interaction_request_certificate_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle connection, MentorLake.Gio.GTlsCertificateRequestFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionResult g_tls_interaction_request_certificate_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
