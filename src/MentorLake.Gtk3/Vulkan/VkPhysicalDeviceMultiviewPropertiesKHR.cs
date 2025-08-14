namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMultiviewPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMultiviewPropertiesKHRExtensions
{

	public static VkPhysicalDeviceMultiviewPropertiesKHR Dereference(this VkPhysicalDeviceMultiviewPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMultiviewPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMultiviewPropertiesKHRExterns
{
}


public struct VkPhysicalDeviceMultiviewPropertiesKHR
{
}
