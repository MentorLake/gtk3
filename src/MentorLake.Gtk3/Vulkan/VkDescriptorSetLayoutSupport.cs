namespace MentorLake.Vulkan;

public class VkDescriptorSetLayoutSupportHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetLayoutSupportExtensions
{

	public static VkDescriptorSetLayoutSupport Dereference(this VkDescriptorSetLayoutSupportHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetLayoutSupport>(x.DangerousGetHandle());
}
internal class VkDescriptorSetLayoutSupportExterns
{
}

public struct VkDescriptorSetLayoutSupport
{
}
