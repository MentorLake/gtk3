namespace MentorLake.Vulkan;

public class VkOpticalFlowExecuteFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowExecuteFlagBitsNVExtensions
{

	public static VkOpticalFlowExecuteFlagBitsNV Dereference(this VkOpticalFlowExecuteFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowExecuteFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowExecuteFlagBitsNVExterns
{
}

public struct VkOpticalFlowExecuteFlagBitsNV
{
}
