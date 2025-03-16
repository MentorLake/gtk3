namespace MentorLake.Vulkan;

public class VkMemoryAllocateFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkMemoryAllocateFlagsKHRExtensions
{

	public static VkMemoryAllocateFlagsKHR Dereference(this VkMemoryAllocateFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryAllocateFlagsKHR>(x.DangerousGetHandle());
}
internal class VkMemoryAllocateFlagsKHRExterns
{
}

public struct VkMemoryAllocateFlagsKHR
{
}
