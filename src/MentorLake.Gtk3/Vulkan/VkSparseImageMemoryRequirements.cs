namespace MentorLake.Vulkan;


public class VkSparseImageMemoryRequirementsHandle : BaseSafeHandle
{
}


public static class VkSparseImageMemoryRequirementsExtensions
{

	public static VkSparseImageMemoryRequirements Dereference(this VkSparseImageMemoryRequirementsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseImageMemoryRequirements>(x.DangerousGetHandle());
}
internal class VkSparseImageMemoryRequirementsExterns
{
}


public struct VkSparseImageMemoryRequirements
{
}
