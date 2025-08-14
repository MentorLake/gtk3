namespace MentorLake.Vulkan;


public class VkPhysicalDeviceTexelBufferAlignmentFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceTexelBufferAlignmentFeaturesEXTExtensions
{

	public static VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT Dereference(this VkPhysicalDeviceTexelBufferAlignmentFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceTexelBufferAlignmentFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
{
}
