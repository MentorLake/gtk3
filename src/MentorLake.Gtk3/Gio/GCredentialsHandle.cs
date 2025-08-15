namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The `GCredentials` type is a reference-counted wrapper for native
/// credentials.
/// </para>
/// <para>
/// The information in `GCredentials` is typically used for identifying,
/// authenticating and authorizing other processes.
/// </para>
/// <para>
/// Some operating systems supports looking up the credentials of the remote
/// peer of a communication endpoint - see e.g. [method@Gio.Socket.get_credentials].
/// </para>
/// <para>
/// Some operating systems supports securely sending and receiving
/// credentials over a Unix Domain Socket, see [class@Gio.UnixCredentialsMessage],
/// [method@Gio.UnixConnection.send_credentials] and
/// [method@Gio.UnixConnection.receive_credentials] for details.
/// </para>
/// <para>
/// On Linux, the native credential type is a `struct ucred` - see the
/// [`unix(7)` man page](man:unix(7)) for details. This corresponds to
/// `G_CREDENTIALS_TYPE_LINUX_UCRED`.
/// </para>
/// <para>
/// On Apple operating systems (including iOS, tvOS, and macOS), the native credential
/// type is a `struct xucred`. This corresponds to `G_CREDENTIALS_TYPE_APPLE_XUCRED`.
/// </para>
/// <para>
/// On FreeBSD, Debian GNU/kFreeBSD, and GNU/Hurd, the native credential type is a
/// `struct cmsgcred`. This corresponds to `G_CREDENTIALS_TYPE_FREEBSD_CMSGCRED`.
/// </para>
/// <para>
/// On NetBSD, the native credential type is a `struct unpcbid`.
/// This corresponds to `G_CREDENTIALS_TYPE_NETBSD_UNPCBID`.
/// </para>
/// <para>
/// On OpenBSD, the native credential type is a `struct sockpeercred`.
/// This corresponds to `G_CREDENTIALS_TYPE_OPENBSD_SOCKPEERCRED`.
/// </para>
/// <para>
/// On Solaris (including OpenSolaris and its derivatives), the native credential type
/// is a `ucred_t`. This corresponds to `G_CREDENTIALS_TYPE_SOLARIS_UCRED`.
/// </para>
/// <para>
/// Since GLib 2.72, on Windows, the native credentials may contain the PID of a
/// process. This corresponds to `G_CREDENTIALS_TYPE_WIN32_PID`.
/// </para>
/// </summary>

public class GCredentialsHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GCredentials object with credentials matching the
/// the current process.
/// </para>
/// </summary>

/// <return>
/// A #GCredentials. Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GCredentialsHandle New()
	{
		return GCredentialsHandleExterns.g_credentials_new();
	}

}

public static class GCredentialsHandleExtensions
{
/// <summary>
/// <para>
/// Gets a pointer to native credentials of type @native_type from
/// @credentials.
/// </para>
/// <para>
/// It is a programming error (which will cause a warning to be
/// logged) to use this method if there is no #GCredentials support for
/// the OS or if @native_type isn&apos;t supported by the OS.
/// </para>
/// </summary>

/// <param name="credentials">
/// A #GCredentials.
/// </param>
/// <param name="native_type">
/// The type of native credentials to get.
/// </param>
/// <return>
/// The pointer to native credentials or
///     %NULL if there is no #GCredentials support for the OS or if @native_type
///     isn&apos;t supported by the OS. Do not free the returned data, it is owned
///     by @credentials.
/// </return>

	public static IntPtr GetNative(this MentorLake.Gio.GCredentialsHandle credentials, MentorLake.Gio.GCredentialsType native_type)
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		return GCredentialsHandleExterns.g_credentials_get_native(credentials, native_type);
	}

/// <summary>
/// <para>
/// Tries to get the UNIX process identifier from @credentials. This
/// method is only available on UNIX platforms.
/// </para>
/// <para>
/// This operation can fail if #GCredentials is not supported on the
/// OS or if the native credentials type does not contain information
/// about the UNIX process ID.
/// </para>
/// </summary>

