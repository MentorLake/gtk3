namespace MentorLake.GLib;

/// <summary>
/// <para>
/// GLib provides a generic API for computing checksums (or ‘digests’)
/// for a sequence of arbitrary bytes, using various hashing algorithms
/// like MD5, SHA-1 and SHA-256. Checksums are commonly used in various
/// environments and specifications.
/// </para>
/// <para>
/// To create a new `GChecksum`, use [ctor@GLib.Checksum.new]. To free
/// a `GChecksum`, use [method@GLib.Checksum.free].
/// </para>
/// <para>
/// GLib supports incremental checksums using the `GChecksum` data
/// structure, by calling [method@GLib.Checksum.update] as long as there’s data
/// available and then using [method@GLib.Checksum.get_string] or
/// [method@GLib.Checksum.get_digest] to compute the checksum and return it
/// either as a string in hexadecimal form, or as a raw sequence of bytes. To
/// compute the checksum for binary blobs and nul-terminated strings in
/// one go, use the convenience functions [func@GLib.compute_checksum_for_data]
/// and [func@GLib.compute_checksum_for_string], respectively.
/// </para>
/// </summary>

public class GChecksumHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GChecksum, using the checksum algorithm @checksum_type.
/// If the @checksum_type is not known, %NULL is returned.
/// A #GChecksum can be used to compute the checksum, or digest, of an
/// arbitrary binary blob, using different hashing algorithms.
/// </para>
/// <para>
/// A #GChecksum works by feeding a binary blob through g_checksum_update()
/// until there is data to be checked; the digest can then be extracted
/// using g_checksum_get_string(), which will return the checksum as a
/// hexadecimal string; or g_checksum_get_digest(), which will return a
/// vector of raw bytes. Once either g_checksum_get_string() or
/// g_checksum_get_digest() have been called on a #GChecksum, the checksum
/// will be closed and it won&apos;t be possible to call g_checksum_update()
/// on it anymore.
/// </para>
/// </summary>

/// <param name="checksum_type">
/// the desired type of checksum
/// </param>
/// <return>
/// the newly created #GChecksum, or %NULL.
///   Use g_checksum_free() to free the memory allocated by it.
/// </return>

	public static MentorLake.GLib.GChecksumHandle New(MentorLake.GLib.GChecksumType checksum_type)
	{
		return GChecksumExterns.g_checksum_new(checksum_type);
	}

}


public static class GChecksumExtensions
{
/// <summary>
/// <para>
/// Copies a #GChecksum. If @checksum has been closed, by calling
/// g_checksum_get_string() or g_checksum_get_digest(), the copied
/// checksum will be closed as well.
/// </para>
/// </summary>

/// <param name="checksum">
/// the #GChecksum to copy
/// </param>
/// <return>
/// the copy of the passed #GChecksum. Use
///   g_checksum_free() when finished using it.
/// </return>

	public static MentorLake.GLib.GChecksumHandle Copy(this MentorLake.GLib.GChecksumHandle checksum)
	{
		if (checksum.IsInvalid) throw new Exception("Invalid handle (GChecksum)");
		return GChecksumExterns.g_checksum_copy(checksum);
	}

/// <summary>
/// <para>
/// Frees the memory allocated for @checksum.
/// </para>
/// </summary>

/// <param name="checksum">
/// a #GChecksum
/// </param>

	public static void Free(this MentorLake.GLib.GChecksumHandle checksum)
	{
		if (checksum.IsInvalid) throw new Exception("Invalid handle (GChecksum)");
		GChecksumExterns.g_checksum_free(checksum);
	}

/// <summary>
/// <para>
/// Gets the digest from @checksum as a raw binary vector and places it
/// into @buffer. The size of the digest depends on the type of checksum.
/// </para>
/// <para>
/// Once this function has been called, the #GChecksum is closed and can
/// no longer be updated with g_checksum_update().
/// </para>
/// </summary>

/// <param name="checksum">
/// a #GChecksum
/// </param>
/// <param name="buffer">
/// output buffer
/// </param>
/// <param name="digest_len">
/// an inout parameter. The caller initializes it to the size of @buffer.
///   After the call it contains the length of the digest.
/// </param>

