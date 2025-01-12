namespace MentorLake.Gtk3.GLib;

public class GStringChunkHandle : BaseSafeHandle
{
}


public static class GStringChunkHandleExtensions
{
	public static T Clear<T>(this T chunk) where T : GStringChunkHandle
	{
		GStringChunkExterns.g_string_chunk_clear(chunk);
		return chunk;
	}

	public static T Free<T>(this T chunk) where T : GStringChunkHandle
	{
		GStringChunkExterns.g_string_chunk_free(chunk);
		return chunk;
	}

	public static string Insert(this GStringChunkHandle chunk, string @string)
	{
		return GStringChunkExterns.g_string_chunk_insert(chunk, @string);
	}

	public static string InsertConst(this GStringChunkHandle chunk, string @string)
	{
		return GStringChunkExterns.g_string_chunk_insert_const(chunk, @string);
	}

	public static string InsertLen(this GStringChunkHandle chunk, string @string, UIntPtr len)
	{
		return GStringChunkExterns.g_string_chunk_insert_len(chunk, @string, len);
	}

	public static GStringChunkHandle New(UIntPtr size)
	{
		return GStringChunkExterns.g_string_chunk_new(size);
	}

}
internal class GStringChunkExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_string_chunk_clear(GStringChunkHandle chunk);

	[DllImport(Libraries.GLib)]
	internal static extern void g_string_chunk_free(GStringChunkHandle chunk);

	[DllImport(Libraries.GLib)]
	internal static extern string g_string_chunk_insert(GStringChunkHandle chunk, string @string);

	[DllImport(Libraries.GLib)]
	internal static extern string g_string_chunk_insert_const(GStringChunkHandle chunk, string @string);

	[DllImport(Libraries.GLib)]
	internal static extern string g_string_chunk_insert_len(GStringChunkHandle chunk, string @string, UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern GStringChunkHandle g_string_chunk_new(UIntPtr size);

}

public struct GStringChunk
{
}
