namespace MentorLake.Vulkan;

public class VkOpticalFlowGridSizeFlagsNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowGridSizeFlagsNVExtensions
{

	public static VkOpticalFlowGridSizeFlagsNV Dereference(this VkOpticalFlowGridSizeFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowGridSizeFlagsNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowGridSizeFlagsNVExterns
{
}

public struct VkOpticalFlowGridSizeFlagsNV
{
}
