namespace MentorLake.Vulkan;

public class VkMutableDescriptorTypeListVALVEHandle : BaseSafeHandle
{
}


public static class VkMutableDescriptorTypeListVALVEExtensions
{

	public static VkMutableDescriptorTypeListVALVE Dereference(this VkMutableDescriptorTypeListVALVEHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMutableDescriptorTypeListVALVE>(x.DangerousGetHandle());
}
internal class VkMutableDescriptorTypeListVALVEExterns
{
}

public struct VkMutableDescriptorTypeListVALVE
{
}
