namespace MentorLake.Vulkan;

public class VkCopyDescriptorSetHandle : BaseSafeHandle
{
}


public static class VkCopyDescriptorSetExtensions
{

	public static VkCopyDescriptorSet Dereference(this VkCopyDescriptorSetHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyDescriptorSet>(x.DangerousGetHandle());
}
internal class VkCopyDescriptorSetExterns
{
}

public struct VkCopyDescriptorSet
{
}
