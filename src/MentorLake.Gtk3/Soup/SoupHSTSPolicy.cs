namespace MentorLake.Soup;

/// <summary>
/// <para>
/// [struct@HSTSPolicy] implements HTTP policies, as described by
/// [RFC 6797](http://tools.ietf.org/html/rfc6797).
/// </para>
/// <para>
/// @domain represents the host that this policy applies to. The domain
/// must be IDNA-canonicalized. [ctor@HSTSPolicy.new] and related methods
/// will do this for you.
/// </para>
/// <para>
/// @max_age contains the &apos;max-age&apos; value from the Strict Transport
/// Security header and indicates the time to live of this policy,
/// in seconds.
/// </para>
/// <para>
/// @expires will be non-%NULL if the policy has been set by the host and
/// hence has an expiry time. If @expires is %NULL, it indicates that the
/// policy is a permanent session policy set by the user agent.
/// </para>
/// <para>
/// If @include_subdomains is %TRUE, the Strict Transport Security policy
/// must also be enforced on subdomains of @domain.
/// </para>
/// </summary>

public class SoupHSTSPolicyHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new [struct@HSTSPolicy] with the given attributes.
/// </para>
/// <para>
/// @domain is a domain on which the strict transport security policy
/// represented by this object must be enforced.
/// </para>
/// <para>
/// @max_age is used to set the &quot;expires&quot; attribute on the policy; pass
/// %SOUP_HSTS_POLICY_MAX_AGE_PAST for an already-expired policy, or a
/// lifetime in seconds.
/// </para>
/// <para>
/// If @include_subdomains is %TRUE, the strict transport security policy
/// must also be enforced on all subdomains of @domain.
/// </para>
/// </summary>

/// <param name="domain">
/// policy domain or hostname
/// </param>
/// <param name="max_age">
/// max age of the policy
/// </param>
/// <param name="include_subdomains">
/// %TRUE if the policy applies on subdomains
/// </param>
/// <return>
/// a new #SoupHSTSPolicy.
/// </return>

	public static MentorLake.Soup.SoupHSTSPolicyHandle New(string domain, ulong max_age, bool include_subdomains)
	{
		return SoupHSTSPolicyExterns.soup_hsts_policy_new(domain, max_age, include_subdomains);
	}

/// <summary>
/// <para>
/// Parses @msg&apos;s first &quot;Strict-Transport-Security&quot; response header and
/// returns a [struct@HSTSPolicy].
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// a new #SoupHSTSPolicy, or %NULL if no valid
///   &quot;Strict-Transport-Security&quot; response header was found.
/// </return>

	public static MentorLake.Soup.SoupHSTSPolicyHandle NewFromResponse(MentorLake.Soup.SoupMessageHandle msg)
	{
		return SoupHSTSPolicyExterns.soup_hsts_policy_new_from_response(msg);
	}

/// <summary>
/// <para>
/// Full version of [ctor@HSTSPolicy.new], to use with an existing
/// expiration date.
/// </para>
/// <para>
/// See [ctor@HSTSPolicy.new] for details.
/// </para>
/// </summary>

/// <param name="domain">
/// policy domain or hostname
/// </param>
/// <param name="max_age">
/// max age of the policy
/// </param>
/// <param name="expires">
/// the date of expiration of the policy or %NULL for a permanent policy
/// </param>
/// <param name="include_subdomains">
/// %TRUE if the policy applies on subdomains
/// </param>
/// <return>
/// a new #SoupHSTSPolicy.
/// </return>

	public static MentorLake.Soup.SoupHSTSPolicyHandle NewFull(string domain, ulong max_age, MentorLake.GLib.GDateTimeHandle expires, bool include_subdomains)
	{
		return SoupHSTSPolicyExterns.soup_hsts_policy_new_full(domain, max_age, expires, include_subdomains);
	}

/// <summary>
/// <para>
/// Creates a new session [struct@HSTSPolicy] with the given attributes.
/// </para>
/// <para>
/// A session policy is a policy that is valid during the lifetime of
/// the [class@HSTSEnforcer] it is added to. Contrary to regular policies,
/// it has no expiration date and is not stored in persistent
/// enforcers. These policies are useful for user-agent to load their
/// own or user-defined rules.
/// </para>
/// <para>
/// @domain is a domain on which the strict transport security policy
/// represented by this object must be enforced.
/// </para>
/// <para>
/// If @include_subdomains is %TRUE, the strict transport security policy
/// must also be enforced on all subdomains of @domain.
/// </para>
/// </summary>

