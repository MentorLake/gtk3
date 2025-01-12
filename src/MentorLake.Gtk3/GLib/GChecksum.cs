namespace MentorLake.Gtk3.GLib;

public class GChecksumHandle : BaseSafeHandle
{
	public static GChecksumHandle New(GChecksumType checksum_type)
	{
		return GChecksumExterns.g_checksum_new(checksum_type);
	}

}


public static class GChecksumHandleExtensions
{
	public static GChecksumHandle Copy(this GChecksumHandle checksum)
	{
		return GChecksumExterns.g_checksum_copy(checksum);
	}

	public static T Free<T>(this T checksum) where T : GChecksumHandle
	{
		GChecksumExterns.g_checksum_free(checksum);
		return checksum;
	}

	public static T GetDigest<T>(this T checksum, byte[] buffer, ref UIntPtr digest_len) where T : GChecksumHandle
	{
		GChecksumExterns.g_checksum_get_digest(checksum, buffer, ref digest_len);
		return checksum;
	}

	public static string GetString(this GChecksumHandle checksum)
	{
		return GChecksumExterns.g_checksum_get_string(checksum);
	}

	public static T Reset<T>(this T checksum) where T : GChecksumHandle
	{
		GChecksumExterns.g_checksum_reset(checksum);
		return checksum;
	}

	public static T Update<T>(this T checksum, string data, UIntPtr length) where T : GChecksumHandle
	{
		GChecksumExterns.g_checksum_update(checksum, data, length);
		return checksum;
	}

	public static UIntPtr TypeGetLength(GChecksumType checksum_type)
	{
		return GChecksumExterns.g_checksum_type_get_length(checksum_type);
	}

}
internal class GChecksumExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GChecksumHandle g_checksum_new(GChecksumType checksum_type);

	[DllImport(Libraries.GLib)]
	internal static extern GChecksumHandle g_checksum_copy(GChecksumHandle checksum);

	[DllImport(Libraries.GLib)]
	internal static extern void g_checksum_free(GChecksumHandle checksum);

	[DllImport(Libraries.GLib)]
	internal static extern void g_checksum_get_digest(GChecksumHandle checksum, byte[] buffer, ref UIntPtr digest_len);

	[DllImport(Libraries.GLib)]
	internal static extern string g_checksum_get_string(GChecksumHandle checksum);

	[DllImport(Libraries.GLib)]
	internal static extern void g_checksum_reset(GChecksumHandle checksum);

	[DllImport(Libraries.GLib)]
	internal static extern void g_checksum_update(GChecksumHandle checksum, string data, UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_checksum_type_get_length(GChecksumType checksum_type);

}

public struct GChecksum
{
}
