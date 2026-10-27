namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Callback used by [class@AuthDomainDigest] for authentication purposes.
/// </para>
/// <para>
/// The application should look up @username in its password database,
/// and return the corresponding encoded password (see
/// [func@AuthDomainDigest.encode_password].
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
/// <param name="user_data">
/// the data passed to [method@AuthDomainDigest.set_auth_callback]
/// </param>
/// <return>
/// the encoded password, or %NULL if
///   @username is not a valid user. @domain will free the password when
///   it is done with it.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string SoupAuthDomainDigestAuthCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, string username, IntPtr user_data);
