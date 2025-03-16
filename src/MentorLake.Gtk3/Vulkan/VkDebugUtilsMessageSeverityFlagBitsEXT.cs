namespace MentorLake.Vulkan;

public class VkDebugUtilsMessageSeverityFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkDebugUtilsMessageSeverityFlagBitsEXTExtensions
{

	public static VkDebugUtilsMessageSeverityFlagBitsEXT Dereference(this VkDebugUtilsMessageSeverityFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugUtilsMessageSeverityFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkDebugUtilsMessageSeverityFlagBitsEXTExterns
{
}

public struct VkDebugUtilsMessageSeverityFlagBitsEXT
{
}
