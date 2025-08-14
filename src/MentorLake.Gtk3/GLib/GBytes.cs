namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A simple reference counted data type representing an immutable sequence of
/// zero or more bytes from an unspecified origin.
/// </para>
/// <para>
/// The purpose of a `GBytes` is to keep the memory region that it holds
/// alive for as long as anyone holds a reference to the bytes.  When
/// the last reference count is dropped, the memory is released. Multiple
/// unrelated callers can use byte data in the `GBytes` without coordinating
/// their activities, resting assured that the byte data will not change or
/// move while they hold a reference.
/// </para>
/// <para>
/// A `GBytes` can come from many different origins that may have
/// different procedures for freeing the memory region.  Examples are
/// memory from [func@GLib.malloc], from memory slices, from a
/// [struct@GLib.MappedFile] or memory from other allocators.
/// </para>
/// <para>
/// `GBytes` work well as keys in [struct@GLib.HashTable]. Use
/// [method@GLib.Bytes.equal] and [method@GLib.Bytes.hash] as parameters to
/// [func@GLib.HashTable.new] or [func@GLib.HashTable.new_full].
/// `GBytes` can also be used as keys in a [struct@GLib.Tree] by passing the
/// [method@GLib.Bytes.compare] function to [ctor@GLib.Tree.new].
/// </para>
/// <para>
/// The data pointed to by this bytes must not be modified. For a mutable
/// array of bytes see [struct@GLib.ByteArray]. Use
/// [method@GLib.Bytes.unref_to_array] to create a mutable array for a `GBytes`
/// sequence. To create an immutable `GBytes` from a mutable
/// [struct@GLib.ByteArray], use the [func@GLib.ByteArray.free_to_bytes]
/// function.
/// </para>
/// </summary>

public class GBytesHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new [struct@GLib.Bytes] from @data.
/// </para>
/// <para>
/// @data is copied. If @size is 0, @data may be `NULL`.
/// </para>
/// <para>
/// As an optimization, [ctor@GLib.Bytes.new] may avoid an extra allocation by
/// copying the data within the resulting bytes structure if sufficiently small
/// (since GLib 2.84).
/// </para>
/// </summary>

/// <param name="data">
/// 
///   the data to be used for the bytes
/// </param>
/// <param name="size">
/// the size of @data
/// </param>
/// <return>
/// a new [struct@GLib.Bytes]
/// </return>

	public static MentorLake.GLib.GBytesHandle New(byte[] data, UIntPtr size)
	{
		return GBytesExterns.g_bytes_new(data, size);
	}

/// <summary>
/// <para>
/// Creates a new [struct@GLib.Bytes] from static data.
/// </para>
/// <para>
/// @data must be static (ie: never modified or freed). It may be `NULL` if @size
/// is 0.
/// </para>
/// </summary>

/// <param name="data">
/// 
///   the data to be used for the bytes
/// </param>
/// <param name="size">
/// the size of @data
/// </param>
/// <return>
/// a new [struct@GLib.Bytes]
/// </return>

	public static MentorLake.GLib.GBytesHandle NewStatic(byte[] data, UIntPtr size)
	{
		return GBytesExterns.g_bytes_new_static(data, size);
	}

/// <summary>
/// <para>
/// Creates a new [struct@GLib.Bytes] from @data.
/// </para>
/// <para>
/// After this call, @data belongs to the `GBytes` and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with [func@GLib.free].
/// </para>
/// <para>
/// For creating `GBytes` with memory from other allocators, see
/// [ctor@GLib.Bytes.new_with_free_func].
/// </para>
/// <para>
/// @data may be `NULL` if @size is 0.
/// </para>
/// </summary>

/// <param name="data">
/// 
///   the data to be used for the bytes
/// </param>
/// <param name="size">
/// the size of @data
/// </param>
/// <return>
/// a new [struct@GLib.Bytes]
/// </return>

	public static MentorLake.GLib.GBytesHandle NewTake(byte[] data, UIntPtr size)
	{
		return GBytesExterns.g_bytes_new_take(data, size);
	}

/// <summary>
/// <para>
/// Creates a [struct@GLib.Bytes] from @data.
/// </para>
/// <para>
/// When the last reference is dropped, @free_func will be called with the
/// @user_data argument.
/// </para>
/// <para>
/// @data must not be modified after this call is made until @free_func has
/// been called to indicate that the bytes is no longer in use.
/// </para>
/// <para>
/// @data may be `NULL` if @size is 0.
/// </para>
/// </summary>

