namespace MentorLake.Vulkan;

public class VkPhysicalDevicePushDescriptorPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePushDescriptorPropertiesKHRExtensions
{

	public static VkPhysicalDevicePushDescriptorPropertiesKHR Dereference(this VkPhysicalDevicePushDescriptorPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePushDescriptorPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePushDescriptorPropertiesKHRExterns
{
}

public struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
}
