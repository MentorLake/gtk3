namespace MentorLake.Vulkan;

public class VkDescriptorUpdateTemplateTypeHandle : BaseSafeHandle
{
}


public static class VkDescriptorUpdateTemplateTypeExtensions
{

	public static VkDescriptorUpdateTemplateType Dereference(this VkDescriptorUpdateTemplateTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorUpdateTemplateType>(x.DangerousGetHandle());
}
internal class VkDescriptorUpdateTemplateTypeExterns
{
}

public struct VkDescriptorUpdateTemplateType
{
}
