namespace MentorLake.Vulkan;

public class VkDescriptorUpdateTemplateCreateFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkDescriptorUpdateTemplateCreateFlagsKHRExtensions
{

	public static VkDescriptorUpdateTemplateCreateFlagsKHR Dereference(this VkDescriptorUpdateTemplateCreateFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorUpdateTemplateCreateFlagsKHR>(x.DangerousGetHandle());
}
internal class VkDescriptorUpdateTemplateCreateFlagsKHRExterns
{
}

public struct VkDescriptorUpdateTemplateCreateFlagsKHR
{
}
