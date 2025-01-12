namespace MentorLake.Gtk3.GLib;

public class GHmacHandle : BaseSafeHandle
{
	public static GHmacHandle New(GChecksumType digest_type, string key, UIntPtr key_len)
	{
		return GHmacExterns.g_hmac_new(digest_type, key, key_len);
	}

}


public static class GHmacHandleExtensions
{
	public static GHmacHandle Copy(this GHmacHandle hmac)
	{
		return GHmacExterns.g_hmac_copy(hmac);
	}

	public static T GetDigest<T>(this T hmac, byte[] buffer, ref UIntPtr digest_len) where T : GHmacHandle
	{
		GHmacExterns.g_hmac_get_digest(hmac, buffer, ref digest_len);
		return hmac;
	}

	public static string GetString(this GHmacHandle hmac)
	{
		return GHmacExterns.g_hmac_get_string(hmac);
	}

	public static GHmacHandle Ref(this GHmacHandle hmac)
	{
		return GHmacExterns.g_hmac_ref(hmac);
	}

	public static T Unref<T>(this T hmac) where T : GHmacHandle
	{
		GHmacExterns.g_hmac_unref(hmac);
		return hmac;
	}

	public static T Update<T>(this T hmac, string data, UIntPtr length) where T : GHmacHandle
	{
		GHmacExterns.g_hmac_update(hmac, data, length);
		return hmac;
	}

}
internal class GHmacExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GHmacHandle g_hmac_new(GChecksumType digest_type, string key, UIntPtr key_len);

	[DllImport(Libraries.GLib)]
	internal static extern GHmacHandle g_hmac_copy(GHmacHandle hmac);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hmac_get_digest(GHmacHandle hmac, byte[] buffer, ref UIntPtr digest_len);

	[DllImport(Libraries.GLib)]
	internal static extern string g_hmac_get_string(GHmacHandle hmac);

	[DllImport(Libraries.GLib)]
	internal static extern GHmacHandle g_hmac_ref(GHmacHandle hmac);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hmac_unref(GHmacHandle hmac);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hmac_update(GHmacHandle hmac, string data, UIntPtr length);

}

public struct GHmac
{
}
