namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMaintenance3PropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMaintenance3PropertiesKHRExtensions
{

	public static VkPhysicalDeviceMaintenance3PropertiesKHR Dereference(this VkPhysicalDeviceMaintenance3PropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMaintenance3PropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMaintenance3PropertiesKHRExterns
{
}

public struct VkPhysicalDeviceMaintenance3PropertiesKHR
{
}
