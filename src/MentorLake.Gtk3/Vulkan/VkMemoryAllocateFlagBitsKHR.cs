namespace MentorLake.Vulkan;


public class VkMemoryAllocateFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkMemoryAllocateFlagBitsKHRExtensions
{

	public static VkMemoryAllocateFlagBitsKHR Dereference(this VkMemoryAllocateFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryAllocateFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkMemoryAllocateFlagBitsKHRExterns
{
}


public struct VkMemoryAllocateFlagBitsKHR
{
}
