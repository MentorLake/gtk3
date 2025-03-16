namespace MentorLake.Vulkan;

public class VkImageMemoryRequirementsInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkImageMemoryRequirementsInfo2KHRExtensions
{

	public static VkImageMemoryRequirementsInfo2KHR Dereference(this VkImageMemoryRequirementsInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageMemoryRequirementsInfo2KHR>(x.DangerousGetHandle());
}
internal class VkImageMemoryRequirementsInfo2KHRExterns
{
}

public struct VkImageMemoryRequirementsInfo2KHR
{
}
