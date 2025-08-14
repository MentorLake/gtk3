namespace MentorLake.Vulkan;


public class VkDescriptorSetLayoutBindingFlagsCreateInfoHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetLayoutBindingFlagsCreateInfoExtensions
{

	public static VkDescriptorSetLayoutBindingFlagsCreateInfo Dereference(this VkDescriptorSetLayoutBindingFlagsCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetLayoutBindingFlagsCreateInfo>(x.DangerousGetHandle());
}
internal class VkDescriptorSetLayoutBindingFlagsCreateInfoExterns
{
}


public struct VkDescriptorSetLayoutBindingFlagsCreateInfo
{
}
