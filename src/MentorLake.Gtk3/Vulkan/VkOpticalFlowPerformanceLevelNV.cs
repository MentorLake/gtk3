namespace MentorLake.Vulkan;

public class VkOpticalFlowPerformanceLevelNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowPerformanceLevelNVExtensions
{

	public static VkOpticalFlowPerformanceLevelNV Dereference(this VkOpticalFlowPerformanceLevelNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowPerformanceLevelNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowPerformanceLevelNVExterns
{
}

public struct VkOpticalFlowPerformanceLevelNV
{
}
