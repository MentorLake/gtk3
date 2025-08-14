namespace MentorLake.Vulkan;


public class VkDescriptorUpdateTemplateHandle : BaseSafeHandle
{
}


public static class VkDescriptorUpdateTemplateExtensions
{

	public static VkDescriptorUpdateTemplate Dereference(this VkDescriptorUpdateTemplateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorUpdateTemplate>(x.DangerousGetHandle());
}
internal class VkDescriptorUpdateTemplateExterns
{
}


public struct VkDescriptorUpdateTemplate
{
}
