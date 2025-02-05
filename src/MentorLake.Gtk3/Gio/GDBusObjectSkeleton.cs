namespace MentorLake.Gtk3.Gio;

public class GDBusObjectSkeletonHandle : GObjectHandle, GDBusObjectHandle
{
	public static GDBusObjectSkeletonHandle GDbusObjectSkeletonNew(string object_path)
	{
		return GDBusObjectSkeletonExterns.g_dbus_object_skeleton_new(object_path);
	}

}

public static class GDBusObjectSkeletonSignalExtensions
{

	public static IObservable<GDBusObjectSkeletonSignalStructs.AuthorizeMethodSignal> Signal_AuthorizeMethod(this GDBusObjectSkeletonHandle instance)
	{
		return Observable.Create((IObserver<GDBusObjectSkeletonSignalStructs.AuthorizeMethodSignal> obs) =>
		{
			GDBusObjectSkeletonSignalDelegates.authorize_method handler = (GDBusObjectSkeletonHandle self, GDBusInterfaceSkeletonHandle @interface, GDBusMethodInvocationHandle invocation, IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectSkeletonSignalStructs.AuthorizeMethodSignal()
				{
					Self = self, Interface = @interface, Invocation = invocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "authorize_method", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GDBusObjectSkeletonSignalStructs
{

public struct AuthorizeMethodSignal
{
	public GDBusObjectSkeletonHandle Self;
	public GDBusInterfaceSkeletonHandle Interface;
	public GDBusMethodInvocationHandle Invocation;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GDBusObjectSkeletonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool authorize_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusObjectSkeletonHandle>))] GDBusObjectSkeletonHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusInterfaceSkeletonHandle>))] GDBusInterfaceSkeletonHandle @interface, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusMethodInvocationHandle>))] GDBusMethodInvocationHandle invocation, IntPtr user_data);

}


public static class GDBusObjectSkeletonHandleExtensions
{
	public static T GDbusObjectSkeletonAddInterface<T>(this T @object, GDBusInterfaceSkeletonHandle interface_) where T : GDBusObjectSkeletonHandle
	{
		GDBusObjectSkeletonExterns.g_dbus_object_skeleton_add_interface(@object, interface_);
		return @object;
	}

	public static T GDbusObjectSkeletonFlush<T>(this T @object) where T : GDBusObjectSkeletonHandle
	{
		GDBusObjectSkeletonExterns.g_dbus_object_skeleton_flush(@object);
		return @object;
	}

	public static T GDbusObjectSkeletonRemoveInterface<T>(this T @object, GDBusInterfaceSkeletonHandle interface_) where T : GDBusObjectSkeletonHandle
	{
		GDBusObjectSkeletonExterns.g_dbus_object_skeleton_remove_interface(@object, interface_);
		return @object;
	}

	public static T GDbusObjectSkeletonRemoveInterfaceByName<T>(this T @object, string interface_name) where T : GDBusObjectSkeletonHandle
	{
		GDBusObjectSkeletonExterns.g_dbus_object_skeleton_remove_interface_by_name(@object, interface_name);
		return @object;
	}

	public static T GDbusObjectSkeletonSetObjectPath<T>(this T @object, string object_path) where T : GDBusObjectSkeletonHandle
	{
		GDBusObjectSkeletonExterns.g_dbus_object_skeleton_set_object_path(@object, object_path);
		return @object;
	}

}

internal class GDBusObjectSkeletonExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectSkeletonHandle g_dbus_object_skeleton_new(string object_path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_skeleton_add_interface(GDBusObjectSkeletonHandle @object, GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_skeleton_flush(GDBusObjectSkeletonHandle @object);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_skeleton_remove_interface(GDBusObjectSkeletonHandle @object, GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_skeleton_remove_interface_by_name(GDBusObjectSkeletonHandle @object, string interface_name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_skeleton_set_object_path(GDBusObjectSkeletonHandle @object, string object_path);

}
