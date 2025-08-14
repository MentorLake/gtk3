namespace MentorLake.Vulkan;


public class VkDescriptorSetLayoutCreateInfoHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetLayoutCreateInfoExtensions
{

	public static VkDescriptorSetLayoutCreateInfo Dereference(this VkDescriptorSetLayoutCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetLayoutCreateInfo>(x.DangerousGetHandle());
}
internal class VkDescriptorSetLayoutCreateInfoExterns
{
}


public struct VkDescriptorSetLayoutCreateInfo
{
}
