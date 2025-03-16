namespace MentorLake.Vulkan;

public class VkDescriptorSetLayoutCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetLayoutCreateFlagBitsExtensions
{

	public static VkDescriptorSetLayoutCreateFlagBits Dereference(this VkDescriptorSetLayoutCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetLayoutCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkDescriptorSetLayoutCreateFlagBitsExterns
{
}

public struct VkDescriptorSetLayoutCreateFlagBits
{
}
