namespace MentorLake.Vulkan;


public class VkWriteDescriptorSetAccelerationStructureKHRHandle : BaseSafeHandle
{
}


public static class VkWriteDescriptorSetAccelerationStructureKHRExtensions
{

	public static VkWriteDescriptorSetAccelerationStructureKHR Dereference(this VkWriteDescriptorSetAccelerationStructureKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkWriteDescriptorSetAccelerationStructureKHR>(x.DangerousGetHandle());
}
internal class VkWriteDescriptorSetAccelerationStructureKHRExterns
{
}


public struct VkWriteDescriptorSetAccelerationStructureKHR
{
}
