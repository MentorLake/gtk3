namespace MentorLake.Vulkan;

public class VkOpticalFlowUsageFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowUsageFlagBitsNVExtensions
{

	public static VkOpticalFlowUsageFlagBitsNV Dereference(this VkOpticalFlowUsageFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowUsageFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowUsageFlagBitsNVExterns
{
}

public struct VkOpticalFlowUsageFlagBitsNV
{
}
