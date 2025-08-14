namespace MentorLake.Vulkan;


public class VkImageSparseMemoryRequirementsInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkImageSparseMemoryRequirementsInfo2KHRExtensions
{

	public static VkImageSparseMemoryRequirementsInfo2KHR Dereference(this VkImageSparseMemoryRequirementsInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageSparseMemoryRequirementsInfo2KHR>(x.DangerousGetHandle());
}
internal class VkImageSparseMemoryRequirementsInfo2KHRExterns
{
}


public struct VkImageSparseMemoryRequirementsInfo2KHR
{
}
