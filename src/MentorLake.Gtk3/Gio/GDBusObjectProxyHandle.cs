namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GDBusObjectProxy` is an object used to represent a remote object
/// with one or more D-Bus interfaces. Normally, you don’t instantiate
/// a `GDBusObjectProxy` yourself — typically [class@Gio.DBusObjectManagerClient]
/// is used to obtain it.
/// </para>
/// </summary>

public class GDBusObjectProxyHandle : GObjectHandle, GDBusObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GDBusObjectProxy for the given connection and
/// object path.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="object_path">
/// the object path
/// </param>
/// <return>
/// a new #GDBusObjectProxy
/// </return>

	public static MentorLake.Gio.GDBusObjectProxyHandle New(MentorLake.Gio.GDBusConnectionHandle connection, string object_path)
	{
		return GDBusObjectProxyHandleExterns.g_dbus_object_proxy_new(connection, object_path);
	}

}
public static class GDBusObjectProxyHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when @interface is added to @object.
/// </para>
/// </summary>

	public static IObservable<GDBusObjectProxyHandleSignalStructs.InterfaceAddedSignal> Signal_InterfaceAdded(this GDBusObjectProxyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectProxyHandleSignalStructs.InterfaceAddedSignal> obs) =>
		{
			GDBusObjectProxyHandleSignalDelegates.interface_added handler = ( MentorLake.Gio.GDBusObjectHandle self,  MentorLake.Gio.GDBusInterfaceHandle @interface,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectProxyHandleSignalStructs.InterfaceAddedSignal()
				{
					Self = self, Interface = @interface, UserData = user_data
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
/// Emitted when @interface is removed from @object.
/// </para>
/// </summary>

	public static IObservable<GDBusObjectProxyHandleSignalStructs.InterfaceRemovedSignal> Signal_InterfaceRemoved(this GDBusObjectProxyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectProxyHandleSignalStructs.InterfaceRemovedSignal> obs) =>
		{
			GDBusObjectProxyHandleSignalDelegates.interface_removed handler = ( MentorLake.Gio.GDBusObjectHandle self,  MentorLake.Gio.GDBusInterfaceHandle @interface,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectProxyHandleSignalStructs.InterfaceRemovedSignal()
				{
					Self = self, Interface = @interface, UserData = user_data
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
}

public static class GDBusObjectProxyHandleSignalStructs
{

public class InterfaceAddedSignal
{

	public MentorLake.Gio.GDBusObjectHandle Self;
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

	public MentorLake.Gio.GDBusObjectHandle Self;
/// <summary>
/// <para>
/// The #GDBusInterface that was removed.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusInterfaceHandle Interface;

	public IntPtr UserData;
}
}

public static class GDBusObjectProxyHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when @interface is added to @object.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@interface">
/// The #GDBusInterface that was added.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void interface_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle @interface, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when @interface is removed from @object.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@interface">
/// The #GDBusInterface that was removed.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void interface_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle @interface, IntPtr user_data);

}


public static class GDBusObjectProxyHandleExtensions
{
/// <summary>
/// <para>
/// Gets the connection that @proxy is for.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GDBusObjectProxy
/// </param>
/// <return>
/// A #GDBusConnection. Do not free, the
///   object is owned by @proxy.
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusObjectProxyHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GDBusObjectProxyHandle)");
		return GDBusObjectProxyHandleExterns.g_dbus_object_proxy_get_connection(proxy);
	}

}

internal class GDBusObjectProxyHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusObjectProxyHandle>))]
	internal static extern MentorLake.Gio.GDBusObjectProxyHandle g_dbus_object_proxy_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_object_proxy_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectProxyHandle>))] MentorLake.Gio.GDBusObjectProxyHandle proxy);

}
