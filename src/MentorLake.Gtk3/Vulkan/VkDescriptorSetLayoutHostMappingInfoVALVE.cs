namespace MentorLake.Vulkan;


public class VkDescriptorSetLayoutHostMappingInfoVALVEHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetLayoutHostMappingInfoVALVEExtensions
{

	public static VkDescriptorSetLayoutHostMappingInfoVALVE Dereference(this VkDescriptorSetLayoutHostMappingInfoVALVEHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetLayoutHostMappingInfoVALVE>(x.DangerousGetHandle());
}
internal class VkDescriptorSetLayoutHostMappingInfoVALVEExterns
{
}


public struct VkDescriptorSetLayoutHostMappingInfoVALVE
{
}
