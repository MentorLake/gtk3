namespace MentorLake.Vulkan;

public class VkOpticalFlowSessionCreateFlagsNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowSessionCreateFlagsNVExtensions
{

	public static VkOpticalFlowSessionCreateFlagsNV Dereference(this VkOpticalFlowSessionCreateFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowSessionCreateFlagsNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowSessionCreateFlagsNVExterns
{
}

public struct VkOpticalFlowSessionCreateFlagsNV
{
}