/// <param name="data">
/// 
///   the data to be used for the bytes
/// </param>
/// <param name="size">
/// the size of @data
/// </param>
/// <param name="free_func">
/// the function to call to release the data
/// </param>
/// <param name="user_data">
/// data to pass to @free_func
/// </param>
/// <return>
/// a new [struct@GLib.Bytes]
/// </return>

	public static MentorLake.GLib.GBytesHandle NewWithFreeFunc(byte[] data, UIntPtr size, MentorLake.GLib.GDestroyNotify free_func, IntPtr user_data)
	{
		return GBytesExterns.g_bytes_new_with_free_func(data, size, free_func, user_data);
	}

}


public static class GBytesExtensions
{
/// <summary>
/// <para>
/// Compares the two [struct@GLib.Bytes] values.
/// </para>
/// <para>
/// This function can be used to sort `GBytes` instances in lexicographical
/// order.
/// </para>
/// <para>
/// If @bytes1 and @bytes2 have different length but the shorter one is a
/// prefix of the longer one then the shorter one is considered to be less than
/// the longer one. Otherwise the first byte where both differ is used for
/// comparison. If @bytes1 has a smaller value at that position it is
/// considered less, otherwise greater than @bytes2.
/// </para>
/// </summary>

/// <param name="bytes1">
/// a pointer to a [struct@GLib.Bytes]
/// </param>
/// <param name="bytes2">
/// a pointer to a [struct@GLib.Bytes] to compare with @bytes1
/// </param>
/// <return>
/// a negative value if @bytes1 is less than @bytes2, a positive value
///   if @bytes1 is greater than @bytes2, and zero if @bytes1 is equal to @bytes2
/// </return>

	public static int Compare(this MentorLake.GLib.GBytesHandle bytes1, MentorLake.GLib.GBytesHandle bytes2)
	{
		if (bytes1.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_compare(bytes1, bytes2);
	}

/// <summary>
/// <para>
/// Compares the two [struct@GLib.Bytes] values being pointed to and returns
/// `TRUE` if they are equal.
/// </para>
/// <para>
/// This function can be passed to [func@GLib.HashTable.new] as the
/// @key_equal_func parameter, when using non-`NULL` `GBytes` pointers as keys in
/// a [struct@GLib.HashTable].
/// </para>
/// </summary>

/// <param name="bytes1">
/// a pointer to a [struct@GLib.Bytes]
/// </param>
/// <param name="bytes2">
/// a pointer to a [struct@GLib.Bytes] to compare with @bytes1
/// </param>
/// <return>
/// `TRUE` if the two keys match.
/// </return>

	public static bool Equal(this MentorLake.GLib.GBytesHandle bytes1, MentorLake.GLib.GBytesHandle bytes2)
	{
		if (bytes1.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_equal(bytes1, bytes2);
	}

/// <summary>
/// <para>
/// Get the byte data in the [struct@GLib.Bytes].
/// </para>
/// <para>
/// This data should not be modified.
/// </para>
/// <para>
/// This function will always return the same pointer for a given `GBytes`.
/// </para>
/// <para>
/// `NULL` may be returned if @size is 0. This is not guaranteed, as the `GBytes`
/// may represent an empty string with @data non-`NULL` and @size as 0. `NULL`
/// will not be returned if @size is non-zero.
/// </para>
/// </summary>

/// <param name="bytes">
/// a [struct@GLib.Bytes]
/// </param>
/// <param name="size">
/// location to return size of byte data
/// </param>
/// <return>
/// 
///   a pointer to the byte data
/// </return>

	public static byte[] GetData(this MentorLake.GLib.GBytesHandle bytes, out UIntPtr size)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_get_data(bytes, out size);
	}

/// <summary>
/// <para>
/// Gets a pointer to a region in @bytes.
/// </para>
/// <para>
/// The region starts at @offset many bytes from the start of the data
/// and contains @n_elements many elements of @element_size size.
/// </para>
/// <para>
/// @n_elements may be zero, but @element_size must always be non-zero.
/// Ideally, @element_size is a static constant (eg: `sizeof` a struct).
/// </para>
/// <para>
/// This function does careful bounds checking (including checking for
/// arithmetic overflows) and returns a non-`NULL` pointer if the
/// specified region lies entirely within the @bytes. If the region is
/// in some way out of range, or if an overflow has occurred, then `NULL`
/// is returned.
/// </para>
/// <para>
/// Note: it is possible to have a valid zero-size region. In this case,
/// the returned pointer will be equal to the base pointer of the data of
/// @bytes, plus @offset.  This will be non-`NULL` except for the case
/// where @bytes itself was a zero-sized region.  Since it is unlikely
/// that you will be using this function to check for a zero-sized region
/// in a zero-sized @bytes, `NULL` effectively always means ‘error’.
/// </para>
/// </summary>

/// <param name="bytes">
/// a [struct@GLib.Bytes]
/// </param>
/// <param name="element_size">
/// a non-zero element size
/// </param>
/// <param name="offset">
/// an offset to the start of the region within the @bytes
/// </param>
/// <param name="n_elements">
/// the number of elements in the region
/// </param>
/// <return>
/// the requested region, or `NULL` in case of an error
/// </return>

	public static IntPtr GetRegion(this MentorLake.GLib.GBytesHandle bytes, UIntPtr element_size, UIntPtr offset, UIntPtr n_elements)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_get_region(bytes, element_size, offset, n_elements);
	}

/// <summary>
/// <para>
/// Get the size of the byte data in the [struct@GLib.Bytes].
/// </para>
/// <para>
/// This function will always return the same value for a given `GBytes`.
/// </para>
/// </summary>

/// <param name="bytes">
/// a [struct@GLib.Bytes]
/// </param>
/// <return>
/// the size
/// </return>

