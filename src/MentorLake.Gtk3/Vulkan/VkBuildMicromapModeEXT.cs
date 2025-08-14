namespace MentorLake.Vulkan;


public class VkBuildMicromapModeEXTHandle : BaseSafeHandle
{
}


public static class VkBuildMicromapModeEXTExtensions
{

	public static VkBuildMicromapModeEXT Dereference(this VkBuildMicromapModeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBuildMicromapModeEXT>(x.DangerousGetHandle());
}
internal class VkBuildMicromapModeEXTExterns
{
}


public struct VkBuildMicromapModeEXT
{
}
