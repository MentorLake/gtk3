namespace MentorLake.Vulkan;


public class VkMemoryAllocateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkMemoryAllocateFlagBitsExtensions
{

	public static VkMemoryAllocateFlagBits Dereference(this VkMemoryAllocateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryAllocateFlagBits>(x.DangerousGetHandle());
}
internal class VkMemoryAllocateFlagBitsExterns
{
}


public struct VkMemoryAllocateFlagBits
{
}
