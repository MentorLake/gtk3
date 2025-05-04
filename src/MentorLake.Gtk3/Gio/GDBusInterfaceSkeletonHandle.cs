namespace MentorLake.Gio;

public class GDBusInterfaceSkeletonHandle : GObjectHandle, GDBusInterfaceHandle
{
}
public static class GDBusInterfaceSkeletonHandleSignalExtensions
{

	public static IObservable<GDBusInterfaceSkeletonHandleSignalStructs.GAuthorizeMethodSignal> Signal_GAuthorizeMethod(this GDBusInterfaceSkeletonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusInterfaceSkeletonHandleSignalStructs.GAuthorizeMethodSignal> obs) =>
		{
			GDBusInterfaceSkeletonHandleSignalDelegates.g_authorize_method handler = ( MentorLake.Gio.GDBusInterfaceSkeletonHandle self,  MentorLake.Gio.GDBusMethodInvocationHandle invocation,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusInterfaceSkeletonHandleSignalStructs.GAuthorizeMethodSignal()
				{
					Self = self, Invocation = invocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "g-authorize-method", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusInterfaceSkeletonHandleSignalStructs
{

public class GAuthorizeMethodSignal
{
	public MentorLake.Gio.GDBusInterfaceSkeletonHandle Self;
	public MentorLake.Gio.GDBusMethodInvocationHandle Invocation;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GDBusInterfaceSkeletonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool g_authorize_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, IntPtr user_data);

}


public static class GDBusInterfaceSkeletonHandleExtensions
{
	public static bool Export(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_, MentorLake.Gio.GDBusConnectionHandle connection, string object_path)
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		var externCallResult = GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_export(interface_, connection, object_path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T Flush<T>(this T interface_) where T : GDBusInterfaceSkeletonHandle
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_flush(interface_);
		return interface_;
	}

	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_connection(interface_);
	}

	public static MentorLake.GLib.GListHandle GetConnections(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_connections(interface_);
	}

	public static MentorLake.Gio.GDBusInterfaceSkeletonFlags GetFlags(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_flags(interface_);
	}

	public static MentorLake.Gio.GDBusInterfaceInfoHandle GetInfo(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_info(interface_);
	}

	public static string GetObjectPath(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_object_path(interface_);
	}

	public static MentorLake.GLib.GVariantHandle GetProperties(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_properties(interface_);
	}

	public static MentorLake.Gio.GDBusInterfaceVTableHandle GetVtable(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_vtable(interface_);
	}

	public static bool HasConnection(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_, MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_has_connection(interface_, connection);
	}

	public static T SetFlags<T>(this T interface_, MentorLake.Gio.GDBusInterfaceSkeletonFlags flags) where T : GDBusInterfaceSkeletonHandle
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_set_flags(interface_, flags);
		return interface_;
	}

	public static T Unexport<T>(this T interface_) where T : GDBusInterfaceSkeletonHandle
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_unexport(interface_);
		return interface_;
	}

	public static T UnexportFromConnection<T>(this T interface_, MentorLake.Gio.GDBusConnectionHandle connection) where T : GDBusInterfaceSkeletonHandle
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceSkeletonHandle)");
		GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_unexport_from_connection(interface_, connection);
		return interface_;
	}

}

internal class GDBusInterfaceSkeletonHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_interface_skeleton_export([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_interface_skeleton_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_interface_skeleton_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_dbus_interface_skeleton_get_connections([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusInterfaceSkeletonFlags g_dbus_interface_skeleton_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusInterfaceInfoHandle g_dbus_interface_skeleton_get_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_interface_skeleton_get_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_interface_skeleton_get_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusInterfaceVTableHandle g_dbus_interface_skeleton_get_vtable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_interface_skeleton_has_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_interface_skeleton_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_, MentorLake.Gio.GDBusInterfaceSkeletonFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_interface_skeleton_unexport([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_interface_skeleton_unexport_from_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

}
