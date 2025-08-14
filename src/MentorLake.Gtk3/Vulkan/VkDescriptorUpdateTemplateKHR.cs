namespace MentorLake.Vulkan;


public class VkDescriptorUpdateTemplateKHRHandle : BaseSafeHandle
{
}


public static class VkDescriptorUpdateTemplateKHRExtensions
{

	public static VkDescriptorUpdateTemplateKHR Dereference(this VkDescriptorUpdateTemplateKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorUpdateTemplateKHR>(x.DangerousGetHandle());
}
internal class VkDescriptorUpdateTemplateKHRExterns
{
}


public struct VkDescriptorUpdateTemplateKHR
{
}
