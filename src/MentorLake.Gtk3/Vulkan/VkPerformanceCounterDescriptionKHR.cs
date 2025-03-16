namespace MentorLake.Vulkan;

public class VkPerformanceCounterDescriptionKHRHandle : BaseSafeHandle
{
}


public static class VkPerformanceCounterDescriptionKHRExtensions
{

	public static VkPerformanceCounterDescriptionKHR Dereference(this VkPerformanceCounterDescriptionKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceCounterDescriptionKHR>(x.DangerousGetHandle());
}
internal class VkPerformanceCounterDescriptionKHRExterns
{
}

public struct VkPerformanceCounterDescriptionKHR
{
}
