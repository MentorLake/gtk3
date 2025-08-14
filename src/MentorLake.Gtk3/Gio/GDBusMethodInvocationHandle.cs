namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Instances of the `GDBusMethodInvocation` class are used when
/// handling D-Bus method calls. It provides a way to asynchronously
/// return results and errors.
/// </para>
/// <para>
/// The normal way to obtain a `GDBusMethodInvocation` object is to receive
/// it as an argument to the `handle_method_call()` function in a
/// [type@Gio.DBusInterfaceVTable] that was passed to
/// [method@Gio.DBusConnection.register_object].
/// </para>
/// </summary>

public class GDBusMethodInvocationHandle : GObjectHandle
{
}

public static class GDBusMethodInvocationHandleExtensions
{
/// <summary>
/// <para>
/// Gets the #GDBusConnection the method was invoked on.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <return>
/// A #GDBusConnection. Do not free, it is owned by @invocation.
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_connection(invocation);
	}

/// <summary>
/// <para>
/// Gets the name of the D-Bus interface the method was invoked on.
/// </para>
/// <para>
/// This can be `NULL` if it was not specified by the sender. See
/// [callback@Gio.DBusInterfaceMethodCallFunc] or the
/// [D-Bus Specification](https://dbus.freedesktop.org/doc/dbus-specification.html#message-protocol-types-method)
/// for details on when this can happen and how it should be handled.
/// </para>
/// <para>
/// If this method call is a property Get, Set or GetAll call that has
/// been redirected to the method call handler then
/// "org.freedesktop.DBus.Properties" will be returned.  See
/// #GDBusInterfaceVTable for more information.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <return>
/// A string. Do not free, it is owned by @invocation.
/// </return>

	public static string GetInterfaceName(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_interface_name(invocation);
	}

/// <summary>
/// <para>
/// Gets the #GDBusMessage for the method invocation. This is useful if
/// you need to use low-level protocol features, such as UNIX file
/// descriptor passing, that cannot be properly expressed in the
/// #GVariant API.
/// </para>
/// <para>
/// See this [server][gdbus-server] and [client][gdbus-unix-fd-client]
/// for an example of how to use this low-level API to send and receive
/// UNIX file descriptors.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <return>
/// #GDBusMessage. Do not free, it is owned by @invocation.
/// </return>

	public static MentorLake.Gio.GDBusMessageHandle GetMessage(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_message(invocation);
	}

/// <summary>
/// <para>
/// Gets information about the method call, if any.
/// </para>
/// <para>
/// If this method invocation is a property Get, Set or GetAll call that
/// has been redirected to the method call handler then %NULL will be
/// returned.  See g_dbus_method_invocation_get_property_info() and
/// #GDBusInterfaceVTable for more information.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <return>
/// A #GDBusMethodInfo or %NULL. Do not free, it is owned by @invocation.
/// </return>

	public static MentorLake.Gio.GDBusMethodInfoHandle GetMethodInfo(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_method_info(invocation);
	}

/// <summary>
/// <para>
/// Gets the name of the method that was invoked.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <return>
/// A string. Do not free, it is owned by @invocation.
/// </return>

	public static string GetMethodName(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_method_name(invocation);
	}

/// <summary>
/// <para>
/// Gets the object path the method was invoked on.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <return>
/// A string. Do not free, it is owned by @invocation.
/// </return>

	public static string GetObjectPath(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_object_path(invocation);
	}

/// <summary>
/// <para>
/// Gets the parameters of the method invocation. If there are no input
/// parameters then this will return a GVariant with 0 children rather than NULL.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <return>
/// A #GVariant tuple. Do not unref this because it is owned by @invocation.
/// </return>

	public static MentorLake.GLib.GVariantHandle GetParameters(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_parameters(invocation);
	}

/// <summary>
/// <para>
/// Gets information about the property that this method call is for, if
/// any.
/// </para>
/// <para>
/// This will only be set in the case of an invocation in response to a
/// property Get or Set call that has been directed to the method call
/// handler for an object on account of its property_get() or
/// property_set() vtable pointers being unset.
/// </para>
/// <para>
/// See #GDBusInterfaceVTable for more information.
/// </para>
/// <para>
/// If the call was GetAll, %NULL will be returned.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation
/// </param>
/// <return>
/// a #GDBusPropertyInfo or %NULL
/// </return>

	public static MentorLake.Gio.GDBusPropertyInfoHandle GetPropertyInfo(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_property_info(invocation);
	}

