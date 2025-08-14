namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDBusObjectManagerClient` is used to create, monitor and delete object
/// proxies for remote objects exported by a [class@Gio.DBusObjectManagerServer]
/// (or any code implementing the
/// [org.freedesktop.DBus.ObjectManager](http://dbus.freedesktop.org/doc/dbus-specification.html#standard-interfaces-objectmanager)
/// interface).
/// </para>
/// <para>
/// Once an instance of this type has been created, you can connect to
/// the [signal@Gio.DBusObjectManager::object-added] and
/// [signal@Gio.DBusObjectManager::object-removed signals] and inspect the
/// [class@Gio.DBusObjectProxy] objects returned by
/// [method@Gio.DBusObjectManager.get_objects].
/// </para>
/// <para>
/// If the name for a `GDBusObjectManagerClient` is not owned by anyone at
/// object construction time, the default behavior is to request the
/// message bus to launch an owner for the name. This behavior can be
/// disabled using the `G_DBUS_OBJECT_MANAGER_CLIENT_FLAGS_DO_NOT_AUTO_START`
/// flag. It’s also worth noting that this only works if the name of
/// interest is activatable in the first place. E.g. in some cases it
/// is not possible to launch an owner for the requested name. In this
/// case, `GDBusObjectManagerClient` object construction still succeeds but
/// there will be no object proxies
/// (e.g. [method@Gio.DBusObjectManager.get_objects] returns the empty list) and
/// the [property@Gio.DBusObjectManagerClient:name-owner] property is `NULL`.
/// </para>
/// <para>
/// The owner of the requested name can come and go (for example
/// consider a system service being restarted) – `GDBusObjectManagerClient`
/// handles this case too; simply connect to the [signal@GObject.Object::notify]
/// signal to watch for changes on the
/// [property@Gio.DBusObjectManagerClient:name-owner] property. When the name
/// owner vanishes, the behavior is that
/// [property@Gio.DBusObjectManagerClient:name-owner] is set to `NULL` (this
/// includes emission of the [signal@GObject.Object::notify] signal) and then
/// [signal@Gio.DBusObjectManager::object-removed] signals are synthesized
/// for all currently existing object proxies. Since
/// [property@Gio.DBusObjectManagerClient:name-owner] is `NULL` when this
/// happens, you can use this information to disambiguate a synthesized signal
/// from a genuine signal caused by object removal on the remote
/// [iface@Gio.DBusObjectManager]. Similarly, when a new name owner appears,
/// [signal@Gio.DBusObjectManager::object-added] signals are synthesized
/// while [property@Gio.DBusObjectManagerClient:name-owner] is still `NULL`. Only
/// when all object proxies have been added, the
/// [property@Gio.DBusObjectManagerClient:name-owner] is set to the new name
/// owner (this includes emission of the [signal@GObject.Object::notify] signal).
/// Furthermore, you are guaranteed that
/// [property@Gio.DBusObjectManagerClient:name-owner] will alternate between a
/// name owner (e.g. `:1.42`) and `NULL` even in the case where
/// the name of interest is atomically replaced
/// </para>
/// <para>
/// Ultimately, `GDBusObjectManagerClient` is used to obtain
/// [class@Gio.DBusProxy] instances. All signals (including the
/// `org.freedesktop.DBus.Properties::PropertiesChanged` signal)
/// delivered to [class@Gio.DBusProxy] instances are guaranteed to originate
/// from the name owner. This guarantee along with the behavior
/// described above, means that certain race conditions including the
/// “half the proxy is from the old owner and the other half is from
/// the new owner” problem cannot happen.
/// </para>
/// <para>
/// To avoid having the application connect to signals on the returned
/// [class@Gio.DBusObjectProxy] and [class@Gio.DBusProxy] objects, the
/// [signal@Gio.DBusObject::interface-added],
/// [signal@Gio.DBusObject::interface-removed],
/// [signal@Gio.DBusProxy::g-properties-changed] and
/// [signal@Gio.DBusProxy::g-signal] signals
/// are also emitted on the `GDBusObjectManagerClient` instance managing these
/// objects. The signals emitted are
/// [signal@Gio.DBusObjectManager::interface-added],
/// [signal@Gio.DBusObjectManager::interface-removed],
/// [signal@Gio.DBusObjectManagerClient::interface-proxy-properties-changed] and
/// [signal@Gio.DBusObjectManagerClient::interface-proxy-signal].
/// </para>
/// <para>
/// Note that all callbacks and signals are emitted in the
/// thread-default main context (see
/// [method@GLib.MainContext.push_thread_default]) that the
/// `GDBusObjectManagerClient` object was constructed in. Additionally, the
/// [class@Gio.DBusObjectProxy] and [class@Gio.DBusProxy] objects
/// originating from the `GDBusObjectManagerClient` object will be created in
/// the same context and, consequently, will deliver signals in the
/// same main loop.
/// </para>
/// </summary>

public class GDBusObjectManagerClientHandle : GObjectHandle, GAsyncInitableHandle, GDBusObjectManagerHandle, GInitableHandle
{
/// <summary>
/// <para>
/// Finishes an operation started with g_dbus_object_manager_client_new().
/// </para>
/// </summary>

/// <param name="res">
/// A #GAsyncResult obtained from the #GAsyncReadyCallback passed to g_dbus_object_manager_client_new().
/// </param>
/// <return>
/// A
///   #GDBusObjectManagerClient object or %NULL if @error is set. Free
///   with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusObjectManagerClientHandle NewFinish(MentorLake.Gio.GAsyncResultHandle res)
	{
		var externCallResult = GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_new_finish(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finishes an operation started with g_dbus_object_manager_client_new_for_bus().
/// </para>
/// </summary>

/// <param name="res">
/// A #GAsyncResult obtained from the #GAsyncReadyCallback passed to g_dbus_object_manager_client_new_for_bus().
/// </param>
/// <return>
/// A
///   #GDBusObjectManagerClient object or %NULL if @error is set. Free
///   with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusObjectManagerClientHandle NewForBusFinish(MentorLake.Gio.GAsyncResultHandle res)
	{
		var externCallResult = GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_new_for_bus_finish(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Like g_dbus_object_manager_client_new_sync() but takes a #GBusType instead
/// of a #GDBusConnection.
/// </para>
/// <para>
/// This is a synchronous failable constructor - the calling thread is
/// blocked until a reply is received. See g_dbus_object_manager_client_new_for_bus()
/// for the asynchronous version.
/// </para>
/// </summary>

/// <param name="bus_type">
/// A #GBusType.
/// </param>
/// <param name="flags">
/// Zero or more flags from the #GDBusObjectManagerClientFlags enumeration.
/// </param>
/// <param name="name">
/// The owner of the control object (unique or well-known name).
/// </param>
/// <param name="object_path">
/// The object path of the control object.
/// </param>
/// <param name="get_proxy_type_func">
/// A #GDBusProxyTypeFunc function or %NULL to always construct #GDBusProxy proxies.
/// </param>
/// <param name="get_proxy_type_user_data">
/// User data to pass to @get_proxy_type_func.
/// </param>
/// <param name="get_proxy_type_destroy_notify">
/// Free function for @get_proxy_type_user_data or %NULL.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL
/// </param>
/// <return>
/// A
///   #GDBusObjectManagerClient object or %NULL if @error is set. Free
///   with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusObjectManagerClientHandle NewForBusSync(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_new_for_bus_sync(bus_type, flags, name, object_path, get_proxy_type_func, get_proxy_type_user_data, get_proxy_type_destroy_notify, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new #GDBusObjectManagerClient object.
/// </para>
/// <para>
/// This is a synchronous failable constructor - the calling thread is
/// blocked until a reply is received. See g_dbus_object_manager_client_new()
/// for the asynchronous version.
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <param name="flags">
/// Zero or more flags from the #GDBusObjectManagerClientFlags enumeration.
/// </param>
/// <param name="name">
/// The owner of the control object (unique or well-known name), or %NULL when not using a message bus connection.
/// </param>
/// <param name="object_path">
/// The object path of the control object.
/// </param>
/// <param name="get_proxy_type_func">
/// A #GDBusProxyTypeFunc function or %NULL to always construct #GDBusProxy proxies.
/// </param>
/// <param name="get_proxy_type_user_data">
/// User data to pass to @get_proxy_type_func.
/// </param>
/// <param name="get_proxy_type_destroy_notify">
/// Free function for @get_proxy_type_user_data or %NULL.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL
/// </param>
/// <return>
/// A
///   #GDBusObjectManagerClient object or %NULL if @error is set. Free
///   with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusObjectManagerClientHandle NewSync(MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_new_sync(connection, flags, name, object_path, get_proxy_type_func, get_proxy_type_user_data, get_proxy_type_destroy_notify, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously creates a new #GDBusObjectManagerClient object.
/// </para>
/// <para>
/// This is an asynchronous failable constructor. When the result is
/// ready, @callback will be invoked in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread you are calling this method from. You can
/// then call g_dbus_object_manager_client_new_finish() to get the result. See
/// g_dbus_object_manager_client_new_sync() for the synchronous version.
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <param name="flags">
/// Zero or more flags from the #GDBusObjectManagerClientFlags enumeration.
/// </param>
/// <param name="name">
/// The owner of the control object (unique or well-known name).
/// </param>
/// <param name="object_path">
/// The object path of the control object.
/// </param>
/// <param name="get_proxy_type_func">
/// A #GDBusProxyTypeFunc function or %NULL to always construct #GDBusProxy proxies.
/// </param>
/// <param name="get_proxy_type_user_data">
/// User data to pass to @get_proxy_type_func.
/// </param>
/// <param name="get_proxy_type_destroy_notify">
/// Free function for @get_proxy_type_user_data or %NULL.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL
/// </param>
/// <param name="callback">
/// A #GAsyncReadyCallback to call when the request is satisfied.
/// </param>
/// <param name="user_data">
/// The data to pass to @callback.
/// </param>

	public static void New(MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_new(connection, flags, name, object_path, get_proxy_type_func, get_proxy_type_user_data, get_proxy_type_destroy_notify, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Like g_dbus_object_manager_client_new() but takes a #GBusType instead of a
/// #GDBusConnection.
/// </para>
/// <para>
/// This is an asynchronous failable constructor. When the result is
/// ready, @callback will be invoked in the
/// [thread-default main loop][g-main-context-push-thread-default]
/// of the thread you are calling this method from. You can
/// then call g_dbus_object_manager_client_new_for_bus_finish() to get the result. See
/// g_dbus_object_manager_client_new_for_bus_sync() for the synchronous version.
/// </para>
/// </summary>

/// <param name="bus_type">
/// A #GBusType.
/// </param>
/// <param name="flags">
/// Zero or more flags from the #GDBusObjectManagerClientFlags enumeration.
/// </param>
/// <param name="name">
/// The owner of the control object (unique or well-known name).
/// </param>
/// <param name="object_path">
/// The object path of the control object.
/// </param>
/// <param name="get_proxy_type_func">
/// A #GDBusProxyTypeFunc function or %NULL to always construct #GDBusProxy proxies.
/// </param>
/// <param name="get_proxy_type_user_data">
/// User data to pass to @get_proxy_type_func.
/// </param>
/// <param name="get_proxy_type_destroy_notify">
/// Free function for @get_proxy_type_user_data or %NULL.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL
/// </param>
/// <param name="callback">
/// A #GAsyncReadyCallback to call when the request is satisfied.
/// </param>
/// <param name="user_data">
/// The data to pass to @callback.
/// </param>

	public static void NewForBus(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_new_for_bus(bus_type, flags, name, object_path, get_proxy_type_func, get_proxy_type_user_data, get_proxy_type_destroy_notify, cancellable, callback, user_data);
	}

}
public static class GDBusObjectManagerClientHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when one or more D-Bus properties on proxy changes. The
/// local cache has already been updated when this signal fires. Note
/// that both @changed_properties and @invalidated_properties are
/// guaranteed to never be %NULL (either may be empty though).
/// </para>
/// <para>
/// This signal exists purely as a convenience to avoid having to
/// connect signals to all interface proxies managed by @manager.
/// </para>
/// <para>
/// This signal is emitted in the
/// [thread-default main context][g-main-context-push-thread-default]
/// that @manager was constructed in.
/// </para>
/// </summary>

	public static IObservable<GDBusObjectManagerClientHandleSignalStructs.InterfaceProxyPropertiesChangedSignal> Signal_InterfaceProxyPropertiesChanged(this GDBusObjectManagerClientHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectManagerClientHandleSignalStructs.InterfaceProxyPropertiesChangedSignal> obs) =>
		{
			GDBusObjectManagerClientHandleSignalDelegates.interface_proxy_properties_changed handler = ( MentorLake.Gio.GDBusObjectManagerClientHandle self,  MentorLake.Gio.GDBusObjectProxyHandle object_proxy,  MentorLake.Gio.GDBusProxyHandle interface_proxy,  MentorLake.GLib.GVariantHandle changed_properties,  string[] invalidated_properties,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectManagerClientHandleSignalStructs.InterfaceProxyPropertiesChangedSignal()
				{
					Self = self, ObjectProxy = object_proxy, InterfaceProxy = interface_proxy, ChangedProperties = changed_properties, InvalidatedProperties = invalidated_properties, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "interface-proxy-properties-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a D-Bus signal is received on @interface_proxy.
/// </para>
/// <para>
/// This signal exists purely as a convenience to avoid having to
/// connect signals to all interface proxies managed by @manager.
/// </para>
/// <para>
/// This signal is emitted in the
/// [thread-default main context][g-main-context-push-thread-default]
/// that @manager was constructed in.
/// </para>
/// </summary>

	public static IObservable<GDBusObjectManagerClientHandleSignalStructs.InterfaceProxySignalSignal> Signal_InterfaceProxySignal(this GDBusObjectManagerClientHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectManagerClientHandleSignalStructs.InterfaceProxySignalSignal> obs) =>
		{
			GDBusObjectManagerClientHandleSignalDelegates.interface_proxy_signal handler = ( MentorLake.Gio.GDBusObjectManagerClientHandle self,  MentorLake.Gio.GDBusObjectProxyHandle object_proxy,  MentorLake.Gio.GDBusProxyHandle interface_proxy,  string sender_name,  string signal_name,  MentorLake.GLib.GVariantHandle parameters,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectManagerClientHandleSignalStructs.InterfaceProxySignalSignal()
				{
					Self = self, ObjectProxy = object_proxy, InterfaceProxy = interface_proxy, SenderName = sender_name, SignalName = signal_name, Parameters = parameters, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "interface-proxy-signal", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when @interface is added to @object.
/// </para>
/// <para>
/// This signal exists purely as a convenience to avoid having to
/// connect signals to all objects managed by @manager.
/// </para>
/// </summary>

	public static IObservable<GDBusObjectManagerClientHandleSignalStructs.InterfaceAddedSignal> Signal_InterfaceAdded(this GDBusObjectManagerClientHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectManagerClientHandleSignalStructs.InterfaceAddedSignal> obs) =>
		{
			GDBusObjectManagerClientHandleSignalDelegates.interface_added handler = ( MentorLake.Gio.GDBusObjectManagerHandle self,  MentorLake.Gio.GDBusObjectHandle @object,  MentorLake.Gio.GDBusInterfaceHandle @interface,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectManagerClientHandleSignalStructs.InterfaceAddedSignal()
				{
					Self = self, Object = @object, Interface = @interface, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "interface-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when @interface has been removed from @object.
/// </para>
/// <para>
/// This signal exists purely as a convenience to avoid having to
/// connect signals to all objects managed by @manager.
/// </para>
/// </summary>

	public static IObservable<GDBusObjectManagerClientHandleSignalStructs.InterfaceRemovedSignal> Signal_InterfaceRemoved(this GDBusObjectManagerClientHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectManagerClientHandleSignalStructs.InterfaceRemovedSignal> obs) =>
		{
			GDBusObjectManagerClientHandleSignalDelegates.interface_removed handler = ( MentorLake.Gio.GDBusObjectManagerHandle self,  MentorLake.Gio.GDBusObjectHandle @object,  MentorLake.Gio.GDBusInterfaceHandle @interface,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectManagerClientHandleSignalStructs.InterfaceRemovedSignal()
				{
					Self = self, Object = @object, Interface = @interface, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "interface-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when @object is added to @manager.
/// </para>
/// </summary>

	public static IObservable<GDBusObjectManagerClientHandleSignalStructs.ObjectAddedSignal> Signal_ObjectAdded(this GDBusObjectManagerClientHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectManagerClientHandleSignalStructs.ObjectAddedSignal> obs) =>
		{
			GDBusObjectManagerClientHandleSignalDelegates.object_added handler = ( MentorLake.Gio.GDBusObjectManagerHandle self,  MentorLake.Gio.GDBusObjectHandle @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectManagerClientHandleSignalStructs.ObjectAddedSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "object-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when @object is removed from @manager.
/// </para>
/// </summary>

	public static IObservable<GDBusObjectManagerClientHandleSignalStructs.ObjectRemovedSignal> Signal_ObjectRemoved(this GDBusObjectManagerClientHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectManagerClientHandleSignalStructs.ObjectRemovedSignal> obs) =>
		{
			GDBusObjectManagerClientHandleSignalDelegates.object_removed handler = ( MentorLake.Gio.GDBusObjectManagerHandle self,  MentorLake.Gio.GDBusObjectHandle @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectManagerClientHandleSignalStructs.ObjectRemovedSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "object-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusObjectManagerClientHandleSignalStructs
{

public class InterfaceProxyPropertiesChangedSignal
{

	public MentorLake.Gio.GDBusObjectManagerClientHandle Self;
/// <summary>
/// <para>
/// The #GDBusObjectProxy on which an interface has properties that are changing.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusObjectProxyHandle ObjectProxy;
/// <summary>
/// <para>
/// The #GDBusProxy that has properties that are changing.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusProxyHandle InterfaceProxy;
/// <summary>
/// <para>
/// A #GVariant containing the properties that changed (type: `a{sv}`).
/// </para>
/// </summary>

	public MentorLake.GLib.GVariantHandle ChangedProperties;
/// <summary>
/// <para>
/// A %NULL terminated
///   array of properties that were invalidated.
/// </para>
/// </summary>

	public string[] InvalidatedProperties;

	public IntPtr UserData;
}

public class InterfaceProxySignalSignal
{

	public MentorLake.Gio.GDBusObjectManagerClientHandle Self;
/// <summary>
/// <para>
/// The #GDBusObjectProxy on which an interface is emitting a D-Bus signal.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusObjectProxyHandle ObjectProxy;
/// <summary>
/// <para>
/// The #GDBusProxy that is emitting a D-Bus signal.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusProxyHandle InterfaceProxy;
/// <summary>
/// <para>
/// The sender of the signal or NULL if the connection is not a bus connection.
/// </para>
/// </summary>

	public string SenderName;
/// <summary>
/// <para>
/// The signal name.
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

public class InterfaceAddedSignal
{

	public MentorLake.Gio.GDBusObjectManagerHandle Self;
/// <summary>
/// <para>
/// The #GDBusObject on which an interface was added.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusObjectHandle Object;
/// <summary>
/// <para>
/// The #GDBusInterface that was added.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusInterfaceHandle Interface;

	public IntPtr UserData;
}

public class InterfaceRemovedSignal
{

	public MentorLake.Gio.GDBusObjectManagerHandle Self;
/// <summary>
/// <para>
/// The #GDBusObject on which an interface was removed.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusObjectHandle Object;
/// <summary>
/// <para>
/// The #GDBusInterface that was removed.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusInterfaceHandle Interface;

	public IntPtr UserData;
}

public class ObjectAddedSignal
{

	public MentorLake.Gio.GDBusObjectManagerHandle Self;
/// <summary>
/// <para>
/// The #GDBusObject that was added.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusObjectHandle Object;

	public IntPtr UserData;
}

public class ObjectRemovedSignal
{

	public MentorLake.Gio.GDBusObjectManagerHandle Self;
/// <summary>
/// <para>
/// The #GDBusObject that was removed.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusObjectHandle Object;

	public IntPtr UserData;
}
}

public static class GDBusObjectManagerClientHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when one or more D-Bus properties on proxy changes. The
/// local cache has already been updated when this signal fires. Note
/// that both @changed_properties and @invalidated_properties are
/// guaranteed to never be %NULL (either may be empty though).
/// </para>
/// <para>
/// This signal exists purely as a convenience to avoid having to
/// connect signals to all interface proxies managed by @manager.
/// </para>
/// <para>
/// This signal is emitted in the
/// [thread-default main context][g-main-context-push-thread-default]
/// that @manager was constructed in.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="object_proxy">
/// The #GDBusObjectProxy on which an interface has properties that are changing.
/// </param>
/// <param name="interface_proxy">
/// The #GDBusProxy that has properties that are changing.
/// </param>
/// <param name="changed_properties">
/// A #GVariant containing the properties that changed (type: `a{sv}`).
/// </param>
/// <param name="invalidated_properties">
/// A %NULL terminated
///   array of properties that were invalidated.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void interface_proxy_properties_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectProxyHandle>))] MentorLake.Gio.GDBusObjectProxyHandle object_proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle interface_proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle changed_properties, string[] invalidated_properties, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a D-Bus signal is received on @interface_proxy.
/// </para>
/// <para>
/// This signal exists purely as a convenience to avoid having to
/// connect signals to all interface proxies managed by @manager.
/// </para>
/// <para>
/// This signal is emitted in the
/// [thread-default main context][g-main-context-push-thread-default]
/// that @manager was constructed in.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="object_proxy">
/// The #GDBusObjectProxy on which an interface is emitting a D-Bus signal.
/// </param>
/// <param name="interface_proxy">
/// The #GDBusProxy that is emitting a D-Bus signal.
/// </param>
/// <param name="sender_name">
/// The sender of the signal or NULL if the connection is not a bus connection.
/// </param>
/// <param name="signal_name">
/// The signal name.
/// </param>
/// <param name="parameters">
/// A #GVariant tuple with parameters for the signal.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void interface_proxy_signal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectProxyHandle>))] MentorLake.Gio.GDBusObjectProxyHandle object_proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle interface_proxy, string sender_name, string signal_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when @interface is added to @object.
/// </para>
/// <para>
/// This signal exists purely as a convenience to avoid having to
/// connect signals to all objects managed by @manager.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@object">
/// The #GDBusObject on which an interface was added.
/// </param>
/// <param name="@interface">
/// The #GDBusInterface that was added.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void interface_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle @interface, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when @interface has been removed from @object.
/// </para>
/// <para>
/// This signal exists purely as a convenience to avoid having to
/// connect signals to all objects managed by @manager.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@object">
/// The #GDBusObject on which an interface was removed.
/// </param>
/// <param name="@interface">
/// The #GDBusInterface that was removed.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void interface_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle @interface, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when @object is added to @manager.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@object">
/// The #GDBusObject that was added.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void object_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when @object is removed from @manager.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@object">
/// The #GDBusObject that was removed.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void object_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object, IntPtr user_data);

}


public static class GDBusObjectManagerClientHandleExtensions
{
/// <summary>
/// <para>
/// Gets the #GDBusConnection used by @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManagerClient
/// </param>
/// <return>
/// A #GDBusConnection object. Do not free,
///   the object belongs to @manager.
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusObjectManagerClientHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerClientHandle)");
		return GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_get_connection(manager);
	}

/// <summary>
/// <para>
/// Gets the flags that @manager was constructed with.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManagerClient
/// </param>
/// <return>
/// Zero of more flags from the #GDBusObjectManagerClientFlags
/// enumeration.
/// </return>

	public static MentorLake.Gio.GDBusObjectManagerClientFlags GetFlags(this MentorLake.Gio.GDBusObjectManagerClientHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerClientHandle)");
		return GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_get_flags(manager);
	}

/// <summary>
/// <para>
/// Gets the name that @manager is for, or %NULL if not a message bus
/// connection.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManagerClient
/// </param>
/// <return>
/// A unique or well-known name. Do not free, the string
/// belongs to @manager.
/// </return>

	public static string GetName(this MentorLake.Gio.GDBusObjectManagerClientHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerClientHandle)");
		return GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_get_name(manager);
	}

/// <summary>
/// <para>
/// The unique name that owns the name that @manager is for or %NULL if
/// no-one currently owns that name. You can connect to the
/// #GObject::notify signal to track changes to the
/// #GDBusObjectManagerClient:name-owner property.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManagerClient.
/// </param>
/// <return>
/// The name owner or %NULL if no name owner
/// exists. Free with g_free().
/// </return>

	public static string GetNameOwner(this MentorLake.Gio.GDBusObjectManagerClientHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerClientHandle)");
		return GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_get_name_owner(manager);
	}

}

internal class GDBusObjectManagerClientHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))]
	internal static extern MentorLake.Gio.GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))]
	internal static extern MentorLake.Gio.GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_for_bus_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))]
	internal static extern MentorLake.Gio.GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_for_bus_sync(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))]
	internal static extern MentorLake.Gio.GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_object_manager_client_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle manager);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectManagerClientFlags g_dbus_object_manager_client_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle manager);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_object_manager_client_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle manager);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_object_manager_client_get_name_owner([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle manager);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_client_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_client_new_for_bus(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

}
