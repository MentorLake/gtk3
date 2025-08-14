namespace MentorLake.Vulkan;


public class VkPhysicalDeviceIDPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceIDPropertiesKHRExtensions
{

	public static VkPhysicalDeviceIDPropertiesKHR Dereference(this VkPhysicalDeviceIDPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceIDPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceIDPropertiesKHRExterns
{
}


public struct VkPhysicalDeviceIDPropertiesKHR
{
}
