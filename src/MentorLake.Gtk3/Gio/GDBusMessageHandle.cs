namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A type for representing D-Bus messages that can be sent or received
/// on a [class@Gio.DBusConnection].
/// </para>
/// </summary>

public class GDBusMessageHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new empty #GDBusMessage.
/// </para>
/// </summary>

/// <return>
/// A #GDBusMessage. Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusMessageHandle New()
	{
		return GDBusMessageHandleExterns.g_dbus_message_new();
	}

/// <summary>
/// <para>
/// Creates a new #GDBusMessage from the data stored at @blob. The byte
/// order that the message was in can be retrieved using
/// g_dbus_message_get_byte_order().
/// </para>
/// <para>
/// If the @blob cannot be parsed, contains invalid fields, or contains invalid
/// headers, %G_IO_ERROR_INVALID_ARGUMENT will be returned.
/// </para>
/// </summary>

/// <param name="blob">
/// A blob representing a binary D-Bus message.
/// </param>
/// <param name="blob_len">
/// The length of @blob.
/// </param>
/// <param name="capabilities">
/// A #GDBusCapabilityFlags describing what protocol features are supported.
/// </param>
/// <return>
/// A new #GDBusMessage or %NULL if @error is set. Free with
/// g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusMessageHandle NewFromBlob(byte[] blob, UIntPtr blob_len, MentorLake.Gio.GDBusCapabilityFlags capabilities)
	{
		var externCallResult = GDBusMessageHandleExterns.g_dbus_message_new_from_blob(blob, blob_len, capabilities, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new #GDBusMessage for a method call.
/// </para>
/// </summary>

/// <param name="name">
/// A valid D-Bus name or %NULL.
/// </param>
/// <param name="path">
/// A valid object path.
/// </param>
/// <param name="interface_">
/// A valid D-Bus interface name or %NULL.
/// </param>
/// <param name="method">
/// A valid method name.
/// </param>
/// <return>
/// A #GDBusMessage. Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusMessageHandle NewMethodCall(string name, string path, string interface_, string method)
	{
		return GDBusMessageHandleExterns.g_dbus_message_new_method_call(name, path, interface_, method);
	}

/// <summary>
/// <para>
/// Creates a new #GDBusMessage for a signal emission.
/// </para>
/// </summary>

/// <param name="path">
/// A valid object path.
/// </param>
/// <param name="interface_">
/// A valid D-Bus interface name.
/// </param>
/// <param name="signal">
/// A valid signal name.
/// </param>
/// <return>
/// A #GDBusMessage. Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusMessageHandle NewSignal(string path, string interface_, string signal)
	{
		return GDBusMessageHandleExterns.g_dbus_message_new_signal(path, interface_, signal);
	}

/// <summary>
/// <para>
/// Utility function to calculate how many bytes are needed to
/// completely deserialize the D-Bus message stored at @blob.
/// </para>
/// </summary>

/// <param name="blob">
/// A blob representing a binary D-Bus message.
/// </param>
/// <param name="blob_len">
/// The length of @blob (must be at least 16).
/// </param>
/// <return>
/// Number of bytes needed or -1 if @error is set (e.g. if
/// @blob contains invalid data or not enough data is available to
/// determine the size).
/// </return>

	public static UIntPtr BytesNeeded(byte[] blob, UIntPtr blob_len)
	{
		var externCallResult = GDBusMessageHandleExterns.g_dbus_message_bytes_needed(blob, blob_len, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GDBusMessageHandleExtensions
{
/// <summary>
/// <para>
/// Copies @message. The copy is a deep copy and the returned
/// #GDBusMessage is completely identical except that it is guaranteed
/// to not be locked.
/// </para>
/// <para>
/// This operation can fail if e.g. @message contains file descriptors
/// and the per-process or system-wide open files limit is reached.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// A new #GDBusMessage or %NULL if @error is set.
///     Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusMessageHandle Copy(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		var externCallResult = GDBusMessageHandleExterns.g_dbus_message_copy(message, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Convenience to get the first item in the body of @message.
/// </para>
/// <para>
/// See [method@Gio.DBusMessage.get_arg0_path] for returning object-path-typed
/// arg0 values.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// The string item or %NULL if the first item in the body of
/// @message is not a string.
/// </return>

	public static string GetArg0(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_arg0(message);
	}

/// <summary>
/// <para>
/// Convenience to get the first item in the body of @message.
/// </para>
/// <para>
/// See [method@Gio.DBusMessage.get_arg0] for returning string-typed arg0 values.
/// </para>
/// </summary>

/// <param name="message">
/// A `GDBusMessage`.
/// </param>
/// <return>
/// The object path item or `NULL` if the first item in the
///   body of @message is not an object path.
/// </return>

	public static string GetArg0Path(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_arg0_path(message);
	}

/// <summary>
/// <para>
/// Gets the body of a message.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// A #GVariant or %NULL if the body is
/// empty. Do not free, it is owned by @message.
/// </return>

	public static MentorLake.GLib.GVariantHandle GetBody(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_body(message);
	}

/// <summary>
/// <para>
/// Gets the byte order of @message.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// The byte order.
/// </return>

	public static MentorLake.Gio.GDBusMessageByteOrder GetByteOrder(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_byte_order(message);
	}

/// <summary>
/// <para>
/// Convenience getter for the %G_DBUS_MESSAGE_HEADER_FIELD_DESTINATION header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// The value.
/// </return>

	public static string GetDestination(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_destination(message);
	}

/// <summary>
/// <para>
/// Convenience getter for the %G_DBUS_MESSAGE_HEADER_FIELD_ERROR_NAME header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// The value.
/// </return>

	public static string GetErrorName(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_error_name(message);
	}

/// <summary>
/// <para>
/// Gets the flags for @message.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// Flags that are set (typically values from the #GDBusMessageFlags enumeration bitwise ORed together).
/// </return>

	public static MentorLake.Gio.GDBusMessageFlags GetFlags(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_flags(message);
	}

/// <summary>
/// <para>
/// Gets a header field on @message.
/// </para>
/// <para>
/// The caller is responsible for checking the type of the returned #GVariant
/// matches what is expected.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="header_field">
/// A 8-bit unsigned integer (typically a value from the #GDBusMessageHeaderField enumeration)
/// </param>
/// <return>
/// A #GVariant with the value if the header was found, %NULL
/// otherwise. Do not free, it is owned by @message.
/// </return>

	public static MentorLake.GLib.GVariantHandle GetHeader(this MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusMessageHeaderField header_field)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_header(message, header_field);
	}

/// <summary>
/// <para>
/// Gets an array of all header fields on @message that are set.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// An array of header fields
/// terminated by %G_DBUS_MESSAGE_HEADER_FIELD_INVALID.  Each element
/// is a #guchar. Free with g_free().
/// </return>

	public static byte[] GetHeaderFields(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_header_fields(message);
	}

/// <summary>
/// <para>
/// Convenience getter for the %G_DBUS_MESSAGE_HEADER_FIELD_INTERFACE header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// The value.
/// </return>

	public static string GetInterface(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_interface(message);
	}

/// <summary>
/// <para>
/// Checks whether @message is locked. To monitor changes to this
/// value, conncet to the #GObject::notify signal to listen for changes
/// on the #GDBusMessage:locked property.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// %TRUE if @message is locked, %FALSE otherwise.
/// </return>

	public static bool GetLocked(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_locked(message);
	}

/// <summary>
/// <para>
/// Convenience getter for the %G_DBUS_MESSAGE_HEADER_FIELD_MEMBER header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// The value.
/// </return>

	public static string GetMember(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_member(message);
	}

/// <summary>
/// <para>
/// Gets the type of @message.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// A 8-bit unsigned integer (typically a value from the #GDBusMessageType enumeration).
/// </return>

	public static MentorLake.Gio.GDBusMessageType GetMessageType(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_message_type(message);
	}

/// <summary>
/// <para>
/// Convenience getter for the %G_DBUS_MESSAGE_HEADER_FIELD_NUM_UNIX_FDS header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// The value.
/// </return>

	public static uint GetNumUnixFds(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_num_unix_fds(message);
	}

/// <summary>
/// <para>
/// Convenience getter for the %G_DBUS_MESSAGE_HEADER_FIELD_PATH header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// The value.
/// </return>

	public static string GetPath(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_path(message);
	}

/// <summary>
/// <para>
/// Convenience getter for the %G_DBUS_MESSAGE_HEADER_FIELD_REPLY_SERIAL header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// The value.
/// </return>

	public static uint GetReplySerial(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_reply_serial(message);
	}

/// <summary>
/// <para>
/// Convenience getter for the %G_DBUS_MESSAGE_HEADER_FIELD_SENDER header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// The value.
/// </return>

	public static string GetSender(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_sender(message);
	}

/// <summary>
/// <para>
/// Gets the serial for @message.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// A #guint32.
/// </return>

	public static uint GetSerial(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_serial(message);
	}

/// <summary>
/// <para>
/// Convenience getter for the %G_DBUS_MESSAGE_HEADER_FIELD_SIGNATURE header field.
/// </para>
/// <para>
/// This will always be non-%NULL, but may be an empty string.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// The value.
/// </return>

	public static string GetSignature(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_signature(message);
	}

/// <summary>
/// <para>
/// Gets the UNIX file descriptors associated with @message, if any.
/// </para>
/// <para>
/// This method is only available on UNIX.
/// </para>
/// <para>
/// The file descriptors normally correspond to %G_VARIANT_TYPE_HANDLE
/// values in the body of the message. For example,
/// if g_variant_get_handle() returns 5, that is intended to be a reference
/// to the file descriptor that can be accessed by
/// `g_unix_fd_list_get (list, 5, ...)`.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// A #GUnixFDList or %NULL if no file descriptors are
/// associated. Do not free, this object is owned by @message.
/// </return>

	public static MentorLake.Gio.GUnixFDListHandle GetUnixFdList(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_unix_fd_list(message);
	}

/// <summary>
/// <para>
/// If @message is locked, does nothing. Otherwise locks the message.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>

	public static T Lock<T>(this T message) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_lock(message);
		return message;
	}

/// <summary>
/// <para>
/// Creates a new #GDBusMessage that is an error reply to @method_call_message.
/// </para>
/// </summary>

/// <param name="method_call_message">
/// A message of type %G_DBUS_MESSAGE_TYPE_METHOD_CALL to
/// create a reply message to.
/// </param>
/// <param name="error_name">
/// A valid D-Bus error name.
/// </param>
/// <param name="error_message_format">
/// The D-Bus error message in a printf() format.
/// </param>
/// <param name="@__arglist">
/// Arguments for @error_message_format.
/// </param>
/// <return>
/// A #GDBusMessage. Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusMessageHandle NewMethodError(this MentorLake.Gio.GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr @__arglist)
	{
		if (method_call_message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_new_method_error(method_call_message, error_name, error_message_format, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a new #GDBusMessage that is an error reply to @method_call_message.
/// </para>
/// </summary>

/// <param name="method_call_message">
/// A message of type %G_DBUS_MESSAGE_TYPE_METHOD_CALL to
/// create a reply message to.
/// </param>
/// <param name="error_name">
/// A valid D-Bus error name.
/// </param>
/// <param name="error_message">
/// The D-Bus error message.
/// </param>
/// <return>
/// A #GDBusMessage. Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusMessageHandle NewMethodErrorLiteral(this MentorLake.Gio.GDBusMessageHandle method_call_message, string error_name, string error_message)
	{
		if (method_call_message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_new_method_error_literal(method_call_message, error_name, error_message);
	}

/// <summary>
/// <para>
/// Like g_dbus_message_new_method_error() but intended for language bindings.
/// </para>
/// </summary>

/// <param name="method_call_message">
/// A message of type %G_DBUS_MESSAGE_TYPE_METHOD_CALL to
/// create a reply message to.
/// </param>
/// <param name="error_name">
/// A valid D-Bus error name.
/// </param>
/// <param name="error_message_format">
/// The D-Bus error message in a printf() format.
/// </param>
/// <param name="var_args">
/// Arguments for @error_message_format.
/// </param>
/// <return>
/// A #GDBusMessage. Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusMessageHandle NewMethodErrorValist(this MentorLake.Gio.GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr var_args)
	{
		if (method_call_message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_new_method_error_valist(method_call_message, error_name, error_message_format, var_args);
	}

/// <summary>
/// <para>
/// Creates a new #GDBusMessage that is a reply to @method_call_message.
/// </para>
/// </summary>

/// <param name="method_call_message">
/// A message of type %G_DBUS_MESSAGE_TYPE_METHOD_CALL to
/// create a reply message to.
/// </param>
/// <return>
/// #GDBusMessage. Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusMessageHandle NewMethodReply(this MentorLake.Gio.GDBusMessageHandle method_call_message)
	{
		if (method_call_message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_new_method_reply(method_call_message);
	}

/// <summary>
/// <para>
/// Produces a human-readable multi-line description of @message.
/// </para>
/// <para>
/// The contents of the description has no ABI guarantees, the contents
/// and formatting is subject to change at any time. Typical output
/// looks something like this:
/// ```
/// Flags:   none
/// Version: 0
/// Serial:  4
/// Headers:
///   path -> objectpath '/org/gtk/GDBus/TestObject'
///   interface -> 'org.gtk.GDBus.TestInterface'
///   member -> 'GimmeStdout'
///   destination -> ':1.146'
/// Body: ()
/// UNIX File Descriptors:
///   (none)
/// ```
/// or
/// ```
/// Flags:   no-reply-expected
/// Version: 0
/// Serial:  477
/// Headers:
///   reply-serial -> uint32 4
///   destination -> ':1.159'
///   sender -> ':1.146'
///   num-unix-fds -> uint32 1
/// Body: ()
/// UNIX File Descriptors:
///   fd 12: dev=0:10,mode=020620,ino=5,uid=500,gid=5,rdev=136:2,size=0,atime=1273085037,mtime=1273085851,ctime=1272982635
/// ```
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="indent">
/// Indentation level.
/// </param>
/// <return>
/// A string that should be freed with [func@GLib.free].
/// </return>

	public static string Print(this MentorLake.Gio.GDBusMessageHandle message, uint indent)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_print(message, indent);
	}

/// <summary>
/// <para>
/// Sets the body @message. As a side-effect the
/// %G_DBUS_MESSAGE_HEADER_FIELD_SIGNATURE header field is set to the
/// type string of @body (or cleared if @body is %NULL).
/// </para>
/// <para>
/// If @body is floating, @message assumes ownership of @body.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="body">
/// Either %NULL or a #GVariant that is a tuple.
/// </param>

	public static T SetBody<T>(this T message, MentorLake.GLib.GVariantHandle body) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_body(message, body);
		return message;
	}

/// <summary>
/// <para>
/// Sets the byte order of @message.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="byte_order">
/// The byte order.
/// </param>

	public static T SetByteOrder<T>(this T message, MentorLake.Gio.GDBusMessageByteOrder byte_order) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_byte_order(message, byte_order);
		return message;
	}

/// <summary>
/// <para>
/// Convenience setter for the %G_DBUS_MESSAGE_HEADER_FIELD_DESTINATION header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="value">
/// The value to set.
/// </param>

	public static T SetDestination<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_destination(message, value);
		return message;
	}

/// <summary>
/// <para>
/// Convenience setter for the %G_DBUS_MESSAGE_HEADER_FIELD_ERROR_NAME header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="value">
/// The value to set.
/// </param>

	public static T SetErrorName<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_error_name(message, value);
		return message;
	}

/// <summary>
/// <para>
/// Sets the flags to set on @message.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="flags">
/// Flags for @message that are set (typically values from the #GDBusMessageFlags
/// enumeration bitwise ORed together).
/// </param>

	public static T SetFlags<T>(this T message, MentorLake.Gio.GDBusMessageFlags flags) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_flags(message, flags);
		return message;
	}

/// <summary>
/// <para>
/// Sets a header field on @message.
/// </para>
/// <para>
/// If @value is floating, @message assumes ownership of @value.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="header_field">
/// A 8-bit unsigned integer (typically a value from the #GDBusMessageHeaderField enumeration)
/// </param>
/// <param name="value">
/// A #GVariant to set the header field or %NULL to clear the header field.
/// </param>

	public static T SetHeader<T>(this T message, MentorLake.Gio.GDBusMessageHeaderField header_field, MentorLake.GLib.GVariantHandle value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_header(message, header_field, value);
		return message;
	}

/// <summary>
/// <para>
/// Convenience setter for the %G_DBUS_MESSAGE_HEADER_FIELD_INTERFACE header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="value">
/// The value to set.
/// </param>

	public static T SetInterface<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_interface(message, value);
		return message;
	}

/// <summary>
/// <para>
/// Convenience setter for the %G_DBUS_MESSAGE_HEADER_FIELD_MEMBER header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="value">
/// The value to set.
/// </param>

	public static T SetMember<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_member(message, value);
		return message;
	}

/// <summary>
/// <para>
/// Sets @message to be of @type.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="type">
/// A 8-bit unsigned integer (typically a value from the #GDBusMessageType enumeration).
/// </param>

	public static T SetMessageType<T>(this T message, MentorLake.Gio.GDBusMessageType type) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_message_type(message, type);
		return message;
	}

