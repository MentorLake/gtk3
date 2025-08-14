namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDBusAuthObserver` provides a mechanism for participating
/// in how a [class@Gio.DBusServer] (or a [class@Gio.DBusConnection])
/// authenticates remote peers.
/// </para>
/// <para>
/// Simply instantiate a `GDBusAuthObserver` and connect to the
/// signals you are interested in. Note that new signals may be added
/// in the future.
/// </para>
/// <para>
/// ## Controlling Authentication Mechanisms
/// </para>
/// <para>
/// By default, a `GDBusServer` or server-side `GDBusConnection` will allow
/// any authentication mechanism to be used. If you only want to allow D-Bus
/// connections with the `EXTERNAL` mechanism, which makes use of credentials
/// passing and is the recommended mechanism for modern Unix platforms such
/// as Linux and the BSD family, you would use a signal handler like this:
/// </para>
/// <para>
/// ```c
/// static gboolean
/// on_allow_mechanism (GDBusAuthObserver *observer,
///                     const gchar       *mechanism,
///                     gpointer           user_data)
/// {
///   if (g_strcmp0 (mechanism, "EXTERNAL") == 0)
///     {
///       return TRUE;
///     }
/// </para>
/// <para>
///   return FALSE;
/// }
/// ```
/// </para>
/// <para>
/// ## Controlling Authorization
/// </para>
/// <para>
/// By default, a `GDBusServer` or server-side `GDBusConnection` will accept
/// connections from any successfully authenticated user (but not from
/// anonymous connections using the `ANONYMOUS` mechanism). If you only
/// want to allow D-Bus connections from processes owned by the same uid
/// as the server, since GLib 2.68, you should use the
/// `G_DBUS_SERVER_FLAGS_AUTHENTICATION_REQUIRE_SAME_USER` flag. It’s equivalent
/// to the following signal handler:
/// </para>
/// <para>
/// ```c
/// static gboolean
/// on_authorize_authenticated_peer (GDBusAuthObserver *observer,
///                                  GIOStream         *stream,
///                                  GCredentials      *credentials,
///                                  gpointer           user_data)
/// {
///   gboolean authorized;
/// </para>
/// <para>
///   authorized = FALSE;
///   if (credentials != NULL)
///     {
///       GCredentials *own_credentials;
///       own_credentials = g_credentials_new ();
///       if (g_credentials_is_same_user (credentials, own_credentials, NULL))
///         authorized = TRUE;
///       g_object_unref (own_credentials);
///     }
/// </para>
/// <para>
///   return authorized;
/// }
/// ```
/// </para>
/// </summary>

public class GDBusAuthObserverHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GDBusAuthObserver object.
/// </para>
/// </summary>

