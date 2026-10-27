namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Soup session state object.
/// </para>
/// <para>
/// [class@Session] is the object that controls client-side HTTP. A
/// [class@Session] encapsulates all of the state that libsoup is keeping
/// on behalf of your program; cached HTTP connections, authentication
/// information, etc. It also keeps track of various global options
/// and features that you are using.
/// </para>
/// <para>
/// Most applications will only need a single [class@Session]; the primary
/// reason you might need multiple sessions is if you need to have
/// multiple independent authentication contexts. (Eg, you are
/// connecting to a server and authenticating as two different users at
/// different times; the easiest way to ensure that each [class@Message]
/// is sent with the authentication information you intended is to use
/// one session for the first user, and a second session for the other
/// user.)
/// </para>
/// <para>
/// Additional [class@Session] functionality is provided by
/// [iface@SessionFeature] objects, which can be added to a session with
/// [method@Session.add_feature] or [method@Session.add_feature_by_type]
/// For example, [class@Logger] provides support for
/// logging HTTP traffic, [class@ContentDecoder] provides support for
/// compressed response handling, and [class@ContentSniffer] provides
/// support for HTML5-style response body content sniffing.
/// Additionally, subtypes of [class@Auth] can be added
/// as features, to add support for additional authentication types.
/// </para>
/// <para>
/// All `SoupSession`s are created with a [class@AuthManager], and support
/// for %SOUP_TYPE_AUTH_BASIC and %SOUP_TYPE_AUTH_DIGEST. Additionally,
/// sessions using the plain [class@Session] class (rather than one of its deprecated
/// subtypes) have a [class@ContentDecoder] by default.
/// </para>
/// <para>
/// Note that all async methods will invoke their callbacks on the thread-default
/// context at the time of the function call.
/// </para>
/// </summary>

public class SoupSessionHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a [class@Session] with the default options.
/// </para>
/// </summary>

/// <return>
/// the new session.
/// </return>

	public static MentorLake.Soup.SoupSessionHandle New()
	{
		return SoupSessionHandleExterns.soup_session_new();
	}

/// <summary>
/// <para>
/// Creates a [class@Session] with the specified options.
/// </para>
/// </summary>

