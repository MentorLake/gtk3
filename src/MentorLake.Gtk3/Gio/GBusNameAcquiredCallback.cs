namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Invoked when the name is acquired.
/// </para>
/// </summary>

/// <param name="connection">
/// The #GDBusConnection on which to acquired the name.
/// </param>
/// <param name="name">
/// The name being owned.
/// </param>
/// <param name="user_data">
/// User data passed to g_bus_own_name() or g_bus_own_name_on_connection().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBusNameAcquiredCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string name, IntPtr user_data);
