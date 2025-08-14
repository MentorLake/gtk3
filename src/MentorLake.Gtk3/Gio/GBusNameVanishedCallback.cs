namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Invoked when the name being watched is known not to have to have an owner.
/// </para>
/// <para>
/// This is also invoked when the #GDBusConnection on which the watch was
/// established has been closed.  In that case, @connection will be
/// %NULL.
/// </para>
/// </summary>

/// <param name="connection">
/// The #GDBusConnection the name is being watched on, or
///     %NULL.
/// </param>
/// <param name="name">
/// The name being watched.
/// </param>
/// <param name="user_data">
/// User data passed to g_bus_watch_name().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBusNameVanishedCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string name, IntPtr user_data);
