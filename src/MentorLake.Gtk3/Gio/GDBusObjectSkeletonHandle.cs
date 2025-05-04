namespace MentorLake.Gio;

public class GDBusObjectSkeletonHandle : GObjectHandle, GDBusObjectHandle
{
	public static MentorLake.Gio.GDBusObjectSkeletonHandle New(string object_path)
	{
		return GDBusObjectSkeletonHandleExterns.g_dbus_object_skeleton_new(object_path);
	}

}
public static class GDBusObjectSkeletonHandleSignalExtensions
{

	public static IObservable<GDBusObjectSkeletonHandleSignalStructs.AuthorizeMethodSignal> Signal_AuthorizeMethod(this GDBusObjectSkeletonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectSkeletonHandleSignalStructs.AuthorizeMethodSignal> obs) =>
		{
			GDBusObjectSkeletonHandleSignalDelegates.authorize_method handler = ( MentorLake.Gio.GDBusObjectSkeletonHandle self,  MentorLake.Gio.GDBusInterfaceSkeletonHandle @interface,  MentorLake.Gio.GDBusMethodInvocationHandle invocation,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectSkeletonHandleSignalStructs.AuthorizeMethodSignal()
				{
					Self = self, Interface = @interface, Invocation = invocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "authorize-method", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusObjectSkeletonHandleSignalStructs
{

public class AuthorizeMethodSignal
{
	public MentorLake.Gio.GDBusObjectSkeletonHandle Self;
	public MentorLake.Gio.GDBusInterfaceSkeletonHandle Interface;
	public MentorLake.Gio.GDBusMethodInvocationHandle Invocation;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GDBusObjectSkeletonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool authorize_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle @interface, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, IntPtr user_data);

}


public static class GDBusObjectSkeletonHandleExtensions
{
	public static T AddInterface<T>(this T @object, MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_) where T : GDBusObjectSkeletonHandle
	{
		if (@object.IsInvalid || @object.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectSkeletonHandle)");
		GDBusObjectSkeletonHandleExterns.g_dbus_object_skeleton_add_interface(@object, interface_);
		return @object;
	}

	public static T Flush<T>(this T @object) where T : GDBusObjectSkeletonHandle
	{
		if (@object.IsInvalid || @object.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectSkeletonHandle)");
		GDBusObjectSkeletonHandleExterns.g_dbus_object_skeleton_flush(@object);
		return @object;
	}

	public static T RemoveInterface<T>(this T @object, MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_) where T : GDBusObjectSkeletonHandle
	{
		if (@object.IsInvalid || @object.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectSkeletonHandle)");
		GDBusObjectSkeletonHandleExterns.g_dbus_object_skeleton_remove_interface(@object, interface_);
		return @object;
	}

	public static T RemoveInterfaceByName<T>(this T @object, string interface_name) where T : GDBusObjectSkeletonHandle
	{
		if (@object.IsInvalid || @object.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectSkeletonHandle)");
		GDBusObjectSkeletonHandleExterns.g_dbus_object_skeleton_remove_interface_by_name(@object, interface_name);
		return @object;
	}

	public static T SetObjectPath<T>(this T @object, string object_path) where T : GDBusObjectSkeletonHandle
	{
		if (@object.IsInvalid || @object.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectSkeletonHandle)");
		GDBusObjectSkeletonHandleExterns.g_dbus_object_skeleton_set_object_path(@object, object_path);
		return @object;
	}

}

internal class GDBusObjectSkeletonHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectSkeletonHandle g_dbus_object_skeleton_new(string object_path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_skeleton_add_interface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_skeleton_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_skeleton_remove_interface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_skeleton_remove_interface_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object, string interface_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_skeleton_set_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object, string object_path);

}
