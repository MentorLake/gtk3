namespace MentorLake.Vulkan;

public class VkOpticalFlowUsageFlagsNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowUsageFlagsNVExtensions
{

	public static VkOpticalFlowUsageFlagsNV Dereference(this VkOpticalFlowUsageFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowUsageFlagsNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowUsageFlagsNVExterns
{
}

public struct VkOpticalFlowUsageFlagsNV
{
}
