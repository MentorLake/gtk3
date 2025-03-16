namespace MentorLake.Vulkan;

public class VkMemoryAllocateFlagsInfoKHRHandle : BaseSafeHandle
{
}


public static class VkMemoryAllocateFlagsInfoKHRExtensions
{

	public static VkMemoryAllocateFlagsInfoKHR Dereference(this VkMemoryAllocateFlagsInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryAllocateFlagsInfoKHR>(x.DangerousGetHandle());
}
internal class VkMemoryAllocateFlagsInfoKHRExterns
{
}

public struct VkMemoryAllocateFlagsInfoKHR
{
}
