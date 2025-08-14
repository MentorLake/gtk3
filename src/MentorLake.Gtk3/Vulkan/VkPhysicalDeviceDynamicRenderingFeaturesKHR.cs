namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDynamicRenderingFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDynamicRenderingFeaturesKHRExtensions
{

	public static VkPhysicalDeviceDynamicRenderingFeaturesKHR Dereference(this VkPhysicalDeviceDynamicRenderingFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDynamicRenderingFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDynamicRenderingFeaturesKHRExterns
{
}


public struct VkPhysicalDeviceDynamicRenderingFeaturesKHR
{
}
