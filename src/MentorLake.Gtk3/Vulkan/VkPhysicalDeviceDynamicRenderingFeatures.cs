namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDynamicRenderingFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDynamicRenderingFeaturesExtensions
{

	public static VkPhysicalDeviceDynamicRenderingFeatures Dereference(this VkPhysicalDeviceDynamicRenderingFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDynamicRenderingFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDynamicRenderingFeaturesExterns
{
}


public struct VkPhysicalDeviceDynamicRenderingFeatures
{
}
