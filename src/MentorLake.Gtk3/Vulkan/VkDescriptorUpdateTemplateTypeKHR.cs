namespace MentorLake.Vulkan;


public class VkDescriptorUpdateTemplateTypeKHRHandle : BaseSafeHandle
{
}


public static class VkDescriptorUpdateTemplateTypeKHRExtensions
{

	public static VkDescriptorUpdateTemplateTypeKHR Dereference(this VkDescriptorUpdateTemplateTypeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorUpdateTemplateTypeKHR>(x.DangerousGetHandle());
}
internal class VkDescriptorUpdateTemplateTypeKHRExterns
{
}


public struct VkDescriptorUpdateTemplateTypeKHR
{
}
