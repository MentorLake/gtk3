namespace MentorLake.Gtk3.Gio;

public class GDBusMessageHandle : GObjectHandle
{
	public static GDBusMessageHandle GDbusMessageNew()
	{
		return GDBusMessageExterns.g_dbus_message_new();
	}

	public static GDBusMessageHandle GDbusMessageNewFromBlob(string blob, UIntPtr blob_len, GDBusCapabilityFlags capabilities, out GErrorHandle error)
	{
		return GDBusMessageExterns.g_dbus_message_new_from_blob(blob, blob_len, capabilities, out error);
	}

	public static GDBusMessageHandle GDbusMessageNewMethodCall(string name, string path, string interface_, string method)
	{
		return GDBusMessageExterns.g_dbus_message_new_method_call(name, path, interface_, method);
	}

	public static GDBusMessageHandle GDbusMessageNewSignal(string path, string interface_, string signal)
	{
		return GDBusMessageExterns.g_dbus_message_new_signal(path, interface_, signal);
	}

	public static UIntPtr GDbusMessageBytesNeeded(string blob, UIntPtr blob_len, out GErrorHandle error)
	{
		return GDBusMessageExterns.g_dbus_message_bytes_needed(blob, blob_len, out error);
	}

}

public static class GDBusMessageHandleExtensions
{
	public static GDBusMessageHandle GDbusMessageCopy(this GDBusMessageHandle message, out GErrorHandle error)
	{
		return GDBusMessageExterns.g_dbus_message_copy(message, out error);
	}

	public static string GDbusMessageGetArg0(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_arg0(message);
	}

	public static string GDbusMessageGetArg0Path(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_arg0_path(message);
	}

	public static GVariantHandle GDbusMessageGetBody(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_body(message);
	}

	public static GDBusMessageByteOrder GDbusMessageGetByteOrder(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_byte_order(message);
	}

	public static string GDbusMessageGetDestination(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_destination(message);
	}

	public static string GDbusMessageGetErrorName(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_error_name(message);
	}

	public static GDBusMessageFlags GDbusMessageGetFlags(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_flags(message);
	}

	public static GVariantHandle GDbusMessageGetHeader(this GDBusMessageHandle message, GDBusMessageHeaderField header_field)
	{
		return GDBusMessageExterns.g_dbus_message_get_header(message, header_field);
	}

	public static IntPtr GDbusMessageGetHeaderFields(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_header_fields(message);
	}

	public static string GDbusMessageGetInterface(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_interface(message);
	}

	public static bool GDbusMessageGetLocked(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_locked(message);
	}

	public static string GDbusMessageGetMember(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_member(message);
	}

	public static GDBusMessageType GDbusMessageGetMessageType(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_message_type(message);
	}

	public static uint GDbusMessageGetNumUnixFds(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_num_unix_fds(message);
	}

	public static string GDbusMessageGetPath(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_path(message);
	}

	public static uint GDbusMessageGetReplySerial(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_reply_serial(message);
	}

	public static string GDbusMessageGetSender(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_sender(message);
	}

	public static uint GDbusMessageGetSerial(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_serial(message);
	}

	public static string GDbusMessageGetSignature(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_signature(message);
	}

	public static GUnixFDListHandle GDbusMessageGetUnixFdList(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_unix_fd_list(message);
	}

	public static T GDbusMessageLock<T>(this T message) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_lock(message);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageNewMethodError(this GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr @__arglist)
	{
		return GDBusMessageExterns.g_dbus_message_new_method_error(method_call_message, error_name, error_message_format, @__arglist);
	}

	public static GDBusMessageHandle GDbusMessageNewMethodErrorLiteral(this GDBusMessageHandle method_call_message, string error_name, string error_message)
	{
		return GDBusMessageExterns.g_dbus_message_new_method_error_literal(method_call_message, error_name, error_message);
	}

	public static GDBusMessageHandle GDbusMessageNewMethodErrorValist(this GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr var_args)
	{
		return GDBusMessageExterns.g_dbus_message_new_method_error_valist(method_call_message, error_name, error_message_format, var_args);
	}

	public static GDBusMessageHandle GDbusMessageNewMethodReply(this GDBusMessageHandle method_call_message)
	{
		return GDBusMessageExterns.g_dbus_message_new_method_reply(method_call_message);
	}

	public static string GDbusMessagePrint(this GDBusMessageHandle message, uint indent)
	{
		return GDBusMessageExterns.g_dbus_message_print(message, indent);
	}

