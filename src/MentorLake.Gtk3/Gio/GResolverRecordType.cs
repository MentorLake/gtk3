namespace MentorLake.Gio;

[Flags]
public enum GResolverRecordType
{
	G_RESOLVER_RECORD_SRV = 1,
	G_RESOLVER_RECORD_MX = 2,
	G_RESOLVER_RECORD_TXT = 3,
	G_RESOLVER_RECORD_SOA = 4,
	G_RESOLVER_RECORD_NS = 5
}
