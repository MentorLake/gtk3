namespace MentorLake.Vulkan;


public class VkDescriptorSetLayoutSupportKHRHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetLayoutSupportKHRExtensions
{

	public static VkDescriptorSetLayoutSupportKHR Dereference(this VkDescriptorSetLayoutSupportKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetLayoutSupportKHR>(x.DangerousGetHandle());
}
internal class VkDescriptorSetLayoutSupportKHRExterns
{
}


public struct VkDescriptorSetLayoutSupportKHR
{
}
