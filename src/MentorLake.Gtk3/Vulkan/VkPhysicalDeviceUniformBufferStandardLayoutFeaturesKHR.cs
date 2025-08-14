namespace MentorLake.Vulkan;


public class VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHRExtensions
{

	public static VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR Dereference(this VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHRExterns
{
}


public struct VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR
{
}
