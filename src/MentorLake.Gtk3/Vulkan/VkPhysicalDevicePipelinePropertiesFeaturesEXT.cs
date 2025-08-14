namespace MentorLake.Vulkan;


public class VkPhysicalDevicePipelinePropertiesFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePipelinePropertiesFeaturesEXTExtensions
{

	public static VkPhysicalDevicePipelinePropertiesFeaturesEXT Dereference(this VkPhysicalDevicePipelinePropertiesFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePipelinePropertiesFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePipelinePropertiesFeaturesEXTExterns
{
}


public struct VkPhysicalDevicePipelinePropertiesFeaturesEXT
{
}
