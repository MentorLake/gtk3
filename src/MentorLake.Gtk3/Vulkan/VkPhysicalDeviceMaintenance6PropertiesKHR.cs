namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMaintenance6PropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMaintenance6PropertiesKHRExtensions
{

	public static VkPhysicalDeviceMaintenance6PropertiesKHR Dereference(this VkPhysicalDeviceMaintenance6PropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMaintenance6PropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMaintenance6PropertiesKHRExterns
{
}

public struct VkPhysicalDeviceMaintenance6PropertiesKHR
{
}
