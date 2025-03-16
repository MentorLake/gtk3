namespace MentorLake.Vulkan;

public class VkPhysicalDevicePointClippingPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePointClippingPropertiesKHRExtensions
{

	public static VkPhysicalDevicePointClippingPropertiesKHR Dereference(this VkPhysicalDevicePointClippingPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePointClippingPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePointClippingPropertiesKHRExterns
{
}

public struct VkPhysicalDevicePointClippingPropertiesKHR
{
}
