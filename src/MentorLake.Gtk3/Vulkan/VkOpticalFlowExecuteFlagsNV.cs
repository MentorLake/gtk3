namespace MentorLake.Vulkan;

public class VkOpticalFlowExecuteFlagsNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowExecuteFlagsNVExtensions
{

	public static VkOpticalFlowExecuteFlagsNV Dereference(this VkOpticalFlowExecuteFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowExecuteFlagsNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowExecuteFlagsNVExterns
{
}

public struct VkOpticalFlowExecuteFlagsNV
{
}
