namespace MentorLake.GLib;


public class GAllocatorHandle : BaseSafeHandle
{
}


public static class GAllocatorExtensions
{

/// <param name="allocator">
/// </param>

	public static void Free(this MentorLake.GLib.GAllocatorHandle allocator)
	{
		if (allocator.IsInvalid) throw new Exception("Invalid handle (GAllocator)");
		GAllocatorExterns.g_allocator_free(allocator);
	}


	public static GAllocator Dereference(this GAllocatorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GAllocator>(x.DangerousGetHandle());
}
internal class GAllocatorExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_allocator_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))]
	internal static extern MentorLake.GLib.GAllocatorHandle g_allocator_new(string name, uint n_preallocs);

}


public struct GAllocator
{

/// <param name="name">
/// </param>
/// <param name="n_preallocs">
/// </param>

	public static MentorLake.GLib.GAllocatorHandle New(string name, uint n_preallocs)
	{
		return GAllocatorExterns.g_allocator_new(name, n_preallocs);
	}

}
