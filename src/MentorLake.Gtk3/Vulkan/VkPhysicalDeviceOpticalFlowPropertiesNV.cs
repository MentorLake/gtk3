namespace MentorLake.Vulkan;

public class VkPhysicalDeviceOpticalFlowPropertiesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceOpticalFlowPropertiesNVExtensions
{

	public static VkPhysicalDeviceOpticalFlowPropertiesNV Dereference(this VkPhysicalDeviceOpticalFlowPropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceOpticalFlowPropertiesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceOpticalFlowPropertiesNVExterns
{
}

public struct VkPhysicalDeviceOpticalFlowPropertiesNV
{
}
