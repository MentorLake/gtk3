namespace MentorLake.GLib;

[Flags]
public enum GChecksumType
{
	G_CHECKSUM_MD5 = 0,
	G_CHECKSUM_SHA1 = 1,
	G_CHECKSUM_SHA256 = 2,
	G_CHECKSUM_SHA512 = 3,
	G_CHECKSUM_SHA384 = 4
}