	public static T GDbusMessageSetBody<T>(this T message, GVariantHandle body) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_body(message, body);
		return message;
	}

	public static T GDbusMessageSetByteOrder<T>(this T message, GDBusMessageByteOrder byte_order) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_byte_order(message, byte_order);
		return message;
	}

	public static T GDbusMessageSetDestination<T>(this T message, string value) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_destination(message, value);
		return message;
	}

	public static T GDbusMessageSetErrorName<T>(this T message, string value) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_error_name(message, value);
		return message;
	}

	public static T GDbusMessageSetFlags<T>(this T message, GDBusMessageFlags flags) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_flags(message, flags);
		return message;
	}

	public static T GDbusMessageSetHeader<T>(this T message, GDBusMessageHeaderField header_field, GVariantHandle value) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_header(message, header_field, value);
		return message;
	}

	public static T GDbusMessageSetInterface<T>(this T message, string value) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_interface(message, value);
		return message;
	}

	public static T GDbusMessageSetMember<T>(this T message, string value) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_member(message, value);
		return message;
	}

	public static T GDbusMessageSetMessageType<T>(this T message, GDBusMessageType type) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_message_type(message, type);
		return message;
	}

	public static T GDbusMessageSetNumUnixFds<T>(this T message, uint value) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_num_unix_fds(message, value);
		return message;
	}

	public static T GDbusMessageSetPath<T>(this T message, string value) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_path(message, value);
		return message;
	}

	public static T GDbusMessageSetReplySerial<T>(this T message, uint value) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_reply_serial(message, value);
		return message;
	}

	public static T GDbusMessageSetSender<T>(this T message, string value) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_sender(message, value);
		return message;
	}

	public static T GDbusMessageSetSerial<T>(this T message, uint serial) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_serial(message, serial);
		return message;
	}

	public static T GDbusMessageSetSignature<T>(this T message, string value) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_signature(message, value);
		return message;
	}

	public static T GDbusMessageSetUnixFdList<T>(this T message, GUnixFDListHandle fd_list) where T : GDBusMessageHandle
	{
		GDBusMessageExterns.g_dbus_message_set_unix_fd_list(message, fd_list);
		return message;
	}

	public static IntPtr GDbusMessageToBlob(this GDBusMessageHandle message, out UIntPtr out_size, GDBusCapabilityFlags capabilities, out GErrorHandle error)
	{
		return GDBusMessageExterns.g_dbus_message_to_blob(message, out out_size, capabilities, out error);
	}

	public static bool GDbusMessageToGerror(this GDBusMessageHandle message, out GErrorHandle error)
	{
		return GDBusMessageExterns.g_dbus_message_to_gerror(message, out error);
	}

}

internal class GDBusMessageExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new();

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_from_blob(string blob, UIntPtr blob_len, GDBusCapabilityFlags capabilities, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_method_call(string name, string path, string interface_, string method);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_signal(string path, string interface_, string signal);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_copy(GDBusMessageHandle message, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_arg0(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_arg0_path(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_message_get_body(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageByteOrder g_dbus_message_get_byte_order(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_destination(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_error_name(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageFlags g_dbus_message_get_flags(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_message_get_header(GDBusMessageHandle message, GDBusMessageHeaderField header_field);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_dbus_message_get_header_fields(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_interface(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_message_get_locked(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_member(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageType g_dbus_message_get_message_type(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_message_get_num_unix_fds(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_path(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_message_get_reply_serial(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_sender(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_message_get_serial(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_signature(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GUnixFDListHandle g_dbus_message_get_unix_fd_list(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_lock(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_method_error(GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_method_error_literal(GDBusMessageHandle method_call_message, string error_name, string error_message);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_method_error_valist(GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr var_args);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_method_reply(GDBusMessageHandle method_call_message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_print(GDBusMessageHandle message, uint indent);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_body(GDBusMessageHandle message, GVariantHandle body);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_byte_order(GDBusMessageHandle message, GDBusMessageByteOrder byte_order);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_destination(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_error_name(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_flags(GDBusMessageHandle message, GDBusMessageFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_header(GDBusMessageHandle message, GDBusMessageHeaderField header_field, GVariantHandle value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_interface(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_member(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_message_type(GDBusMessageHandle message, GDBusMessageType type);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_num_unix_fds(GDBusMessageHandle message, uint value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_path(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_reply_serial(GDBusMessageHandle message, uint value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_sender(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_serial(GDBusMessageHandle message, uint serial);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_signature(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_unix_fd_list(GDBusMessageHandle message, GUnixFDListHandle fd_list);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_dbus_message_to_blob(GDBusMessageHandle message, out UIntPtr out_size, GDBusCapabilityFlags capabilities, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_message_to_gerror(GDBusMessageHandle message, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_dbus_message_bytes_needed(string blob, UIntPtr blob_len, out GErrorHandle error);

}
