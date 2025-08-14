namespace MentorLake.Vulkan;


public class VkMicromapBuildInfoEXTHandle : BaseSafeHandle
{
}


public static class VkMicromapBuildInfoEXTExtensions
{

	public static VkMicromapBuildInfoEXT Dereference(this VkMicromapBuildInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMicromapBuildInfoEXT>(x.DangerousGetHandle());
}
internal class VkMicromapBuildInfoEXTExterns
{
}


public struct VkMicromapBuildInfoEXT
{
}
