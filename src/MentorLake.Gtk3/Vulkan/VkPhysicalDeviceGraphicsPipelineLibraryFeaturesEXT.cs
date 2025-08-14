namespace MentorLake.Vulkan;


public class VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXTExtensions
{

	public static VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT Dereference(this VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT
{
}
