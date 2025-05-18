namespace MentorLake.Gio;

public class GTlsPasswordHandle : GObjectHandle
{
	public static MentorLake.Gio.GTlsPasswordHandle New(MentorLake.Gio.GTlsPasswordFlags flags, string description)
	{
		return GTlsPasswordHandleExterns.g_tls_password_new(flags, description);
	}

}

public static class GTlsPasswordHandleExtensions
{
	public static string GetDescription(this MentorLake.Gio.GTlsPasswordHandle password)
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		return GTlsPasswordHandleExterns.g_tls_password_get_description(password);
	}

	public static MentorLake.Gio.GTlsPasswordFlags GetFlags(this MentorLake.Gio.GTlsPasswordHandle password)
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		return GTlsPasswordHandleExterns.g_tls_password_get_flags(password);
	}

	public static char[] GetValue(this MentorLake.Gio.GTlsPasswordHandle password, out UIntPtr length)
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		return GTlsPasswordHandleExterns.g_tls_password_get_value(password, out length);
	}

	public static string GetWarning(this MentorLake.Gio.GTlsPasswordHandle password)
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		return GTlsPasswordHandleExterns.g_tls_password_get_warning(password);
	}

	public static T SetDescription<T>(this T password, string description) where T : GTlsPasswordHandle
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		GTlsPasswordHandleExterns.g_tls_password_set_description(password, description);
		return password;
	}

	public static T SetFlags<T>(this T password, MentorLake.Gio.GTlsPasswordFlags flags) where T : GTlsPasswordHandle
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		GTlsPasswordHandleExterns.g_tls_password_set_flags(password, flags);
		return password;
	}

	public static T SetValue<T>(this T password, char[] value, UIntPtr length) where T : GTlsPasswordHandle
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		GTlsPasswordHandleExterns.g_tls_password_set_value(password, value, length);
		return password;
	}

	public static T SetValueFull<T>(this T password, char[] value, UIntPtr length, MentorLake.GLib.GDestroyNotify destroy) where T : GTlsPasswordHandle
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		GTlsPasswordHandleExterns.g_tls_password_set_value_full(password, value, length, destroy);
		return password;
	}

	public static T SetWarning<T>(this T password, string warning) where T : GTlsPasswordHandle
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		GTlsPasswordHandleExterns.g_tls_password_set_warning(password, warning);
		return password;
	}

}

internal class GTlsPasswordHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))]
	internal static extern MentorLake.Gio.GTlsPasswordHandle g_tls_password_new(MentorLake.Gio.GTlsPasswordFlags flags, string description);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_tls_password_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsPasswordFlags g_tls_password_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password);

	[DllImport(GioLibrary.Name)]
	internal static extern char[] g_tls_password_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, out UIntPtr length);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_tls_password_get_warning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_password_set_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, string description);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_password_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, MentorLake.Gio.GTlsPasswordFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_password_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, char[] value, UIntPtr length);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_password_set_value_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, char[] value, UIntPtr length, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_password_set_warning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, string warning);

}
