namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Signature for callback function used in g_dbus_connection_signal_subscribe().
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <param name="sender_name">
/// The unique bus name of the sender of the signal,
///    or %NULL on a peer-to-peer D-Bus connection.
/// </param>
/// <param name="object_path">
/// The object path that the signal was emitted on.
/// </param>
/// <param name="interface_name">
/// The name of the interface.
/// </param>
/// <param name="signal_name">
/// The name of the signal.
/// </param>
/// <param name="parameters">
/// A #GVariant tuple with parameters for the signal.
/// </param>
/// <param name="user_data">
/// User data passed when subscribing to the signal.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDBusSignalCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string sender_name, string object_path, string interface_name, string signal_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, IntPtr user_data);
