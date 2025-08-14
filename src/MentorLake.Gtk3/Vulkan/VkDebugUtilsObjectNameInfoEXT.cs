namespace MentorLake.Vulkan;


public class VkDebugUtilsObjectNameInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDebugUtilsObjectNameInfoEXTExtensions
{

	public static VkDebugUtilsObjectNameInfoEXT Dereference(this VkDebugUtilsObjectNameInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugUtilsObjectNameInfoEXT>(x.DangerousGetHandle());
}
internal class VkDebugUtilsObjectNameInfoEXTExterns
{
}


public struct VkDebugUtilsObjectNameInfoEXT
{
}
