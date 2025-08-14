namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The type of the @introspect function in #GDBusSubtreeVTable.
/// </para>
/// <para>
/// Subtrees are flat.  @node, if non-%NULL, is always exactly one
/// segment of the object path (ie: it never contains a slash).
/// </para>
/// <para>
/// This function should return %NULL to indicate that there is no object
/// at this node.
/// </para>
/// <para>
/// If this function returns non-%NULL, the return value is expected to
/// be a %NULL-terminated array of pointers to #GDBusInterfaceInfo
/// structures describing the interfaces implemented by @node.  This
/// array will have g_dbus_interface_info_unref() called on each item
/// before being freed with g_free().
/// </para>
/// <para>
/// The difference between returning %NULL and an array containing zero
/// items is that the standard DBus interfaces will returned to the
/// remote introspector in the empty array case, but not in the %NULL
/// case.
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
/// <param name="node">
/// A node that is a child of @object_path (relative to @object_path) or %NULL for the root of the subtree.
/// </param>
/// <param name="user_data">
/// The @user_data #gpointer passed to g_dbus_connection_register_subtree().
/// </param>
/// <return>
/// A %NULL-terminated array of pointers to #GDBusInterfaceInfo, or %NULL.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gio.GDBusInterfaceInfoHandle[] GDBusSubtreeIntrospectFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string sender, string object_path, string node, IntPtr user_data);
