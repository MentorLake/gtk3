namespace MentorLake.Gtk3.Gio;

public class GTlsPasswordHandle : GObjectHandle
{
	public static GTlsPasswordHandle New(GTlsPasswordFlags flags, string description)
	{
		return GTlsPasswordExterns.g_tls_password_new(flags, description);
	}

}

public static class GTlsPasswordHandleExtensions
{
	public static string GetDescription(this GTlsPasswordHandle password)
	{
		return GTlsPasswordExterns.g_tls_password_get_description(password);
	}

	public static GTlsPasswordFlags GetFlags(this GTlsPasswordHandle password)
	{
		return GTlsPasswordExterns.g_tls_password_get_flags(password);
	}

	public static IntPtr GetValue(this GTlsPasswordHandle password, out UIntPtr length)
	{
		return GTlsPasswordExterns.g_tls_password_get_value(password, out length);
	}

	public static string GetWarning(this GTlsPasswordHandle password)
	{
		return GTlsPasswordExterns.g_tls_password_get_warning(password);
	}

	public static T SetDescription<T>(this T password, string description) where T : GTlsPasswordHandle
	{
		GTlsPasswordExterns.g_tls_password_set_description(password, description);
		return password;
	}

	public static T SetFlags<T>(this T password, GTlsPasswordFlags flags) where T : GTlsPasswordHandle
	{
		GTlsPasswordExterns.g_tls_password_set_flags(password, flags);
		return password;
	}

	public static T SetValue<T>(this T password, string value, UIntPtr length) where T : GTlsPasswordHandle
	{
		GTlsPasswordExterns.g_tls_password_set_value(password, value, length);
		return password;
	}

	public static T SetValueFull<T>(this T password, string value, UIntPtr length, GDestroyNotify destroy) where T : GTlsPasswordHandle
	{
		GTlsPasswordExterns.g_tls_password_set_value_full(password, value, length, destroy);
		return password;
	}

	public static T SetWarning<T>(this T password, string warning) where T : GTlsPasswordHandle
	{
		GTlsPasswordExterns.g_tls_password_set_warning(password, warning);
		return password;
	}

}

internal class GTlsPasswordExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GTlsPasswordHandle g_tls_password_new(GTlsPasswordFlags flags, string description);

	[DllImport(Libraries.Gio)]
	internal static extern string g_tls_password_get_description(GTlsPasswordHandle password);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsPasswordFlags g_tls_password_get_flags(GTlsPasswordHandle password);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_tls_password_get_value(GTlsPasswordHandle password, out UIntPtr length);

	[DllImport(Libraries.Gio)]
	internal static extern string g_tls_password_get_warning(GTlsPasswordHandle password);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_password_set_description(GTlsPasswordHandle password, string description);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_password_set_flags(GTlsPasswordHandle password, GTlsPasswordFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_password_set_value(GTlsPasswordHandle password, string value, UIntPtr length);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_password_set_value_full(GTlsPasswordHandle password, string value, UIntPtr length, GDestroyNotify destroy);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_password_set_warning(GTlsPasswordHandle password, string warning);

}
