namespace MentorLake.Vulkan;

public class VkPhysicalDeviceImageRobustnessFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageRobustnessFeaturesExtensions
{

	public static VkPhysicalDeviceImageRobustnessFeatures Dereference(this VkPhysicalDeviceImageRobustnessFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageRobustnessFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageRobustnessFeaturesExterns
{
}

public struct VkPhysicalDeviceImageRobustnessFeatures
{
}