	public static UIntPtr GetSize(this MentorLake.GLib.GBytesHandle bytes)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_get_size(bytes);
	}

/// <summary>
/// <para>
/// Creates an integer hash code for the byte data in the [struct@GLib.Bytes].
/// </para>
/// <para>
/// This function can be passed to [func@GLib.HashTable.new] as the
/// @key_hash_func parameter, when using non-`NULL` `GBytes` pointers as keys in
/// a [struct@GLib.HashTable].
/// </para>
/// </summary>

/// <param name="bytes">
/// a pointer to a [struct@GLib.Bytes] key
/// </param>
/// <return>
/// a hash value corresponding to the key.
/// </return>

	public static uint Hash(this MentorLake.GLib.GBytesHandle bytes)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_hash(bytes);
	}

/// <summary>
/// <para>
/// Creates a [struct@GLib.Bytes] which is a subsection of another `GBytes`.
/// </para>
/// <para>
/// The @offset + @length may not be longer than the size of @bytes.
/// </para>
/// <para>
/// A reference to @bytes will be held by the newly created `GBytes` until
/// the byte data is no longer needed.
/// </para>
/// <para>
/// Since 2.56, if @offset is 0 and @length matches the size of @bytes, then
/// @bytes will be returned with the reference count incremented by 1. If @bytes
/// is a slice of another `GBytes`, then the resulting `GBytes` will reference
/// the same `GBytes` instead of @bytes. This allows consumers to simplify the
/// usage of `GBytes` when asynchronously writing to streams.
/// </para>
/// </summary>

/// <param name="bytes">
/// a [struct@GLib.Bytes]
/// </param>
/// <param name="offset">
/// offset which subsection starts at
/// </param>
/// <param name="length">
/// length of subsection
/// </param>
/// <return>
/// a new [struct@GLib.Bytes]
/// </return>

	public static MentorLake.GLib.GBytesHandle NewFromBytes(this MentorLake.GLib.GBytesHandle bytes, UIntPtr offset, UIntPtr length)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_new_from_bytes(bytes, offset, length);
	}

/// <summary>
/// <para>
/// Increase the reference count on @bytes.
/// </para>
/// </summary>

/// <param name="bytes">
/// a [struct@GLib.Bytes]
/// </param>
/// <return>
/// the [struct@GLib.Bytes]
/// </return>

	public static MentorLake.GLib.GBytesHandle Ref(this MentorLake.GLib.GBytesHandle bytes)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_ref(bytes);
	}

/// <summary>
/// <para>
/// Releases a reference on @bytes.
/// </para>
/// <para>
/// This may result in the bytes being freed. If @bytes is `NULL`, it will
/// return immediately.
/// </para>
/// </summary>

/// <param name="bytes">
/// a [struct@GLib.Bytes]
/// </param>

	public static void Unref(this MentorLake.GLib.GBytesHandle bytes)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		GBytesExterns.g_bytes_unref(bytes);
	}

