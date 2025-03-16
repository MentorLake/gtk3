namespace MentorLake.Vulkan;

public class VkSparseImageMemoryRequirements2Handle : BaseSafeHandle
{
}


public static class VkSparseImageMemoryRequirements2Extensions
{

	public static VkSparseImageMemoryRequirements2 Dereference(this VkSparseImageMemoryRequirements2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseImageMemoryRequirements2>(x.DangerousGetHandle());
}
internal class VkSparseImageMemoryRequirements2Externs
{
}

public struct VkSparseImageMemoryRequirements2
{
}