/// <param name="domain">
/// policy domain or hostname
/// </param>
/// <param name="include_subdomains">
/// %TRUE if the policy applies on sub domains
/// </param>
/// <return>
/// a new #SoupHSTSPolicy.
/// </return>

	public static MentorLake.Soup.SoupHSTSPolicyHandle NewSessionPolicy(string domain, bool include_subdomains)
	{
		return SoupHSTSPolicyExterns.soup_hsts_policy_new_session_policy(domain, include_subdomains);
	}

}


public static class SoupHSTSPolicyExtensions
{
/// <summary>
/// <para>
/// Copies @policy.
/// </para>
/// </summary>

/// <param name="policy">
/// a #SoupHSTSPolicy
/// </param>
/// <return>
/// a copy of @policy
/// </return>

	public static MentorLake.Soup.SoupHSTSPolicyHandle Copy(this MentorLake.Soup.SoupHSTSPolicyHandle policy)
	{
		if (policy.IsInvalid) throw new Exception("Invalid handle (SoupHSTSPolicy)");
		return SoupHSTSPolicyExterns.soup_hsts_policy_copy(policy);
	}

/// <summary>
/// <para>
/// Tests if @policy1 and @policy2 are equal.
/// </para>
/// </summary>

/// <param name="policy1">
/// a #SoupHSTSPolicy
/// </param>
/// <param name="policy2">
/// a #SoupHSTSPolicy
/// </param>
/// <return>
/// whether the policies are equal.
/// </return>

	public static bool Equal(this MentorLake.Soup.SoupHSTSPolicyHandle policy1, MentorLake.Soup.SoupHSTSPolicyHandle policy2)
	{
		if (policy1.IsInvalid) throw new Exception("Invalid handle (SoupHSTSPolicy)");
		return SoupHSTSPolicyExterns.soup_hsts_policy_equal(policy1, policy2);
	}

/// <summary>
/// <para>
/// Frees @policy.
/// </para>
/// </summary>

/// <param name="policy">
/// a #SoupHSTSPolicy
/// </param>

	public static void Free(this MentorLake.Soup.SoupHSTSPolicyHandle policy)
	{
		if (policy.IsInvalid) throw new Exception("Invalid handle (SoupHSTSPolicy)");
		SoupHSTSPolicyExterns.soup_hsts_policy_free(policy);
	}

/// <summary>
/// <para>
/// Gets @policy&apos;s domain.
/// </para>
/// </summary>

/// <param name="policy">
/// a #SoupHSTSPolicy
/// </param>
/// <return>
/// @policy&apos;s domain.
/// </return>

	public static string GetDomain(this MentorLake.Soup.SoupHSTSPolicyHandle policy)
	{
		if (policy.IsInvalid) throw new Exception("Invalid handle (SoupHSTSPolicy)");
		return SoupHSTSPolicyExterns.soup_hsts_policy_get_domain(policy);
	}

/// <summary>
/// <para>
/// Returns the expiration date for @policy.
/// </para>
/// </summary>

/// <param name="policy">
/// a #SoupHSTSPolicy
/// </param>
/// <return>
/// A #GDateTime or %NULL if unset
/// </return>

	public static MentorLake.GLib.GDateTimeHandle GetExpires(this MentorLake.Soup.SoupHSTSPolicyHandle policy)
	{
		if (policy.IsInvalid) throw new Exception("Invalid handle (SoupHSTSPolicy)");
		return SoupHSTSPolicyExterns.soup_hsts_policy_get_expires(policy);
	}

/// <summary>
/// <para>
/// Returns the max age for @policy.
/// </para>
/// </summary>

/// <param name="policy">
/// a #SoupHSTSPolicy
/// </param>
/// <return>
/// Max age in seconds
/// </return>

	public static ulong GetMaxAge(this MentorLake.Soup.SoupHSTSPolicyHandle policy)
	{
		if (policy.IsInvalid) throw new Exception("Invalid handle (SoupHSTSPolicy)");
		return SoupHSTSPolicyExterns.soup_hsts_policy_get_max_age(policy);
	}

/// <summary>
/// <para>
/// Gets whether @policy include its subdomains.
/// </para>
/// </summary>

/// <param name="policy">
/// a #SoupHSTSPolicy
/// </param>
/// <return>
/// %TRUE if @policy includes subdomains, %FALSE otherwise.
/// </return>

