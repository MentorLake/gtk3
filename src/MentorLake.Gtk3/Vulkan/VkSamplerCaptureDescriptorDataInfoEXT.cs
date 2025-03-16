namespace MentorLake.Vulkan;

public class VkSamplerCaptureDescriptorDataInfoEXTHandle : BaseSafeHandle
{
}


public static class VkSamplerCaptureDescriptorDataInfoEXTExtensions
{

	public static VkSamplerCaptureDescriptorDataInfoEXT Dereference(this VkSamplerCaptureDescriptorDataInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerCaptureDescriptorDataInfoEXT>(x.DangerousGetHandle());
}
internal class VkSamplerCaptureDescriptorDataInfoEXTExterns
{
}

public struct VkSamplerCaptureDescriptorDataInfoEXT
{
}
