namespace MentorLake.Vulkan;

public class VkPhysicalDeviceUniformBufferStandardLayoutFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceUniformBufferStandardLayoutFeaturesExtensions
{

	public static VkPhysicalDeviceUniformBufferStandardLayoutFeatures Dereference(this VkPhysicalDeviceUniformBufferStandardLayoutFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceUniformBufferStandardLayoutFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceUniformBufferStandardLayoutFeaturesExterns
{
}

public struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
{
}
