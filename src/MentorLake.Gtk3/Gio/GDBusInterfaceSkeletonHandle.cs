namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Abstract base class for D-Bus interfaces on the service side.
/// </para>
/// </summary>

public class GDBusInterfaceSkeletonHandle : GObjectHandle, GDBusInterfaceHandle
{
}
public static class GDBusInterfaceSkeletonHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when a method is invoked by a remote caller and used to
/// determine if the method call is authorized.
/// </para>
/// <para>
/// Note that this signal is emitted in a thread dedicated to
/// handling the method call so handlers are allowed to perform
/// blocking IO. This means that it is appropriate to call e.g.
/// [polkit_authority_check_authorization_sync()](http://hal.freedesktop.org/docs/polkit/PolkitAuthority.html#polkit-authority-check-authorization-sync)
/// with the
/// [POLKIT_CHECK_AUTHORIZATION_FLAGS_ALLOW_USER_INTERACTION](http://hal.freedesktop.org/docs/polkit/PolkitAuthority.html#POLKIT-CHECK-AUTHORIZATION-FLAGS-ALLOW-USER-INTERACTION:CAPS)
/// flag set.
/// </para>
/// <para>
/// If %FALSE is returned then no further handlers are run and the
/// signal handler must take a reference to @invocation and finish
/// handling the call (e.g. return an error via
/// g_dbus_method_invocation_return_error()).
/// </para>
/// <para>
/// Otherwise, if %TRUE is returned, signal emission continues. If no
/// handlers return %FALSE, then the method is dispatched. If
/// @interface has an enclosing #GDBusObjectSkeleton, then the
/// #GDBusObjectSkeleton::authorize-method signal handlers run before
/// the handlers for this signal.
/// </para>
/// <para>
/// The default class handler just returns %TRUE.
/// </para>
/// <para>
/// Please note that the common case is optimized: if no signals
/// handlers are connected and the default class handler isn&apos;t
/// overridden (for both @interface and the enclosing
/// #GDBusObjectSkeleton, if any) and #GDBusInterfaceSkeleton:g-flags does
/// not have the
/// %G_DBUS_INTERFACE_SKELETON_FLAGS_HANDLE_METHOD_INVOCATIONS_IN_THREAD
/// flags set, no dedicated thread is ever used and the call will be
/// handled in the same thread as the object that @interface belongs
/// to was exported in.
/// </para>
/// </summary>

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

public static class GDBusInterfaceSkeletonHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when a method is invoked by a remote caller and used to
/// determine if the method call is authorized.
/// </para>
/// <para>
/// Note that this signal is emitted in a thread dedicated to
/// handling the method call so handlers are allowed to perform
/// blocking IO. This means that it is appropriate to call e.g.
/// [polkit_authority_check_authorization_sync()](http://hal.freedesktop.org/docs/polkit/PolkitAuthority.html#polkit-authority-check-authorization-sync)
/// with the
/// [POLKIT_CHECK_AUTHORIZATION_FLAGS_ALLOW_USER_INTERACTION](http://hal.freedesktop.org/docs/polkit/PolkitAuthority.html#POLKIT-CHECK-AUTHORIZATION-FLAGS-ALLOW-USER-INTERACTION:CAPS)
/// flag set.
/// </para>
/// <para>
/// If %FALSE is returned then no further handlers are run and the
/// signal handler must take a reference to @invocation and finish
/// handling the call (e.g. return an error via
/// g_dbus_method_invocation_return_error()).
/// </para>
/// <para>
/// Otherwise, if %TRUE is returned, signal emission continues. If no
/// handlers return %FALSE, then the method is dispatched. If
/// @interface has an enclosing #GDBusObjectSkeleton, then the
/// #GDBusObjectSkeleton::authorize-method signal handlers run before
/// the handlers for this signal.
/// </para>
/// <para>
/// The default class handler just returns %TRUE.
/// </para>
/// <para>
/// Please note that the common case is optimized: if no signals
/// handlers are connected and the default class handler isn&apos;t
/// overridden (for both @interface and the enclosing
/// #GDBusObjectSkeleton, if any) and #GDBusInterfaceSkeleton:g-flags does
/// not have the
/// %G_DBUS_INTERFACE_SKELETON_FLAGS_HANDLE_METHOD_INVOCATIONS_IN_THREAD
/// flags set, no dedicated thread is ever used and the call will be
/// handled in the same thread as the object that @interface belongs
/// to was exported in.
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
public delegate bool g_authorize_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, IntPtr user_data);

}


public static class GDBusInterfaceSkeletonHandleExtensions
{
/// <summary>
/// <para>
/// Exports @interface_ at @object_path on @connection.
/// </para>
/// <para>
/// This can be called multiple times to export the same @interface_
/// onto multiple connections however the @object_path provided must be
/// the same for all connections.
/// </para>
/// <para>
/// Use g_dbus_interface_skeleton_unexport() to unexport the object.
/// </para>
/// </summary>

/// <param name="interface_">
/// The D-Bus interface to export.
/// </param>
/// <param name="connection">
/// A #GDBusConnection to export @interface_ on.
/// </param>
/// <param name="object_path">
/// The path to export the interface at.
/// </param>
/// <return>
/// %TRUE if the interface was exported on @connection, otherwise %FALSE with
/// @error set.
/// </return>

