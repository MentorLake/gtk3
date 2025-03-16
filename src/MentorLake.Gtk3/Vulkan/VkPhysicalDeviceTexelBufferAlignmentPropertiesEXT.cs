namespace MentorLake.Vulkan;

public class VkPhysicalDeviceTexelBufferAlignmentPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceTexelBufferAlignmentPropertiesEXTExtensions
{

	public static VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT Dereference(this VkPhysicalDeviceTexelBufferAlignmentPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceTexelBufferAlignmentPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
{
}
