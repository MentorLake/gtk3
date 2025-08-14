namespace MentorLake.Vulkan;


public class VkLatencySubmissionPresentIdNVHandle : BaseSafeHandle
{
}


public static class VkLatencySubmissionPresentIdNVExtensions
{

	public static VkLatencySubmissionPresentIdNV Dereference(this VkLatencySubmissionPresentIdNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLatencySubmissionPresentIdNV>(x.DangerousGetHandle());
}
internal class VkLatencySubmissionPresentIdNVExterns
{
}


public struct VkLatencySubmissionPresentIdNV
{
}
