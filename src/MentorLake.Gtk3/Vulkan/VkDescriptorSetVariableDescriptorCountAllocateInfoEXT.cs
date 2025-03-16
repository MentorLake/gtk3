namespace MentorLake.Vulkan;

public class VkDescriptorSetVariableDescriptorCountAllocateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetVariableDescriptorCountAllocateInfoEXTExtensions
{

	public static VkDescriptorSetVariableDescriptorCountAllocateInfoEXT Dereference(this VkDescriptorSetVariableDescriptorCountAllocateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetVariableDescriptorCountAllocateInfoEXT>(x.DangerousGetHandle());
}
internal class VkDescriptorSetVariableDescriptorCountAllocateInfoEXTExterns
{
}

public struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT
{
}
