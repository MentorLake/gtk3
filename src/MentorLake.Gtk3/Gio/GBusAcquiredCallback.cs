namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Invoked when a connection to a message bus has been obtained.
/// </para>
/// </summary>

/// <param name="connection">
/// The #GDBusConnection to a message bus.
/// </param>
/// <param name="name">
/// The name that is requested to be owned.
/// </param>
/// <param name="user_data">
/// User data passed to g_bus_own_name().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBusAcquiredCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string name, IntPtr user_data);
