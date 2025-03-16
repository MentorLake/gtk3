namespace MentorLake.Gio;

[Flags]
public enum GResolverNameLookupFlags : long
{
	G_RESOLVER_NAME_LOOKUP_FLAGS_DEFAULT = 0,
	G_RESOLVER_NAME_LOOKUP_FLAGS_IPV4_ONLY = 1,
	G_RESOLVER_NAME_LOOKUP_FLAGS_IPV6_ONLY = 2
}
