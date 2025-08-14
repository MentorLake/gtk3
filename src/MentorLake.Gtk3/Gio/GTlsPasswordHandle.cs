namespace MentorLake.Gio;

/// <summary>
/// <para>
/// An abstract interface representing a password used in TLS. Often used in
/// user interaction such as unlocking a key storage token.
/// </para>
/// </summary>

public class GTlsPasswordHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new #GTlsPassword object.
/// </para>
/// </summary>

/// <param name="flags">
/// the password flags
/// </param>
/// <param name="description">
/// description of what the password is for
/// </param>
/// <return>
/// The newly allocated password object
/// </return>

	public static MentorLake.Gio.GTlsPasswordHandle New(MentorLake.Gio.GTlsPasswordFlags flags, string description)
	{
		return GTlsPasswordHandleExterns.g_tls_password_new(flags, description);
	}

}

public static class GTlsPasswordHandleExtensions
{
/// <summary>
/// <para>
/// Get a description string about what the password will be used for.
/// </para>
/// </summary>

/// <param name="password">
/// a #GTlsPassword object
/// </param>
/// <return>
/// The description of the password.
/// </return>

	public static string GetDescription(this MentorLake.Gio.GTlsPasswordHandle password)
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		return GTlsPasswordHandleExterns.g_tls_password_get_description(password);
	}

/// <summary>
/// <para>
/// Get flags about the password.
/// </para>
/// </summary>

/// <param name="password">
/// a #GTlsPassword object
/// </param>
/// <return>
/// The flags about the password.
/// </return>

	public static MentorLake.Gio.GTlsPasswordFlags GetFlags(this MentorLake.Gio.GTlsPasswordHandle password)
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		return GTlsPasswordHandleExterns.g_tls_password_get_flags(password);
	}

/// <summary>
/// <para>
/// Get the password value. If @length is not %NULL then it will be
/// filled in with the length of the password value. (Note that the
/// password value is not nul-terminated, so you can only pass %NULL
/// for @length in contexts where you know the password will have a
/// certain fixed length.)
/// </para>
/// </summary>

/// <param name="password">
/// a #GTlsPassword object
/// </param>
/// <param name="length">
/// location to place the length of the password.
/// </param>
/// <return>
/// The password value (owned by the password object).
/// </return>

	public static byte[] GetValue(this MentorLake.Gio.GTlsPasswordHandle password, out UIntPtr length)
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		return GTlsPasswordHandleExterns.g_tls_password_get_value(password, out length);
	}

/// <summary>
/// <para>
/// Get a user readable translated warning. Usually this warning is a
/// representation of the password flags returned from
/// g_tls_password_get_flags().
/// </para>
/// </summary>

/// <param name="password">
/// a #GTlsPassword object
/// </param>
/// <return>
/// The warning.
/// </return>

	public static string GetWarning(this MentorLake.Gio.GTlsPasswordHandle password)
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		return GTlsPasswordHandleExterns.g_tls_password_get_warning(password);
	}

/// <summary>
/// <para>
/// Set a description string about what the password will be used for.
/// </para>
/// </summary>

/// <param name="password">
/// a #GTlsPassword object
/// </param>
/// <param name="description">
/// The description of the password
/// </param>

	public static T SetDescription<T>(this T password, string description) where T : GTlsPasswordHandle
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		GTlsPasswordHandleExterns.g_tls_password_set_description(password, description);
		return password;
	}

/// <summary>
/// <para>
/// Set flags about the password.
/// </para>
/// </summary>

/// <param name="password">
/// a #GTlsPassword object
/// </param>
/// <param name="flags">
/// The flags about the password
/// </param>

	public static T SetFlags<T>(this T password, MentorLake.Gio.GTlsPasswordFlags flags) where T : GTlsPasswordHandle
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		GTlsPasswordHandleExterns.g_tls_password_set_flags(password, flags);
		return password;
	}

/// <summary>
/// <para>
/// Set the value for this password. The @value will be copied by the password
/// object.
/// </para>
/// <para>
/// Specify the @length, for a non-nul-terminated password. Pass -1 as
/// @length if using a nul-terminated password, and @length will be
/// calculated automatically. (Note that the terminating nul is not
/// considered part of the password in this case.)
/// </para>
/// </summary>

/// <param name="password">
/// a #GTlsPassword object
/// </param>
/// <param name="value">
/// the new password value
/// </param>
/// <param name="length">
/// the length of the password, or -1
/// </param>

	public static T SetValue<T>(this T password, byte[] value, UIntPtr length) where T : GTlsPasswordHandle
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		GTlsPasswordHandleExterns.g_tls_password_set_value(password, value, length);
		return password;
	}

/// <summary>
/// <para>
/// Provide the value for this password.
/// </para>
/// <para>
/// The @value will be owned by the password object, and later freed using
/// the @destroy function callback.
/// </para>
/// <para>
/// Specify the @length, for a non-nul-terminated password. Pass -1 as
/// @length if using a nul-terminated password, and @length will be
/// calculated automatically. (Note that the terminating nul is not
/// considered part of the password in this case.)
/// </para>
/// </summary>

/// <param name="password">
/// a #GTlsPassword object
/// </param>
/// <param name="value">
/// the value for the password
/// </param>
/// <param name="length">
/// the length of the password, or -1
/// </param>
/// <param name="destroy">
/// a function to use to free the password.
/// </param>

	public static T SetValueFull<T>(this T password, byte[] value, UIntPtr length, MentorLake.GLib.GDestroyNotify destroy) where T : GTlsPasswordHandle
	{
		if (password.IsInvalid) throw new Exception("Invalid handle (GTlsPasswordHandle)");
		GTlsPasswordHandleExterns.g_tls_password_set_value_full(password, value, length, destroy);
		return password;
	}

/// <summary>
/// <para>
/// Set a user readable translated warning. Usually this warning is a
/// representation of the password flags returned from
/// g_tls_password_get_flags().
/// </para>
/// </summary>

/// <param name="password">
/// a #GTlsPassword object
/// </param>
/// <param name="warning">
/// The user readable warning
/// </param>

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
	internal static extern byte[] g_tls_password_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, out UIntPtr length);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_tls_password_get_warning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_password_set_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, string description);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_password_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, MentorLake.Gio.GTlsPasswordFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_password_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, byte[] value, UIntPtr length);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_password_set_value_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, byte[] value, UIntPtr length, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_password_set_warning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, string warning);

}
