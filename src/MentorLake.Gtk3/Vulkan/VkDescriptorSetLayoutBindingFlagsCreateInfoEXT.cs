namespace MentorLake.Vulkan;

public class VkDescriptorSetLayoutBindingFlagsCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetLayoutBindingFlagsCreateInfoEXTExtensions
{

	public static VkDescriptorSetLayoutBindingFlagsCreateInfoEXT Dereference(this VkDescriptorSetLayoutBindingFlagsCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetLayoutBindingFlagsCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkDescriptorSetLayoutBindingFlagsCreateInfoEXTExterns
{
}

public struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT
{
}
