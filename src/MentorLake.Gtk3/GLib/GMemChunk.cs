namespace MentorLake.Gtk3.GLib;

public class GMemChunkHandle : BaseSafeHandle
{
}


public static class GMemChunkHandleExtensions
{
	public static IntPtr Alloc(this GMemChunkHandle mem_chunk)
	{
		return GMemChunkExterns.g_mem_chunk_alloc(mem_chunk);
	}

	public static IntPtr Alloc0(this GMemChunkHandle mem_chunk)
	{
		return GMemChunkExterns.g_mem_chunk_alloc0(mem_chunk);
	}

	public static T Clean<T>(this T mem_chunk) where T : GMemChunkHandle
	{
		GMemChunkExterns.g_mem_chunk_clean(mem_chunk);
		return mem_chunk;
	}

	public static T Destroy<T>(this T mem_chunk) where T : GMemChunkHandle
	{
		GMemChunkExterns.g_mem_chunk_destroy(mem_chunk);
		return mem_chunk;
	}

	public static T Free<T>(this T mem_chunk, IntPtr mem) where T : GMemChunkHandle
	{
		GMemChunkExterns.g_mem_chunk_free(mem_chunk, mem);
		return mem_chunk;
	}

	public static T Print<T>(this T mem_chunk) where T : GMemChunkHandle
	{
		GMemChunkExterns.g_mem_chunk_print(mem_chunk);
		return mem_chunk;
	}

	public static T Reset<T>(this T mem_chunk) where T : GMemChunkHandle
	{
		GMemChunkExterns.g_mem_chunk_reset(mem_chunk);
		return mem_chunk;
	}

	public static void Info()
	{
		GMemChunkExterns.g_mem_chunk_info();
	}

	public static GMemChunkHandle New(string name, int atom_size, UIntPtr area_size, int type)
	{
		return GMemChunkExterns.g_mem_chunk_new(name, atom_size, area_size, type);
	}

}
internal class GMemChunkExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_mem_chunk_alloc(GMemChunkHandle mem_chunk);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_mem_chunk_alloc0(GMemChunkHandle mem_chunk);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_chunk_clean(GMemChunkHandle mem_chunk);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_chunk_destroy(GMemChunkHandle mem_chunk);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_chunk_free(GMemChunkHandle mem_chunk, IntPtr mem);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_chunk_print(GMemChunkHandle mem_chunk);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_chunk_reset(GMemChunkHandle mem_chunk);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_chunk_info();

	[DllImport(Libraries.GLib)]
	internal static extern GMemChunkHandle g_mem_chunk_new(string name, int atom_size, UIntPtr area_size, int type);

}

public struct GMemChunk
{
}
