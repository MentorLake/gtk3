namespace MentorLake.Vulkan;


public class VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXTExtensions
{

	public static VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT Dereference(this VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
{
}
