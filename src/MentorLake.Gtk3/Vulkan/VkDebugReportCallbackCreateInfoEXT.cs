namespace MentorLake.Vulkan;


public class VkDebugReportCallbackCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDebugReportCallbackCreateInfoEXTExtensions
{

	public static VkDebugReportCallbackCreateInfoEXT Dereference(this VkDebugReportCallbackCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugReportCallbackCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkDebugReportCallbackCreateInfoEXTExterns
{
}


public struct VkDebugReportCallbackCreateInfoEXT
{
}
