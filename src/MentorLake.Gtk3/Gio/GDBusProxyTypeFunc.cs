namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Function signature for a function used to determine the #GType to
/// use for an interface proxy (if @interface_name is not %NULL) or
/// object proxy (if @interface_name is %NULL).
/// </para>
/// <para>
/// This function is called in the
/// [thread-default main loop][g-main-context-push-thread-default]
/// that @manager was constructed in.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManagerClient.
/// </param>
/// <param name="object_path">
/// The object path of the remote object.
/// </param>
/// <param name="interface_name">
/// The interface name of the remote object or %NULL if a #GDBusObjectProxy #GType is requested.
/// </param>
/// <param name="data">
/// data passed in by the user.
/// </param>
/// <return>
/// A #GType to use for the remote object. The returned type
///   must be a #GDBusProxy or #GDBusObjectProxy -derived
///   type.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.GObject.GType GDBusProxyTypeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle manager, string object_path, string interface_name, IntPtr data);
