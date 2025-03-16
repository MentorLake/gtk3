namespace MentorLake.Vulkan;

public class VkPhysicalDeviceGroupPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceGroupPropertiesKHRExtensions
{

	public static VkPhysicalDeviceGroupPropertiesKHR Dereference(this VkPhysicalDeviceGroupPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceGroupPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceGroupPropertiesKHRExterns
{
}

public struct VkPhysicalDeviceGroupPropertiesKHR
{
}
