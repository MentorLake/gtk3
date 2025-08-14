namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Signature for function used in g_dbus_connection_add_filter().
/// </para>
/// <para>
/// A filter function is passed a #GDBusMessage and expected to return
/// a #GDBusMessage too. Passive filter functions that don't modify the
/// message can simply return the @message object:
/// |[
/// static GDBusMessage *
/// passive_filter (GDBusConnection *connection
///                 GDBusMessage    *message,
///                 gboolean         incoming,
///                 gpointer         user_data)
/// {
///   // inspect @message
///   return message;
/// }
/// ]|
/// Filter functions that wants to drop a message can simply return %NULL:
/// |[
/// static GDBusMessage *
/// drop_filter (GDBusConnection *connection
///              GDBusMessage    *message,
///              gboolean         incoming,
///              gpointer         user_data)
/// {
///   if (should_drop_message)
///     {
///       g_object_unref (message);
///       message = NULL;
///     }
///   return message;
/// }
/// ]|
/// Finally, a filter function may modify a message by copying it:
/// |[
/// static GDBusMessage *
/// modifying_filter (GDBusConnection *connection
///                   GDBusMessage    *message,
///                   gboolean         incoming,
///                   gpointer         user_data)
/// {
///   GDBusMessage *copy;
///   GError *error;
/// </para>
/// <para>
///   error = NULL;
///   copy = g_dbus_message_copy (message, &error);
///   // handle @error being set
///   g_object_unref (message);
/// </para>
/// <para>
///   // modify @copy
/// </para>
/// <para>
///   return copy;
/// }
/// ]|
/// If the returned #GDBusMessage is different from @message and cannot
/// be sent on @connection (it could use features, such as file
/// descriptors, not compatible with @connection), then a warning is
/// logged to standard error. Applications can
/// check this ahead of time using g_dbus_message_to_blob() passing a
/// #GDBusCapabilityFlags value obtained from @connection.
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <param name="message">
/// A locked #GDBusMessage that the filter function takes ownership of.
/// </param>
/// <param name="incoming">
/// %TRUE if it is a message received from the other peer, %FALSE if it is
/// a message to be sent to the other peer.
/// </param>
/// <param name="user_data">
/// User data passed when adding the filter.
/// </param>
/// <return>
/// A #GDBusMessage that will be freed with
/// g_object_unref() or %NULL to drop the message. Passive filter
/// functions can simply return the passed @message object.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gio.GDBusMessageHandle GDBusMessageFilterFunction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, bool incoming, IntPtr user_data);
