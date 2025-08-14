namespace MentorLake.GLib;

/// <summary>
/// <para>
/// HMACs should be used when producing a cookie or hash based on data
/// and a key. Simple mechanisms for using SHA1 and other algorithms to
/// digest a key and data together are vulnerable to various security
/// issues.
/// [HMAC](http://en.wikipedia.org/wiki/HMAC)
/// uses algorithms like SHA1 in a secure way to produce a digest of a
/// key and data.
/// </para>
/// <para>
/// Both the key and data are arbitrary byte arrays of bytes or characters.
/// </para>
/// <para>
/// Support for HMAC Digests has been added in GLib 2.30, and support for SHA-512
/// in GLib 2.42. Support for SHA-384 was added in GLib 2.52.
/// </para>
/// <para>
/// To create a new `GHmac`, use [ctor@GLib.Hmac.new]. To free a `GHmac`, use
/// [method@GLib.Hmac.unref].
/// </para>
/// </summary>

public class GHmacHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GHmac, using the digest algorithm @digest_type.
/// If the @digest_type is not known, %NULL is returned.
/// A #GHmac can be used to compute the HMAC of a key and an
/// arbitrary binary blob, using different hashing algorithms.
/// </para>
/// <para>
/// A #GHmac works by feeding a binary blob through g_hmac_update()
/// until the data is complete; the digest can then be extracted
/// using g_hmac_get_string(), which will return the checksum as a
/// hexadecimal string; or g_hmac_get_digest(), which will return a
/// array of raw bytes. Once either g_hmac_get_string() or
/// g_hmac_get_digest() have been called on a #GHmac, the HMAC
/// will be closed and it won't be possible to call g_hmac_update()
/// on it anymore.
/// </para>
/// <para>
/// Support for digests of type %G_CHECKSUM_SHA512 has been added in GLib 2.42.
/// Support for %G_CHECKSUM_SHA384 was added in GLib 2.52.
/// </para>
/// </summary>

/// <param name="digest_type">
/// the desired type of digest
/// </param>
/// <param name="key">
/// the key for the HMAC
/// </param>
/// <param name="key_len">
/// the length of the keys
/// </param>
/// <return>
/// the newly created #GHmac, or %NULL.
///   Use g_hmac_unref() to free the memory allocated by it.
/// </return>

	public static MentorLake.GLib.GHmacHandle New(MentorLake.GLib.GChecksumType digest_type, byte[] key, UIntPtr key_len)
	{
		return GHmacExterns.g_hmac_new(digest_type, key, key_len);
	}

}


public static class GHmacExtensions
{
/// <summary>
/// <para>
/// Copies a #GHmac. If @hmac has been closed, by calling
/// g_hmac_get_string() or g_hmac_get_digest(), the copied
/// HMAC will be closed as well.
/// </para>
/// </summary>

/// <param name="hmac">
/// the #GHmac to copy
/// </param>
/// <return>
/// the copy of the passed #GHmac. Use g_hmac_unref()
///   when finished using it.
/// </return>

	public static MentorLake.GLib.GHmacHandle Copy(this MentorLake.GLib.GHmacHandle hmac)
	{
		if (hmac.IsInvalid) throw new Exception("Invalid handle (GHmac)");
		return GHmacExterns.g_hmac_copy(hmac);
	}

/// <summary>
/// <para>
/// Gets the digest from @checksum as a raw binary array and places it
/// into @buffer. The size of the digest depends on the type of checksum.
/// </para>
/// <para>
/// Once this function has been called, the #GHmac is closed and can
/// no longer be updated with g_checksum_update().
/// </para>
/// </summary>

/// <param name="hmac">
/// a #GHmac
/// </param>
/// <param name="buffer">
/// output buffer
/// </param>
/// <param name="digest_len">
/// an inout parameter. The caller initializes it to the
///   size of @buffer. After the call it contains the length of the digest
/// </param>

	public static void GetDigest(this MentorLake.GLib.GHmacHandle hmac, byte[] buffer, ref UIntPtr digest_len)
	{
		if (hmac.IsInvalid) throw new Exception("Invalid handle (GHmac)");
		GHmacExterns.g_hmac_get_digest(hmac, buffer, ref digest_len);
	}

/// <summary>
/// <para>
/// Gets the HMAC as a hexadecimal string.
/// </para>
/// <para>
/// Once this function has been called the #GHmac can no longer be
/// updated with g_hmac_update().
/// </para>
/// <para>
/// The hexadecimal characters will be lower case.
/// </para>
/// </summary>

/// <param name="hmac">
/// a #GHmac
/// </param>
/// <return>
/// the hexadecimal representation of the HMAC. The
///   returned string is owned by the HMAC and should not be modified
///   or freed.
/// </return>

