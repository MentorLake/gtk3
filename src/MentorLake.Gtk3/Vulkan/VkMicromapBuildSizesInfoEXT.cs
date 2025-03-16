namespace MentorLake.Vulkan;

public class VkMicromapBuildSizesInfoEXTHandle : BaseSafeHandle
{
}


public static class VkMicromapBuildSizesInfoEXTExtensions
{

	public static VkMicromapBuildSizesInfoEXT Dereference(this VkMicromapBuildSizesInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMicromapBuildSizesInfoEXT>(x.DangerousGetHandle());
}
internal class VkMicromapBuildSizesInfoEXTExterns
{
}

public struct VkMicromapBuildSizesInfoEXT
{
}