	public static bool IncludesSubdomains(this MentorLake.Soup.SoupHSTSPolicyHandle policy)
	{
		if (policy.IsInvalid) throw new Exception("Invalid handle (SoupHSTSPolicy)");
		return SoupHSTSPolicyExterns.soup_hsts_policy_includes_subdomains(policy);
	}

/// <summary>
/// <para>
/// Gets whether @policy is expired.
/// </para>
/// <para>
/// Permanent policies never expire.
/// </para>
/// </summary>

/// <param name="policy">
/// a #SoupHSTSPolicy
/// </param>
/// <return>
/// %TRUE if @policy is expired, %FALSE otherwise.
/// </return>

	public static bool IsExpired(this MentorLake.Soup.SoupHSTSPolicyHandle policy)
	{
		if (policy.IsInvalid) throw new Exception("Invalid handle (SoupHSTSPolicy)");
		return SoupHSTSPolicyExterns.soup_hsts_policy_is_expired(policy);
	}

/// <summary>
/// <para>
/// Gets whether @policy is a non-permanent, non-expirable session policy.
/// </para>
/// <para>
/// See [ctor@HSTSPolicy.new_session_policy] for details.
/// </para>
/// </summary>

/// <param name="policy">
/// a #SoupHSTSPolicy
/// </param>
/// <return>
/// %TRUE if @policy is permanent, %FALSE otherwise
/// </return>

	public static bool IsSessionPolicy(this MentorLake.Soup.SoupHSTSPolicyHandle policy)
	{
		if (policy.IsInvalid) throw new Exception("Invalid handle (SoupHSTSPolicy)");
		return SoupHSTSPolicyExterns.soup_hsts_policy_is_session_policy(policy);
	}


	public static SoupHSTSPolicy Dereference(this SoupHSTSPolicyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupHSTSPolicy>(x.DangerousGetHandle());
}
internal class SoupHSTSPolicyExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))]
	internal static extern MentorLake.Soup.SoupHSTSPolicyHandle soup_hsts_policy_new(string domain, ulong max_age, bool include_subdomains);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))]
	internal static extern MentorLake.Soup.SoupHSTSPolicyHandle soup_hsts_policy_new_from_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))]
	internal static extern MentorLake.Soup.SoupHSTSPolicyHandle soup_hsts_policy_new_full(string domain, ulong max_age, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle expires, bool include_subdomains);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))]
	internal static extern MentorLake.Soup.SoupHSTSPolicyHandle soup_hsts_policy_new_session_policy(string domain, bool include_subdomains);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))]
	internal static extern MentorLake.Soup.SoupHSTSPolicyHandle soup_hsts_policy_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle policy);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_hsts_policy_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle policy1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle policy2);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_hsts_policy_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle policy);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_hsts_policy_get_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle policy);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle soup_hsts_policy_get_expires([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle policy);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_hsts_policy_get_max_age([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle policy);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_hsts_policy_includes_subdomains([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle policy);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_hsts_policy_is_expired([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle policy);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_hsts_policy_is_session_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle policy);

}

/// <summary>
/// <para>
/// [struct@HSTSPolicy] implements HTTP policies, as described by
/// [RFC 6797](http://tools.ietf.org/html/rfc6797).
/// </para>
/// <para>
/// @domain represents the host that this policy applies to. The domain
/// must be IDNA-canonicalized. [ctor@HSTSPolicy.new] and related methods
/// will do this for you.
/// </para>
/// <para>
/// @max_age contains the &apos;max-age&apos; value from the Strict Transport
/// Security header and indicates the time to live of this policy,
/// in seconds.
/// </para>
/// <para>
/// @expires will be non-%NULL if the policy has been set by the host and
/// hence has an expiry time. If @expires is %NULL, it indicates that the
/// policy is a permanent session policy set by the user agent.
/// </para>
/// <para>
/// If @include_subdomains is %TRUE, the Strict Transport Security policy
/// must also be enforced on subdomains of @domain.
/// </para>
/// </summary>

public struct SoupHSTSPolicy
{
}
