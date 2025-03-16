namespace MentorLake.Vulkan;

public class VkBuildMicromapFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkBuildMicromapFlagBitsEXTExtensions
{

	public static VkBuildMicromapFlagBitsEXT Dereference(this VkBuildMicromapFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBuildMicromapFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkBuildMicromapFlagBitsEXTExterns
{
}

public struct VkBuildMicromapFlagBitsEXT
{
}
