namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The type of the @method_call function in #GDBusInterfaceVTable.
/// </para>
/// <para>
/// @interface_name may be `NULL` if not specified by the sender, although it’s
/// encouraged for the sender to set it. If unset, and the object has only one
/// method (across all interfaces) matching @method_name, that method is invoked.
/// Otherwise, behaviour is implementation defined. See the
/// [D-Bus specification](https://dbus.freedesktop.org/doc/dbus-specification.html#message-protocol-types-method).
/// It is recommended to return [error@Gio.DBusError.UNKNOWN_METHOD].
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <param name="sender">
/// The unique bus name of the remote caller, or `NULL` if
///     not specified by the caller, e.g. on peer-to-peer connections.
/// </param>
/// <param name="object_path">
/// The object path that the method was invoked on.
/// </param>
/// <param name="interface_name">
/// The D-Bus interface name the method was invoked on,
///     or `NULL` if not specified by the sender.
/// </param>
/// <param name="method_name">
/// The name of the method that was invoked.
/// </param>
/// <param name="parameters">
/// A #GVariant tuple with parameters.
/// </param>
/// <param name="invocation">
/// A #GDBusMethodInvocation object that must be used to return a value or error.
/// </param>
/// <param name="user_data">
/// The @user_data #gpointer passed to g_dbus_connection_register_object().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDBusInterfaceMethodCallFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string sender, string object_path, string interface_name, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, IntPtr user_data);
