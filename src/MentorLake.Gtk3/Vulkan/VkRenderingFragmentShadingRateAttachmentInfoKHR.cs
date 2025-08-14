namespace MentorLake.Vulkan;


public class VkRenderingFragmentShadingRateAttachmentInfoKHRHandle : BaseSafeHandle
{
}


public static class VkRenderingFragmentShadingRateAttachmentInfoKHRExtensions
{

	public static VkRenderingFragmentShadingRateAttachmentInfoKHR Dereference(this VkRenderingFragmentShadingRateAttachmentInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingFragmentShadingRateAttachmentInfoKHR>(x.DangerousGetHandle());
}
internal class VkRenderingFragmentShadingRateAttachmentInfoKHRExterns
{
}


public struct VkRenderingFragmentShadingRateAttachmentInfoKHR
{
}
