namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The hashing algorithm to be used by #GChecksum when performing the
/// digest of some data.
/// </para>
/// <para>
/// Note that the #GChecksumType enumeration may be extended at a later
/// date to include new hashing algorithm types.
/// </para>
/// </summary>

[Flags]
public enum GChecksumType
{
/// <summary>
/// <para>
/// Use the MD5 hashing algorithm
/// </para>
/// </summary>

	G_CHECKSUM_MD5 = 0,
/// <summary>
/// <para>
/// Use the SHA-1 hashing algorithm
/// </para>
/// </summary>

	G_CHECKSUM_SHA1 = 1,
/// <summary>
/// <para>
/// Use the SHA-256 hashing algorithm
/// </para>
/// </summary>

	G_CHECKSUM_SHA256 = 2,
/// <summary>
/// <para>
/// Use the SHA-512 hashing algorithm (Since: 2.36)
/// </para>
/// </summary>

	G_CHECKSUM_SHA512 = 3,
/// <summary>
/// <para>
/// Use the SHA-384 hashing algorithm (Since: 2.51)
/// </para>
/// </summary>

	G_CHECKSUM_SHA384 = 4
}
