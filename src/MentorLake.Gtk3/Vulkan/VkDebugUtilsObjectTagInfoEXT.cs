namespace MentorLake.Vulkan;

public class VkDebugUtilsObjectTagInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDebugUtilsObjectTagInfoEXTExtensions
{

	public static VkDebugUtilsObjectTagInfoEXT Dereference(this VkDebugUtilsObjectTagInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugUtilsObjectTagInfoEXT>(x.DangerousGetHandle());
}
internal class VkDebugUtilsObjectTagInfoEXTExterns
{
}

public struct VkDebugUtilsObjectTagInfoEXT
{
}
