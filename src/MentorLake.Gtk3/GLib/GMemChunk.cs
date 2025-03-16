namespace MentorLake.GLib;

public class GMemChunkHandle : BaseSafeHandle
{
}


public static class GMemChunkExtensions
{
	public static IntPtr Alloc(this MentorLake.GLib.GMemChunkHandle mem_chunk)
	{
		return GMemChunkExterns.g_mem_chunk_alloc(mem_chunk);
	}

	public static IntPtr Alloc0(this MentorLake.GLib.GMemChunkHandle mem_chunk)
	{
		return GMemChunkExterns.g_mem_chunk_alloc0(mem_chunk);
	}

	public static void Clean(this MentorLake.GLib.GMemChunkHandle mem_chunk)
	{
		GMemChunkExterns.g_mem_chunk_clean(mem_chunk);
	}

	public static void Destroy(this MentorLake.GLib.GMemChunkHandle mem_chunk)
	{
		GMemChunkExterns.g_mem_chunk_destroy(mem_chunk);
	}

	public static void Free(this MentorLake.GLib.GMemChunkHandle mem_chunk, IntPtr mem)
	{
		GMemChunkExterns.g_mem_chunk_free(mem_chunk, mem);
	}

	public static void Print(this MentorLake.GLib.GMemChunkHandle mem_chunk)
	{
		GMemChunkExterns.g_mem_chunk_print(mem_chunk);
	}

	public static void Reset(this MentorLake.GLib.GMemChunkHandle mem_chunk)
	{
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
	internal static extern MentorLake.GLib.GMemChunkHandle g_mem_chunk_new(string name, int atom_size, UIntPtr area_size, int type);

}

public struct GMemChunk
{
	public static void Info()
	{
		GMemChunkExterns.g_mem_chunk_info();
	}

	public static MentorLake.GLib.GMemChunkHandle New(string name, int atom_size, UIntPtr area_size, int type)
	{
		return GMemChunkExterns.g_mem_chunk_new(name, atom_size, area_size, type);
	}

}
