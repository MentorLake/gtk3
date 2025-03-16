namespace MentorLake.Vulkan;

public class VkPhysicalDeviceOpticalFlowFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceOpticalFlowFeaturesNVExtensions
{

	public static VkPhysicalDeviceOpticalFlowFeaturesNV Dereference(this VkPhysicalDeviceOpticalFlowFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceOpticalFlowFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceOpticalFlowFeaturesNVExterns
{
}

public struct VkPhysicalDeviceOpticalFlowFeaturesNV
{
}
