namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The abstract base class for handling authentication.
/// </para>
/// <para>
/// Specific HTTP Authentication mechanisms are implemented by its subclasses,
/// but applications never need to be aware of the specific subclasses being
/// used.
/// </para>
/// <para>
/// [class@Auth] objects store the authentication data associated with a given bit
/// of web space. They are created automatically by [class@Session].
/// </para>
/// </summary>

public class SoupAuthHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new [class@Auth] of type @type with the information from
/// @msg and @auth_header.
/// </para>
/// <para>
/// This is called by [class@Session]; you will normally not create auths
/// yourself.
/// </para>
/// </summary>

/// <param name="type">
/// the type of auth to create (a subtype of [class@Auth])
/// </param>
/// <param name="msg">
/// the #SoupMessage the auth is being created for
/// </param>
/// <param name="auth_header">
/// the WWW-Authenticate/Proxy-Authenticate header
/// </param>
/// <return>
/// the new [class@Auth], or %NULL if it could
///   not be created
/// </return>

	public static MentorLake.Soup.SoupAuthHandle New(MentorLake.GObject.GType type, MentorLake.Soup.SoupMessageHandle msg, string auth_header)
	{
		return SoupAuthHandleExterns.soup_auth_new(type, msg, auth_header);
	}

}

public static class SoupAuthHandleExtensions
{
/// <summary>
/// <para>
/// Call this on an auth to authenticate it.
/// </para>
/// <para>
/// Normally this will cause the auth&apos;s message to be requeued with the new
/// authentication info.
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <param name="username">
/// the username provided by the user or client
/// </param>
/// <param name="password">
/// the password provided by the user or client
/// </param>

	public static T Authenticate<T>(this T auth, string username, string password) where T : SoupAuthHandle
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		SoupAuthHandleExterns.soup_auth_authenticate(auth, username, password);
		return auth;
	}

/// <summary>
/// <para>
/// Tests if @auth is able to authenticate by providing credentials to the
/// [method@Auth.authenticate].
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <return>
/// %TRUE if @auth is able to accept credentials.
/// </return>

	public static bool CanAuthenticate(this MentorLake.Soup.SoupAuthHandle auth)
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		return SoupAuthHandleExterns.soup_auth_can_authenticate(auth);
	}

/// <summary>
/// <para>
/// Call this on an auth to cancel it.
/// </para>
/// <para>
/// You need to cancel an auth to complete an asynchronous authenticate operation
/// when no credentials are provided ([method@Auth.authenticate] is not called).
/// The [class@Auth] will be cancelled on dispose if it hasn&apos;t been authenticated.
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>

	public static T Cancel<T>(this T auth) where T : SoupAuthHandle
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		SoupAuthHandleExterns.soup_auth_cancel(auth);
		return auth;
	}

/// <summary>
/// <para>
/// Frees @space.
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <param name="space">
/// the return value from [method@Auth.get_protection_space]
/// </param>

	public static T FreeProtectionSpace<T>(this T auth, MentorLake.GLib.GSListHandle space) where T : SoupAuthHandle
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		SoupAuthHandleExterns.soup_auth_free_protection_space(auth, space);
		return auth;
	}

/// <summary>
/// <para>
/// Returns the authority (host:port) that @auth is associated with.
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <return>
/// the authority
/// </return>

	public static string GetAuthority(this MentorLake.Soup.SoupAuthHandle auth)
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		return SoupAuthHandleExterns.soup_auth_get_authority(auth);
	}

/// <summary>
/// <para>
/// Generates an appropriate &quot;Authorization&quot; header for @msg.
/// </para>
/// <para>
/// (The session will only call this if [method@Auth.is_authenticated] returned
/// %TRUE.)
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <param name="msg">
/// the #SoupMessage to be authorized
/// </param>
/// <return>
/// the &quot;Authorization&quot; header, which must be freed.
/// </return>

	public static string GetAuthorization(this MentorLake.Soup.SoupAuthHandle auth, MentorLake.Soup.SoupMessageHandle msg)
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		return SoupAuthHandleExterns.soup_auth_get_authorization(auth, msg);
	}

/// <summary>
/// <para>
/// Gets an opaque identifier for @auth.
/// </para>
/// <para>
/// The identifier can be used as a hash key or the like. [class@Auth] objects from
/// the same server with the same identifier refer to the same authentication
/// domain (eg, the URLs associated with them take the same usernames and
/// passwords).
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <return>
/// the identifier
/// </return>

	public static string GetInfo(this MentorLake.Soup.SoupAuthHandle auth)
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		return SoupAuthHandleExterns.soup_auth_get_info(auth);
	}

