namespace MentorLake.Vulkan;


public class VkDescriptorUpdateTemplateEntryKHRHandle : BaseSafeHandle
{
}


public static class VkDescriptorUpdateTemplateEntryKHRExtensions
{

	public static VkDescriptorUpdateTemplateEntryKHR Dereference(this VkDescriptorUpdateTemplateEntryKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorUpdateTemplateEntryKHR>(x.DangerousGetHandle());
}
internal class VkDescriptorUpdateTemplateEntryKHRExterns
{
}


public struct VkDescriptorUpdateTemplateEntryKHR
{
}