/// <param name="credentials">
/// A #GCredentials
/// </param>
/// <return>
/// The UNIX process ID, or `-1` if @error is set.
/// </return>

	public static int GetUnixPid(this MentorLake.Gio.GCredentialsHandle credentials)
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		var externCallResult = GCredentialsHandleExterns.g_credentials_get_unix_pid(credentials, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to get the UNIX user identifier from @credentials. This
/// method is only available on UNIX platforms.
/// </para>
/// <para>
/// This operation can fail if #GCredentials is not supported on the
/// OS or if the native credentials type does not contain information
/// about the UNIX user.
/// </para>
/// </summary>

/// <param name="credentials">
/// A #GCredentials
/// </param>
/// <return>
/// The UNIX user identifier or `-1` if @error is set.
/// </return>

	public static int GetUnixUser(this MentorLake.Gio.GCredentialsHandle credentials)
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		var externCallResult = GCredentialsHandleExterns.g_credentials_get_unix_user(credentials, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks if @credentials and @other_credentials is the same user.
/// </para>
/// <para>
/// This operation can fail if #GCredentials is not supported on the
/// the OS.
/// </para>
/// </summary>

/// <param name="credentials">
/// A #GCredentials.
/// </param>
/// <param name="other_credentials">
/// A #GCredentials.
/// </param>
/// <return>
/// %TRUE if @credentials and @other_credentials has the same
/// user, %FALSE otherwise or if @error is set.
/// </return>

	public static bool IsSameUser(this MentorLake.Gio.GCredentialsHandle credentials, MentorLake.Gio.GCredentialsHandle other_credentials)
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		var externCallResult = GCredentialsHandleExterns.g_credentials_is_same_user(credentials, other_credentials, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Copies the native credentials of type @native_type from @native
/// into @credentials.
/// </para>
/// <para>
/// It is a programming error (which will cause a warning to be
/// logged) to use this method if there is no #GCredentials support for
/// the OS or if @native_type isn&apos;t supported by the OS.
/// </para>
/// </summary>

/// <param name="credentials">
/// A #GCredentials.
/// </param>
/// <param name="native_type">
/// The type of native credentials to set.
/// </param>
/// <param name="native">
/// A pointer to native credentials.
/// </param>

	public static T SetNative<T>(this T credentials, MentorLake.Gio.GCredentialsType native_type, IntPtr native) where T : GCredentialsHandle
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		GCredentialsHandleExterns.g_credentials_set_native(credentials, native_type, native);
		return credentials;
	}

/// <summary>
/// <para>
/// Tries to set the UNIX user identifier on @credentials. This method
/// is only available on UNIX platforms.
/// </para>
/// <para>
/// This operation can fail if #GCredentials is not supported on the
/// OS or if the native credentials type does not contain information
/// about the UNIX user. It can also fail if the OS does not allow the
/// use of &quot;spoofed&quot; credentials.
/// </para>
/// </summary>

/// <param name="credentials">
/// A #GCredentials.
/// </param>
/// <param name="uid">
/// The UNIX user identifier to set.
/// </param>
/// <return>
/// %TRUE if @uid was set, %FALSE if error is set.
/// </return>

	public static bool SetUnixUser(this MentorLake.Gio.GCredentialsHandle credentials, int uid)
	{
		if (credentials.IsInvalid) throw new Exception("Invalid handle (GCredentialsHandle)");
		var externCallResult = GCredentialsHandleExterns.g_credentials_set_unix_user(credentials, uid, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a human-readable textual representation of @credentials
/// that can be used in logging and debug messages. The format of the
/// returned string may change in future GLib release.
/// </para>
/// </summary>

/// <param name="credentials">
/// A #GCredentials object.
/// </param>
/// <return>
/// A string that should be freed with g_free().
/// </return>

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