/// <summary>
/// <para>
/// Returns a list of paths on the server which @auth extends over.
/// </para>
/// <para>
/// (All subdirectories of these paths are also assumed to be part
/// of @auth&apos;s protection space, unless otherwise discovered not to
/// be.)
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <param name="source_uri">
/// the URI of the request that @auth was generated in
///   response to.
/// </param>
/// <return>
/// the list of
///   paths, which can be freed with [method@Auth.free_protection_space].
/// </return>

	public static MentorLake.GLib.GSListHandle GetProtectionSpace(this MentorLake.Soup.SoupAuthHandle auth, MentorLake.GLib.GUriHandle source_uri)
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		return SoupAuthHandleExterns.soup_auth_get_protection_space(auth, source_uri);
	}

/// <summary>
/// <para>
/// Returns @auth&apos;s realm.
/// </para>
/// <para>
/// This is an identifier that distinguishes separate authentication spaces on a
/// given server, and may be some string that is meaningful to the user.
/// (Although it is probably not localized.)
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <return>
/// the realm name
/// </return>

	public static string GetRealm(this MentorLake.Soup.SoupAuthHandle auth)
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		return SoupAuthHandleExterns.soup_auth_get_realm(auth);
	}

/// <summary>
/// <para>
/// soup_auth_get_scheme_name: (attributes org.gtk.Method.get_property=scheme-name)
/// Returns @auth&apos;s scheme name. (Eg, &quot;Basic&quot;, &quot;Digest&quot;, or &quot;NTLM&quot;)
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <return>
/// the scheme name
/// </return>

	public static string GetSchemeName(this MentorLake.Soup.SoupAuthHandle auth)
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		return SoupAuthHandleExterns.soup_auth_get_scheme_name(auth);
	}

/// <summary>
/// <para>
/// Tests if @auth has been given a username and password.
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <return>
/// %TRUE if @auth has been given a username and password
/// </return>

	public static bool IsAuthenticated(this MentorLake.Soup.SoupAuthHandle auth)
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		return SoupAuthHandleExterns.soup_auth_is_authenticated(auth);
	}

/// <summary>
/// <para>
/// Tests if @auth has been cancelled
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <return>
/// %TRUE if @auth has been cancelled
/// </return>

	public static bool IsCancelled(this MentorLake.Soup.SoupAuthHandle auth)
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		return SoupAuthHandleExterns.soup_auth_is_cancelled(auth);
	}

/// <summary>
/// <para>
/// Tests whether or not @auth is associated with a proxy server rather
/// than an &quot;origin&quot; server.
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <return>
/// %TRUE or %FALSE
/// </return>

	public static bool IsForProxy(this MentorLake.Soup.SoupAuthHandle auth)
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		return SoupAuthHandleExterns.soup_auth_is_for_proxy(auth);
	}

/// <summary>
/// <para>
/// Tests if @auth is ready to make a request for @msg with.
/// </para>
/// <para>
/// For most auths, this is equivalent to [method@Auth.is_authenticated], but for
/// some auth types (eg, NTLM), the auth may be sendable (eg, as an
/// authentication request) even before it is authenticated.
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// %TRUE if @auth is ready to make a request with.
/// </return>

	public static bool IsReady(this MentorLake.Soup.SoupAuthHandle auth, MentorLake.Soup.SoupMessageHandle msg)
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		return SoupAuthHandleExterns.soup_auth_is_ready(auth, msg);
	}

/// <summary>
/// <para>
/// Updates @auth with the information from @msg and @auth_header,
/// possibly un-authenticating it.
/// </para>
/// <para>
/// As with [ctor@Auth.new], this is normally only used by [class@Session].
/// </para>
/// </summary>

/// <param name="auth">
/// a #SoupAuth
/// </param>
/// <param name="msg">
/// the #SoupMessage @auth is being updated for
/// </param>
/// <param name="auth_header">
/// the WWW-Authenticate/Proxy-Authenticate header
/// </param>
/// <return>
/// %TRUE if @auth is still a valid (but potentially
///   unauthenticated) [class@Auth]. %FALSE if something about @auth_params
///   could not be parsed or incorporated into @auth at all.
/// </return>

	public static bool Update(this MentorLake.Soup.SoupAuthHandle auth, MentorLake.Soup.SoupMessageHandle msg, string auth_header)
	{
		if (auth.IsInvalid) throw new Exception("Invalid handle (SoupAuthHandle)");
		return SoupAuthHandleExterns.soup_auth_update(auth, msg, auth_header);
	}

}

internal class SoupAuthHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))]
	internal static extern MentorLake.Soup.SoupAuthHandle soup_auth_new(MentorLake.GObject.GType type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, string auth_header);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_auth_authenticate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth, string username, string password);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_auth_can_authenticate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_auth_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_auth_free_protection_space([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle space);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_auth_get_authority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_auth_get_authorization([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_auth_get_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle soup_auth_get_protection_space([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle source_uri);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_auth_get_realm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_auth_get_scheme_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_auth_is_authenticated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_auth_is_cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_auth_is_for_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_auth_is_ready([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_auth_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, string auth_header);

}
