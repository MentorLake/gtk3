namespace MentorLake.Vulkan;


public class VkDebugUtilsMessageSeverityFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkDebugUtilsMessageSeverityFlagsEXTExtensions
{

	public static VkDebugUtilsMessageSeverityFlagsEXT Dereference(this VkDebugUtilsMessageSeverityFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugUtilsMessageSeverityFlagsEXT>(x.DangerousGetHandle());
}
internal class VkDebugUtilsMessageSeverityFlagsEXTExterns
{
}


public struct VkDebugUtilsMessageSeverityFlagsEXT
{
}
