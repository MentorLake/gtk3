namespace MentorLake.Gio;

public class GDBusMessageHandle : GObjectHandle
{
	public static MentorLake.Gio.GDBusMessageHandle New()
	{
		return GDBusMessageHandleExterns.g_dbus_message_new();
	}

	public static MentorLake.Gio.GDBusMessageHandle NewFromBlob(byte[] blob, UIntPtr blob_len, MentorLake.Gio.GDBusCapabilityFlags capabilities)
	{
		var externCallResult = GDBusMessageHandleExterns.g_dbus_message_new_from_blob(blob, blob_len, capabilities, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GDBusMessageHandle NewMethodCall(string name, string path, string interface_, string method)
	{
		return GDBusMessageHandleExterns.g_dbus_message_new_method_call(name, path, interface_, method);
	}

	public static MentorLake.Gio.GDBusMessageHandle NewSignal(string path, string interface_, string signal)
	{
		return GDBusMessageHandleExterns.g_dbus_message_new_signal(path, interface_, signal);
	}

	public static UIntPtr BytesNeeded(byte[] blob, UIntPtr blob_len)
	{
		var externCallResult = GDBusMessageHandleExterns.g_dbus_message_bytes_needed(blob, blob_len, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GDBusMessageHandleExtensions
{
	public static MentorLake.Gio.GDBusMessageHandle Copy(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		var externCallResult = GDBusMessageHandleExterns.g_dbus_message_copy(message, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string GetArg0(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_arg0(message);
	}

	public static string GetArg0Path(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_arg0_path(message);
	}

	public static MentorLake.GLib.GVariantHandle GetBody(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_body(message);
	}

	public static MentorLake.Gio.GDBusMessageByteOrder GetByteOrder(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_byte_order(message);
	}

	public static string GetDestination(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_destination(message);
	}

	public static string GetErrorName(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_error_name(message);
	}

	public static MentorLake.Gio.GDBusMessageFlags GetFlags(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_flags(message);
	}

	public static MentorLake.GLib.GVariantHandle GetHeader(this MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusMessageHeaderField header_field)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_header(message, header_field);
	}

	public static byte[] GetHeaderFields(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_header_fields(message);
	}

	public static string GetInterface(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_interface(message);
	}

	public static bool GetLocked(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_locked(message);
	}

	public static string GetMember(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_member(message);
	}

	public static MentorLake.Gio.GDBusMessageType GetMessageType(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_message_type(message);
	}

	public static uint GetNumUnixFds(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_num_unix_fds(message);
	}

	public static string GetPath(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_path(message);
	}

	public static uint GetReplySerial(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_reply_serial(message);
	}

	public static string GetSender(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_sender(message);
	}

	public static uint GetSerial(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_serial(message);
	}

	public static string GetSignature(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_signature(message);
	}

	public static MentorLake.Gio.GUnixFDListHandle GetUnixFdList(this MentorLake.Gio.GDBusMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_get_unix_fd_list(message);
	}

	public static T Lock<T>(this T message) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_lock(message);
		return message;
	}

	public static MentorLake.Gio.GDBusMessageHandle NewMethodError(this MentorLake.Gio.GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr @__arglist)
	{
		if (method_call_message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_new_method_error(method_call_message, error_name, error_message_format, @__arglist);
	}

	public static MentorLake.Gio.GDBusMessageHandle NewMethodErrorLiteral(this MentorLake.Gio.GDBusMessageHandle method_call_message, string error_name, string error_message)
	{
		if (method_call_message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_new_method_error_literal(method_call_message, error_name, error_message);
	}

	public static MentorLake.Gio.GDBusMessageHandle NewMethodErrorValist(this MentorLake.Gio.GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr var_args)
	{
		if (method_call_message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_new_method_error_valist(method_call_message, error_name, error_message_format, var_args);
	}

	public static MentorLake.Gio.GDBusMessageHandle NewMethodReply(this MentorLake.Gio.GDBusMessageHandle method_call_message)
	{
		if (method_call_message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_new_method_reply(method_call_message);
	}

	public static string Print(this MentorLake.Gio.GDBusMessageHandle message, uint indent)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		return GDBusMessageHandleExterns.g_dbus_message_print(message, indent);
	}

	public static T SetBody<T>(this T message, MentorLake.GLib.GVariantHandle body) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_body(message, body);
		return message;
	}

	public static T SetByteOrder<T>(this T message, MentorLake.Gio.GDBusMessageByteOrder byte_order) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_byte_order(message, byte_order);
		return message;
	}

	public static T SetDestination<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_destination(message, value);
		return message;
	}

	public static T SetErrorName<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_error_name(message, value);
		return message;
	}

	public static T SetFlags<T>(this T message, MentorLake.Gio.GDBusMessageFlags flags) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_flags(message, flags);
		return message;
	}

	public static T SetHeader<T>(this T message, MentorLake.Gio.GDBusMessageHeaderField header_field, MentorLake.GLib.GVariantHandle value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_header(message, header_field, value);
		return message;
	}

	public static T SetInterface<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_interface(message, value);
		return message;
	}

	public static T SetMember<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_member(message, value);
		return message;
	}

	public static T SetMessageType<T>(this T message, MentorLake.Gio.GDBusMessageType type) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_message_type(message, type);
		return message;
	}

	public static T SetNumUnixFds<T>(this T message, uint value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_num_unix_fds(message, value);
		return message;
	}

	public static T SetPath<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_path(message, value);
		return message;
	}

	public static T SetReplySerial<T>(this T message, uint value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_reply_serial(message, value);
		return message;
	}

	public static T SetSender<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_sender(message, value);
		return message;
	}

	public static T SetSerial<T>(this T message, uint serial) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_serial(message, serial);
		return message;
	}

	public static T SetSignature<T>(this T message, string value) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_signature(message, value);
		return message;
	}

	public static T SetUnixFdList<T>(this T message, MentorLake.Gio.GUnixFDListHandle fd_list) where T : GDBusMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		GDBusMessageHandleExterns.g_dbus_message_set_unix_fd_list(message, fd_list);
		return message;
	}

	public static byte[] ToBlob(this MentorLake.Gio.GDBusMessageHandle message, out UIntPtr out_size, MentorLake.Gio.GDBusCapabilityFlags capabilities)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GDBusMessageHandle)");
		var externCallResult = GDBusMessageHandleExterns.g_dbus_message_to_blob(message, out out_size, capabilities, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

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
