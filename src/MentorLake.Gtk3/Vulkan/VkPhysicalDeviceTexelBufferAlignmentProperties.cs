namespace MentorLake.Vulkan;


public class VkPhysicalDeviceTexelBufferAlignmentPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceTexelBufferAlignmentPropertiesExtensions
{

	public static VkPhysicalDeviceTexelBufferAlignmentProperties Dereference(this VkPhysicalDeviceTexelBufferAlignmentPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceTexelBufferAlignmentProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceTexelBufferAlignmentPropertiesExterns
{
}


public struct VkPhysicalDeviceTexelBufferAlignmentProperties
{
}
