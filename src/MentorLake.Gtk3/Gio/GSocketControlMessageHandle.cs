namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GSocketControlMessage` is a special-purpose utility message that
/// can be sent to or received from a [class@Gio.Socket]. These types of
/// messages are often called ‘ancillary data’.
/// </para>
/// <para>
/// The message can represent some sort of special instruction to or
/// information from the socket or can represent a special kind of
/// transfer to the peer (for example, sending a file descriptor over
/// a UNIX socket).
/// </para>
/// <para>
/// These messages are sent with [method@Gio.Socket.send_message] and received
/// with [method@Gio.Socket.receive_message].
/// </para>
/// <para>
/// To extend the set of control message that can be sent, subclass this
/// class and override the `get_size`, `get_level`, `get_type` and `serialize`
/// methods.
/// </para>
/// <para>
/// To extend the set of control messages that can be received, subclass
/// this class and implement the `deserialize` method. Also, make sure your
/// class is registered with the [type@GObject.Type] type system before calling
/// [method@Gio.Socket.receive_message] to read such a message.
/// </para>
/// </summary>

public class GSocketControlMessageHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Tries to deserialize a socket control message of a given
/// @level and @type. This will ask all known (to GType) subclasses
/// of #GSocketControlMessage if they can understand this kind
/// of message and if so deserialize it into a #GSocketControlMessage.
/// </para>
/// <para>
/// If there is no implementation for this kind of control message, %NULL
/// will be returned.
/// </para>
/// </summary>

/// <param name="level">
/// a socket level
/// </param>
/// <param name="type">
/// a socket control message type for the given @level
/// </param>
/// <param name="size">
/// the size of the data in bytes
/// </param>
/// <param name="data">
/// pointer to the message data
/// </param>
/// <return>
/// the deserialized message or %NULL
/// </return>

	public static MentorLake.Gio.GSocketControlMessageHandle Deserialize(int level, int type, UIntPtr size, byte[] data)
	{
		return GSocketControlMessageHandleExterns.g_socket_control_message_deserialize(level, type, size, data);
	}

}

public static class GSocketControlMessageHandleExtensions
{
/// <summary>
/// <para>
/// Returns the &quot;level&quot; (i.e. the originating protocol) of the control message.
/// This is often SOL_SOCKET.
/// </para>
/// </summary>

/// <param name="message">
/// a #GSocketControlMessage
/// </param>
/// <return>
/// an integer describing the level
/// </return>

	public static int GetLevel(this MentorLake.Gio.GSocketControlMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GSocketControlMessageHandle)");
		return GSocketControlMessageHandleExterns.g_socket_control_message_get_level(message);
	}

/// <summary>
/// <para>
/// Returns the protocol specific type of the control message.
/// For instance, for UNIX fd passing this would be SCM_RIGHTS.
/// </para>
/// </summary>

/// <param name="message">
/// a #GSocketControlMessage
/// </param>
/// <return>
/// an integer describing the type of control message
/// </return>

	public static int GetMsgType(this MentorLake.Gio.GSocketControlMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GSocketControlMessageHandle)");
		return GSocketControlMessageHandleExterns.g_socket_control_message_get_msg_type(message);
	}

/// <summary>
/// <para>
/// Returns the space required for the control message, not including
/// headers or alignment.
/// </para>
/// </summary>

/// <param name="message">
/// a #GSocketControlMessage
/// </param>
/// <return>
/// The number of bytes required.
/// </return>

	public static UIntPtr GetSize(this MentorLake.Gio.GSocketControlMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GSocketControlMessageHandle)");
		return GSocketControlMessageHandleExterns.g_socket_control_message_get_size(message);
	}

/// <summary>
/// <para>
/// Converts the data in the message to bytes placed in the
/// message.
/// </para>
/// <para>
/// @data is guaranteed to have enough space to fit the size
/// returned by g_socket_control_message_get_size() on this
/// object.
/// </para>
/// </summary>

/// <param name="message">
/// a #GSocketControlMessage
/// </param>
/// <param name="data">
/// A buffer to write data to
/// </param>

	public static T Serialize<T>(this T message, IntPtr data) where T : GSocketControlMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GSocketControlMessageHandle)");
		GSocketControlMessageHandleExterns.g_socket_control_message_serialize(message, data);
		return message;
	}

}

internal class GSocketControlMessageHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern int g_socket_control_message_get_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketControlMessageHandle>))] MentorLake.Gio.GSocketControlMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_socket_control_message_get_msg_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketControlMessageHandle>))] MentorLake.Gio.GSocketControlMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_control_message_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketControlMessageHandle>))] MentorLake.Gio.GSocketControlMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_control_message_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketControlMessageHandle>))] MentorLake.Gio.GSocketControlMessageHandle message, IntPtr data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketControlMessageHandle>))]
	internal static extern MentorLake.Gio.GSocketControlMessageHandle g_socket_control_message_deserialize(int level, int type, UIntPtr size, byte[] data);

}
