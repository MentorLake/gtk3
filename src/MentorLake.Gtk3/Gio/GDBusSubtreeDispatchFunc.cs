namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The type of the @dispatch function in #GDBusSubtreeVTable.
/// </para>
/// <para>
/// Subtrees are flat.  @node, if non-%NULL, is always exactly one
/// segment of the object path (ie: it never contains a slash).
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <param name="sender">
/// The unique bus name of the remote caller.
/// </param>
/// <param name="object_path">
/// The object path that was registered with g_dbus_connection_register_subtree().
/// </param>
/// <param name="interface_name">
/// The D-Bus interface name that the method call or property access is for.
/// </param>
/// <param name="node">
/// A node that is a child of @object_path (relative to @object_path) or %NULL for the root of the subtree.
/// </param>
/// <param name="out_user_data">
/// Return location for user data to pass to functions in the returned #GDBusInterfaceVTable.
/// </param>
/// <param name="user_data">
/// The @user_data #gpointer passed to g_dbus_connection_register_subtree().
/// </param>
/// <return>
/// A #GDBusInterfaceVTable or %NULL if you don&apos;t want to handle the methods.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gio.GDBusInterfaceVTableHandle GDBusSubtreeDispatchFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string sender, string object_path, string interface_name, string node, IntPtr out_user_data, IntPtr user_data);
