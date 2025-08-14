namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVEHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVEExtensions
{

	public static VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE Dereference(this VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVEHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVEExterns
{
}


public struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
{
}
