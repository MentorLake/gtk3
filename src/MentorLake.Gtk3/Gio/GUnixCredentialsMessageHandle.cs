namespace MentorLake.Gio;

public class GUnixCredentialsMessageHandle : GSocketControlMessageHandle
{
	public static MentorLake.Gio.GUnixCredentialsMessageHandle New()
	{
		return GUnixCredentialsMessageHandleExterns.g_unix_credentials_message_new();
	}

	public static MentorLake.Gio.GUnixCredentialsMessageHandle NewWithCredentials(MentorLake.Gio.GCredentialsHandle credentials)
	{
		return GUnixCredentialsMessageHandleExterns.g_unix_credentials_message_new_with_credentials(credentials);
	}

	public static bool IsSupported()
	{
		return GUnixCredentialsMessageHandleExterns.g_unix_credentials_message_is_supported();
	}

}

public static class GUnixCredentialsMessageHandleExtensions
{
	public static MentorLake.Gio.GCredentialsHandle GetCredentials(this MentorLake.Gio.GUnixCredentialsMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GUnixCredentialsMessageHandle)");
		return GUnixCredentialsMessageHandleExterns.g_unix_credentials_message_get_credentials(message);
	}

}

internal class GUnixCredentialsMessageHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixCredentialsMessageHandle>))]
	internal static extern MentorLake.Gio.GUnixCredentialsMessageHandle g_unix_credentials_message_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixCredentialsMessageHandle>))]
	internal static extern MentorLake.Gio.GUnixCredentialsMessageHandle g_unix_credentials_message_new_with_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))]
	internal static extern MentorLake.Gio.GCredentialsHandle g_unix_credentials_message_get_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixCredentialsMessageHandle>))] MentorLake.Gio.GUnixCredentialsMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_credentials_message_is_supported();

}
