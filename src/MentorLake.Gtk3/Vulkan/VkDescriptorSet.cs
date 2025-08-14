namespace MentorLake.Vulkan;


public class VkDescriptorSetHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetExtensions
{

	public static VkDescriptorSet Dereference(this VkDescriptorSetHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSet>(x.DangerousGetHandle());
}
internal class VkDescriptorSetExterns
{
}


public struct VkDescriptorSet
{
}
