namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDebugControllerDBus` is an implementation of [iface@Gio.DebugController]
/// which exposes debug settings as a D-Bus object.
/// </para>
/// <para>
/// It is a [iface@Gio.Initable] object, and will register an object at
/// `/org/gtk/Debugging` on the bus given as
/// [property@Gio.DebugControllerDBus:connection] once it’s initialized. The
/// object will be unregistered when the last reference to the
/// `GDebugControllerDBus` is dropped.
/// </para>
/// <para>
/// This D-Bus object can be used by remote processes to enable or disable debug
/// output in this process. Remote processes calling
/// `org.gtk.Debugging.SetDebugEnabled()` will affect the value of
/// [property@Gio.DebugController:debug-enabled] and, by default,
/// [func@GLib.log_get_debug_enabled].
/// </para>
/// <para>
/// By default, no processes are allowed to call `SetDebugEnabled()` unless a
/// [signal@Gio.DebugControllerDBus::authorize] signal handler is installed. This
/// is because the process may be privileged, or might expose sensitive
/// information in its debug output. You may want to restrict the ability to
/// enable debug output to privileged users or processes.
/// </para>
/// <para>
/// One option is to install a D-Bus security policy which restricts access to
/// `SetDebugEnabled()`, installing something like the following in
/// `$datadir/dbus-1/system.d/`:
/// </para>
/// <para>
/// ```xml
/// <?xml version="1.0"?> <!--*-nxml-*-->
/// <!DOCTYPE busconfig PUBLIC "-//freedesktop//DTD D-BUS Bus Configuration 1.0//EN"
///      "http://www.freedesktop.org/standards/dbus/1.0/busconfig.dtd">
/// <busconfig>
///   <policy user="root">
///     <allow send_destination="com.example.MyService" send_interface="org.gtk.Debugging"/>
///   </policy>
///   <policy context="default">
///     <deny send_destination="com.example.MyService" send_interface="org.gtk.Debugging"/>
///   </policy>
/// </busconfig>
/// ```
/// </para>
/// <para>
/// This will prevent the `SetDebugEnabled()` method from being called by all
/// except root. It will not prevent the `DebugEnabled` property from being read,
/// as it’s accessed through the `org.freedesktop.DBus.Properties` interface.
/// </para>
/// <para>
/// Another option is to use polkit to allow or deny requests on a case-by-case
/// basis, allowing for the possibility of dynamic authorisation. To do this,
/// connect to the [signal@Gio.DebugControllerDBus::authorize] signal and query
/// polkit in it:
/// </para>
/// <para>
/// ```c
///   g_autoptr(GError) child_error = NULL;
///   g_autoptr(GDBusConnection) connection = g_bus_get_sync (G_BUS_TYPE_SYSTEM, NULL, NULL);
///   gulong debug_controller_authorize_id = 0;
/// </para>
/// <para>
///   // Set up the debug controller.
///   debug_controller = G_DEBUG_CONTROLLER (g_debug_controller_dbus_new (priv->connection, NULL, &child_error));
///   if (debug_controller == NULL)
///     {
///       g_error ("Could not register debug controller on bus: %s"),
///                child_error->message);
///     }
/// </para>
/// <para>
///   debug_controller_authorize_id = g_signal_connect (debug_controller,
///                                                     "authorize",
///                                                     G_CALLBACK (debug_controller_authorize_cb),
///                                                     self);
/// </para>
/// <para>
///   static gboolean
///   debug_controller_authorize_cb (GDebugControllerDBus  *debug_controller,
///                                  GDBusMethodInvocation *invocation,
///                                  gpointer               user_data)
///   {
///     g_autoptr(PolkitAuthority) authority = NULL;
///     g_autoptr(PolkitSubject) subject = NULL;
///     g_autoptr(PolkitAuthorizationResult) auth_result = NULL;
///     g_autoptr(GError) local_error = NULL;
///     GDBusMessage *message;
///     GDBusMessageFlags message_flags;
///     PolkitCheckAuthorizationFlags flags = POLKIT_CHECK_AUTHORIZATION_FLAGS_NONE;
/// </para>
/// <para>
///     message = g_dbus_method_invocation_get_message (invocation);
///     message_flags = g_dbus_message_get_flags (message);
/// </para>
/// <para>
///     authority = polkit_authority_get_sync (NULL, &local_error);
///     if (authority == NULL)
///       {
///         g_warning ("Failed to get polkit authority: %s", local_error->message);
///         return FALSE;
///       }
/// </para>
/// <para>
///     if (message_flags & G_DBUS_MESSAGE_FLAGS_ALLOW_INTERACTIVE_AUTHORIZATION)
///       flags |= POLKIT_CHECK_AUTHORIZATION_FLAGS_ALLOW_USER_INTERACTION;
/// </para>
/// <para>
///     subject = polkit_system_bus_name_new (g_dbus_method_invocation_get_sender (invocation));
/// </para>
/// <para>
///     auth_result = polkit_authority_check_authorization_sync (authority,
///                                                              subject,
///                                                              "com.example.MyService.set-debug-enabled",
///                                                              NULL,
///                                                              flags,
///                                                              NULL,
///                                                              &local_error);
///     if (auth_result == NULL)
///       {
///         g_warning ("Failed to get check polkit authorization: %s", local_error->message);
///         return FALSE;
///       }
/// </para>
/// <para>
///     return polkit_authorization_result_get_is_authorized (auth_result);
///   }
/// ```
/// </para>
/// </summary>

