namespace MentorLake.Vulkan;


public class VkPhysicalDevicePipelineRobustnessFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePipelineRobustnessFeaturesEXTExtensions
{

	public static VkPhysicalDevicePipelineRobustnessFeaturesEXT Dereference(this VkPhysicalDevicePipelineRobustnessFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePipelineRobustnessFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePipelineRobustnessFeaturesEXTExterns
{
}


public struct VkPhysicalDevicePipelineRobustnessFeaturesEXT
{
}
