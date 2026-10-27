namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Callback used by [class@AuthDomainBasic] for authentication purposes.
/// </para>
/// <para>
/// The application should verify that @username and @password and valid
/// and return %TRUE or %FALSE.
/// </para>
/// <para>
/// If you are maintaining your own password database (rather than
/// using the password to authenticate against some other system like
/// PAM or a remote server), you should make sure you know what you are
/// doing. In particular, don&apos;t store cleartext passwords, or
/// easily-computed hashes of cleartext passwords, even if you don&apos;t
/// care that much about the security of your server, because users
/// will frequently use the same password for multiple sites, and so
/// compromising any site with a cleartext (or easily-cracked) password
/// database may give attackers access to other more-interesting sites
/// as well.
/// </para>
/// </summary>

/// <param name="domain">
/// the domain
/// </param>
/// <param name="msg">
/// the message being authenticated
/// </param>
/// <param name="username">
/// the username provided by the client
/// </param>
/// <param name="password">
/// the password provided by the client
/// </param>
/// <param name="user_data">
/// the data passed to [method@AuthDomainBasic.set_auth_callback]
/// </param>
/// <return>
/// %TRUE if @username and @password are valid
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool SoupAuthDomainBasicAuthCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, string username, string password, IntPtr user_data);
