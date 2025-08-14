namespace MentorLake.Vulkan;


public class VkDescriptorSetVariableDescriptorCountLayoutSupportHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetVariableDescriptorCountLayoutSupportExtensions
{

	public static VkDescriptorSetVariableDescriptorCountLayoutSupport Dereference(this VkDescriptorSetVariableDescriptorCountLayoutSupportHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetVariableDescriptorCountLayoutSupport>(x.DangerousGetHandle());
}
internal class VkDescriptorSetVariableDescriptorCountLayoutSupportExterns
{
}


public struct VkDescriptorSetVariableDescriptorCountLayoutSupport
{
}
