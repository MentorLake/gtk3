namespace MentorLake.Vulkan;

public class VkCopyMemoryToMicromapInfoEXTHandle : BaseSafeHandle
{
}


public static class VkCopyMemoryToMicromapInfoEXTExtensions
{

	public static VkCopyMemoryToMicromapInfoEXT Dereference(this VkCopyMemoryToMicromapInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyMemoryToMicromapInfoEXT>(x.DangerousGetHandle());
}
internal class VkCopyMemoryToMicromapInfoEXTExterns
{
}

public struct VkCopyMemoryToMicromapInfoEXT
{
}
