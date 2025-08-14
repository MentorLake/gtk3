namespace MentorLake.Vulkan;


public class VkDescriptorSetLayoutHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetLayoutExtensions
{

	public static VkDescriptorSetLayout Dereference(this VkDescriptorSetLayoutHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetLayout>(x.DangerousGetHandle());
}
internal class VkDescriptorSetLayoutExterns
{
}


public struct VkDescriptorSetLayout
{
}
