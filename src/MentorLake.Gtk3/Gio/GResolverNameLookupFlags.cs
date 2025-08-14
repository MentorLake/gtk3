namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags to modify lookup behavior.
/// </para>
/// </summary>

[Flags]
public enum GResolverNameLookupFlags : uint
{
/// <summary>
/// <para>
/// default behavior (same as g_resolver_lookup_by_name())
/// </para>
/// </summary>

	G_RESOLVER_NAME_LOOKUP_FLAGS_DEFAULT = 0,
/// <summary>
/// <para>
/// only resolve ipv4 addresses
/// </para>
/// </summary>

	G_RESOLVER_NAME_LOOKUP_FLAGS_IPV4_ONLY = 1,
/// <summary>
/// <para>
/// only resolve ipv6 addresses
/// </para>
/// </summary>

	G_RESOLVER_NAME_LOOKUP_FLAGS_IPV6_ONLY = 2
}
