namespace MentorLake.GLib;

public class GChecksumHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GChecksumHandle New(MentorLake.GLib.GChecksumType checksum_type)
	{
		return GChecksumExterns.g_checksum_new(checksum_type);
	}

}


public static class GChecksumExtensions
{
	public static MentorLake.GLib.GChecksumHandle Copy(this MentorLake.GLib.GChecksumHandle checksum)
	{
		if (checksum.IsInvalid || checksum.IsClosed) throw new Exception("Invalid or closed handle (GChecksum)");
		return GChecksumExterns.g_checksum_copy(checksum);
	}

	public static void Free(this MentorLake.GLib.GChecksumHandle checksum)
	{
		if (checksum.IsInvalid || checksum.IsClosed) throw new Exception("Invalid or closed handle (GChecksum)");
		GChecksumExterns.g_checksum_free(checksum);
	}

	public static void GetDigest(this MentorLake.GLib.GChecksumHandle checksum, byte[] buffer, ref UIntPtr digest_len)
	{
		if (checksum.IsInvalid || checksum.IsClosed) throw new Exception("Invalid or closed handle (GChecksum)");
		GChecksumExterns.g_checksum_get_digest(checksum, buffer, ref digest_len);
	}

	public static string GetString(this MentorLake.GLib.GChecksumHandle checksum)
	{
		if (checksum.IsInvalid || checksum.IsClosed) throw new Exception("Invalid or closed handle (GChecksum)");
		return GChecksumExterns.g_checksum_get_string(checksum);
	}

	public static void Reset(this MentorLake.GLib.GChecksumHandle checksum)
	{
		if (checksum.IsInvalid || checksum.IsClosed) throw new Exception("Invalid or closed handle (GChecksum)");
		GChecksumExterns.g_checksum_reset(checksum);
	}

	public static void Update(this MentorLake.GLib.GChecksumHandle checksum, byte[] data, UIntPtr length)
	{
		if (checksum.IsInvalid || checksum.IsClosed) throw new Exception("Invalid or closed handle (GChecksum)");
		GChecksumExterns.g_checksum_update(checksum, data, length);
	}


	public static GChecksum Dereference(this GChecksumHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GChecksum>(x.DangerousGetHandle());
}
internal class GChecksumExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GChecksumHandle g_checksum_new(MentorLake.GLib.GChecksumType checksum_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GChecksumHandle g_checksum_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GChecksumHandle>))] MentorLake.GLib.GChecksumHandle checksum);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_checksum_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GChecksumHandle>))] MentorLake.GLib.GChecksumHandle checksum);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_checksum_get_digest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GChecksumHandle>))] MentorLake.GLib.GChecksumHandle checksum, byte[] buffer, ref UIntPtr digest_len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_checksum_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GChecksumHandle>))] MentorLake.GLib.GChecksumHandle checksum);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_checksum_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GChecksumHandle>))] MentorLake.GLib.GChecksumHandle checksum);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_checksum_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GChecksumHandle>))] MentorLake.GLib.GChecksumHandle checksum, byte[] data, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_checksum_type_get_length(MentorLake.GLib.GChecksumType checksum_type);

}

public struct GChecksum
{
	public static UIntPtr TypeGetLength(MentorLake.GLib.GChecksumType checksum_type)
	{
		return GChecksumExterns.g_checksum_type_get_length(checksum_type);
	}

}
