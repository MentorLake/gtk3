namespace MentorLake.Vulkan;

public class VkPhysicalDevicePerStageDescriptorSetFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePerStageDescriptorSetFeaturesNVExtensions
{

	public static VkPhysicalDevicePerStageDescriptorSetFeaturesNV Dereference(this VkPhysicalDevicePerStageDescriptorSetFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePerStageDescriptorSetFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePerStageDescriptorSetFeaturesNVExterns
{
}

public struct VkPhysicalDevicePerStageDescriptorSetFeaturesNV
{
}
