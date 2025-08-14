namespace MentorLake.Vulkan;


public class VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHRExtensions
{

	public static VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR Dereference(this VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHRExterns
{
}


public struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
{
}
