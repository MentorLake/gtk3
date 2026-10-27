namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The prototype for a [class@AuthDomain] generic authentication callback.
/// </para>
/// <para>
/// The callback should look up the user&apos;s password, call
/// [method@AuthDomain.check_password], and use the return value from that method
/// as its own return value.
/// </para>
/// <para>
/// In general, for security reasons, it is preferable to use the
/// auth-domain-specific auth callbacks (eg,
/// [callback@AuthDomainBasicAuthCallback] and
/// [callback@AuthDomainDigestAuthCallback]), because they don&apos;t require
/// keeping a cleartext password database. Most users will use the same
/// password for many different sites, meaning if any site with a
/// cleartext password database is compromised, accounts on other
/// servers might be compromised as well. For many of the cases where
/// [class@Server] is used, this is not really relevant, but it may still
/// be worth considering.
/// </para>
/// </summary>

/// <param name="domain">
/// a #SoupAuthDomain
/// </param>
/// <param name="msg">
/// the [class@ServerMessage] being authenticated
/// </param>
/// <param name="username">
/// the username from @msg
/// </param>
/// <param name="user_data">
/// the data passed to [method@AuthDomain.set_generic_auth_callback]
/// </param>
/// <return>
/// %TRUE if @msg is authenticated, %FALSE if not.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool SoupAuthDomainGenericAuthCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, string username, IntPtr user_data);
