namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The prototype for a [class@AuthDomain] filter.
/// </para>
/// <para>
/// See [method@AuthDomain.set_filter] for details.
/// </para>
/// </summary>

/// <param name="domain">
/// a #SoupAuthDomain
/// </param>
/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <param name="user_data">
/// the data passed to [method@AuthDomain.set_filter]
/// </param>
/// <return>
/// %TRUE if @msg requires authentication, %FALSE if not.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool SoupAuthDomainFilter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, IntPtr user_data);
