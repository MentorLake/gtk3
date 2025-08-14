namespace MentorLake.Vulkan;


public class VkWriteDescriptorSetHandle : BaseSafeHandle
{
}


public static class VkWriteDescriptorSetExtensions
{

	public static VkWriteDescriptorSet Dereference(this VkWriteDescriptorSetHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkWriteDescriptorSet>(x.DangerousGetHandle());
}
internal class VkWriteDescriptorSetExterns
{
}


public struct VkWriteDescriptorSet
{
}
