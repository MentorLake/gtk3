namespace MentorLake.Vulkan;

public class VkPhysicalDevicePipelineProtectedAccessFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePipelineProtectedAccessFeaturesEXTExtensions
{

	public static VkPhysicalDevicePipelineProtectedAccessFeaturesEXT Dereference(this VkPhysicalDevicePipelineProtectedAccessFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePipelineProtectedAccessFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePipelineProtectedAccessFeaturesEXTExterns
{
}

public struct VkPhysicalDevicePipelineProtectedAccessFeaturesEXT
{
}