/// <summary>
/// <para>
/// Convenience setter for the %G_DBUS_MESSAGE_HEADER_FIELD_NUM_UNIX_FDS header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="value">
/// The value to set.
/// </param>

	public static T SetNumUnixFds<T>(this T message, uint value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_num_unix_fds(message, value);
		return message;
	}

/// <summary>
/// <para>
/// Convenience setter for the %G_DBUS_MESSAGE_HEADER_FIELD_PATH header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="value">
/// The value to set.
/// </param>

	public static T SetPath<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_path(message, value);
		return message;
	}

/// <summary>
/// <para>
/// Convenience setter for the %G_DBUS_MESSAGE_HEADER_FIELD_REPLY_SERIAL header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="value">
/// The value to set.
/// </param>

	public static T SetReplySerial<T>(this T message, uint value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_reply_serial(message, value);
		return message;
	}

/// <summary>
/// <para>
/// Convenience setter for the %G_DBUS_MESSAGE_HEADER_FIELD_SENDER header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="value">
/// The value to set.
/// </param>

	public static T SetSender<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_sender(message, value);
		return message;
	}

/// <summary>
/// <para>
/// Sets the serial for @message.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="serial">
/// A #guint32.
/// </param>

	public static T SetSerial<T>(this T message, uint serial) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_serial(message, serial);
		return message;
	}

