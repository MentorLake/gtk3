namespace MentorLake.GLib;

public class GHmacHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GHmacHandle New(MentorLake.GLib.GChecksumType digest_type, char[] key, UIntPtr key_len)
	{
		return GHmacExterns.g_hmac_new(digest_type, key, key_len);
	}

}


public static class GHmacExtensions
{
	public static MentorLake.GLib.GHmacHandle Copy(this MentorLake.GLib.GHmacHandle hmac)
	{
		if (hmac.IsInvalid || hmac.IsClosed) throw new Exception("Invalid or closed handle (GHmac)");
		return GHmacExterns.g_hmac_copy(hmac);
	}

	public static void GetDigest(this MentorLake.GLib.GHmacHandle hmac, byte[] buffer, ref UIntPtr digest_len)
	{
		if (hmac.IsInvalid || hmac.IsClosed) throw new Exception("Invalid or closed handle (GHmac)");
		GHmacExterns.g_hmac_get_digest(hmac, buffer, ref digest_len);
	}

	public static string GetString(this MentorLake.GLib.GHmacHandle hmac)
	{
		if (hmac.IsInvalid || hmac.IsClosed) throw new Exception("Invalid or closed handle (GHmac)");
		return GHmacExterns.g_hmac_get_string(hmac);
	}

	public static MentorLake.GLib.GHmacHandle Ref(this MentorLake.GLib.GHmacHandle hmac)
	{
		if (hmac.IsInvalid || hmac.IsClosed) throw new Exception("Invalid or closed handle (GHmac)");
		return GHmacExterns.g_hmac_ref(hmac);
	}

	public static void Unref(this MentorLake.GLib.GHmacHandle hmac)
	{
		if (hmac.IsInvalid || hmac.IsClosed) throw new Exception("Invalid or closed handle (GHmac)");
		GHmacExterns.g_hmac_unref(hmac);
	}

	public static void Update(this MentorLake.GLib.GHmacHandle hmac, char[] data, UIntPtr length)
	{
		if (hmac.IsInvalid || hmac.IsClosed) throw new Exception("Invalid or closed handle (GHmac)");
		GHmacExterns.g_hmac_update(hmac, data, length);
	}


	public static GHmac Dereference(this GHmacHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GHmac>(x.DangerousGetHandle());
}
internal class GHmacExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GHmacHandle g_hmac_new(MentorLake.GLib.GChecksumType digest_type, char[] key, UIntPtr key_len);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GHmacHandle g_hmac_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))] MentorLake.GLib.GHmacHandle hmac);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hmac_get_digest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))] MentorLake.GLib.GHmacHandle hmac, byte[] buffer, ref UIntPtr digest_len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_hmac_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))] MentorLake.GLib.GHmacHandle hmac);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GHmacHandle g_hmac_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))] MentorLake.GLib.GHmacHandle hmac);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hmac_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))] MentorLake.GLib.GHmacHandle hmac);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hmac_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))] MentorLake.GLib.GHmacHandle hmac, char[] data, UIntPtr length);

}

public struct GHmac
{
}
