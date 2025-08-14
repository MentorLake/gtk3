namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The type of the @set_property function in #GDBusInterfaceVTable.
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <param name="sender">
/// The unique bus name of the remote caller or %NULL if
///     not specified by the caller, e.g. on peer-to-peer connections.
/// </param>
/// <param name="object_path">
/// The object path that the method was invoked on.
/// </param>
/// <param name="interface_name">
/// The D-Bus interface name for the property.
/// </param>
/// <param name="property_name">
/// The name of the property to get the value of.
/// </param>
/// <param name="value">
/// The value to set the property to.
/// </param>
/// <param name="error">
/// Return location for error.
/// </param>
/// <param name="user_data">
/// The @user_data #gpointer passed to g_dbus_connection_register_object().
/// </param>
/// <return>
/// %TRUE if the property was set to @value, %FALSE if @error is set.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GDBusInterfaceSetPropertyFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string sender, string object_path, string interface_name, string property_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, IntPtr error, IntPtr user_data);
