namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Invoked when the name being watched is known to have to have an owner.
/// </para>
/// </summary>

/// <param name="connection">
/// The #GDBusConnection the name is being watched on.
/// </param>
/// <param name="name">
/// The name being watched.
/// </param>
/// <param name="name_owner">
/// Unique name of the owner of the name being watched.
/// </param>
/// <param name="user_data">
/// User data passed to g_bus_watch_name().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBusNameAppearedCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string name, string name_owner, IntPtr user_data);
