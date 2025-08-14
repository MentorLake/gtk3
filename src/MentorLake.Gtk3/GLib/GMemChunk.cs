namespace MentorLake.GLib;


public class GMemChunkHandle : BaseSafeHandle
{
}


public static class GMemChunkExtensions
{

/// <param name="mem_chunk">
/// </param>

	public static IntPtr Alloc(this MentorLake.GLib.GMemChunkHandle mem_chunk)
	{
		if (mem_chunk.IsInvalid) throw new Exception("Invalid handle (GMemChunk)");
		return GMemChunkExterns.g_mem_chunk_alloc(mem_chunk);
	}


/// <param name="mem_chunk">
/// </param>

	public static IntPtr Alloc0(this MentorLake.GLib.GMemChunkHandle mem_chunk)
	{
		if (mem_chunk.IsInvalid) throw new Exception("Invalid handle (GMemChunk)");
		return GMemChunkExterns.g_mem_chunk_alloc0(mem_chunk);
	}


/// <param name="mem_chunk">
/// </param>

	public static void Clean(this MentorLake.GLib.GMemChunkHandle mem_chunk)
	{
		if (mem_chunk.IsInvalid) throw new Exception("Invalid handle (GMemChunk)");
		GMemChunkExterns.g_mem_chunk_clean(mem_chunk);
	}


/// <param name="mem_chunk">
/// </param>

	public static void Destroy(this MentorLake.GLib.GMemChunkHandle mem_chunk)
	{
		if (mem_chunk.IsInvalid) throw new Exception("Invalid handle (GMemChunk)");
		GMemChunkExterns.g_mem_chunk_destroy(mem_chunk);
	}


/// <param name="mem_chunk">
/// </param>
/// <param name="mem">
/// </param>

	public static void Free(this MentorLake.GLib.GMemChunkHandle mem_chunk, IntPtr mem)
	{
		if (mem_chunk.IsInvalid) throw new Exception("Invalid handle (GMemChunk)");
		GMemChunkExterns.g_mem_chunk_free(mem_chunk, mem);
	}


/// <param name="mem_chunk">
/// </param>

	public static void Print(this MentorLake.GLib.GMemChunkHandle mem_chunk)
	{
		if (mem_chunk.IsInvalid) throw new Exception("Invalid handle (GMemChunk)");
		GMemChunkExterns.g_mem_chunk_print(mem_chunk);
	}


/// <param name="mem_chunk">
/// </param>

	public static void Reset(this MentorLake.GLib.GMemChunkHandle mem_chunk)
	{
		if (mem_chunk.IsInvalid) throw new Exception("Invalid handle (GMemChunk)");
		GMemChunkExterns.g_mem_chunk_reset(mem_chunk);
	}


	public static GMemChunk Dereference(this GMemChunkHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMemChunk>(x.DangerousGetHandle());
}
internal class GMemChunkExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_mem_chunk_alloc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMemChunkHandle>))] MentorLake.GLib.GMemChunkHandle mem_chunk);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_mem_chunk_alloc0([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMemChunkHandle>))] MentorLake.GLib.GMemChunkHandle mem_chunk);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mem_chunk_clean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMemChunkHandle>))] MentorLake.GLib.GMemChunkHandle mem_chunk);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mem_chunk_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMemChunkHandle>))] MentorLake.GLib.GMemChunkHandle mem_chunk);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mem_chunk_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMemChunkHandle>))] MentorLake.GLib.GMemChunkHandle mem_chunk, IntPtr mem);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mem_chunk_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMemChunkHandle>))] MentorLake.GLib.GMemChunkHandle mem_chunk);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mem_chunk_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMemChunkHandle>))] MentorLake.GLib.GMemChunkHandle mem_chunk);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mem_chunk_info();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMemChunkHandle>))]
	internal static extern MentorLake.GLib.GMemChunkHandle g_mem_chunk_new(string name, int atom_size, UIntPtr area_size, int type);

}


public struct GMemChunk
{


	public static void Info()
	{
		GMemChunkExterns.g_mem_chunk_info();
	}


/// <param name="name">
/// </param>
/// <param name="atom_size">
/// </param>
/// <param name="area_size">
/// </param>
/// <param name="type">
/// </param>

	public static MentorLake.GLib.GMemChunkHandle New(string name, int atom_size, UIntPtr area_size, int type)
	{
		return GMemChunkExterns.g_mem_chunk_new(name, atom_size, area_size, type);
	}

}
