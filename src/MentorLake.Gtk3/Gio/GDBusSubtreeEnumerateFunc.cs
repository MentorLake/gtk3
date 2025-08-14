namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The type of the @enumerate function in #GDBusSubtreeVTable.
/// </para>
/// <para>
/// This function is called when generating introspection data and also
/// when preparing to dispatch incoming messages in the event that the
/// %G_DBUS_SUBTREE_FLAGS_DISPATCH_TO_UNENUMERATED_NODES flag is not
/// specified (ie: to verify that the object path is valid).
/// </para>
/// <para>
/// Hierarchies are not supported; the items that you return should not
/// contain the `/` character.
/// </para>
/// <para>
/// The return value will be freed with g_strfreev().
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
/// <param name="user_data">
/// The @user_data #gpointer passed to g_dbus_connection_register_subtree().
/// </param>
/// <return>
/// A newly allocated array of strings for node names that are children of @object_path.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string[] GDBusSubtreeEnumerateFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string sender, string object_path, IntPtr user_data);
