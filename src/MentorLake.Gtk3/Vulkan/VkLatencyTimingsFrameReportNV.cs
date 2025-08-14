namespace MentorLake.Vulkan;


public class VkLatencyTimingsFrameReportNVHandle : BaseSafeHandle
{
}


public static class VkLatencyTimingsFrameReportNVExtensions
{

	public static VkLatencyTimingsFrameReportNV Dereference(this VkLatencyTimingsFrameReportNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLatencyTimingsFrameReportNV>(x.DangerousGetHandle());
}
internal class VkLatencyTimingsFrameReportNVExterns
{
}


public struct VkLatencyTimingsFrameReportNV
{
}