/// <summary>
/// <para>
/// Convenience setter for the %G_DBUS_MESSAGE_HEADER_FIELD_SIGNATURE header field.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="value">
/// The value to set.
/// </param>

	public static T SetSignature<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_signature(message, value);
		return message;
	}

/// <summary>
/// <para>
/// Sets the UNIX file descriptors associated with @message. As a
/// side-effect the %G_DBUS_MESSAGE_HEADER_FIELD_NUM_UNIX_FDS header
/// field is set to the number of fds in @fd_list (or cleared if
/// @fd_list is %NULL).
/// </para>
/// <para>
/// This method is only available on UNIX.
/// </para>
/// <para>
/// When designing D-Bus APIs that are intended to be interoperable,
/// please note that non-GDBus implementations of D-Bus can usually only
/// access file descriptors if they are referenced by a value of type
/// %G_VARIANT_TYPE_HANDLE in the body of the message.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="fd_list">
/// A #GUnixFDList or %NULL.
/// </param>

	public static T SetUnixFdList<T>(this T message, MentorLake.Gio.GUnixFDListHandle fd_list) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_unix_fd_list(message, fd_list);
		return message;
	}

/// <summary>
/// <para>
/// Serializes @message to a blob. The byte order returned by
/// g_dbus_message_get_byte_order() will be used.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <param name="out_size">
/// Return location for size of generated blob.
/// </param>
/// <param name="capabilities">
/// A #GDBusCapabilityFlags describing what protocol features are supported.
/// </param>
/// <return>
/// A pointer to a
/// valid binary D-Bus message of @out_size bytes generated by @message
/// or %NULL if @error is set. Free with g_free().
/// </return>

	public static byte[] ToBlob(this MentorLake.Gio.GDBusMessageHandle message, out UIntPtr out_size, MentorLake.Gio.GDBusCapabilityFlags capabilities)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		var externCallResult = GDBusMessageHandleExterns.g_dbus_message_to_blob(message, out out_size, capabilities, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// If @message is not of type %G_DBUS_MESSAGE_TYPE_ERROR does
/// nothing and returns %FALSE.
/// </para>
/// <para>
/// Otherwise this method encodes the error in @message as a #GError
/// using g_dbus_error_set_dbus_error() using the information in the
/// %G_DBUS_MESSAGE_HEADER_FIELD_ERROR_NAME header field of @message as
/// well as the first string item in @message's body.
/// </para>
/// </summary>

/// <param name="message">
/// A #GDBusMessage.
/// </param>
/// <return>
/// %TRUE if @error was set, %FALSE otherwise.
/// </return>

	public static bool ToGerror(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		var externCallResult = GDBusMessageHandleExterns.g_dbus_message_to_gerror(message, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GDBusMessageHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_message_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_message_new_from_blob(byte[] blob, UIntPtr blob_len, MentorLake.Gio.GDBusCapabilityFlags capabilities, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_message_new_method_call(string name, string path, string interface_, string method);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_message_new_signal(string path, string interface_, string signal);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_message_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_message_get_arg0([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_message_get_arg0_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_message_get_body([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusMessageByteOrder g_dbus_message_get_byte_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_message_get_destination([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_message_get_error_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusMessageFlags g_dbus_message_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_message_get_header([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusMessageHeaderField header_field);

	[DllImport(GioLibrary.Name)]
	internal static extern byte[] g_dbus_message_get_header_fields([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_message_get_interface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_message_get_locked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_message_get_member([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusMessageType g_dbus_message_get_message_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_message_get_num_unix_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_message_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_message_get_reply_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_message_get_sender([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_message_get_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_message_get_signature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))]
	internal static extern MentorLake.Gio.GUnixFDListHandle g_dbus_message_get_unix_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_message_new_method_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_message_new_method_error_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle method_call_message, string error_name, string error_message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_message_new_method_error_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr var_args);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_message_new_method_reply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle method_call_message);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_message_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, uint indent);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_body([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle body);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_byte_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusMessageByteOrder byte_order);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_destination([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, string value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_error_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, string value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusMessageFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_header([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusMessageHeaderField header_field, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_interface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, string value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_member([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, string value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_message_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusMessageType type);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_num_unix_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, uint value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, string value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_reply_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, uint value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_sender([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, string value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, uint serial);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_signature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, string value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_message_set_unix_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list);

	[DllImport(GioLibrary.Name)]
	internal static extern byte[] g_dbus_message_to_blob([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, out UIntPtr out_size, MentorLake.Gio.GDBusCapabilityFlags capabilities, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_message_to_gerror([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_dbus_message_bytes_needed(byte[] blob, UIntPtr blob_len, out MentorLake.GLib.GErrorHandle error);

}
