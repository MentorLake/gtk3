namespace MentorLake.Vulkan;

public class VkImageCaptureDescriptorDataInfoEXTHandle : BaseSafeHandle
{
}


public static class VkImageCaptureDescriptorDataInfoEXTExtensions
{

	public static VkImageCaptureDescriptorDataInfoEXT Dereference(this VkImageCaptureDescriptorDataInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCaptureDescriptorDataInfoEXT>(x.DangerousGetHandle());
}
internal class VkImageCaptureDescriptorDataInfoEXTExterns
{
}

public struct VkImageCaptureDescriptorDataInfoEXT
{
}