	public static string GetString(this MentorLake.GLib.GHmacHandle hmac)
	{
		if (hmac.IsInvalid) throw new Exception("Invalid handle (GHmac)");
		return GHmacExterns.g_hmac_get_string(hmac);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @hmac by one.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="hmac">
/// a valid #GHmac
/// </param>
/// <return>
/// the passed in #GHmac.
/// </return>

	public static MentorLake.GLib.GHmacHandle Ref(this MentorLake.GLib.GHmacHandle hmac)
	{
		if (hmac.IsInvalid) throw new Exception("Invalid handle (GHmac)");
		return GHmacExterns.g_hmac_ref(hmac);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @hmac by one.
/// </para>
/// <para>
/// If the reference count drops to 0, all keys and values will be
/// destroyed, and all memory allocated by the hash table is released.
/// This function is MT-safe and may be called from any thread.
/// Frees the memory allocated for @hmac.
/// </para>
/// </summary>

/// <param name="hmac">
/// a #GHmac
/// </param>

	public static void Unref(this MentorLake.GLib.GHmacHandle hmac)
	{
		if (hmac.IsInvalid) throw new Exception("Invalid handle (GHmac)");
		GHmacExterns.g_hmac_unref(hmac);
	}

/// <summary>
/// <para>
/// Feeds @data into an existing #GHmac.
/// </para>
/// <para>
/// The HMAC must still be open, that is g_hmac_get_string() or
/// g_hmac_get_digest() must not have been called on @hmac.
/// </para>
/// </summary>

/// <param name="hmac">
/// a #GHmac
/// </param>
/// <param name="data">
/// buffer used to compute the checksum
/// </param>
/// <param name="length">
/// size of the buffer, or -1 if it is a nul-terminated string
/// </param>

	public static void Update(this MentorLake.GLib.GHmacHandle hmac, byte[] data, UIntPtr length)
	{
		if (hmac.IsInvalid) throw new Exception("Invalid handle (GHmac)");
		GHmacExterns.g_hmac_update(hmac, data, length);
	}


	public static GHmac Dereference(this GHmacHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GHmac>(x.DangerousGetHandle());
}
internal class GHmacExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))]
	internal static extern MentorLake.GLib.GHmacHandle g_hmac_new(MentorLake.GLib.GChecksumType digest_type, byte[] key, UIntPtr key_len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))]
	internal static extern MentorLake.GLib.GHmacHandle g_hmac_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))] MentorLake.GLib.GHmacHandle hmac);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hmac_get_digest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))] MentorLake.GLib.GHmacHandle hmac, byte[] buffer, ref UIntPtr digest_len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_hmac_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))] MentorLake.GLib.GHmacHandle hmac);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))]
	internal static extern MentorLake.GLib.GHmacHandle g_hmac_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))] MentorLake.GLib.GHmacHandle hmac);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hmac_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))] MentorLake.GLib.GHmacHandle hmac);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hmac_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHmacHandle>))] MentorLake.GLib.GHmacHandle hmac, byte[] data, UIntPtr length);

}

/// <summary>
/// <para>
/// HMACs should be used when producing a cookie or hash based on data
/// and a key. Simple mechanisms for using SHA1 and other algorithms to
/// digest a key and data together are vulnerable to various security
/// issues.
/// [HMAC](http://en.wikipedia.org/wiki/HMAC)
/// uses algorithms like SHA1 in a secure way to produce a digest of a
/// key and data.
/// </para>
/// <para>
/// Both the key and data are arbitrary byte arrays of bytes or characters.
/// </para>
/// <para>
/// Support for HMAC Digests has been added in GLib 2.30, and support for SHA-512
/// in GLib 2.42. Support for SHA-384 was added in GLib 2.52.
/// </para>
/// <para>
/// To create a new `GHmac`, use [ctor@GLib.Hmac.new]. To free a `GHmac`, use
/// [method@GLib.Hmac.unref].
/// </para>
/// </summary>

public struct GHmac
{
}
