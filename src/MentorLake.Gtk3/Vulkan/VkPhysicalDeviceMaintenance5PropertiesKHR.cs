namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMaintenance5PropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMaintenance5PropertiesKHRExtensions
{

	public static VkPhysicalDeviceMaintenance5PropertiesKHR Dereference(this VkPhysicalDeviceMaintenance5PropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMaintenance5PropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMaintenance5PropertiesKHRExterns
{
}


public struct VkPhysicalDeviceMaintenance5PropertiesKHR
{
}
