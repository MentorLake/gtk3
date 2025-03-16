namespace MentorLake.Vulkan;

public class VkPushDescriptorSetWithTemplateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPushDescriptorSetWithTemplateInfoKHRExtensions
{

	public static VkPushDescriptorSetWithTemplateInfoKHR Dereference(this VkPushDescriptorSetWithTemplateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPushDescriptorSetWithTemplateInfoKHR>(x.DangerousGetHandle());
}
internal class VkPushDescriptorSetWithTemplateInfoKHRExterns
{
}

public struct VkPushDescriptorSetWithTemplateInfoKHR
{
}
