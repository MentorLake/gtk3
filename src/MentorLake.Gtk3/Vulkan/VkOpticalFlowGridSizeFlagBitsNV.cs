namespace MentorLake.Vulkan;

public class VkOpticalFlowGridSizeFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowGridSizeFlagBitsNVExtensions
{

	public static VkOpticalFlowGridSizeFlagBitsNV Dereference(this VkOpticalFlowGridSizeFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowGridSizeFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowGridSizeFlagBitsNVExterns
{
}

public struct VkOpticalFlowGridSizeFlagBitsNV
{
}
