namespace MentorLake.Vulkan;


public class VkDescriptorUpdateTemplateCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkDescriptorUpdateTemplateCreateFlagsExtensions
{

	public static VkDescriptorUpdateTemplateCreateFlags Dereference(this VkDescriptorUpdateTemplateCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorUpdateTemplateCreateFlags>(x.DangerousGetHandle());
}
internal class VkDescriptorUpdateTemplateCreateFlagsExterns
{
}


public struct VkDescriptorUpdateTemplateCreateFlags
{
}
