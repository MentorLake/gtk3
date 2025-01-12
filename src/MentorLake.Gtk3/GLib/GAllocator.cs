namespace MentorLake.Gtk3.GLib;

public class GAllocatorHandle : BaseSafeHandle
{
}


public static class GAllocatorHandleExtensions
{
	public static GAllocatorHandle Free(this GAllocatorHandle allocator)
	{
		GAllocatorExterns.g_allocator_free(allocator);
		return allocator;
	}

	public static GAllocatorHandle New(string name, uint n_preallocs)
	{
		return GAllocatorExterns.g_allocator_new(name, n_preallocs);
	}

}
internal class GAllocatorExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_allocator_free(GAllocatorHandle allocator);

	[DllImport(Libraries.GLib)]
	internal static extern GAllocatorHandle g_allocator_new(string name, uint n_preallocs);

}

public struct GAllocator
{
}
