namespace MentorLake.Vulkan;

public class VkDescriptorSetVariableDescriptorCountAllocateInfoHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetVariableDescriptorCountAllocateInfoExtensions
{

	public static VkDescriptorSetVariableDescriptorCountAllocateInfo Dereference(this VkDescriptorSetVariableDescriptorCountAllocateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetVariableDescriptorCountAllocateInfo>(x.DangerousGetHandle());
}
internal class VkDescriptorSetVariableDescriptorCountAllocateInfoExterns
{
}

public struct VkDescriptorSetVariableDescriptorCountAllocateInfo
{
}
