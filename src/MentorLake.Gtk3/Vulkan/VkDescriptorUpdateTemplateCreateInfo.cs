namespace MentorLake.Vulkan;


public class VkDescriptorUpdateTemplateCreateInfoHandle : BaseSafeHandle
{
}


public static class VkDescriptorUpdateTemplateCreateInfoExtensions
{

	public static VkDescriptorUpdateTemplateCreateInfo Dereference(this VkDescriptorUpdateTemplateCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorUpdateTemplateCreateInfo>(x.DangerousGetHandle());
}
internal class VkDescriptorUpdateTemplateCreateInfoExterns
{
}


public struct VkDescriptorUpdateTemplateCreateInfo
{
}
