namespace MentorLake.Vulkan;


public class VkDebugUtilsLabelEXTHandle : BaseSafeHandle
{
}


public static class VkDebugUtilsLabelEXTExtensions
{

	public static VkDebugUtilsLabelEXT Dereference(this VkDebugUtilsLabelEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugUtilsLabelEXT>(x.DangerousGetHandle());
}
internal class VkDebugUtilsLabelEXTExterns
{
}


public struct VkDebugUtilsLabelEXT
{
}
