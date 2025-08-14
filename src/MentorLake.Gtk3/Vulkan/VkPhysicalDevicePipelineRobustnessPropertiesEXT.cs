namespace MentorLake.Vulkan;


public class VkPhysicalDevicePipelineRobustnessPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePipelineRobustnessPropertiesEXTExtensions
{

	public static VkPhysicalDevicePipelineRobustnessPropertiesEXT Dereference(this VkPhysicalDevicePipelineRobustnessPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePipelineRobustnessPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePipelineRobustnessPropertiesEXTExterns
{
}


public struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
{
}
