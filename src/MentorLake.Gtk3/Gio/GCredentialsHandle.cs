namespace MentorLake.Gio;

public class GCredentialsHandle : GObjectHandle
{
	public static MentorLake.Gio.GCredentialsHandle New()
	{
		return GCredentialsHandleExterns.g_credentials_new();
	}

}

public static class GCredentialsHandleExtensions
{
	public static IntPtr GetNative(this MentorLake.Gio.GCredentialsHandle credentials, MentorLake.Gio.GCredentialsType native_type)
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		return GCredentialsHandleExterns.g_credentials_get_native(credentials, native_type);
	}

	public static int GetUnixPid(this MentorLake.Gio.GCredentialsHandle credentials)
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		var externCallResult = GCredentialsHandleExterns.g_credentials_get_unix_pid(credentials, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static int GetUnixUser(this MentorLake.Gio.GCredentialsHandle credentials)
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		var externCallResult = GCredentialsHandleExterns.g_credentials_get_unix_user(credentials, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool IsSameUser(this MentorLake.Gio.GCredentialsHandle credentials, MentorLake.Gio.GCredentialsHandle other_credentials)
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		var externCallResult = GCredentialsHandleExterns.g_credentials_is_same_user(credentials, other_credentials, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetNative<T>(this T credentials, MentorLake.Gio.GCredentialsType native_type, IntPtr native) where T : GCredentialsHandle
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		GCredentialsHandleExterns.g_credentials_set_native(credentials, native_type, native);
		return credentials;
	}

	public static bool SetUnixUser(this MentorLake.Gio.GCredentialsHandle credentials, int uid)
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		var externCallResult = GCredentialsHandleExterns.g_credentials_set_unix_user(credentials, uid, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string ToString(this MentorLake.Gio.GCredentialsHandle credentials)
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		return GCredentialsHandleExterns.g_credentials_to_string(credentials);
	}

}

internal class GCredentialsHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))]
	internal static extern MentorLake.Gio.GCredentialsHandle g_credentials_new();

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_credentials_get_native([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials, MentorLake.Gio.GCredentialsType native_type);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_credentials_get_unix_pid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_credentials_get_unix_user([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_credentials_is_same_user([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle other_credentials, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_credentials_set_native([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials, MentorLake.Gio.GCredentialsType native_type, IntPtr native);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_credentials_set_unix_user([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials, int uid, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_credentials_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials);

}
