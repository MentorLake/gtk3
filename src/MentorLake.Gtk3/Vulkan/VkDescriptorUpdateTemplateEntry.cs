namespace MentorLake.Vulkan;

public class VkDescriptorUpdateTemplateEntryHandle : BaseSafeHandle
{
}


public static class VkDescriptorUpdateTemplateEntryExtensions
{

	public static VkDescriptorUpdateTemplateEntry Dereference(this VkDescriptorUpdateTemplateEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorUpdateTemplateEntry>(x.DangerousGetHandle());
}
internal class VkDescriptorUpdateTemplateEntryExterns
{
}

public struct VkDescriptorUpdateTemplateEntry
{
}