/// <summary>
/// <para>
/// Unreferences the bytes, and returns a new mutable [struct@GLib.ByteArray]
/// containing the same byte data.
/// </para>
/// <para>
/// As an optimization, the byte data is transferred to the array without copying
/// if this was the last reference to @bytes and @bytes was created with
/// [ctor@GLib.Bytes.new], [ctor@GLib.Bytes.new_take] or
/// [func@GLib.ByteArray.free_to_bytes] and the buffer was larger than the size
/// [struct@GLib.Bytes] may internalize within its allocation. In all other cases
/// the data is copied.
/// </para>
/// <para>
/// Do not use it if @bytes contains more than %G_MAXUINT
/// bytes. [struct@GLib.ByteArray] stores the length of its data in `guint`,
/// which may be shorter than `gsize`, that @bytes is using.
/// </para>
/// </summary>

/// <param name="bytes">
/// a [struct@GLib.Bytes]
/// </param>
/// <return>
/// a new mutable [struct@GLib.ByteArray] containing
///   the same byte data
/// </return>

	public static MentorLake.GLib.GByteArrayHandle UnrefToArray(this MentorLake.GLib.GBytesHandle bytes)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_unref_to_array(bytes);
	}

/// <summary>
/// <para>
/// Unreferences the bytes, and returns a pointer the same byte data
/// contents.
/// </para>
/// <para>
/// As an optimization, the byte data is returned without copying if this was
/// the last reference to @bytes and @bytes was created with
/// [ctor@GLib.Bytes.new], [ctor@GLib.Bytes.new_take] or
/// [func@GLib.ByteArray.free_to_bytes] and the buffer was larger than the size
/// [struct@GLib.Bytes] may internalize within its allocation. In all other cases
/// the data is copied.
/// </para>
/// </summary>

/// <param name="bytes">
/// a [struct@GLib.Bytes]
/// </param>
/// <param name="size">
/// location to place the length of the returned data
/// </param>
/// <return>
/// 
///   a pointer to the same byte data, which should be freed with [func@GLib.free]
/// </return>

	public static byte[] UnrefToData(this MentorLake.GLib.GBytesHandle bytes, out UIntPtr size)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_unref_to_data(bytes, out size);
	}


	public static GBytes Dereference(this GBytesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GBytes>(x.DangerousGetHandle());
}
internal class GBytesExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_new(byte[] data, UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_new_static(byte[] data, UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_new_take(byte[] data, UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_new_with_free_func(byte[] data, UIntPtr size, MentorLake.GLib.GDestroyNotify free_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_bytes_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes2);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bytes_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes2);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_bytes_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, out UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_bytes_get_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, UIntPtr element_size, UIntPtr offset, UIntPtr n_elements);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_bytes_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_bytes_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_new_from_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, UIntPtr offset, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bytes_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_bytes_unref_to_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_bytes_unref_to_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, out UIntPtr size);

}

/// <summary>
/// <para>
/// A simple reference counted data type representing an immutable sequence of
/// zero or more bytes from an unspecified origin.
/// </para>
/// <para>
/// The purpose of a `GBytes` is to keep the memory region that it holds
/// alive for as long as anyone holds a reference to the bytes.  When
/// the last reference count is dropped, the memory is released. Multiple
/// unrelated callers can use byte data in the `GBytes` without coordinating
/// their activities, resting assured that the byte data will not change or
/// move while they hold a reference.
/// </para>
/// <para>
/// A `GBytes` can come from many different origins that may have
/// different procedures for freeing the memory region.  Examples are
/// memory from [func@GLib.malloc], from memory slices, from a
/// [struct@GLib.MappedFile] or memory from other allocators.
/// </para>
/// <para>
/// `GBytes` work well as keys in [struct@GLib.HashTable]. Use
/// [method@GLib.Bytes.equal] and [method@GLib.Bytes.hash] as parameters to
/// [func@GLib.HashTable.new] or [func@GLib.HashTable.new_full].
/// `GBytes` can also be used as keys in a [struct@GLib.Tree] by passing the
/// [method@GLib.Bytes.compare] function to [ctor@GLib.Tree.new].
/// </para>
/// <para>
/// The data pointed to by this bytes must not be modified. For a mutable
/// array of bytes see [struct@GLib.ByteArray]. Use
/// [method@GLib.Bytes.unref_to_array] to create a mutable array for a `GBytes`
/// sequence. To create an immutable `GBytes` from a mutable
/// [struct@GLib.ByteArray], use the [func@GLib.ByteArray.free_to_bytes]
/// function.
/// </para>
/// </summary>

public struct GBytes
{
}
