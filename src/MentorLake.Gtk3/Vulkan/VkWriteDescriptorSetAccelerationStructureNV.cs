namespace MentorLake.Vulkan;


public class VkWriteDescriptorSetAccelerationStructureNVHandle : BaseSafeHandle
{
}


public static class VkWriteDescriptorSetAccelerationStructureNVExtensions
{

	public static VkWriteDescriptorSetAccelerationStructureNV Dereference(this VkWriteDescriptorSetAccelerationStructureNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkWriteDescriptorSetAccelerationStructureNV>(x.DangerousGetHandle());
}
internal class VkWriteDescriptorSetAccelerationStructureNVExterns
{
}


public struct VkWriteDescriptorSetAccelerationStructureNV
{
}
