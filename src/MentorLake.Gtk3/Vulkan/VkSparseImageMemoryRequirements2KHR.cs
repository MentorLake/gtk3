namespace MentorLake.Vulkan;

public class VkSparseImageMemoryRequirements2KHRHandle : BaseSafeHandle
{
}


public static class VkSparseImageMemoryRequirements2KHRExtensions
{

	public static VkSparseImageMemoryRequirements2KHR Dereference(this VkSparseImageMemoryRequirements2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseImageMemoryRequirements2KHR>(x.DangerousGetHandle());
}
internal class VkSparseImageMemoryRequirements2KHRExterns
{
}

public struct VkSparseImageMemoryRequirements2KHR
{
}
