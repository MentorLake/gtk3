namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDBusProxy` is a base class used for proxies to access a D-Bus
/// interface on a remote object. A `GDBusProxy` can be constructed for
/// both well-known and unique names.
/// </para>
/// <para>
/// By default, `GDBusProxy` will cache all properties (and listen to
/// changes) of the remote object, and proxy all signals that get
/// emitted. This behaviour can be changed by passing suitable
/// [flags@Gio.DBusProxyFlags] when the proxy is created. If the proxy is for a
/// well-known name, the property cache is flushed when the name owner
/// vanishes and reloaded when a name owner appears.
/// </para>
/// <para>
/// The unique name owner of the proxy’s name is tracked and can be read from
/// [property@Gio.DBusProxy:g-name-owner]. Connect to the
/// [signal@GObject.Object::notify] signal to get notified of changes.
/// Additionally, only signals and property changes emitted from the current name
/// owner are considered and calls are always sent to the current name owner.
/// This avoids a number of race conditions when the name is lost by one owner
/// and claimed by another. However, if no name owner currently exists,
/// then calls will be sent to the well-known name which may result in
/// the message bus launching an owner (unless
/// `G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START` is set).
/// </para>
/// <para>
/// If the proxy is for a stateless D-Bus service, where the name owner may
/// be started and stopped between calls, the
/// [property@Gio.DBusProxy:g-name-owner] tracking of `GDBusProxy` will cause the
/// proxy to drop signal and property changes from the service after it has
/// restarted for the first time. When interacting with a stateless D-Bus
/// service, do not use `GDBusProxy` — use direct D-Bus method calls and signal
/// connections.
/// </para>
/// <para>
/// The generic [signal@Gio.DBusProxy::g-properties-changed] and
/// [signal@Gio.DBusProxy::g-signal] signals are not very convenient to work
/// with. Therefore, the recommended way of working with proxies is to subclass
/// `GDBusProxy`, and have more natural properties and signals in your derived
/// class. This [example](migrating-gdbus.html#using-gdbus-codegen) shows how
/// this can easily be done using the &amp;lt;see href=&quot;gdbus-codegen.html&quot;&amp;gt;gdbus-codegen&amp;lt;/see&amp;gt; tool.
/// </para>
/// <para>
/// A `GDBusProxy` instance can be used from multiple threads but note
/// that all signals (e.g. [signal@Gio.DBusProxy::g-signal],
/// [signal@Gio.DBusProxy::g-properties-changed] and
/// [signal@GObject.Object::notify]) are emitted in the thread-default main
/// context (see [method@GLib.MainContext.push_thread_default]) of the thread
/// where the instance was constructed.
/// </para>
/// <para>
/// An example using a proxy for a well-known name can be found in
/// &amp;lt;see href=&quot;https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gdbus-example-watch-proxy.c&quot;&amp;gt;gdbus-example-watch-proxy.c&amp;lt;/see&amp;gt;.
/// </para>
/// </summary>

public class GDBusProxyHandle : GObjectHandle, GAsyncInitableHandle, GDBusInterfaceHandle, GInitableHandle
{
/// <summary>
/// <para>
/// Finishes creating a #GDBusProxy.
/// </para>
/// </summary>

/// <param name="res">
/// A #GAsyncResult obtained from the #GAsyncReadyCallback function passed to g_dbus_proxy_new().
/// </param>
/// <return>
/// A #GDBusProxy or %NULL if @error is set.
///    Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusProxyHandle NewFinish(MentorLake.Gio.GAsyncResultHandle res)
	{
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_new_finish(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finishes creating a #GDBusProxy.
/// </para>
/// </summary>

/// <param name="res">
/// A #GAsyncResult obtained from the #GAsyncReadyCallback function passed to g_dbus_proxy_new_for_bus().
/// </param>
/// <return>
/// A #GDBusProxy or %NULL if @error is set.
///    Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusProxyHandle NewForBusFinish(MentorLake.Gio.GAsyncResultHandle res)
	{
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_new_for_bus_finish(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Like g_dbus_proxy_new_sync() but takes a #GBusType instead of a #GDBusConnection.
/// </para>
/// <para>
/// #GDBusProxy is used in this [example][gdbus-wellknown-proxy].
/// </para>
/// </summary>

/// <param name="bus_type">
/// A #GBusType.
/// </param>
/// <param name="flags">
/// Flags used when constructing the proxy.
/// </param>
/// <param name="info">
/// A #GDBusInterfaceInfo specifying the minimal interface
///        that @proxy conforms to or %NULL.
/// </param>
/// <param name="name">
/// A bus name (well-known or unique).
/// </param>
/// <param name="object_path">
/// An object path.
/// </param>
/// <param name="interface_name">
/// A D-Bus interface name.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <return>
/// A #GDBusProxy or %NULL if error is set.
///    Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusProxyHandle NewForBusSync(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusProxyFlags flags, MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_new_for_bus_sync(bus_type, flags, info, name, object_path, interface_name, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a proxy for accessing @interface_name on the remote object
/// at @object_path owned by @name at @connection and synchronously
/// loads D-Bus properties unless the
/// %G_DBUS_PROXY_FLAGS_DO_NOT_LOAD_PROPERTIES flag is used.
/// </para>
/// <para>
/// If the %G_DBUS_PROXY_FLAGS_DO_NOT_CONNECT_SIGNALS flag is not set, also sets up
/// match rules for signals. Connect to the #GDBusProxy::g-signal signal
/// to handle signals from the remote object.
/// </para>
/// <para>
/// If both %G_DBUS_PROXY_FLAGS_DO_NOT_LOAD_PROPERTIES and
/// %G_DBUS_PROXY_FLAGS_DO_NOT_CONNECT_SIGNALS are set, this constructor is
/// guaranteed to return immediately without blocking.
/// </para>
/// <para>
/// If @name is a well-known name and the
/// %G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START and %G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START_AT_CONSTRUCTION
/// flags aren&apos;t set and no name owner currently exists, the message bus
/// will be requested to launch a name owner for the name.
/// </para>
/// <para>
/// This is a synchronous failable constructor. See g_dbus_proxy_new()
/// and g_dbus_proxy_new_finish() for the asynchronous version.
/// </para>
/// <para>
/// #GDBusProxy is used in this [example][gdbus-wellknown-proxy].
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <param name="flags">
/// Flags used when constructing the proxy.
/// </param>
/// <param name="info">
/// A #GDBusInterfaceInfo specifying the minimal interface that @proxy conforms to or %NULL.
/// </param>
/// <param name="name">
/// A bus name (well-known or unique) or %NULL if @connection is not a message bus connection.
/// </param>
/// <param name="object_path">
/// An object path.
/// </param>
/// <param name="interface_name">
/// A D-Bus interface name.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <return>
/// A #GDBusProxy or %NULL if error is set.
///    Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusProxyHandle NewSync(MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusProxyFlags flags, MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_new_sync(connection, flags, info, name, object_path, interface_name, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a proxy for accessing @interface_name on the remote object
/// at @object_path owned by @name at @connection and asynchronously
/// loads D-Bus properties unless the
/// %G_DBUS_PROXY_FLAGS_DO_NOT_LOAD_PROPERTIES flag is used. Connect to
/// the #GDBusProxy::g-properties-changed signal to get notified about
/// property changes.
/// </para>
/// <para>
/// If the %G_DBUS_PROXY_FLAGS_DO_NOT_CONNECT_SIGNALS flag is not set, also sets up
/// match rules for signals. Connect to the #GDBusProxy::g-signal signal
/// to handle signals from the remote object.
/// </para>
/// <para>
/// If both %G_DBUS_PROXY_FLAGS_DO_NOT_LOAD_PROPERTIES and
/// %G_DBUS_PROXY_FLAGS_DO_NOT_CONNECT_SIGNALS are set, this constructor is
/// guaranteed to complete immediately without blocking.
/// </para>
/// <para>
/// If @name is a well-known name and the
/// %G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START and %G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START_AT_CONSTRUCTION
/// flags aren&apos;t set and no name owner currently exists, the message bus
/// will be requested to launch a name owner for the name.
/// </para>
/// <para>
/// This is a failable asynchronous constructor - when the proxy is
/// ready, @callback will be invoked and you can use
/// g_dbus_proxy_new_finish() to get the result.
/// </para>
/// <para>
/// See g_dbus_proxy_new_sync() and for a synchronous version of this constructor.
/// </para>
/// <para>
/// #GDBusProxy is used in this [example][gdbus-wellknown-proxy].
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <param name="flags">
/// Flags used when constructing the proxy.
/// </param>
/// <param name="info">
/// A #GDBusInterfaceInfo specifying the minimal interface that @proxy conforms to or %NULL.
/// </param>
/// <param name="name">
/// A bus name (well-known or unique) or %NULL if @connection is not a message bus connection.
/// </param>
/// <param name="object_path">
/// An object path.
/// </param>
/// <param name="interface_name">
/// A D-Bus interface name.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <param name="callback">
/// Callback function to invoke when the proxy is ready.
/// </param>
/// <param name="user_data">
/// User data to pass to @callback.
/// </param>

	public static void New(MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusProxyFlags flags, MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusProxyHandleExterns.g_dbus_proxy_new(connection, flags, info, name, object_path, interface_name, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Like g_dbus_proxy_new() but takes a #GBusType instead of a #GDBusConnection.
/// </para>
/// <para>
/// #GDBusProxy is used in this [example][gdbus-wellknown-proxy].
/// </para>
/// </summary>

/// <param name="bus_type">
/// A #GBusType.
/// </param>
/// <param name="flags">
/// Flags used when constructing the proxy.
/// </param>
/// <param name="info">
/// A #GDBusInterfaceInfo specifying the minimal interface that @proxy conforms to or %NULL.
/// </param>
/// <param name="name">
/// A bus name (well-known or unique).
/// </param>
/// <param name="object_path">
/// An object path.
/// </param>
/// <param name="interface_name">
/// A D-Bus interface name.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <param name="callback">
/// Callback function to invoke when the proxy is ready.
/// </param>
/// <param name="user_data">
/// User data to pass to @callback.
/// </param>

	public static void NewForBus(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusProxyFlags flags, MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusProxyHandleExterns.g_dbus_proxy_new_for_bus(bus_type, flags, info, name, object_path, interface_name, cancellable, callback, user_data);
	}

}
public static class GDBusProxyHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when one or more D-Bus properties on @proxy changes. The
/// local cache has already been updated when this signal fires. Note
/// that both @changed_properties and @invalidated_properties are
/// guaranteed to never be %NULL (either may be empty though).
/// </para>
/// <para>
/// If the proxy has the flag
/// %G_DBUS_PROXY_FLAGS_GET_INVALIDATED_PROPERTIES set, then
/// @invalidated_properties will always be empty.
/// </para>
/// <para>
/// This signal corresponds to the
/// `PropertiesChanged` D-Bus signal on the
/// `org.freedesktop.DBus.Properties` interface.
/// </para>
/// </summary>

	public static IObservable<GDBusProxyHandleSignalStructs.GPropertiesChangedSignal> Signal_GPropertiesChanged(this GDBusProxyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusProxyHandleSignalStructs.GPropertiesChangedSignal> obs) =>
		{
			GDBusProxyHandleSignalDelegates.g_properties_changed handler = ( MentorLake.Gio.GDBusProxyHandle self,  MentorLake.GLib.GVariantHandle changed_properties,  string[] invalidated_properties,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusProxyHandleSignalStructs.GPropertiesChangedSignal()
				{
					Self = self, ChangedProperties = changed_properties, InvalidatedProperties = invalidated_properties, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "g-properties-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a signal from the remote object and interface that @proxy is for, has been received.
/// </para>
/// <para>
/// Since 2.72 this signal supports detailed connections. You can connect to
/// the detailed signal `g-signal::x` in order to receive callbacks only when
/// signal `x` is received from the remote object.
/// </para>
/// </summary>

	public static IObservable<GDBusProxyHandleSignalStructs.GSignalSignal> Signal_GSignal(this GDBusProxyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusProxyHandleSignalStructs.GSignalSignal> obs) =>
		{
			GDBusProxyHandleSignalDelegates.g_signal handler = ( MentorLake.Gio.GDBusProxyHandle self,  string sender_name,  string signal_name,  MentorLake.GLib.GVariantHandle parameters,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusProxyHandleSignalStructs.GSignalSignal()
				{
					Self = self, SenderName = sender_name, SignalName = signal_name, Parameters = parameters, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "g-signal", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusProxyHandleSignalStructs
{

public class GPropertiesChangedSignal
{

	public MentorLake.Gio.GDBusProxyHandle Self;
/// <summary>
/// <para>
/// A #GVariant containing the properties that changed (type: `a{sv}`)
/// </para>
/// </summary>

	public MentorLake.GLib.GVariantHandle ChangedProperties;
/// <summary>
/// <para>
/// A %NULL terminated array of properties that was invalidated
/// </para>
/// </summary>

	public string[] InvalidatedProperties;

	public IntPtr UserData;
}

public class GSignalSignal
{

	public MentorLake.Gio.GDBusProxyHandle Self;
/// <summary>
/// <para>
/// The sender of the signal or %NULL if the connection is not a bus connection.
/// </para>
/// </summary>

	public string SenderName;
/// <summary>
/// <para>
/// The name of the signal.
/// </para>
/// </summary>

	public string SignalName;
/// <summary>
/// <para>
/// A #GVariant tuple with parameters for the signal.
/// </para>
/// </summary>

	public MentorLake.GLib.GVariantHandle Parameters;

	public IntPtr UserData;
}
}

public static class GDBusProxyHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when one or more D-Bus properties on @proxy changes. The
/// local cache has already been updated when this signal fires. Note
/// that both @changed_properties and @invalidated_properties are
/// guaranteed to never be %NULL (either may be empty though).
/// </para>
/// <para>
/// If the proxy has the flag
/// %G_DBUS_PROXY_FLAGS_GET_INVALIDATED_PROPERTIES set, then
/// @invalidated_properties will always be empty.
/// </para>
/// <para>
/// This signal corresponds to the
/// `PropertiesChanged` D-Bus signal on the
/// `org.freedesktop.DBus.Properties` interface.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="changed_properties">
/// A #GVariant containing the properties that changed (type: `a{sv}`)
/// </param>
/// <param name="invalidated_properties">
/// A %NULL terminated array of properties that was invalidated
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void g_properties_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle changed_properties, string[] invalidated_properties, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a signal from the remote object and interface that @proxy is for, has been received.
/// </para>
/// <para>
/// Since 2.72 this signal supports detailed connections. You can connect to
/// the detailed signal `g-signal::x` in order to receive callbacks only when
/// signal `x` is received from the remote object.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="sender_name">
/// The sender of the signal or %NULL if the connection is not a bus connection.
/// </param>
/// <param name="signal_name">
/// The name of the signal.
/// </param>
/// <param name="parameters">
/// A #GVariant tuple with parameters for the signal.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void g_signal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle self, string sender_name, string signal_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, IntPtr user_data);

}


public static class GDBusProxyHandleExtensions
{
/// <summary>
/// <para>
/// Asynchronously invokes the @method_name method on @proxy.
/// </para>
/// <para>
/// If @method_name contains any dots, then @name is split into interface and
/// method name parts. This allows using @proxy for invoking methods on
/// other interfaces.
/// </para>
/// <para>
/// If the #GDBusConnection associated with @proxy is closed then
/// the operation will fail with %G_IO_ERROR_CLOSED. If
/// @cancellable is canceled, the operation will fail with
/// %G_IO_ERROR_CANCELLED. If @parameters contains a value not
/// compatible with the D-Bus protocol, the operation fails with
/// %G_IO_ERROR_INVALID_ARGUMENT.
/// </para>
/// <para>
/// If the @parameters #GVariant is floating, it is consumed. This allows
/// convenient &apos;inline&apos; use of g_variant_new(), e.g.:
/// <code>
///  g_dbus_proxy_call (proxy,
///  g_dbus_proxy_call (proxy,
///                     &quot;TwoStrings&quot;,
///                     g_variant_new (&quot;(ss)&quot;,
///                                    &quot;Thing One&quot;,
///                                    &quot;Thing Two&quot;),
///                     G_DBUS_CALL_FLAGS_NONE,
///                     -1,
///                     NULL,
///                     (GAsyncReadyCallback) two_strings_done,
///                     &amp;data);
/// </code>
/// If @proxy has an expected interface (see
/// #GDBusProxy:g-interface-info) and @method_name is referenced by it,
/// then the return value is checked against the return type.
/// </para>
/// <para>
/// This is an asynchronous method. When the operation is finished,
/// @callback will be invoked in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread you are calling this method from.
/// You can then call g_dbus_proxy_call_finish() to get the result of
/// the operation. See g_dbus_proxy_call_sync() for the synchronous
/// version of this method.
/// </para>
/// <para>
/// If @callback is %NULL then the D-Bus method call message will be sent with
/// the %G_DBUS_MESSAGE_FLAGS_NO_REPLY_EXPECTED flag set.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <param name="method_name">
/// Name of method to invoke.
/// </param>
/// <param name="parameters">
/// A #GVariant tuple with parameters for the signal or %NULL if not passing parameters.
/// </param>
/// <param name="flags">
/// Flags from the #GDBusCallFlags enumeration.
/// </param>
/// <param name="timeout_msec">
/// The timeout in milliseconds (with %G_MAXINT meaning
///                &quot;infinite&quot;) or -1 to use the proxy default timeout.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <param name="callback">
/// A #GAsyncReadyCallback to call when the request is satisfied or %NULL if you don&apos;t
/// care about the result of the method invocation.
/// </param>
/// <param name="user_data">
/// The data to pass to @callback.
/// </param>

	public static T Call<T>(this T proxy, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusProxyHandle
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		GDBusProxyHandleExterns.g_dbus_proxy_call(proxy, method_name, parameters, flags, timeout_msec, cancellable, callback, user_data);
		return proxy;
	}

/// <summary>
/// <para>
/// Finishes an operation started with g_dbus_proxy_call().
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <param name="res">
/// A #GAsyncResult obtained from the #GAsyncReadyCallback passed to g_dbus_proxy_call().
/// </param>
/// <return>
/// %NULL if @error is set. Otherwise a #GVariant tuple with
/// return values. Free with g_variant_unref().
/// </return>

	public static MentorLake.GLib.GVariantHandle CallFinish(this MentorLake.Gio.GDBusProxyHandle proxy, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_call_finish(proxy, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously invokes the @method_name method on @proxy.
/// </para>
/// <para>
/// If @method_name contains any dots, then @name is split into interface and
/// method name parts. This allows using @proxy for invoking methods on
/// other interfaces.
/// </para>
/// <para>
/// If the #GDBusConnection associated with @proxy is disconnected then
/// the operation will fail with %G_IO_ERROR_CLOSED. If
/// @cancellable is canceled, the operation will fail with
/// %G_IO_ERROR_CANCELLED. If @parameters contains a value not
/// compatible with the D-Bus protocol, the operation fails with
/// %G_IO_ERROR_INVALID_ARGUMENT.
/// </para>
/// <para>
/// If the @parameters #GVariant is floating, it is consumed. This allows
/// convenient &apos;inline&apos; use of g_variant_new(), e.g.:
/// <code>
///  g_dbus_proxy_call_sync (proxy,
///  g_dbus_proxy_call_sync (proxy,
///                          &quot;TwoStrings&quot;,
///                          g_variant_new (&quot;(ss)&quot;,
///                                         &quot;Thing One&quot;,
///                                         &quot;Thing Two&quot;),
///                          G_DBUS_CALL_FLAGS_NONE,
///                          -1,
///                          NULL,
///                          &amp;error);
/// </code>
/// The calling thread is blocked until a reply is received. See
/// g_dbus_proxy_call() for the asynchronous version of this
/// method.
/// </para>
/// <para>
/// If @proxy has an expected interface (see
/// #GDBusProxy:g-interface-info) and @method_name is referenced by it,
/// then the return value is checked against the return type.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <param name="method_name">
/// Name of method to invoke.
/// </param>
/// <param name="parameters">
/// A #GVariant tuple with parameters for the signal
///              or %NULL if not passing parameters.
/// </param>
/// <param name="flags">
/// Flags from the #GDBusCallFlags enumeration.
/// </param>
/// <param name="timeout_msec">
/// The timeout in milliseconds (with %G_MAXINT meaning
///                &quot;infinite&quot;) or -1 to use the proxy default timeout.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <return>
/// %NULL if @error is set. Otherwise a #GVariant tuple with
/// return values. Free with g_variant_unref().
/// </return>

	public static MentorLake.GLib.GVariantHandle CallSync(this MentorLake.Gio.GDBusProxyHandle proxy, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_call_sync(proxy, method_name, parameters, flags, timeout_msec, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Like g_dbus_proxy_call() but also takes a #GUnixFDList object.
/// </para>
/// <para>
/// This method is only available on UNIX.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <param name="method_name">
/// Name of method to invoke.
/// </param>
/// <param name="parameters">
/// A #GVariant tuple with parameters for the signal or %NULL if not passing parameters.
/// </param>
/// <param name="flags">
/// Flags from the #GDBusCallFlags enumeration.
/// </param>
/// <param name="timeout_msec">
/// The timeout in milliseconds (with %G_MAXINT meaning
///                &quot;infinite&quot;) or -1 to use the proxy default timeout.
/// </param>
/// <param name="fd_list">
/// A #GUnixFDList or %NULL.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <param name="callback">
/// A #GAsyncReadyCallback to call when the request is satisfied or %NULL if you don&apos;t
/// care about the result of the method invocation.
/// </param>
/// <param name="user_data">
/// The data to pass to @callback.
/// </param>

	public static T CallWithUnixFdList<T>(this T proxy, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GUnixFDListHandle fd_list, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusProxyHandle
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		GDBusProxyHandleExterns.g_dbus_proxy_call_with_unix_fd_list(proxy, method_name, parameters, flags, timeout_msec, fd_list, cancellable, callback, user_data);
		return proxy;
	}

/// <summary>
/// <para>
/// Finishes an operation started with g_dbus_proxy_call_with_unix_fd_list().
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <param name="out_fd_list">
/// Return location for a #GUnixFDList or %NULL.
/// </param>
/// <param name="res">
/// A #GAsyncResult obtained from the #GAsyncReadyCallback passed to g_dbus_proxy_call_with_unix_fd_list().
/// </param>
/// <return>
/// %NULL if @error is set. Otherwise a #GVariant tuple with
/// return values. Free with g_variant_unref().
/// </return>

	public static MentorLake.GLib.GVariantHandle CallWithUnixFdListFinish(this MentorLake.Gio.GDBusProxyHandle proxy, out MentorLake.Gio.GUnixFDListHandle out_fd_list, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_call_with_unix_fd_list_finish(proxy, out out_fd_list, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Like g_dbus_proxy_call_sync() but also takes and returns #GUnixFDList objects.
/// </para>
/// <para>
/// This method is only available on UNIX.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <param name="method_name">
/// Name of method to invoke.
/// </param>
/// <param name="parameters">
/// A #GVariant tuple with parameters for the signal
///              or %NULL if not passing parameters.
/// </param>
/// <param name="flags">
/// Flags from the #GDBusCallFlags enumeration.
/// </param>
/// <param name="timeout_msec">
/// The timeout in milliseconds (with %G_MAXINT meaning
///                &quot;infinite&quot;) or -1 to use the proxy default timeout.
/// </param>
/// <param name="fd_list">
/// A #GUnixFDList or %NULL.
/// </param>
/// <param name="out_fd_list">
/// Return location for a #GUnixFDList or %NULL.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <return>
/// %NULL if @error is set. Otherwise a #GVariant tuple with
/// return values. Free with g_variant_unref().
/// </return>

	public static MentorLake.GLib.GVariantHandle CallWithUnixFdListSync(this MentorLake.Gio.GDBusProxyHandle proxy, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GUnixFDListHandle fd_list, out MentorLake.Gio.GUnixFDListHandle out_fd_list, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_call_with_unix_fd_list_sync(proxy, method_name, parameters, flags, timeout_msec, fd_list, out out_fd_list, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Looks up the value for a property from the cache. This call does no
/// blocking IO.
/// </para>
/// <para>
/// If @proxy has an expected interface (see
/// #GDBusProxy:g-interface-info) and @property_name is referenced by
/// it, then @value is checked against the type of the property.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <param name="property_name">
/// Property name.
/// </param>
/// <return>
/// A reference to the #GVariant instance
///    that holds the value for @property_name or %NULL if the value is not in
///    the cache. The returned reference must be freed with g_variant_unref().
/// </return>

	public static MentorLake.GLib.GVariantHandle GetCachedProperty(this MentorLake.Gio.GDBusProxyHandle proxy, string property_name)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_cached_property(proxy, property_name);
	}

/// <summary>
/// <para>
/// Gets the names of all cached properties on @proxy.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <return>
/// A
///          %NULL-terminated array of strings or %NULL if
///          @proxy has no cached properties. Free the returned array with
///          g_strfreev().
/// </return>

	public static string[] GetCachedPropertyNames(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_cached_property_names(proxy);
	}

/// <summary>
/// <para>
/// Gets the connection @proxy is for.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <return>
/// A #GDBusConnection owned by @proxy. Do not free.
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_connection(proxy);
	}

/// <summary>
/// <para>
/// Gets the timeout to use if -1 (specifying default timeout) is
/// passed as @timeout_msec in the g_dbus_proxy_call() and
/// g_dbus_proxy_call_sync() functions.
/// </para>
/// <para>
/// See the #GDBusProxy:g-default-timeout property for more details.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <return>
/// Timeout to use for @proxy.
/// </return>

	public static int GetDefaultTimeout(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_default_timeout(proxy);
	}

/// <summary>
/// <para>
/// Gets the flags that @proxy was constructed with.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <return>
/// Flags from the #GDBusProxyFlags enumeration.
/// </return>

	public static MentorLake.Gio.GDBusProxyFlags GetFlags(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_flags(proxy);
	}

/// <summary>
/// <para>
/// Returns the #GDBusInterfaceInfo, if any, specifying the interface
/// that @proxy conforms to. See the #GDBusProxy:g-interface-info
/// property for more details.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy
/// </param>
/// <return>
/// A #GDBusInterfaceInfo or %NULL.
///    Do not unref the returned object, it is owned by @proxy.
/// </return>

	public static MentorLake.Gio.GDBusInterfaceInfoHandle GetInterfaceInfo(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_interface_info(proxy);
	}

/// <summary>
/// <para>
/// Gets the D-Bus interface name @proxy is for.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <return>
/// A string owned by @proxy. Do not free.
/// </return>

	public static string GetInterfaceName(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_interface_name(proxy);
	}

/// <summary>
/// <para>
/// Gets the name that @proxy was constructed for.
/// </para>
/// <para>
/// When connected to a message bus, this will usually be non-%NULL.
/// However, it may be %NULL for a proxy that communicates using a peer-to-peer
/// pattern.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <return>
/// A string owned by @proxy. Do not free.
/// </return>

	public static string GetName(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_name(proxy);
	}

/// <summary>
/// <para>
/// The unique name that owns the name that @proxy is for or %NULL if
/// no-one currently owns that name. You may connect to the
/// #GObject::notify signal to track changes to the
/// #GDBusProxy:g-name-owner property.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <return>
/// The name owner or %NULL if no name
///    owner exists. Free with g_free().
/// </return>

	public static string GetNameOwner(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_name_owner(proxy);
	}

/// <summary>
/// <para>
/// Gets the object path @proxy is for.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <return>
/// A string owned by @proxy. Do not free.
/// </return>

	public static string GetObjectPath(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_object_path(proxy);
	}

/// <summary>
/// <para>
/// If @value is not %NULL, sets the cached value for the property with
/// name @property_name to the value in @value.
/// </para>
/// <para>
/// If @value is %NULL, then the cached value is removed from the
/// property cache.
/// </para>
/// <para>
/// If @proxy has an expected interface (see
/// #GDBusProxy:g-interface-info) and @property_name is referenced by
/// it, then @value is checked against the type of the property.
/// </para>
/// <para>
/// If the @value #GVariant is floating, it is consumed. This allows
/// convenient &apos;inline&apos; use of g_variant_new(), e.g.
/// <code>
///  g_dbus_proxy_set_cached_property (proxy,
///  g_dbus_proxy_set_cached_property (proxy,
///                                    &quot;SomeProperty&quot;,
///                                    g_variant_new (&quot;(si)&quot;,
///                                                  &quot;A String&quot;,
///                                                  42));
/// </code>
/// Normally you will not need to use this method since @proxy
/// is tracking changes using the
/// `org.freedesktop.DBus.Properties.PropertiesChanged`
/// D-Bus signal. However, for performance reasons an object may
/// decide to not use this signal for some properties and instead
/// use a proprietary out-of-band mechanism to transmit changes.
/// </para>
/// <para>
/// As a concrete example, consider an object with a property
/// `ChatroomParticipants` which is an array of strings. Instead of
/// transmitting the same (long) array every time the property changes,
/// it is more efficient to only transmit the delta using e.g. signals
/// `ChatroomParticipantJoined(String name)` and
/// `ChatroomParticipantParted(String name)`.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy
/// </param>
/// <param name="property_name">
/// Property name.
/// </param>
/// <param name="value">
/// Value for the property or %NULL to remove it from the cache.
/// </param>

	public static T SetCachedProperty<T>(this T proxy, string property_name, MentorLake.GLib.GVariantHandle value) where T : GDBusProxyHandle
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		GDBusProxyHandleExterns.g_dbus_proxy_set_cached_property(proxy, property_name, value);
		return proxy;
	}

/// <summary>
/// <para>
/// Sets the timeout to use if -1 (specifying default timeout) is
/// passed as @timeout_msec in the g_dbus_proxy_call() and
/// g_dbus_proxy_call_sync() functions.
/// </para>
/// <para>
/// See the #GDBusProxy:g-default-timeout property for more details.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy.
/// </param>
/// <param name="timeout_msec">
/// Timeout in milliseconds.
/// </param>

	public static T SetDefaultTimeout<T>(this T proxy, int timeout_msec) where T : GDBusProxyHandle
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		GDBusProxyHandleExterns.g_dbus_proxy_set_default_timeout(proxy, timeout_msec);
		return proxy;
	}

/// <summary>
/// <para>
/// Ensure that interactions with @proxy conform to the given
/// interface. See the #GDBusProxy:g-interface-info property for more
/// details.
/// </para>
/// </summary>

/// <param name="proxy">
/// A #GDBusProxy
/// </param>
/// <param name="info">
/// Minimum interface this proxy conforms to
///    or %NULL to unset.
/// </param>

	public static T SetInterfaceInfo<T>(this T proxy, MentorLake.Gio.GDBusInterfaceInfoHandle info) where T : GDBusProxyHandle
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusProxyHandle)");
		GDBusProxyHandleExterns.g_dbus_proxy_set_interface_info(proxy, info);
		return proxy;
	}

}

internal class GDBusProxyHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))]
	internal static extern MentorLake.Gio.GDBusProxyHandle g_dbus_proxy_new_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))]
	internal static extern MentorLake.Gio.GDBusProxyHandle g_dbus_proxy_new_for_bus_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))]
	internal static extern MentorLake.Gio.GDBusProxyHandle g_dbus_proxy_new_for_bus_sync(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusProxyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))]
	internal static extern MentorLake.Gio.GDBusProxyHandle g_dbus_proxy_new_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusProxyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_call([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_proxy_call_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_proxy_call_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_call_with_unix_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_proxy_call_with_unix_fd_list_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] out MentorLake.Gio.GUnixFDListHandle out_fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_proxy_call_with_unix_fd_list_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] out MentorLake.Gio.GUnixFDListHandle out_fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_proxy_get_cached_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, string property_name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_dbus_proxy_get_cached_property_names([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_proxy_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_dbus_proxy_get_default_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusProxyFlags g_dbus_proxy_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusInterfaceInfoHandle g_dbus_proxy_get_interface_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_proxy_get_interface_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_proxy_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_proxy_get_name_owner([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_proxy_get_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_set_cached_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, string property_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_set_default_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, int timeout_msec);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_set_interface_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusProxyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_new_for_bus(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusProxyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

}
