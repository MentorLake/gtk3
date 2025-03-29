namespace MentorLake.GLib;

public class GAllocatorHandle : BaseSafeHandle
{
}


public static class GAllocatorExtensions
{
	public static void Free(this MentorLake.GLib.GAllocatorHandle allocator)
	{
		if (allocator.IsInvalid || allocator.IsClosed) throw new Exception("Invalid or closed handle (GAllocator)");
		GAllocatorExterns.g_allocator_free(allocator);
	}


	public static GAllocator Dereference(this GAllocatorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GAllocator>(x.DangerousGetHandle());
}
internal class GAllocatorExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_allocator_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GAllocatorHandle g_allocator_new(string name, uint n_preallocs);

}

public struct GAllocator
{
	public static MentorLake.GLib.GAllocatorHandle New(string name, uint n_preallocs)
	{
		return GAllocatorExterns.g_allocator_new(name, n_preallocs);
	}

}
