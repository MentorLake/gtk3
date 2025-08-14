namespace MentorLake.Vulkan;


public class VkMemoryAllocateFlagsHandle : BaseSafeHandle
{
}


public static class VkMemoryAllocateFlagsExtensions
{

	public static VkMemoryAllocateFlags Dereference(this VkMemoryAllocateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryAllocateFlags>(x.DangerousGetHandle());
}
internal class VkMemoryAllocateFlagsExterns
{
}


public struct VkMemoryAllocateFlags
{
}
