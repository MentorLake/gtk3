namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVEHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVEExtensions
{

	public static VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE Dereference(this VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVEHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVEExterns
{
}


public struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
{
}
