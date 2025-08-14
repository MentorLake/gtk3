namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDriverPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDriverPropertiesKHRExtensions
{

	public static VkPhysicalDeviceDriverPropertiesKHR Dereference(this VkPhysicalDeviceDriverPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDriverPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDriverPropertiesKHRExterns
{
}


public struct VkPhysicalDeviceDriverPropertiesKHR
{
}
