namespace MentorLake.Vulkan;

public class VkCopyMicromapInfoEXTHandle : BaseSafeHandle
{
}


public static class VkCopyMicromapInfoEXTExtensions
{

	public static VkCopyMicromapInfoEXT Dereference(this VkCopyMicromapInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyMicromapInfoEXT>(x.DangerousGetHandle());
}
internal class VkCopyMicromapInfoEXTExterns
{
}

public struct VkCopyMicromapInfoEXT
{
}