	public static bool Export(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_, MentorLake.Gio.GDBusConnectionHandle connection, string object_path)
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
		var externCallResult = GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_export(interface_, connection, object_path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// If @interface_ has outstanding changes, request for these changes to be
/// emitted immediately.
/// </para>
/// <para>
/// For example, an exported D-Bus interface may queue up property
/// changes and emit the
/// `org.freedesktop.DBus.Properties.PropertiesChanged`
/// signal later (e.g. in an idle handler). This technique is useful
/// for collapsing multiple property changes into one.
/// </para>
/// </summary>

/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>

	public static T Flush<T>(this T interface_) where T : GDBusInterfaceSkeletonHandle
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
		GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_flush(interface_);
		return interface_;
	}

/// <summary>
/// <para>
/// Gets the first connection that @interface_ is exported on, if any.
/// </para>
/// </summary>

/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>
/// <return>
/// A #GDBusConnection or %NULL if @interface_ is
/// not exported anywhere. Do not free, the object belongs to @interface_.
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_connection(interface_);
	}

/// <summary>
/// <para>
/// Gets a list of the connections that @interface_ is exported on.
/// </para>
/// </summary>

/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>
/// <return>
/// A list of
///   all the connections that @interface_ is exported on. The returned
///   list should be freed with g_list_free() after each element has
///   been freed with g_object_unref().
/// </return>

	public static MentorLake.GLib.GListHandle GetConnections(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_connections(interface_);
	}

/// <summary>
/// <para>
/// Gets the #GDBusInterfaceSkeletonFlags that describes what the behavior
/// of @interface_
/// </para>
/// </summary>

/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>
/// <return>
/// One or more flags from the #GDBusInterfaceSkeletonFlags enumeration.
/// </return>

	public static MentorLake.Gio.GDBusInterfaceSkeletonFlags GetFlags(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_flags(interface_);
	}

/// <summary>
/// <para>
/// Gets D-Bus introspection information for the D-Bus interface
/// implemented by @interface_.
/// </para>
/// </summary>

/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>
/// <return>
/// A #GDBusInterfaceInfo (never %NULL). Do not free.
/// </return>

	public static MentorLake.Gio.GDBusInterfaceInfoHandle GetInfo(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_info(interface_);
	}

/// <summary>
/// <para>
/// Gets the object path that @interface_ is exported on, if any.
/// </para>
/// </summary>

/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>
/// <return>
/// A string owned by @interface_ or %NULL if @interface_ is not exported
/// anywhere. Do not free, the string belongs to @interface_.
/// </return>

	public static string GetObjectPath(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_object_path(interface_);
	}

/// <summary>
/// <para>
/// Gets all D-Bus properties for @interface_.
/// </para>
/// </summary>

/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>
/// <return>
/// A #GVariant of type
/// [&apos;a{sv}&apos;][G-VARIANT-TYPE-VARDICT:CAPS].
/// Free with g_variant_unref().
/// </return>

	public static MentorLake.GLib.GVariantHandle GetProperties(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_properties(interface_);
	}

/// <summary>
/// <para>
/// Gets the interface vtable for the D-Bus interface implemented by
/// @interface_. The returned function pointers should expect @interface_
/// itself to be passed as @user_data.
/// </para>
/// </summary>

/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>
/// <return>
/// the vtable of the D-Bus interface implemented by the skeleton
/// </return>

	public static MentorLake.Gio.GDBusInterfaceVTableHandle GetVtable(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_)
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_get_vtable(interface_);
	}

/// <summary>
/// <para>
/// Checks if @interface_ is exported on @connection.
/// </para>
/// </summary>

/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>
/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <return>
/// %TRUE if @interface_ is exported on @connection, %FALSE otherwise.
/// </return>

	public static bool HasConnection(this MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_, MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
		return GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_has_connection(interface_, connection);
	}

/// <summary>
/// <para>
/// Sets flags describing what the behavior of @skeleton should be.
/// </para>
/// </summary>

/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>
/// <param name="flags">
/// Flags from the #GDBusInterfaceSkeletonFlags enumeration.
/// </param>

	public static T SetFlags<T>(this T interface_, MentorLake.Gio.GDBusInterfaceSkeletonFlags flags) where T : GDBusInterfaceSkeletonHandle
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
		GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_set_flags(interface_, flags);
		return interface_;
	}

/// <summary>
/// <para>
/// Stops exporting @interface_ on all connections it is exported on.
/// </para>
/// <para>
/// To unexport @interface_ from only a single connection, use
/// g_dbus_interface_skeleton_unexport_from_connection()
/// </para>
/// </summary>

/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>

	public static T Unexport<T>(this T interface_) where T : GDBusInterfaceSkeletonHandle
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
		GDBusInterfaceSkeletonHandleExterns.g_dbus_interface_skeleton_unexport(interface_);
		return interface_;
	}

/// <summary>
/// <para>
/// Stops exporting @interface_ on @connection.
/// </para>
/// <para>
/// To stop exporting on all connections the interface is exported on,
/// use g_dbus_interface_skeleton_unexport().
/// </para>
/// </summary>

/// <param name="interface_">
/// A #GDBusInterfaceSkeleton.
/// </param>
/// <param name="connection">
/// A #GDBusConnection.
/// </param>

	public static T UnexportFromConnection<T>(this T interface_, MentorLake.Gio.GDBusConnectionHandle connection) where T : GDBusInterfaceSkeletonHandle
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceSkeletonHandle)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_interface_skeleton_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_dbus_interface_skeleton_get_connections([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusInterfaceSkeletonFlags g_dbus_interface_skeleton_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusInterfaceInfoHandle g_dbus_interface_skeleton_get_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_interface_skeleton_get_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_interface_skeleton_get_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceSkeletonHandle>))] MentorLake.Gio.GDBusInterfaceSkeletonHandle interface_);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceVTableHandle>))]
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
