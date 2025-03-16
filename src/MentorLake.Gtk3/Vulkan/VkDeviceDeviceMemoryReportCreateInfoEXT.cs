namespace MentorLake.Vulkan;

public class VkDeviceDeviceMemoryReportCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceDeviceMemoryReportCreateInfoEXTExtensions
{

	public static VkDeviceDeviceMemoryReportCreateInfoEXT Dereference(this VkDeviceDeviceMemoryReportCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceDeviceMemoryReportCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkDeviceDeviceMemoryReportCreateInfoEXTExterns
{
}

public struct VkDeviceDeviceMemoryReportCreateInfoEXT
{
}
