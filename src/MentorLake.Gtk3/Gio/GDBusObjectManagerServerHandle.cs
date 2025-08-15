namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDBusObjectManagerServer` is used to export [iface@Gio.DBusObject] instances
/// using the standardized
/// &amp;lt;see href=&quot;http://dbus.freedesktop.org/doc/dbus-specification.html#standard-interfaces-objectmanager&quot;&amp;gt;org.freedesktop.DBus.ObjectManager&amp;lt;/see&amp;gt;
/// interface. For example, remote D-Bus clients can get all objects
/// and properties in a single call. Additionally, any change in the
/// object hierarchy is broadcast using signals. This means that D-Bus
/// clients can keep caches up to date by only listening to D-Bus
/// signals.
/// </para>
/// <para>
/// The recommended path to export an object manager at is the path form of the
/// well-known name of a D-Bus service, or below. For example, if a D-Bus service
/// is available at the well-known name `net.example.ExampleService1`, the object
/// manager should typically be exported at `/net/example/ExampleService1`, or
/// below (to allow for multiple object managers in a service).
/// </para>
/// <para>
/// It is supported, but not recommended, to export an object manager at the root
/// path, `/`.
/// </para>
/// <para>
/// See [class@Gio.DBusObjectManagerClient] for the client-side code that is
/// intended to be used with `GDBusObjectManagerServer` or any D-Bus
/// object implementing the `org.freedesktop.DBus.ObjectManager` interface.
/// </para>
/// </summary>

public class GDBusObjectManagerServerHandle : GObjectHandle, GDBusObjectManagerHandle
{
/// <summary>
/// <para>
/// Creates a new #GDBusObjectManagerServer object.
/// </para>
/// <para>
/// The returned server isn&apos;t yet exported on any connection. To do so,
/// use g_dbus_object_manager_server_set_connection(). Normally you
/// want to export all of your objects before doing so to avoid
/// [InterfacesAdded](http://dbus.freedesktop.org/doc/dbus-specification.html#standard-interfaces-objectmanager)
/// signals being emitted.
/// </para>
/// </summary>

/// <param name="object_path">
/// The object path to export the manager object at.
/// </param>
/// <return>
/// A #GDBusObjectManagerServer object. Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusObjectManagerServerHandle New(string object_path)
	{
		return GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_new(object_path);
	}

}
public static class GDBusObjectManagerServerHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when @interface is added to @object.
/// </para>
/// <para>
/// This signal exists purely as a convenience to avoid having to
/// connect signals to all objects managed by @manager.
/// </para>
/// </summary>

	public static IObservable<GDBusObjectManagerServerHandleSignalStructs.InterfaceAddedSignal> Signal_InterfaceAdded(this GDBusObjectManagerServerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectManagerServerHandleSignalStructs.InterfaceAddedSignal> obs) =>
		{
			GDBusObjectManagerServerHandleSignalDelegates.interface_added handler = ( MentorLake.Gio.GDBusObjectManagerHandle self,  MentorLake.Gio.GDBusObjectHandle @object,  MentorLake.Gio.GDBusInterfaceHandle @interface,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectManagerServerHandleSignalStructs.InterfaceAddedSignal()
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

	public static IObservable<GDBusObjectManagerServerHandleSignalStructs.InterfaceRemovedSignal> Signal_InterfaceRemoved(this GDBusObjectManagerServerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectManagerServerHandleSignalStructs.InterfaceRemovedSignal> obs) =>
		{
			GDBusObjectManagerServerHandleSignalDelegates.interface_removed handler = ( MentorLake.Gio.GDBusObjectManagerHandle self,  MentorLake.Gio.GDBusObjectHandle @object,  MentorLake.Gio.GDBusInterfaceHandle @interface,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectManagerServerHandleSignalStructs.InterfaceRemovedSignal()
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

	public static IObservable<GDBusObjectManagerServerHandleSignalStructs.ObjectAddedSignal> Signal_ObjectAdded(this GDBusObjectManagerServerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectManagerServerHandleSignalStructs.ObjectAddedSignal> obs) =>
		{
			GDBusObjectManagerServerHandleSignalDelegates.object_added handler = ( MentorLake.Gio.GDBusObjectManagerHandle self,  MentorLake.Gio.GDBusObjectHandle @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectManagerServerHandleSignalStructs.ObjectAddedSignal()
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

	public static IObservable<GDBusObjectManagerServerHandleSignalStructs.ObjectRemovedSignal> Signal_ObjectRemoved(this GDBusObjectManagerServerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectManagerServerHandleSignalStructs.ObjectRemovedSignal> obs) =>
		{
			GDBusObjectManagerServerHandleSignalDelegates.object_removed handler = ( MentorLake.Gio.GDBusObjectManagerHandle self,  MentorLake.Gio.GDBusObjectHandle @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectManagerServerHandleSignalStructs.ObjectRemovedSignal()
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

public static class GDBusObjectManagerServerHandleSignalStructs
{

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

public static class GDBusObjectManagerServerHandleSignalDelegates
{

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


public static class GDBusObjectManagerServerHandleExtensions
{
/// <summary>
/// <para>
/// Exports @object on @manager.
/// </para>
/// <para>
/// If there is already a #GDBusObject exported at the object path,
/// then the old object is removed.
/// </para>
/// <para>
/// The object path for @object must be in the hierarchy rooted by the
/// object path for @manager.
/// </para>
/// <para>
/// Note that @manager will take a reference on @object for as long as
/// it is exported.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManagerServer.
/// </param>
/// <param name="@object">
/// A #GDBusObjectSkeleton.
/// </param>

	public static T Export<T>(this T manager, MentorLake.Gio.GDBusObjectSkeletonHandle @object) where T : GDBusObjectManagerServerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerServerHandle)");
		GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_export(manager, @object);
		return manager;
	}

/// <summary>
/// <para>
/// Like g_dbus_object_manager_server_export() but appends a string of
/// the form _N (with N being a natural number) to @object&apos;s object path
/// if an object with the given path already exists. As such, the
/// #GDBusObjectProxy:g-object-path property of @object may be modified.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManagerServer.
/// </param>
/// <param name="@object">
/// An object.
/// </param>

	public static T ExportUniquely<T>(this T manager, MentorLake.Gio.GDBusObjectSkeletonHandle @object) where T : GDBusObjectManagerServerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerServerHandle)");
		GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_export_uniquely(manager, @object);
		return manager;
	}

/// <summary>
/// <para>
/// Gets the #GDBusConnection used by @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManagerServer
/// </param>
/// <return>
/// A #GDBusConnection object or %NULL if
///   @manager isn&apos;t exported on a connection. The returned object should
///   be freed with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusObjectManagerServerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerServerHandle)");
		return GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_get_connection(manager);
	}

/// <summary>
/// <para>
/// Returns whether @object is currently exported on @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManagerServer.
/// </param>
/// <param name="@object">
/// An object.
/// </param>
/// <return>
/// %TRUE if @object is exported
/// </return>

	public static bool IsExported(this MentorLake.Gio.GDBusObjectManagerServerHandle manager, MentorLake.Gio.GDBusObjectSkeletonHandle @object)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerServerHandle)");
		return GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_is_exported(manager, @object);
	}

/// <summary>
/// <para>
/// Exports all objects managed by @manager on @connection. If
/// @connection is %NULL, stops exporting objects.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManagerServer.
/// </param>
/// <param name="connection">
/// A #GDBusConnection or %NULL.
/// </param>

	public static T SetConnection<T>(this T manager, MentorLake.Gio.GDBusConnectionHandle connection) where T : GDBusObjectManagerServerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerServerHandle)");
		GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_set_connection(manager, connection);
		return manager;
	}

/// <summary>
/// <para>
/// If @manager has an object at @path, removes the object. Otherwise
/// does nothing.
/// </para>
/// <para>
/// Note that @object_path must be in the hierarchy rooted by the
/// object path for @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManagerServer.
/// </param>
/// <param name="object_path">
/// An object path.
/// </param>
/// <return>
/// %TRUE if object at @object_path was removed, %FALSE otherwise.
/// </return>

	public static bool Unexport(this MentorLake.Gio.GDBusObjectManagerServerHandle manager, string object_path)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerServerHandle)");
		return GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_unexport(manager, object_path);
	}

}

internal class GDBusObjectManagerServerHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))]
	internal static extern MentorLake.Gio.GDBusObjectManagerServerHandle g_dbus_object_manager_server_new(string object_path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_server_export([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_server_export_uniquely([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_object_manager_server_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_object_manager_server_is_exported([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_server_set_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_object_manager_server_unexport([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, string object_path);

}
