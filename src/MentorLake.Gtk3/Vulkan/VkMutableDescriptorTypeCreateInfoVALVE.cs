namespace MentorLake.Vulkan;


public class VkMutableDescriptorTypeCreateInfoVALVEHandle : BaseSafeHandle
{
}


public static class VkMutableDescriptorTypeCreateInfoVALVEExtensions
{

	public static VkMutableDescriptorTypeCreateInfoVALVE Dereference(this VkMutableDescriptorTypeCreateInfoVALVEHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMutableDescriptorTypeCreateInfoVALVE>(x.DangerousGetHandle());
}
internal class VkMutableDescriptorTypeCreateInfoVALVEExterns
{
}


public struct VkMutableDescriptorTypeCreateInfoVALVE
{
}
