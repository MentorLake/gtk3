namespace MentorLake.Vulkan;

public class VkOpticalFlowImageFormatInfoNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowImageFormatInfoNVExtensions
{

	public static VkOpticalFlowImageFormatInfoNV Dereference(this VkOpticalFlowImageFormatInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowImageFormatInfoNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowImageFormatInfoNVExterns
{
}

public struct VkOpticalFlowImageFormatInfoNV
{
}
