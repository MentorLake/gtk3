namespace MentorLake.Vulkan;


public class VkDescriptorSetLayoutCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetLayoutCreateFlagsExtensions
{

	public static VkDescriptorSetLayoutCreateFlags Dereference(this VkDescriptorSetLayoutCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetLayoutCreateFlags>(x.DangerousGetHandle());
}
internal class VkDescriptorSetLayoutCreateFlagsExterns
{
}


public struct VkDescriptorSetLayoutCreateFlags
{
}
