namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GDBusObjectSkeleton` instance is essentially a group of D-Bus
/// interfaces. The set of exported interfaces on the object may be
/// dynamic and change at runtime.
/// </para>
/// <para>
/// This type is intended to be used with [iface@Gio.DBusObjectManager].
/// </para>
/// </summary>

public class GDBusObjectSkeletonHandle : GObjectHandle, GDBusObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GDBusObjectSkeleton.
/// </para>
/// </summary>

/// <param name="object_path">
/// An object path.
/// </param>
/// <return>
/// A #GDBusObjectSkeleton. Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusObjectSkeletonHandle New(string object_path)
	{
		return GDBusObjectSkeletonHandleExterns.g_dbus_object_skeleton_new(object_path);
	}

}
public static class GDBusObjectSkeletonHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when a method is invoked by a remote caller and used to
/// determine if the method call is authorized.
/// </para>
/// <para>
/// This signal is like #GDBusInterfaceSkeleton&apos;s
/// #GDBusInterfaceSkeleton::g-authorize-method signal,
/// except that it is for the enclosing object.
/// </para>
/// <para>
/// The default class handler just returns %TRUE.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when @interface is added to @object.
/// </para>
/// </summary>

	public static IObservable<GDBusObjectSkeletonHandleSignalStructs.InterfaceAddedSignal> Signal_InterfaceAdded(this GDBusObjectSkeletonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectSkeletonHandleSignalStructs.InterfaceAddedSignal> obs) =>
		{
			GDBusObjectSkeletonHandleSignalDelegates.interface_added handler = ( MentorLake.Gio.GDBusObjectHandle self,  MentorLake.Gio.GDBusInterfaceHandle @interface,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectSkeletonHandleSignalStructs.InterfaceAddedSignal()
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

	public static IObservable<GDBusObjectSkeletonHandleSignalStructs.InterfaceRemovedSignal> Signal_InterfaceRemoved(this GDBusObjectSkeletonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectSkeletonHandleSignalStructs.InterfaceRemovedSignal> obs) =>
		{
			GDBusObjectSkeletonHandleSignalDelegates.interface_removed handler = ( MentorLake.Gio.GDBusObjectHandle self,  MentorLake.Gio.GDBusInterfaceHandle @interface,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectSkeletonHandleSignalStructs.InterfaceRemovedSignal()
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

public static class GDBusObjectSkeletonHandleSignalStructs
{

public class AuthorizeMethodSignal
{

	public MentorLake.Gio.GDBusObjectSkeletonHandle Self;
/// <summary>
/// <para>
/// The #GDBusInterfaceSkeleton that @invocation is for.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusInterfaceSkeletonHandle Interface;
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

public static class GDBusObjectSkeletonHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when a method is invoked by a remote caller and used to
/// determine if the method call is authorized.
/// </para>
/// <para>
/// This signal is like #GDBusInterfaceSkeleton&apos;s
/// #GDBusInterfaceSkeleton::g-authorize-method signal,
/// except that it is for the enclosing object.
/// </para>
/// <para>
/// The default class handler just returns %TRUE.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@interface">
/// The #GDBusInterfaceSkeleton that @invocation is for.
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
public delegate bool authorize_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle @interface, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, IntPtr user_data);


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


public static class GDBusObjectSkeletonHandleExtensions
{
/// <summary>
/// <para>
/// Adds @interface_ to @object.
/// </para>
/// <para>
/// If @object already contains a #GDBusInterfaceSkeleton with the same
/// interface name, it is removed before @interface_ is added.
/// </para>
/// <para>
/// Note that @object takes its own reference on @interface_ and holds
/// it until removed.
/// </para>
/// </summary>

/// <param name="@object">
/// A #GDBusObjectSkeleton.
/// </param>
/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>

	public static T AddInterface<T>(this T @object, MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_) where T : GDBusObjectSkeletonHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GDBusObjectSkeletonHandle)");
		GDBusObjectSkeletonHandleExterns.g_dbus_object_skeleton_add_interface(@object, interface_);
		return @object;
	}

/// <summary>
/// <para>
/// This method simply calls g_dbus_interface_skeleton_flush() on all
/// interfaces belonging to @object. See that method for when flushing
/// is useful.
/// </para>
/// </summary>

/// <param name="@object">
/// A #GDBusObjectSkeleton.
/// </param>

	public static T Flush<T>(this T @object) where T : GDBusObjectSkeletonHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GDBusObjectSkeletonHandle)");
		GDBusObjectSkeletonHandleExterns.g_dbus_object_skeleton_flush(@object);
		return @object;
	}

/// <summary>
/// <para>
/// Removes @interface_ from @object.
/// </para>
/// </summary>

/// <param name="@object">
/// A #GDBusObjectSkeleton.
/// </param>
/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>

	public static T RemoveInterface<T>(this T @object, MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_) where T : GDBusObjectSkeletonHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GDBusObjectSkeletonHandle)");
		GDBusObjectSkeletonHandleExterns.g_dbus_object_skeleton_remove_interface(@object, interface_);
		return @object;
	}

/// <summary>
/// <para>
/// Removes the #GDBusInterface with @interface_name from @object.
/// </para>
/// <para>
/// If no D-Bus interface of the given interface exists, this function
/// does nothing.
/// </para>
/// </summary>

/// <param name="@object">
/// A #GDBusObjectSkeleton.
/// </param>
/// <param name="interface_name">
/// A D-Bus interface name.
/// </param>

	public static T RemoveInterfaceByName<T>(this T @object, string interface_name) where T : GDBusObjectSkeletonHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GDBusObjectSkeletonHandle)");
		GDBusObjectSkeletonHandleExterns.g_dbus_object_skeleton_remove_interface_by_name(@object, interface_name);
		return @object;
	}

/// <summary>
/// <para>
/// Sets the object path for @object.
/// </para>
/// </summary>

/// <param name="@object">
/// A #GDBusObjectSkeleton.
/// </param>
/// <param name="object_path">
/// A valid D-Bus object path.
/// </param>

	public static T SetObjectPath<T>(this T @object, string object_path) where T : GDBusObjectSkeletonHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GDBusObjectSkeletonHandle)");
		GDBusObjectSkeletonHandleExterns.g_dbus_object_skeleton_set_object_path(@object, object_path);
		return @object;
	}

}

internal class GDBusObjectSkeletonHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))]
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
