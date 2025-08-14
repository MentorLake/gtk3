namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Invoked when the name is lost or @connection has been closed.
/// </para>
/// </summary>

/// <param name="connection">
/// The #GDBusConnection on which to acquire the name or %NULL if
/// the connection was disconnected.
/// </param>
/// <param name="name">
/// The name being owned.
/// </param>
/// <param name="user_data">
/// User data passed to g_bus_own_name() or g_bus_own_name_on_connection().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBusNameLostCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string name, IntPtr user_data);
