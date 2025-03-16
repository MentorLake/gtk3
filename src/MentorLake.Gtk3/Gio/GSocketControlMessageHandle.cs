namespace MentorLake.Gio;

public class GSocketControlMessageHandle : GObjectHandle
{
	public static MentorLake.Gio.GSocketControlMessageHandle Deserialize(int level, int type, UIntPtr size, byte[] data)
	{
		return GSocketControlMessageHandleExterns.g_socket_control_message_deserialize(level, type, size, data);
	}

}

public static class GSocketControlMessageHandleExtensions
{
	public static int GetLevel(this MentorLake.Gio.GSocketControlMessageHandle message)
	{
		return GSocketControlMessageHandleExterns.g_socket_control_message_get_level(message);
	}

	public static int GetMsgType(this MentorLake.Gio.GSocketControlMessageHandle message)
	{
		return GSocketControlMessageHandleExterns.g_socket_control_message_get_msg_type(message);
	}

	public static UIntPtr GetSize(this MentorLake.Gio.GSocketControlMessageHandle message)
	{
		return GSocketControlMessageHandleExterns.g_socket_control_message_get_size(message);
	}

	public static T Serialize<T>(this T message, IntPtr data) where T : GSocketControlMessageHandle
	{
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
	internal static extern MentorLake.Gio.GSocketControlMessageHandle g_socket_control_message_deserialize(int level, int type, UIntPtr size, byte[] data);

}
