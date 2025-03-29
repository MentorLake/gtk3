namespace MentorLake.GLib;

public class GStringChunkHandle : BaseSafeHandle
{
}


public static class GStringChunkExtensions
{
	public static void Clear(this MentorLake.GLib.GStringChunkHandle chunk)
	{
		if (chunk.IsInvalid || chunk.IsClosed) throw new Exception("Invalid or closed handle (GStringChunk)");
		GStringChunkExterns.g_string_chunk_clear(chunk);
	}

	public static void Free(this MentorLake.GLib.GStringChunkHandle chunk)
	{
		if (chunk.IsInvalid || chunk.IsClosed) throw new Exception("Invalid or closed handle (GStringChunk)");
		GStringChunkExterns.g_string_chunk_free(chunk);
	}

	public static string Insert(this MentorLake.GLib.GStringChunkHandle chunk, string @string)
	{
		if (chunk.IsInvalid || chunk.IsClosed) throw new Exception("Invalid or closed handle (GStringChunk)");
		return GStringChunkExterns.g_string_chunk_insert(chunk, @string);
	}

	public static string InsertConst(this MentorLake.GLib.GStringChunkHandle chunk, string @string)
	{
		if (chunk.IsInvalid || chunk.IsClosed) throw new Exception("Invalid or closed handle (GStringChunk)");
		return GStringChunkExterns.g_string_chunk_insert_const(chunk, @string);
	}

	public static string InsertLen(this MentorLake.GLib.GStringChunkHandle chunk, string @string, UIntPtr len)
	{
		if (chunk.IsInvalid || chunk.IsClosed) throw new Exception("Invalid or closed handle (GStringChunk)");
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
	internal static extern MentorLake.GLib.GStringChunkHandle g_string_chunk_new(UIntPtr size);

}

public struct GStringChunk
{
	public static MentorLake.GLib.GStringChunkHandle New(UIntPtr size)
	{
		return GStringChunkExterns.g_string_chunk_new(size);
	}

}
