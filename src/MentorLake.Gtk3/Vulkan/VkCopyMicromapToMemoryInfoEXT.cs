namespace MentorLake.Vulkan;

public class VkCopyMicromapToMemoryInfoEXTHandle : BaseSafeHandle
{
}


public static class VkCopyMicromapToMemoryInfoEXTExtensions
{

	public static VkCopyMicromapToMemoryInfoEXT Dereference(this VkCopyMicromapToMemoryInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyMicromapToMemoryInfoEXT>(x.DangerousGetHandle());
}
internal class VkCopyMicromapToMemoryInfoEXTExterns
{
}

public struct VkCopyMicromapToMemoryInfoEXT
{
}
