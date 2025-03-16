namespace MentorLake.Vulkan;

public class VkPhysicalDeviceRobustness2FeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRobustness2FeaturesEXTExtensions
{

	public static VkPhysicalDeviceRobustness2FeaturesEXT Dereference(this VkPhysicalDeviceRobustness2FeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRobustness2FeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRobustness2FeaturesEXTExterns
{
}

public struct VkPhysicalDeviceRobustness2FeaturesEXT
{
}
