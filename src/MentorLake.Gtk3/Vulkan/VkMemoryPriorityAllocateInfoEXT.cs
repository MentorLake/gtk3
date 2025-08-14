namespace MentorLake.Vulkan;


public class VkMemoryPriorityAllocateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkMemoryPriorityAllocateInfoEXTExtensions
{

	public static VkMemoryPriorityAllocateInfoEXT Dereference(this VkMemoryPriorityAllocateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryPriorityAllocateInfoEXT>(x.DangerousGetHandle());
}
internal class VkMemoryPriorityAllocateInfoEXTExterns
{
}


public struct VkMemoryPriorityAllocateInfoEXT
{
}
