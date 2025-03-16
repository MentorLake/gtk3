namespace MentorLake.Vulkan;

public class VkImageSparseMemoryRequirementsInfo2Handle : BaseSafeHandle
{
}


public static class VkImageSparseMemoryRequirementsInfo2Extensions
{

	public static VkImageSparseMemoryRequirementsInfo2 Dereference(this VkImageSparseMemoryRequirementsInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageSparseMemoryRequirementsInfo2>(x.DangerousGetHandle());
}
internal class VkImageSparseMemoryRequirementsInfo2Externs
{
}

public struct VkImageSparseMemoryRequirementsInfo2
{
}
