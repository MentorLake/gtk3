namespace MentorLake.Vulkan;


public class VkImageViewCaptureDescriptorDataInfoEXTHandle : BaseSafeHandle
{
}


public static class VkImageViewCaptureDescriptorDataInfoEXTExtensions
{

	public static VkImageViewCaptureDescriptorDataInfoEXT Dereference(this VkImageViewCaptureDescriptorDataInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewCaptureDescriptorDataInfoEXT>(x.DangerousGetHandle());
}
internal class VkImageViewCaptureDescriptorDataInfoEXTExterns
{
}


public struct VkImageViewCaptureDescriptorDataInfoEXT
{
}
