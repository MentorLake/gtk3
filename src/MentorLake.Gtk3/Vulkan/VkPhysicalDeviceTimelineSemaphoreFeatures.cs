namespace MentorLake.Vulkan;

public class VkPhysicalDeviceTimelineSemaphoreFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceTimelineSemaphoreFeaturesExtensions
{

	public static VkPhysicalDeviceTimelineSemaphoreFeatures Dereference(this VkPhysicalDeviceTimelineSemaphoreFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceTimelineSemaphoreFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceTimelineSemaphoreFeaturesExterns
{
}

public struct VkPhysicalDeviceTimelineSemaphoreFeatures
{
}
