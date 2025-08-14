namespace MentorLake.GLib;

/// <summary>
/// <para>
/// `GStringChunk` provides efficient storage of groups of strings
/// </para>
/// <para>
/// String chunks are used to store groups of strings. Memory is
/// allocated in blocks, and as strings are added to the `GStringChunk`
/// they are copied into the next free position in a block. When a block
/// is full a new block is allocated.
/// </para>
/// <para>
/// When storing a large number of strings, string chunks are more
/// efficient than using [func@GLib.strdup] since fewer calls to `malloc()`
/// are needed, and less memory is wasted in memory allocation overheads.
/// </para>
/// <para>
/// By adding strings with [method@GLib.StringChunk.insert_const] it is also
/// possible to remove duplicates.
/// </para>
/// <para>
/// To create a new `GStringChunk` use [func@GLib.StringChunk.new].
/// </para>
/// <para>
/// To add strings to a `GStringChunk` use [method@GLib.StringChunk.insert].
/// </para>
/// <para>
/// To add strings to a `GStringChunk`, but without duplicating strings
/// which are already in the `GStringChunk`, use [method@GLib.StringChunk.insert_const].
/// </para>
/// <para>
/// To free the entire `GStringChunk` use [method@GLib.StringChunk.free].
/// It is not possible to free individual strings.
/// </para>
/// </summary>

public class GStringChunkHandle : BaseSafeHandle
{
}


public static class GStringChunkExtensions
{
/// <summary>
/// <para>
/// Frees all strings contained within the #GStringChunk.
/// After calling g_string_chunk_clear() it is not safe to
/// access any of the strings which were contained within it.
/// </para>
/// </summary>

/// <param name="chunk">
/// a #GStringChunk
/// </param>

	public static void Clear(this MentorLake.GLib.GStringChunkHandle chunk)
	{
		if (chunk.IsInvalid) throw new Exception("Invalid handle (GStringChunk)");
		GStringChunkExterns.g_string_chunk_clear(chunk);
	}

/// <summary>
/// <para>
/// Frees all memory allocated by the #GStringChunk.
/// After calling g_string_chunk_free() it is not safe to
/// access any of the strings which were contained within it.
/// </para>
/// </summary>

/// <param name="chunk">
/// a #GStringChunk
/// </param>

	public static void Free(this MentorLake.GLib.GStringChunkHandle chunk)
	{
		if (chunk.IsInvalid) throw new Exception("Invalid handle (GStringChunk)");
		GStringChunkExterns.g_string_chunk_free(chunk);
	}

/// <summary>
/// <para>
/// Adds a copy of @string to the #GStringChunk.
/// It returns a pointer to the new copy of the string
/// in the #GStringChunk. The characters in the string
/// can be changed, if necessary, though you should not
/// change anything after the end of the string.
/// </para>
/// <para>
/// Unlike g_string_chunk_insert_const(), this function
/// does not check for duplicates. Also strings added
/// with g_string_chunk_insert() will not be searched
/// by g_string_chunk_insert_const() when looking for
/// duplicates.
/// </para>
/// </summary>

/// <param name="chunk">
/// a #GStringChunk
/// </param>
/// <param name="@string">
/// the string to add
/// </param>
/// <return>
/// a pointer to the copy of @string within
///     the #GStringChunk
/// </return>

	public static string Insert(this MentorLake.GLib.GStringChunkHandle chunk, string @string)
	{
		if (chunk.IsInvalid) throw new Exception("Invalid handle (GStringChunk)");
		return GStringChunkExterns.g_string_chunk_insert(chunk, @string);
	}

/// <summary>
/// <para>
/// Adds a copy of @string to the #GStringChunk, unless the same
/// string has already been added to the #GStringChunk with
/// g_string_chunk_insert_const().
/// </para>
/// <para>
/// This function is useful if you need to copy a large number
/// of strings but do not want to waste space storing duplicates.
/// But you must remember that there may be several pointers to
/// the same string, and so any changes made to the strings
/// should be done very carefully.
/// </para>
/// <para>
/// Note that g_string_chunk_insert_const() will not return a
/// pointer to a string added with g_string_chunk_insert(), even
/// if they do match.
/// </para>
/// </summary>

/// <param name="chunk">
/// a #GStringChunk
/// </param>
/// <param name="@string">
/// the string to add
/// </param>
/// <return>
/// a pointer to the new or existing copy of @string
///     within the #GStringChunk
/// </return>

