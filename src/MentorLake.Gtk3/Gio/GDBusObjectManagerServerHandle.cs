namespace MentorLake.Gio;

public class GDBusObjectManagerServerHandle : GObjectHandle, GDBusObjectManagerHandle
{
	public static MentorLake.Gio.GDBusObjectManagerServerHandle New(string object_path)
	{
		return GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_new(object_path);
	}

}
public static class GDBusObjectManagerServerHandleSignalExtensions
{

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
	public MentorLake.Gio.GDBusObjectHandle Object;
	public MentorLake.Gio.GDBusInterfaceHandle Interface;
	public IntPtr UserData;
}

public class InterfaceRemovedSignal
{
	public MentorLake.Gio.GDBusObjectManagerHandle Self;
	public MentorLake.Gio.GDBusObjectHandle Object;
	public MentorLake.Gio.GDBusInterfaceHandle Interface;
	public IntPtr UserData;
}

public class ObjectAddedSignal
{
	public MentorLake.Gio.GDBusObjectManagerHandle Self;
	public MentorLake.Gio.GDBusObjectHandle Object;
	public IntPtr UserData;
}

public class ObjectRemovedSignal
{
	public MentorLake.Gio.GDBusObjectManagerHandle Self;
	public MentorLake.Gio.GDBusObjectHandle Object;
	public IntPtr UserData;
}
}

public static class GDBusObjectManagerServerHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void interface_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle @interface, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void interface_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle @interface, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void object_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void object_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object, IntPtr user_data);

}


public static class GDBusObjectManagerServerHandleExtensions
{
	public static T Export<T>(this T manager, MentorLake.Gio.GDBusObjectSkeletonHandle @object) where T : GDBusObjectManagerServerHandle
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerServerHandle)");
		GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_export(manager, @object);
		return manager;
	}

	public static T ExportUniquely<T>(this T manager, MentorLake.Gio.GDBusObjectSkeletonHandle @object) where T : GDBusObjectManagerServerHandle
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerServerHandle)");
		GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_export_uniquely(manager, @object);
		return manager;
	}

	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusObjectManagerServerHandle manager)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerServerHandle)");
		return GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_get_connection(manager);
	}

	public static bool IsExported(this MentorLake.Gio.GDBusObjectManagerServerHandle manager, MentorLake.Gio.GDBusObjectSkeletonHandle @object)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerServerHandle)");
		return GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_is_exported(manager, @object);
	}

	public static T SetConnection<T>(this T manager, MentorLake.Gio.GDBusConnectionHandle connection) where T : GDBusObjectManagerServerHandle
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerServerHandle)");
		GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_set_connection(manager, connection);
		return manager;
	}

	public static bool Unexport(this MentorLake.Gio.GDBusObjectManagerServerHandle manager, string object_path)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerServerHandle)");
		return GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_unexport(manager, object_path);
	}

}

internal class GDBusObjectManagerServerHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectManagerServerHandle g_dbus_object_manager_server_new(string object_path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_server_export([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_server_export_uniquely([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_object_manager_server_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_object_manager_server_is_exported([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_server_set_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_object_manager_server_unexport([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, string object_path);

}
