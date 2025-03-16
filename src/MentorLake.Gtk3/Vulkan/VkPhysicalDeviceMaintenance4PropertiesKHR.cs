namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMaintenance4PropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMaintenance4PropertiesKHRExtensions
{

	public static VkPhysicalDeviceMaintenance4PropertiesKHR Dereference(this VkPhysicalDeviceMaintenance4PropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMaintenance4PropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMaintenance4PropertiesKHRExterns
{
}

public struct VkPhysicalDeviceMaintenance4PropertiesKHR
{
}
