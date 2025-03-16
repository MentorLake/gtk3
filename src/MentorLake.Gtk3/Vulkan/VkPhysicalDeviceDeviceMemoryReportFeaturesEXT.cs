namespace MentorLake.Vulkan;

public class VkPhysicalDeviceDeviceMemoryReportFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDeviceMemoryReportFeaturesEXTExtensions
{

	public static VkPhysicalDeviceDeviceMemoryReportFeaturesEXT Dereference(this VkPhysicalDeviceDeviceMemoryReportFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDeviceMemoryReportFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDeviceMemoryReportFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
{
}
