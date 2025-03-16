namespace MentorLake.Vulkan;

public class VkPhysicalDevicePipelineCreationCacheControlFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePipelineCreationCacheControlFeaturesExtensions
{

	public static VkPhysicalDevicePipelineCreationCacheControlFeatures Dereference(this VkPhysicalDevicePipelineCreationCacheControlFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePipelineCreationCacheControlFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePipelineCreationCacheControlFeaturesExterns
{
}

public struct VkPhysicalDevicePipelineCreationCacheControlFeatures
{
}