/// <summary>
/// <para>
/// Gets the bus name that invoked the method.
/// </para>
/// <para>
/// This can return %NULL if not specified by the caller, e.g. on peer-to-peer
/// connections.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <return>
/// A string. Do not free, it is owned by @invocation.
/// </return>

	public static string GetSender(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_sender(invocation);
	}

/// <summary>
/// <para>
/// Gets the @user_data #gpointer passed to g_dbus_connection_register_object().
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <return>
/// A #gpointer.
/// </return>

	public static IntPtr GetUserData(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_user_data(invocation);
	}

/// <summary>
/// <para>
/// Finishes handling a D-Bus method call by returning an error.
/// </para>
/// <para>
/// This method will take ownership of @invocation. See
/// #GDBusInterfaceVTable for more information about the ownership of
/// @invocation.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <param name="error_name">
/// A valid D-Bus error name.
/// </param>
/// <param name="error_message">
/// A valid D-Bus error message.
/// </param>

	public static T ReturnDbusError<T>(this T invocation, string error_name, string error_message) where T : GDBusMethodInvocationHandle
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_dbus_error(invocation, error_name, error_message);
		return invocation;
	}

/// <summary>
/// <para>
/// Finishes handling a D-Bus method call by returning an error.
/// </para>
/// <para>
/// See g_dbus_error_encode_gerror() for details about what error name
/// will be returned on the wire. In a nutshell, if the given error is
/// registered using g_dbus_error_register_error() the name given
/// during registration is used. Otherwise, a name of the form
/// `org.gtk.GDBus.UnmappedGError.Quark...` is used. This provides
/// transparent mapping of #GError between applications using GDBus.
/// </para>
/// <para>
/// If you are writing an application intended to be portable,
/// always register errors with g_dbus_error_register_error()
/// or use g_dbus_method_invocation_return_dbus_error().
/// </para>
/// <para>
/// This method will take ownership of @invocation. See
/// #GDBusInterfaceVTable for more information about the ownership of
/// @invocation.
/// </para>
/// <para>
/// Since 2.48, if the method call requested for a reply not to be sent
/// then this call will free @invocation but otherwise do nothing (as per
/// the recommendations of the D-Bus specification).
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <param name="domain">
/// A #GQuark for the #GError error domain.
/// </param>
/// <param name="code">
/// The error code.
/// </param>
/// <param name="format">
/// printf()-style format.
/// </param>
/// <param name="@__arglist">
/// Parameters for @format.
/// </param>

	public static T ReturnError<T>(this T invocation, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist) where T : GDBusMethodInvocationHandle
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_error(invocation, domain, code, format, @__arglist);
		return invocation;
	}

/// <summary>
/// <para>
/// Like g_dbus_method_invocation_return_error() but without printf()-style formatting.
/// </para>
/// <para>
/// This method will take ownership of @invocation. See
/// #GDBusInterfaceVTable for more information about the ownership of
/// @invocation.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <param name="domain">
/// A #GQuark for the #GError error domain.
/// </param>
/// <param name="code">
/// The error code.
/// </param>
/// <param name="message">
/// The error message.
/// </param>

	public static T ReturnErrorLiteral<T>(this T invocation, MentorLake.GLib.GQuark domain, int code, string message) where T : GDBusMethodInvocationHandle
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_error_literal(invocation, domain, code, message);
		return invocation;
	}

/// <summary>
/// <para>
/// Like g_dbus_method_invocation_return_error() but intended for
/// language bindings.
/// </para>
/// <para>
/// This method will take ownership of @invocation. See
/// #GDBusInterfaceVTable for more information about the ownership of
/// @invocation.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <param name="domain">
/// A #GQuark for the #GError error domain.
/// </param>
/// <param name="code">
/// The error code.
/// </param>
/// <param name="format">
/// printf()-style format.
/// </param>
/// <param name="var_args">
/// #va_list of parameters for @format.
/// </param>

	public static T ReturnErrorValist<T>(this T invocation, MentorLake.GLib.GQuark domain, int code, string format, IntPtr var_args) where T : GDBusMethodInvocationHandle
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_error_valist(invocation, domain, code, format, var_args);
		return invocation;
	}

