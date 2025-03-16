namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMemoryPriorityFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMemoryPriorityFeaturesEXTExtensions
{

	public static VkPhysicalDeviceMemoryPriorityFeaturesEXT Dereference(this VkPhysicalDeviceMemoryPriorityFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMemoryPriorityFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMemoryPriorityFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
{
}
