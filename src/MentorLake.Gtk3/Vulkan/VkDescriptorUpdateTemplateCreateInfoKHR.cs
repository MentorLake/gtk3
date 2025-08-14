namespace MentorLake.Vulkan;


public class VkDescriptorUpdateTemplateCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDescriptorUpdateTemplateCreateInfoKHRExtensions
{

	public static VkDescriptorUpdateTemplateCreateInfoKHR Dereference(this VkDescriptorUpdateTemplateCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorUpdateTemplateCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkDescriptorUpdateTemplateCreateInfoKHRExterns
{
}


public struct VkDescriptorUpdateTemplateCreateInfoKHR
{
}