/// <summary>
/// <para>
/// Like g_dbus_method_invocation_return_error() but takes a #GError
/// instead of the error domain, error code and message.
/// </para>
/// <para>
/// This method will take ownership of @invocation. See
/// #GDBusInterfaceVTable for more information about the ownership of
/// @invocation.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <param name="error">
/// A #GError.
/// </param>

	public static T ReturnGerror<T>(this T invocation, MentorLake.GLib.GErrorHandle error) where T : GDBusMethodInvocationHandle
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_gerror(invocation, error);
		return invocation;
	}

/// <summary>
/// <para>
/// Finishes handling a D-Bus method call by returning @parameters.
/// If the @parameters GVariant is floating, it is consumed.
/// </para>
/// <para>
/// It is an error if @parameters is not of the right format: it must be a tuple
/// containing the out-parameters of the D-Bus method. Even if the method has a
/// single out-parameter, it must be contained in a tuple. If the method has no
/// out-parameters, @parameters may be %NULL or an empty tuple.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// GDBusMethodInvocation *invocation = some_invocation;
/// g_autofree gchar *result_string = NULL;
/// g_autoptr (GError) error = NULL;
/// </para>
/// <para>
/// result_string = calculate_result (&error);
/// </para>
/// <para>
/// if (error != NULL)
///   g_dbus_method_invocation_return_gerror (invocation, error);
/// else
///   g_dbus_method_invocation_return_value (invocation,
///                                          g_variant_new ("(s)", result_string));
/// </para>
/// <para>
/// // Do not free @invocation here; returning a value does that
/// ]|
/// </para>
/// <para>
/// This method will take ownership of @invocation. See
/// #GDBusInterfaceVTable for more information about the ownership of
/// @invocation.
/// </para>
/// <para>
/// Since 2.48, if the method call requested for a reply not to be sent
/// then this call will sink @parameters and free @invocation, but
/// otherwise do nothing (as per the recommendations of the D-Bus
/// specification).
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <param name="parameters">
/// A #GVariant tuple with out parameters for the method or %NULL if not passing any parameters.
/// </param>

	public static T ReturnValue<T>(this T invocation, MentorLake.GLib.GVariantHandle parameters) where T : GDBusMethodInvocationHandle
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_value(invocation, parameters);
		return invocation;
	}

/// <summary>
/// <para>
/// Like g_dbus_method_invocation_return_value() but also takes a #GUnixFDList.
/// </para>
/// <para>
/// This method is only available on UNIX.
/// </para>
/// <para>
/// This method will take ownership of @invocation. See
/// #GDBusInterfaceVTable for more information about the ownership of
/// @invocation.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <param name="parameters">
/// A #GVariant tuple with out parameters for the method or %NULL if not passing any parameters.
/// </param>
/// <param name="fd_list">
/// A #GUnixFDList or %NULL.
/// </param>

	public static T ReturnValueWithUnixFdList<T>(this T invocation, MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GUnixFDListHandle fd_list) where T : GDBusMethodInvocationHandle
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_value_with_unix_fd_list(invocation, parameters, fd_list);
		return invocation;
	}

/// <summary>
/// <para>
/// Like g_dbus_method_invocation_return_gerror() but takes ownership
/// of @error so the caller does not need to free it.
/// </para>
/// <para>
/// This method will take ownership of @invocation. See
/// #GDBusInterfaceVTable for more information about the ownership of
/// @invocation.
/// </para>
/// </summary>

/// <param name="invocation">
/// A #GDBusMethodInvocation.
/// </param>
/// <param name="error">
/// A #GError.
/// </param>

	public static T TakeError<T>(this T invocation, MentorLake.GLib.GErrorHandle error) where T : GDBusMethodInvocationHandle
	{
		if (invocation.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInvocationHandle)");
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_take_error(invocation, error);
		return invocation;
	}

}

internal class GDBusMethodInvocationHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_method_invocation_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_method_invocation_get_interface_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_method_invocation_get_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusMethodInfoHandle g_dbus_method_invocation_get_method_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_method_invocation_get_method_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_method_invocation_get_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_method_invocation_get_parameters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusPropertyInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusPropertyInfoHandle g_dbus_method_invocation_get_property_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_method_invocation_get_sender([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_dbus_method_invocation_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_dbus_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, string error_name, string error_message);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_error_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, MentorLake.GLib.GQuark domain, int code, string message);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_error_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, MentorLake.GLib.GQuark domain, int code, string format, IntPtr var_args);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_gerror([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_value_with_unix_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_take_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

}
