namespace MentorLake.Vulkan;

public class VkPhysicalDeviceLineRasterizationPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceLineRasterizationPropertiesKHRExtensions
{

	public static VkPhysicalDeviceLineRasterizationPropertiesKHR Dereference(this VkPhysicalDeviceLineRasterizationPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceLineRasterizationPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceLineRasterizationPropertiesKHRExterns
{
}

public struct VkPhysicalDeviceLineRasterizationPropertiesKHR
{
}
