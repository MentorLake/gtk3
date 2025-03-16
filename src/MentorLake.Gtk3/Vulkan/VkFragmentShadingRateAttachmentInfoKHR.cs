namespace MentorLake.Vulkan;

public class VkFragmentShadingRateAttachmentInfoKHRHandle : BaseSafeHandle
{
}


public static class VkFragmentShadingRateAttachmentInfoKHRExtensions
{

	public static VkFragmentShadingRateAttachmentInfoKHR Dereference(this VkFragmentShadingRateAttachmentInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFragmentShadingRateAttachmentInfoKHR>(x.DangerousGetHandle());
}
internal class VkFragmentShadingRateAttachmentInfoKHRExterns
{
}

public struct VkFragmentShadingRateAttachmentInfoKHR
{
}
