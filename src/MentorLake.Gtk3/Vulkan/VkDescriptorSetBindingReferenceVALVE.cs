namespace MentorLake.Vulkan;

public class VkDescriptorSetBindingReferenceVALVEHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetBindingReferenceVALVEExtensions
{

	public static VkDescriptorSetBindingReferenceVALVE Dereference(this VkDescriptorSetBindingReferenceVALVEHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetBindingReferenceVALVE>(x.DangerousGetHandle());
}
internal class VkDescriptorSetBindingReferenceVALVEExterns
{
}

public struct VkDescriptorSetBindingReferenceVALVE
{
}