/// <return>
/// A #GDBusAuthObserver. Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusAuthObserverHandle New()
	{
		return GDBusAuthObserverHandleExterns.g_dbus_auth_observer_new();
	}

}
public static class GDBusAuthObserverHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted to check if @mechanism is allowed to be used.
/// </para>
/// </summary>

	public static IObservable<GDBusAuthObserverHandleSignalStructs.AllowMechanismSignal> Signal_AllowMechanism(this GDBusAuthObserverHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusAuthObserverHandleSignalStructs.AllowMechanismSignal> obs) =>
		{
			GDBusAuthObserverHandleSignalDelegates.allow_mechanism handler = ( MentorLake.Gio.GDBusAuthObserverHandle self,  string mechanism,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusAuthObserverHandleSignalStructs.AllowMechanismSignal()
				{
					Self = self, Mechanism = mechanism, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "allow-mechanism", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted to check if a peer that is successfully authenticated
/// is authorized.
/// </para>
/// </summary>

	public static IObservable<GDBusAuthObserverHandleSignalStructs.AuthorizeAuthenticatedPeerSignal> Signal_AuthorizeAuthenticatedPeer(this GDBusAuthObserverHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusAuthObserverHandleSignalStructs.AuthorizeAuthenticatedPeerSignal> obs) =>
		{
			GDBusAuthObserverHandleSignalDelegates.authorize_authenticated_peer handler = ( MentorLake.Gio.GDBusAuthObserverHandle self,  MentorLake.Gio.GIOStreamHandle stream,  MentorLake.Gio.GCredentialsHandle credentials,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusAuthObserverHandleSignalStructs.AuthorizeAuthenticatedPeerSignal()
				{
					Self = self, Stream = stream, Credentials = credentials, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "authorize-authenticated-peer", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusAuthObserverHandleSignalStructs
{

public class AllowMechanismSignal
{

	public MentorLake.Gio.GDBusAuthObserverHandle Self;
/// <summary>
/// <para>
/// The name of the mechanism, e.g. `DBUS_COOKIE_SHA1`.
/// </para>
/// </summary>

	public string Mechanism;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if @mechanism can be used to authenticate the other peer, %FALSE if not.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class AuthorizeAuthenticatedPeerSignal
{

	public MentorLake.Gio.GDBusAuthObserverHandle Self;
/// <summary>
/// <para>
/// A #GIOStream for the #GDBusConnection.
/// </para>
/// </summary>

	public MentorLake.Gio.GIOStreamHandle Stream;
/// <summary>
/// <para>
/// Credentials received from the peer or %NULL.
/// </para>
/// </summary>

	public MentorLake.Gio.GCredentialsHandle Credentials;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the peer is authorized, %FALSE if not.
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GDBusAuthObserverHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted to check if @mechanism is allowed to be used.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="mechanism">
/// The name of the mechanism, e.g. `DBUS_COOKIE_SHA1`.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if @mechanism can be used to authenticate the other peer, %FALSE if not.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool allow_mechanism([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle self, string mechanism, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted to check if a peer that is successfully authenticated
/// is authorized.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="stream">
/// A #GIOStream for the #GDBusConnection.
/// </param>
/// <param name="credentials">
/// Credentials received from the peer or %NULL.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the peer is authorized, %FALSE if not.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool authorize_authenticated_peer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials, IntPtr user_data);

}


public static class GDBusAuthObserverHandleExtensions
{
/// <summary>
/// <para>
/// Emits the #GDBusAuthObserver::allow-mechanism signal on @observer.
/// </para>
/// </summary>

/// <param name="observer">
/// A #GDBusAuthObserver.
/// </param>
/// <param name="mechanism">
/// The name of the mechanism, e.g. `DBUS_COOKIE_SHA1`.
/// </param>
/// <return>
/// %TRUE if @mechanism can be used to authenticate the other peer, %FALSE if not.
/// </return>

	public static bool AllowMechanism(this MentorLake.Gio.GDBusAuthObserverHandle observer, string mechanism)
	{
		if (observer.IsInvalid) throw new Exception("Invalid handle (GDBusAuthObserverHandle)");
		return GDBusAuthObserverHandleExterns.g_dbus_auth_observer_allow_mechanism(observer, mechanism);
	}

/// <summary>
/// <para>
/// Emits the #GDBusAuthObserver::authorize-authenticated-peer signal on @observer.
/// </para>
/// </summary>

/// <param name="observer">
/// A #GDBusAuthObserver.
/// </param>
/// <param name="stream">
/// A #GIOStream for the #GDBusConnection.
/// </param>
/// <param name="credentials">
/// Credentials received from the peer or %NULL.
/// </param>
/// <return>
/// %TRUE if the peer is authorized, %FALSE if not.
/// </return>

	public static bool AuthorizeAuthenticatedPeer(this MentorLake.Gio.GDBusAuthObserverHandle observer, MentorLake.Gio.GIOStreamHandle stream, MentorLake.Gio.GCredentialsHandle credentials)
	{
		if (observer.IsInvalid) throw new Exception("Invalid handle (GDBusAuthObserverHandle)");
		return GDBusAuthObserverHandleExterns.g_dbus_auth_observer_authorize_authenticated_peer(observer, stream, credentials);
	}

}

internal class GDBusAuthObserverHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))]
	internal static extern MentorLake.Gio.GDBusAuthObserverHandle g_dbus_auth_observer_new();

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_auth_observer_allow_mechanism([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, string mechanism);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_auth_observer_authorize_authenticated_peer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials);

}
