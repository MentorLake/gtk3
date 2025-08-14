namespace MentorLake.Vulkan;


public class VkDescriptorSetLayoutBindingHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetLayoutBindingExtensions
{

	public static VkDescriptorSetLayoutBinding Dereference(this VkDescriptorSetLayoutBindingHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetLayoutBinding>(x.DangerousGetHandle());
}
internal class VkDescriptorSetLayoutBindingExterns
{
}


public struct VkDescriptorSetLayoutBinding
{
}