/// <param name="optname1">
/// name of first property to set
/// </param>
/// <param name="@__arglist">
/// value of @optname1, followed by additional property/value pairs
/// </param>
/// <return>
/// the new session.
/// </return>

	public static MentorLake.Soup.SoupSessionHandle NewWithOptions(string optname1, IntPtr @__arglist)
	{
		return SoupSessionHandleExterns.soup_session_new_with_options(optname1, @__arglist);
	}

}
public static class SoupSessionHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when a request is queued on @session.
/// </para>
/// <para>
/// When sending a request, first [signal@Session::request-queued]
/// is emitted, indicating that the session has become aware of
/// the request.
/// </para>
/// <para>
/// After a connection is available to send the request various
/// [class@Message] signals are emitted as the message is
/// processed. If the message is requeued, it will emit
/// [signal@Message::restarted], which will then be followed by other
/// [class@Message] signals when the message is re-sent.
/// </para>
/// <para>
/// Eventually, the message will emit [signal@Message::finished].
/// Normally, this signals the completion of message
/// processing. However, it is possible that the application
/// will requeue the message from the &quot;finished&quot; handler.
/// In that case the process will loop back.
/// </para>
/// <para>
/// Eventually, a message will reach &quot;finished&quot; and not be
/// requeued. At that point, the session will emit
/// [signal@Session::request-unqueued] to indicate that it is done
/// with the message.
/// </para>
/// <para>
/// To sum up: [signal@Session::request-queued] and
/// [signal@Session::request-unqueued] are guaranteed to be emitted
/// exactly once, but [signal@Message::finished] (and all of the other
/// [class@Message] signals) may be invoked multiple times for a given
/// message.
/// </para>
/// </summary>

	public static IObservable<SoupSessionHandleSignalStructs.RequestQueuedSignal> Signal_RequestQueued(this SoupSessionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupSessionHandleSignalStructs.RequestQueuedSignal> obs) =>
		{
			SoupSessionHandleSignalDelegates.request_queued handler = ( MentorLake.Soup.SoupSessionHandle self,  MentorLake.Soup.SoupMessageHandle msg,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupSessionHandleSignalStructs.RequestQueuedSignal()
				{
					Self = self, Msg = msg, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "request-queued", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a request is removed from @session&apos;s queue,
/// indicating that @session is done with it.
/// </para>
/// <para>
/// See [signal@Session::request-queued] for a detailed description of
/// the message lifecycle within a session.
/// </para>
/// </summary>

	public static IObservable<SoupSessionHandleSignalStructs.RequestUnqueuedSignal> Signal_RequestUnqueued(this SoupSessionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupSessionHandleSignalStructs.RequestUnqueuedSignal> obs) =>
		{
			SoupSessionHandleSignalDelegates.request_unqueued handler = ( MentorLake.Soup.SoupSessionHandle self,  MentorLake.Soup.SoupMessageHandle msg,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupSessionHandleSignalStructs.RequestUnqueuedSignal()
				{
					Self = self, Msg = msg, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "request-unqueued", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class SoupSessionHandleSignalStructs
{

public class RequestQueuedSignal
{

	public MentorLake.Soup.SoupSessionHandle Self;
/// <summary>
/// <para>
/// the request that was queued
/// </para>
/// </summary>

	public MentorLake.Soup.SoupMessageHandle Msg;

	public IntPtr UserData;
}

public class RequestUnqueuedSignal
{

	public MentorLake.Soup.SoupSessionHandle Self;
/// <summary>
/// <para>
/// the request that was unqueued
/// </para>
/// </summary>

	public MentorLake.Soup.SoupMessageHandle Msg;

	public IntPtr UserData;
}
}

public static class SoupSessionHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when a request is queued on @session.
/// </para>
/// <para>
/// When sending a request, first [signal@Session::request-queued]
/// is emitted, indicating that the session has become aware of
/// the request.
/// </para>
/// <para>
/// After a connection is available to send the request various
/// [class@Message] signals are emitted as the message is
/// processed. If the message is requeued, it will emit
/// [signal@Message::restarted], which will then be followed by other
/// [class@Message] signals when the message is re-sent.
/// </para>
/// <para>
/// Eventually, the message will emit [signal@Message::finished].
/// Normally, this signals the completion of message
/// processing. However, it is possible that the application
/// will requeue the message from the &quot;finished&quot; handler.
/// In that case the process will loop back.
/// </para>
/// <para>
/// Eventually, a message will reach &quot;finished&quot; and not be
/// requeued. At that point, the session will emit
/// [signal@Session::request-unqueued] to indicate that it is done
/// with the message.
/// </para>
/// <para>
/// To sum up: [signal@Session::request-queued] and
/// [signal@Session::request-unqueued] are guaranteed to be emitted
/// exactly once, but [signal@Message::finished] (and all of the other
/// [class@Message] signals) may be invoked multiple times for a given
/// message.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="msg">
/// the request that was queued
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void request_queued([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a request is removed from @session&apos;s queue,
/// indicating that @session is done with it.
/// </para>
/// <para>
/// See [signal@Session::request-queued] for a detailed description of
/// the message lifecycle within a session.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="msg">
/// the request that was unqueued
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void request_unqueued([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, IntPtr user_data);

}


public static class SoupSessionHandleExtensions
{
/// <summary>
/// <para>
/// Cancels all pending requests in @session and closes all idle
/// persistent connections.
/// </para>
/// </summary>

/// <param name="session">
/// the session
/// </param>

	public static T Abort<T>(this T session) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_abort(session);
		return session;
	}

/// <summary>
/// <para>
/// Adds @feature&apos;s functionality to @session. You cannot add multiple
/// features of the same [alias@GObject.Type] to a session.
/// </para>
/// <para>
/// See the main [class@Session] documentation for information on what
/// features are present in sessions by default.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="feature">
/// an object that implements #SoupSessionFeature
/// </param>

	public static T AddFeature<T>(this T session, MentorLake.Soup.SoupSessionFeatureHandle feature) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_add_feature(session, feature);
		return session;
	}

/// <summary>
/// <para>
/// If @feature_type is the type of a class that implements
/// [iface@SessionFeature], this creates a new feature of that type and
/// adds it to @session as with [method@Session.add_feature]. You can use
/// this when you don&apos;t need to customize the new feature in any way.
/// Adding multiple features of the same @feature_type is not allowed.
/// </para>
/// <para>
/// If @feature_type is not a [iface@SessionFeature] type, this gives each
/// existing feature on @session the chance to accept @feature_type as
/// a &quot;subfeature&quot;. This can be used to add new [class@Auth] types, for instance.
/// </para>
/// <para>
/// See the main [class@Session] documentation for information on what
/// features are present in sessions by default.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="feature_type">
/// a #GType
/// </param>

	public static T AddFeatureByType<T>(this T session, MentorLake.GObject.GType feature_type) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_add_feature_by_type(session, feature_type);
		return session;
	}

/// <summary>
/// <para>
/// Get the value used by @session for the &quot;Accept-Language&quot; header on new
/// requests.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <return>
/// the accept language string
/// </return>

	public static string GetAcceptLanguage(this MentorLake.Soup.SoupSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_accept_language(session);
	}

/// <summary>
/// <para>
/// Gets whether @session automatically sets the &quot;Accept-Language&quot; header on new
/// requests.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <return>
/// %TRUE if @session sets &quot;Accept-Language&quot; header automatically, or
///   %FALSE otherwise.
/// </return>

	public static bool GetAcceptLanguageAuto(this MentorLake.Soup.SoupSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_accept_language_auto(session);
	}

/// <summary>
/// <para>
/// Gets the [class@Message] of the @result asynchronous operation This is useful
/// to get the [class@Message] of an asynchronous operation started by @session
/// from its [callback@Gio.AsyncReadyCallback].
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="result">
/// the #GAsyncResult passed to your callback
/// </param>
/// <return>
/// a #SoupMessage or
///   %NULL if @result is not a valid @session async operation result.
/// </return>

	public static MentorLake.Soup.SoupMessageHandle GetAsyncResultMessage(this MentorLake.Soup.SoupSessionHandle session, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_async_result_message(session, result);
	}

/// <summary>
/// <para>
/// Gets the feature in @session of type @feature_type.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="feature_type">
/// the #GType of the feature to get
/// </param>
/// <return>
/// a #SoupSessionFeature, or %NULL. The
///   feature is owned by @session.
/// </return>

	public static MentorLake.Soup.SoupSessionFeatureHandle GetFeature(this MentorLake.Soup.SoupSessionHandle session, MentorLake.GObject.GType feature_type)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_feature(session, feature_type);
	}

/// <summary>
/// <para>
/// Gets the feature in @session of type @feature_type, provided
/// that it is not disabled for @msg.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="feature_type">
/// the #GType of the feature to get
/// </param>
/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// a #SoupSessionFeature. The feature is
///   owned by @session.
/// </return>

	public static MentorLake.Soup.SoupSessionFeatureHandle GetFeatureForMessage(this MentorLake.Soup.SoupSessionHandle session, MentorLake.GObject.GType feature_type, MentorLake.Soup.SoupMessageHandle msg)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_feature_for_message(session, feature_type, msg);
	}

/// <summary>
/// <para>
/// Get the timeout in seconds for idle connection lifetime currently used by
/// @session.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <return>
/// the timeout in seconds
/// </return>

	public static uint GetIdleTimeout(this MentorLake.Soup.SoupSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_idle_timeout(session);
	}

/// <summary>
/// <para>
/// Get the [class@Gio.InetSocketAddress] to use for the client side of
/// connections in @session.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <return>
/// a #GInetSocketAddress
/// </return>

	public static MentorLake.Gio.GInetSocketAddressHandle GetLocalAddress(this MentorLake.Soup.SoupSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_local_address(session);
	}

/// <summary>
/// <para>
/// Get the maximum number of connections that @session can open at once.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <return>
/// the maximum number of connections
/// </return>

	public static uint GetMaxConns(this MentorLake.Soup.SoupSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_max_conns(session);
	}

/// <summary>
/// <para>
/// Get the maximum number of connections that @session can open at once to a
/// given host.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <return>
/// the maximum number of connections per host
/// </return>

	public static uint GetMaxConnsPerHost(this MentorLake.Soup.SoupSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_max_conns_per_host(session);
	}

/// <summary>
/// <para>
/// Get the [iface@Gio.ProxyResolver] currently used by @session.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <return>
/// a #GProxyResolver or %NULL if proxies
///   are disabled in @session
/// </return>

	public static MentorLake.Gio.GProxyResolverHandle GetProxyResolver(this MentorLake.Soup.SoupSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_proxy_resolver(session);
	}

/// <summary>
/// <para>
/// Gets the remote connectable if one set.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <return>
/// the #GSocketConnectable
/// </return>

	public static MentorLake.Gio.GSocketConnectableHandle GetRemoteConnectable(this MentorLake.Soup.SoupSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_remote_connectable(session);
	}

/// <summary>
/// <para>
/// Get the timeout in seconds for socket I/O operations currently used by
/// @session.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <return>
/// the timeout in seconds
/// </return>

	public static uint GetTimeout(this MentorLake.Soup.SoupSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_timeout(session);
	}

/// <summary>
/// <para>
/// Get the [class@Gio.TlsDatabase] currently used by @session.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <return>
/// a #GTlsDatabase
/// </return>

	public static MentorLake.Gio.GTlsDatabaseHandle GetTlsDatabase(this MentorLake.Soup.SoupSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_tls_database(session);
	}

/// <summary>
/// <para>
/// Get the [class@Gio.TlsInteraction] currently used by @session.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <return>
/// a #GTlsInteraction
/// </return>

	public static MentorLake.Gio.GTlsInteractionHandle GetTlsInteraction(this MentorLake.Soup.SoupSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_tls_interaction(session);
	}

/// <summary>
/// <para>
/// Get the value used by @session for the &quot;User-Agent&quot; header on new requests.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <return>
/// the user agent string
/// </return>

	public static string GetUserAgent(this MentorLake.Soup.SoupSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_get_user_agent(session);
	}

/// <summary>
/// <para>
/// Tests if @session has at a feature of type @feature_type (which can
/// be the type of either a [iface@SessionFeature], or else a subtype of
/// some class managed by another feature, such as [class@Auth]).
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="feature_type">
/// the #GType of the class of features to check for
/// </param>
/// <return>
/// %TRUE or %FALSE
/// </return>

	public static bool HasFeature(this MentorLake.Soup.SoupSessionHandle session, MentorLake.GObject.GType feature_type)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		return SoupSessionHandleExterns.soup_session_has_feature(session, feature_type);
	}

/// <summary>
/// <para>
/// Start a preconnection to @msg.
/// </para>
/// <para>
/// Once the connection is done, it will remain in idle state so that it can be
/// reused by future requests. If there&apos;s already an idle connection for the
/// given @msg host, the operation finishes successfully without creating a new
/// connection. If a new request for the given @msg host is made while the
/// preconnect is still ongoing, the request will take the ownership of the
/// connection and the preconnect operation will finish successfully (if there&apos;s
/// a connection error it will be handled by the request).
/// </para>
/// <para>
/// The operation finishes when the connection is done or an error occurred.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="io_priority">
/// the I/O priority of the request
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <param name="callback">
/// the callback to invoke when the operation finishes
/// </param>
/// <param name="user_data">
/// data for @progress_callback and @callback
/// </param>

	public static T PreconnectAsync<T>(this T session, MentorLake.Soup.SoupMessageHandle msg, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_preconnect_async(session, msg, io_priority, cancellable, callback, user_data);
		return session;
	}

/// <summary>
/// <para>
/// Complete a preconnect async operation started with [method@Session.preconnect_async].
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="result">
/// the #GAsyncResult passed to your callback
/// </param>
/// <return>
/// %TRUE if the preconnect succeeded, or %FALSE in case of error.
/// </return>

	public static bool PreconnectFinish(this MentorLake.Soup.SoupSessionHandle session, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		var externCallResult = SoupSessionHandleExterns.soup_session_preconnect_finish(session, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes @feature&apos;s functionality from @session.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="feature">
/// a feature that has previously been added to @session
/// </param>

	public static T RemoveFeature<T>(this T session, MentorLake.Soup.SoupSessionFeatureHandle feature) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_remove_feature(session, feature);
		return session;
	}

/// <summary>
/// <para>
/// Removes all features of type @feature_type (or any subclass of
/// @feature_type) from @session.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="feature_type">
/// a #GType
/// </param>

	public static T RemoveFeatureByType<T>(this T session, MentorLake.GObject.GType feature_type) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_remove_feature_by_type(session, feature_type);
		return session;
	}

/// <summary>
/// <para>
/// Synchronously sends @msg and waits for the beginning of a response.
/// </para>
/// <para>
/// On success, a [class@Gio.InputStream] will be returned which you can use to
/// read the response body. (&quot;Success&quot; here means only that an HTTP
/// response was received and understood; it does not necessarily mean
/// that a 2xx class status code was received.)
/// </para>
/// <para>
/// If non-%NULL, @cancellable can be used to cancel the request;
/// [method@Session.send] will return a %G_IO_ERROR_CANCELLED error. Note that
/// with requests that have side effects (eg, `POST`, `PUT`, `DELETE`) it is
/// possible that you might cancel the request after the server acts on it, but
/// before it returns a response, leaving the remote resource in an unknown
/// state.
/// </para>
/// <para>
/// If @msg is requeued due to a redirect or authentication, the
/// initial (`3xx/401/407`) response body will be suppressed, and
/// [method@Session.send] will only return once a final response has been
/// received.
/// </para>
/// <para>
/// Possible error domains include [error@SessionError], [error@Gio.IOErrorEnum],
/// and [error@Gio.TlsError] which you may want to specifically handle.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <return>
/// a #GInputStream for reading the
///   response body, or %NULL on error.
/// </return>

	public static MentorLake.Gio.GInputStreamHandle Send(this MentorLake.Soup.SoupSessionHandle session, MentorLake.Soup.SoupMessageHandle msg, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		var externCallResult = SoupSessionHandleExterns.soup_session_send(session, msg, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously sends @msg and reads the response body.
/// </para>
/// <para>
/// On success, a [struct@GLib.Bytes] will be returned with the response body.
/// This function should only be used when the resource to be retrieved
/// is not too long and can be stored in memory.
/// </para>
/// <para>
/// See [method@Session.send] for more details on the general semantics.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <return>
/// a #GBytes, or %NULL on error.
/// </return>

	public static MentorLake.GLib.GBytesHandle SendAndRead(this MentorLake.Soup.SoupSessionHandle session, MentorLake.Soup.SoupMessageHandle msg, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		var externCallResult = SoupSessionHandleExterns.soup_session_send_and_read(session, msg, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously sends @msg and reads the response body.
/// </para>
/// <para>
/// When @callback is called, then either @msg has been sent, and its response
/// body read, or else an error has occurred. This function should only be used
/// when the resource to be retrieved is not too long and can be stored in
/// memory. Call [method@Session.send_and_read_finish] to get a
/// [struct@GLib.Bytes] with the response body.
/// </para>
/// <para>
/// See [method@Session.send] for more details on the general semantics.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="io_priority">
/// the I/O priority of the request
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <param name="callback">
/// the callback to invoke
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>

	public static T SendAndReadAsync<T>(this T session, MentorLake.Soup.SoupMessageHandle msg, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_send_and_read_async(session, msg, io_priority, cancellable, callback, user_data);
		return session;
	}

/// <summary>
/// <para>
/// Gets the response to a [method@Session.send_and_read_async].
/// </para>
/// <para>
/// If successful, returns a [struct@GLib.Bytes] with the response body.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="result">
/// the #GAsyncResult passed to your callback
/// </param>
/// <return>
/// a #GBytes, or %NULL on error.
/// </return>

	public static MentorLake.GLib.GBytesHandle SendAndReadFinish(this MentorLake.Soup.SoupSessionHandle session, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		var externCallResult = SoupSessionHandleExterns.soup_session_send_and_read_finish(session, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously sends @msg and splices the response body stream into @out_stream.
/// </para>
/// <para>
/// See [method@Session.send] for more details on the general semantics.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="out_stream">
/// a #GOutputStream
/// </param>
/// <param name="flags">
/// a set of #GOutputStreamSpliceFlags
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <return>
/// a #gssize containing the size of the data spliced, or -1 if an error occurred.
/// </return>

	public static UIntPtr SendAndSplice(this MentorLake.Soup.SoupSessionHandle session, MentorLake.Soup.SoupMessageHandle msg, MentorLake.Gio.GOutputStreamHandle out_stream, MentorLake.Gio.GOutputStreamSpliceFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		var externCallResult = SoupSessionHandleExterns.soup_session_send_and_splice(session, msg, out_stream, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously sends @msg and splices the response body stream into @out_stream.
/// When @callback is called, then either @msg has been sent and its response body
/// spliced, or else an error has occurred.
/// </para>
/// <para>
/// See [method@Session.send] for more details on the general semantics.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="out_stream">
/// a #GOutputStream
/// </param>
/// <param name="flags">
/// a set of #GOutputStreamSpliceFlags
/// </param>
/// <param name="io_priority">
/// the I/O priority of the request
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <param name="callback">
/// the callback to invoke
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>

	public static T SendAndSpliceAsync<T>(this T session, MentorLake.Soup.SoupMessageHandle msg, MentorLake.Gio.GOutputStreamHandle out_stream, MentorLake.Gio.GOutputStreamSpliceFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_send_and_splice_async(session, msg, out_stream, flags, io_priority, cancellable, callback, user_data);
		return session;
	}

/// <summary>
/// <para>
/// Gets the response to a [method@Session.send_and_splice_async].
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="result">
/// the #GAsyncResult passed to your callback
/// </param>
/// <return>
/// a #gssize containing the size of the data spliced, or -1 if an error occurred.
/// </return>

	public static UIntPtr SendAndSpliceFinish(this MentorLake.Soup.SoupSessionHandle session, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		var externCallResult = SoupSessionHandleExterns.soup_session_send_and_splice_finish(session, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously sends @msg and waits for the beginning of a response.
/// </para>
/// <para>
/// When @callback is called, then either @msg has been sent, and its response
/// headers received, or else an error has occurred. Call
/// [method@Session.send_finish] to get a [class@Gio.InputStream] for reading the
/// response body.
/// </para>
/// <para>
/// See [method@Session.send] for more details on the general semantics.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="io_priority">
/// the I/O priority of the request
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <param name="callback">
/// the callback to invoke
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>

	public static T SendAsync<T>(this T session, MentorLake.Soup.SoupMessageHandle msg, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_send_async(session, msg, io_priority, cancellable, callback, user_data);
		return session;
	}

/// <summary>
/// <para>
/// Gets the response to a [method@Session.send_async] call.
/// </para>
/// <para>
/// If successful returns a [class@Gio.InputStream] that can be used to read the
/// response body.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="result">
/// the #GAsyncResult passed to your callback
/// </param>
/// <return>
/// a #GInputStream for reading the
///   response body, or %NULL on error.
/// </return>

	public static MentorLake.Gio.GInputStreamHandle SendFinish(this MentorLake.Soup.SoupSessionHandle session, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		var externCallResult = SoupSessionHandleExterns.soup_session_send_finish(session, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Set the value to use for the &quot;Accept-Language&quot; header on [class@Message]s
/// sent from @session.
/// </para>
/// <para>
/// If @accept_language is %NULL then no &quot;Accept-Language&quot; will be included in
/// requests. See [property@Session:accept-language] for more information.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="accept_language">
/// the languages string
/// </param>

	public static T SetAcceptLanguage<T>(this T session, string accept_language) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_set_accept_language(session, accept_language);
		return session;
	}

/// <summary>
/// <para>
/// Set whether @session will automatically set the &quot;Accept-Language&quot; header on
/// requests using a value generated from system languages based on
/// [func@GLib.get_language_names].
/// </para>
/// <para>
/// See [property@Session:accept-language-auto] for more information.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="accept_language_auto">
/// the value to set
/// </param>

	public static T SetAcceptLanguageAuto<T>(this T session, bool accept_language_auto) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_set_accept_language_auto(session, accept_language_auto);
		return session;
	}

/// <summary>
/// <para>
/// Set a timeout in seconds for idle connection lifetime to be used by @session
/// on new connections.
/// </para>
/// <para>
/// See [property@Session:idle-timeout] for more information.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="timeout">
/// a timeout in seconds
/// </param>

	public static T SetIdleTimeout<T>(this T session, uint timeout) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_set_idle_timeout(session, timeout);
		return session;
	}

/// <summary>
/// <para>
/// Set a [iface@Gio.ProxyResolver] to be used by @session on new connections.
/// </para>
/// <para>
/// If @proxy_resolver is %NULL then no proxies will be used. See
/// [property@Session:proxy-resolver] for more information.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="proxy_resolver">
/// a #GProxyResolver or %NULL
/// </param>

	public static T SetProxyResolver<T>(this T session, MentorLake.Gio.GProxyResolverHandle proxy_resolver) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_set_proxy_resolver(session, proxy_resolver);
		return session;
	}

/// <summary>
/// <para>
/// Set a timeout in seconds for socket I/O operations to be used by @session
/// on new connections.
/// </para>
/// <para>
/// See [property@Session:timeout] for more information.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="timeout">
/// a timeout in seconds
/// </param>

	public static T SetTimeout<T>(this T session, uint timeout) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_set_timeout(session, timeout);
		return session;
	}

/// <summary>
/// <para>
/// Set a [class@Gio.TlsDatabase] to be used by @session on new connections.
/// </para>
/// <para>
/// If @tls_database is %NULL then certificate validation will always fail. See
/// [property@Session:tls-database] for more information.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="tls_database">
/// a #GTlsDatabase
/// </param>

	public static T SetTlsDatabase<T>(this T session, MentorLake.Gio.GTlsDatabaseHandle tls_database) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_set_tls_database(session, tls_database);
		return session;
	}

/// <summary>
/// <para>
/// Set a [class@Gio.TlsInteraction] to be used by @session on new connections.
/// </para>
/// <para>
/// If @tls_interaction is %NULL then client certificate validation will always
/// fail.
/// </para>
/// <para>
/// See [property@Session:tls-interaction] for more information.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="tls_interaction">
/// a #GTlsInteraction
/// </param>

	public static T SetTlsInteraction<T>(this T session, MentorLake.Gio.GTlsInteractionHandle tls_interaction) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_set_tls_interaction(session, tls_interaction);
		return session;
	}

/// <summary>
/// <para>
/// Set the value to use for the &quot;User-Agent&quot; header on [class@Message]s sent
/// from @session.
/// </para>
/// <para>
/// If @user_agent has trailing whitespace, @session will append its own product
/// token (eg, `libsoup/3.0.0`) to the end of the header for you. If @user_agent
/// is %NULL then no &quot;User-Agent&quot; will be included in requests. See
/// [property@Session:user-agent] for more information.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="user_agent">
/// the user agent string
/// </param>

	public static T SetUserAgent<T>(this T session, string user_agent) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_set_user_agent(session, user_agent);
		return session;
	}

/// <summary>
/// <para>
/// Asynchronously creates a [class@WebsocketConnection] to communicate with a
/// remote server.
/// </para>
/// <para>
/// All necessary WebSocket-related headers will be added to @msg, and
/// it will then be sent and asynchronously processed normally
/// (including handling of redirection and HTTP authentication).
/// </para>
/// <para>
/// If the server returns &quot;101 Switching Protocols&quot;, then @msg&apos;s status
/// code and response headers will be updated, and then the WebSocket
/// handshake will be completed. On success,
/// [method@Session.websocket_connect_finish] will return a new
/// [class@WebsocketConnection]. On failure it will return a #GError.
/// </para>
/// <para>
/// If the server returns a status other than &quot;101 Switching Protocols&quot;, then
/// @msg will contain the complete response headers and body from the server&apos;s
/// response, and [method@Session.websocket_connect_finish] will return
/// %SOUP_WEBSOCKET_ERROR_NOT_WEBSOCKET.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="msg">
/// #SoupMessage indicating the WebSocket server to connect to
/// </param>
/// <param name="origin">
/// origin of the connection
/// </param>
/// <param name="protocols">
/// a
///   %NULL-terminated array of protocols supported
/// </param>
/// <param name="io_priority">
/// the I/O priority of the request
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <param name="callback">
/// the callback to invoke
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>

	public static T WebsocketConnectAsync<T>(this T session, MentorLake.Soup.SoupMessageHandle msg, string origin, string[] protocols, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : SoupSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		SoupSessionHandleExterns.soup_session_websocket_connect_async(session, msg, origin, protocols, io_priority, cancellable, callback, user_data);
		return session;
	}

/// <summary>
/// <para>
/// Gets the [class@WebsocketConnection] response to a
/// [method@Session.websocket_connect_async] call.
/// </para>
/// <para>
/// If successful, returns a [class@WebsocketConnection] that can be used to
/// communicate with the server.
/// </para>
/// </summary>

/// <param name="session">
/// a #SoupSession
/// </param>
/// <param name="result">
/// the #GAsyncResult passed to your callback
/// </param>
/// <return>
/// a new #SoupWebsocketConnection, or
///   %NULL on error.
/// </return>

	public static MentorLake.Soup.SoupWebsocketConnectionHandle WebsocketConnectFinish(this MentorLake.Soup.SoupSessionHandle session, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (SoupSessionHandle)");
		var externCallResult = SoupSessionHandleExterns.soup_session_websocket_connect_finish(session, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class SoupSessionHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))]
	internal static extern MentorLake.Soup.SoupSessionHandle soup_session_new();

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))]
	internal static extern MentorLake.Soup.SoupSessionHandle soup_session_new_with_options(string optname1, IntPtr @__arglist);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_abort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_add_feature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionFeatureHandleImpl>))] MentorLake.Soup.SoupSessionFeatureHandle feature);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_add_feature_by_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, MentorLake.GObject.GType feature_type);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_session_get_accept_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_session_get_accept_language_auto([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHandle soup_session_get_async_result_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionFeatureHandleImpl>))]
	internal static extern MentorLake.Soup.SoupSessionFeatureHandle soup_session_get_feature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, MentorLake.GObject.GType feature_type);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionFeatureHandleImpl>))]
	internal static extern MentorLake.Soup.SoupSessionFeatureHandle soup_session_get_feature_for_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, MentorLake.GObject.GType feature_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_session_get_idle_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GInetSocketAddressHandle soup_session_get_local_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_session_get_max_conns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_session_get_max_conns_per_host([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyResolverHandleImpl>))]
	internal static extern MentorLake.Gio.GProxyResolverHandle soup_session_get_proxy_resolver([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))]
	internal static extern MentorLake.Gio.GSocketConnectableHandle soup_session_get_remote_connectable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_session_get_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))]
	internal static extern MentorLake.Gio.GTlsDatabaseHandle soup_session_get_tls_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))]
	internal static extern MentorLake.Gio.GTlsInteractionHandle soup_session_get_tls_interaction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_session_get_user_agent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_session_has_feature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, MentorLake.GObject.GType feature_type);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_preconnect_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_session_preconnect_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_remove_feature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionFeatureHandleImpl>))] MentorLake.Soup.SoupSessionFeatureHandle feature);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_remove_feature_by_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, MentorLake.GObject.GType feature_type);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle soup_session_send([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle soup_session_send_and_read([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_send_and_read_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle soup_session_send_and_read_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern UIntPtr soup_session_send_and_splice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle out_stream, MentorLake.Gio.GOutputStreamSpliceFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_send_and_splice_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle out_stream, MentorLake.Gio.GOutputStreamSpliceFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(SoupLibrary.Name)]
	internal static extern UIntPtr soup_session_send_and_splice_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_send_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle soup_session_send_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_set_accept_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, string accept_language);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_set_accept_language_auto([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, bool accept_language_auto);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_set_idle_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, uint timeout);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_set_proxy_resolver([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyResolverHandleImpl>))] MentorLake.Gio.GProxyResolverHandle proxy_resolver);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_set_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, uint timeout);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_set_tls_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle tls_database);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_set_tls_interaction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle tls_interaction);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_set_user_agent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, string user_agent);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_session_websocket_connect_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, string origin, string[] protocols, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))]
	internal static extern MentorLake.Soup.SoupWebsocketConnectionHandle soup_session_websocket_connect_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupSessionHandle>))] MentorLake.Soup.SoupSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
