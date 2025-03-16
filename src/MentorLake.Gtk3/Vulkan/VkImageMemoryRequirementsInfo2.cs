namespace MentorLake.Vulkan;

public class VkImageMemoryRequirementsInfo2Handle : BaseSafeHandle
{
}


public static class VkImageMemoryRequirementsInfo2Extensions
{

	public static VkImageMemoryRequirementsInfo2 Dereference(this VkImageMemoryRequirementsInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageMemoryRequirementsInfo2>(x.DangerousGetHandle());
}
internal class VkImageMemoryRequirementsInfo2Externs
{
}

public struct VkImageMemoryRequirementsInfo2
{
}