public class GDebugControllerDBusHandle : GObjectHandle, GDebugControllerHandle, GInitableHandle
{
/// <summary>
/// <para>
/// Create a new #GDebugControllerDBus and synchronously initialize it.
/// </para>
/// <para>
/// Initializing the object will export the debug object on @connection. The
/// object will remain registered until the last reference to the
/// #GDebugControllerDBus is dropped.
/// </para>
/// <para>
/// Initialization may fail if registering the object on @connection fails.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection to register the debug object on
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a new #GDebugControllerDBus, or %NULL
///   on failure
/// </return>

	public static MentorLake.Gio.GDebugControllerDBusHandle New(MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDebugControllerDBusHandleExterns.g_debug_controller_dbus_new(connection, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}
public static class GDebugControllerDBusHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when a D-Bus peer is trying to change the debug settings and used
/// to determine if that is authorized.
/// </para>
/// <para>
/// This signal is emitted in a dedicated worker thread, so handlers are
/// allowed to perform blocking I/O. This means that, for example, it is
/// appropriate to call `polkit_authority_check_authorization_sync()` to check
/// authorization using polkit.
/// </para>
/// <para>
/// If %FALSE is returned then no further handlers are run and the request to
/// change the debug settings is rejected.
/// </para>
/// <para>
/// Otherwise, if %TRUE is returned, signal emission continues. If no handlers
/// return %FALSE, then the debug settings are allowed to be changed.
/// </para>
/// <para>
/// Signal handlers must not modify @invocation, or cause it to return a value.
/// </para>
/// <para>
/// The default class handler just returns %TRUE.
/// </para>
/// </summary>

	public static IObservable<GDebugControllerDBusHandleSignalStructs.AuthorizeSignal> Signal_Authorize(this GDebugControllerDBusHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDebugControllerDBusHandleSignalStructs.AuthorizeSignal> obs) =>
		{
			GDebugControllerDBusHandleSignalDelegates.authorize handler = ( MentorLake.Gio.GDebugControllerDBusHandle self,  MentorLake.Gio.GDBusMethodInvocationHandle invocation,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDebugControllerDBusHandleSignalStructs.AuthorizeSignal()
				{
					Self = self, Invocation = invocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "authorize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDebugControllerDBusHandleSignalStructs
{

public class AuthorizeSignal
{

	public MentorLake.Gio.GDebugControllerDBusHandle Self;
/// <summary>
/// <para>
/// A #GDBusMethodInvocation.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusMethodInvocationHandle Invocation;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the call is authorized, %FALSE otherwise.
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GDebugControllerDBusHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when a D-Bus peer is trying to change the debug settings and used
/// to determine if that is authorized.
/// </para>
/// <para>
/// This signal is emitted in a dedicated worker thread, so handlers are
/// allowed to perform blocking I/O. This means that, for example, it is
/// appropriate to call `polkit_authority_check_authorization_sync()` to check
/// authorization using polkit.
/// </para>
/// <para>
/// If %FALSE is returned then no further handlers are run and the request to
/// change the debug settings is rejected.
/// </para>
/// <para>
/// Otherwise, if %TRUE is returned, signal emission continues. If no handlers
/// return %FALSE, then the debug settings are allowed to be changed.
/// </para>
/// <para>
/// Signal handlers must not modify @invocation, or cause it to return a value.
/// </para>
/// <para>
/// The default class handler just returns %TRUE.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the call is authorized, %FALSE otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool authorize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDebugControllerDBusHandle>))] MentorLake.Gio.GDebugControllerDBusHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, IntPtr user_data);

}


public static class GDebugControllerDBusHandleExtensions
{
/// <summary>
/// <para>
/// Stop the debug controller, unregistering its object from the bus.
/// </para>
/// <para>
/// Any pending method calls to the object will complete successfully, but new
/// ones will return an error. This method will block until all pending
/// #GDebugControllerDBus::authorize signals have been handled. This is expected
/// to not take long, as it will just be waiting for threads to join. If any
/// #GDebugControllerDBus::authorize signal handlers are still executing in other
/// threads, this will block until after they have returned.
/// </para>
/// <para>
/// This method will be called automatically when the final reference to the
/// #GDebugControllerDBus is dropped. You may want to call it explicitly to know
/// when the controller has been fully removed from the bus, or to break
/// reference count cycles.
/// </para>
/// <para>
/// Calling this method from within a #GDebugControllerDBus::authorize signal
/// handler will cause a deadlock and must not be done.
/// </para>
/// </summary>

/// <param name="self">
/// a #GDebugControllerDBus
/// </param>

	public static T Stop<T>(this T self) where T : GDebugControllerDBusHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GDebugControllerDBusHandle)");
		GDebugControllerDBusHandleExterns.g_debug_controller_dbus_stop(self);
		return self;
	}

}

internal class GDebugControllerDBusHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDebugControllerDBusHandle>))]
	internal static extern MentorLake.Gio.GDebugControllerDBusHandle g_debug_controller_dbus_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_debug_controller_dbus_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDebugControllerDBusHandle>))] MentorLake.Gio.GDebugControllerDBusHandle self);

}
