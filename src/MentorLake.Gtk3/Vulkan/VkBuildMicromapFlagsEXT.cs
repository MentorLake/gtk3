namespace MentorLake.Vulkan;


public class VkBuildMicromapFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkBuildMicromapFlagsEXTExtensions
{

	public static VkBuildMicromapFlagsEXT Dereference(this VkBuildMicromapFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBuildMicromapFlagsEXT>(x.DangerousGetHandle());
}
internal class VkBuildMicromapFlagsEXTExterns
{
}


public struct VkBuildMicromapFlagsEXT
{
}