	public static void GetDigest(this MentorLake.GLib.GChecksumHandle checksum, byte[] buffer, ref UIntPtr digest_len)
	{
		if (checksum.IsInvalid) throw new Exception("Invalid handle (GChecksum)");
		GChecksumExterns.g_checksum_get_digest(checksum, buffer, ref digest_len);
	}

/// <summary>
/// <para>
/// Gets the digest as a hexadecimal string.
/// </para>
/// <para>
/// Once this function has been called the #GChecksum can no longer be
/// updated with g_checksum_update().
/// </para>
/// <para>
/// The hexadecimal characters will be lower case.
/// </para>
/// </summary>

/// <param name="checksum">
/// a #GChecksum
/// </param>
/// <return>
/// the hexadecimal representation of the checksum. The
///   returned string is owned by the checksum and should not be modified
///   or freed.
/// </return>

	public static string GetString(this MentorLake.GLib.GChecksumHandle checksum)
	{
		if (checksum.IsInvalid) throw new Exception("Invalid handle (GChecksum)");
		return GChecksumExterns.g_checksum_get_string(checksum);
	}

/// <summary>
/// <para>
/// Resets the state of the @checksum back to its initial state.
/// </para>
/// </summary>

/// <param name="checksum">
/// the #GChecksum to reset
/// </param>

	public static void Reset(this MentorLake.GLib.GChecksumHandle checksum)
	{
		if (checksum.IsInvalid) throw new Exception("Invalid handle (GChecksum)");
		GChecksumExterns.g_checksum_reset(checksum);
	}

/// <summary>
/// <para>
/// Feeds @data into an existing #GChecksum. The checksum must still be
/// open, that is g_checksum_get_string() or g_checksum_get_digest() must
/// not have been called on @checksum.
/// </para>
/// </summary>

/// <param name="checksum">
/// a #GChecksum
/// </param>
/// <param name="data">
/// buffer used to compute the checksum
/// </param>
/// <param name="length">
/// size of the buffer, or -1 if it is a null-terminated string.
/// </param>

	public static void Update(this MentorLake.GLib.GChecksumHandle checksum, byte[] data, UIntPtr length)
	{
		if (checksum.IsInvalid) throw new Exception("Invalid handle (GChecksum)");
		GChecksumExterns.g_checksum_update(checksum, data, length);
	}


	public static GChecksum Dereference(this GChecksumHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GChecksum>(x.DangerousGetHandle());
}
internal class GChecksumExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GChecksumHandle>))]
	internal static extern MentorLake.GLib.GChecksumHandle g_checksum_new(MentorLake.GLib.GChecksumType checksum_type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GChecksumHandle>))]
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

/// <summary>
/// <para>
/// GLib provides a generic API for computing checksums (or ‘digests’)
/// for a sequence of arbitrary bytes, using various hashing algorithms
/// like MD5, SHA-1 and SHA-256. Checksums are commonly used in various
/// environments and specifications.
/// </para>
/// <para>
/// To create a new `GChecksum`, use [ctor@GLib.Checksum.new]. To free
/// a `GChecksum`, use [method@GLib.Checksum.free].
/// </para>
/// <para>
/// GLib supports incremental checksums using the `GChecksum` data
/// structure, by calling [method@GLib.Checksum.update] as long as there’s data
/// available and then using [method@GLib.Checksum.get_string] or
/// [method@GLib.Checksum.get_digest] to compute the checksum and return it
/// either as a string in hexadecimal form, or as a raw sequence of bytes. To
/// compute the checksum for binary blobs and nul-terminated strings in
/// one go, use the convenience functions [func@GLib.compute_checksum_for_data]
/// and [func@GLib.compute_checksum_for_string], respectively.
/// </para>
/// </summary>

public struct GChecksum
{
/// <summary>
/// <para>
/// Gets the length in bytes of digests of type @checksum_type
/// </para>
/// </summary>

/// <param name="checksum_type">
/// a #GChecksumType
/// </param>
/// <return>
/// the checksum length, or -1 if @checksum_type is
/// not supported.
/// </return>

	public static UIntPtr TypeGetLength(MentorLake.GLib.GChecksumType checksum_type)
	{
		return GChecksumExterns.g_checksum_type_get_length(checksum_type);
	}

}
