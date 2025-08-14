namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The type of record that g_resolver_lookup_records() or
/// g_resolver_lookup_records_async() should retrieve. The records are returned
/// as lists of #GVariant tuples. Each record type has different values in
/// the variant tuples returned.
/// </para>
/// <para>
/// %G_RESOLVER_RECORD_SRV records are returned as variants with the signature
/// `(qqqs)`, containing a `guint16` with the priority, a `guint16` with the
/// weight, a `guint16` with the port, and a string of the hostname.
/// </para>
/// <para>
/// %G_RESOLVER_RECORD_MX records are returned as variants with the signature
/// `(qs)`, representing a `guint16` with the preference, and a string containing
/// the mail exchanger hostname.
/// </para>
/// <para>
/// %G_RESOLVER_RECORD_TXT records are returned as variants with the signature
/// `(as)`, representing an array of the strings in the text record. Note: Most TXT
/// records only contain a single string, but
/// [RFC 1035](https://tools.ietf.org/html/rfc1035#section-3.3.14) does allow a
/// record to contain multiple strings. The RFC which defines the interpretation
/// of a specific TXT record will likely require concatenation of multiple
/// strings if they are present, as with
/// [RFC 7208](https://tools.ietf.org/html/rfc7208#section-3.3).
/// </para>
/// <para>
/// %G_RESOLVER_RECORD_SOA records are returned as variants with the signature
/// `(ssuuuuu)`, representing a string containing the primary name server, a
/// string containing the administrator, the serial as a `guint32`, the refresh
/// interval as a `guint32`, the retry interval as a `guint32`, the expire timeout
/// as a `guint32`, and the TTL as a `guint32`.
/// </para>
/// <para>
/// %G_RESOLVER_RECORD_NS records are returned as variants with the signature
/// `(s)`, representing a string of the hostname of the name server.
/// </para>
/// </summary>

[Flags]
public enum GResolverRecordType
{
/// <summary>
/// <para>
/// look up DNS SRV records for a domain
/// </para>
/// </summary>

	G_RESOLVER_RECORD_SRV = 1,
/// <summary>
/// <para>
/// look up DNS MX records for a domain
/// </para>
/// </summary>

	G_RESOLVER_RECORD_MX = 2,
/// <summary>
/// <para>
/// look up DNS TXT records for a name
/// </para>
/// </summary>

	G_RESOLVER_RECORD_TXT = 3,
/// <summary>
/// <para>
/// look up DNS SOA records for a zone
/// </para>
/// </summary>

	G_RESOLVER_RECORD_SOA = 4,
/// <summary>
/// <para>
/// look up DNS NS records for a domain
/// </para>
/// </summary>

	G_RESOLVER_RECORD_NS = 5
}
