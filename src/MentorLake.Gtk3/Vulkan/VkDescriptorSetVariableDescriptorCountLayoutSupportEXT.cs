namespace MentorLake.Vulkan;


public class VkDescriptorSetVariableDescriptorCountLayoutSupportEXTHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetVariableDescriptorCountLayoutSupportEXTExtensions
{

	public static VkDescriptorSetVariableDescriptorCountLayoutSupportEXT Dereference(this VkDescriptorSetVariableDescriptorCountLayoutSupportEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetVariableDescriptorCountLayoutSupportEXT>(x.DangerousGetHandle());
}
internal class VkDescriptorSetVariableDescriptorCountLayoutSupportEXTExterns
{
}


public struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT
{
}