	public static string InsertConst(this MentorLake.GLib.GStringChunkHandle chunk, string @string)
	{
		if (chunk.IsInvalid) throw new Exception("Invalid handle (GStringChunk)");
		return GStringChunkExterns.g_string_chunk_insert_const(chunk, @string);
	}

/// <summary>
/// <para>
/// Adds a copy of the first @len bytes of @string to the #GStringChunk.
/// The copy is nul-terminated.
/// </para>
/// <para>
/// Since this function does not stop at nul bytes, it is the caller's
/// responsibility to ensure that @string has at least @len addressable
/// bytes.
/// </para>
/// <para>
/// The characters in the returned string can be changed, if necessary,
/// though you should not change anything after the end of the string.
/// </para>
/// </summary>

/// <param name="chunk">
/// a #GStringChunk
/// </param>
/// <param name="@string">
/// bytes to insert
/// </param>
/// <param name="len">
/// number of bytes of @string to insert, or -1 to insert a
///     nul-terminated string
/// </param>
/// <return>
/// a pointer to the copy of @string within the #GStringChunk
/// </return>

	public static string InsertLen(this MentorLake.GLib.GStringChunkHandle chunk, string @string, UIntPtr len)
	{
		if (chunk.IsInvalid) throw new Exception("Invalid handle (GStringChunk)");
		return GStringChunkExterns.g_string_chunk_insert_len(chunk, @string, len);
	}


	public static GStringChunk Dereference(this GStringChunkHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStringChunk>(x.DangerousGetHandle());
}
internal class GStringChunkExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_string_chunk_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringChunkHandle>))] MentorLake.GLib.GStringChunkHandle chunk);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_string_chunk_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringChunkHandle>))] MentorLake.GLib.GStringChunkHandle chunk);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_string_chunk_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringChunkHandle>))] MentorLake.GLib.GStringChunkHandle chunk, string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_string_chunk_insert_const([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringChunkHandle>))] MentorLake.GLib.GStringChunkHandle chunk, string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_string_chunk_insert_len([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringChunkHandle>))] MentorLake.GLib.GStringChunkHandle chunk, string @string, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringChunkHandle>))]
	internal static extern MentorLake.GLib.GStringChunkHandle g_string_chunk_new(UIntPtr size);

}

/// <summary>
/// <para>
/// `GStringChunk` provides efficient storage of groups of strings
/// </para>
/// <para>
/// String chunks are used to store groups of strings. Memory is
/// allocated in blocks, and as strings are added to the `GStringChunk`
/// they are copied into the next free position in a block. When a block
/// is full a new block is allocated.
/// </para>
/// <para>
/// When storing a large number of strings, string chunks are more
/// efficient than using [func@GLib.strdup] since fewer calls to `malloc()`
/// are needed, and less memory is wasted in memory allocation overheads.
/// </para>
/// <para>
/// By adding strings with [method@GLib.StringChunk.insert_const] it is also
/// possible to remove duplicates.
/// </para>
/// <para>
/// To create a new `GStringChunk` use [func@GLib.StringChunk.new].
/// </para>
/// <para>
/// To add strings to a `GStringChunk` use [method@GLib.StringChunk.insert].
/// </para>
/// <para>
/// To add strings to a `GStringChunk`, but without duplicating strings
/// which are already in the `GStringChunk`, use [method@GLib.StringChunk.insert_const].
/// </para>
/// <para>
/// To free the entire `GStringChunk` use [method@GLib.StringChunk.free].
/// It is not possible to free individual strings.
/// </para>
/// </summary>

public struct GStringChunk
{
/// <summary>
/// <para>
/// Creates a new #GStringChunk.
/// </para>
/// </summary>

/// <param name="size">
/// the default size of the blocks of memory which are
///     allocated to store the strings. If a particular string
///     is larger than this default size, a larger block of
///     memory will be allocated for it.
/// </param>
/// <return>
/// a new #GStringChunk
/// </return>

	public static MentorLake.GLib.GStringChunkHandle New(UIntPtr size)
	{
		return GStringChunkExterns.g_string_chunk_new(size);
	}

}
