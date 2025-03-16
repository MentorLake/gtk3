namespace MentorLake.Vulkan;

public class VkPerformanceCounterDescriptionFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkPerformanceCounterDescriptionFlagsKHRExtensions
{

	public static VkPerformanceCounterDescriptionFlagsKHR Dereference(this VkPerformanceCounterDescriptionFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceCounterDescriptionFlagsKHR>(x.DangerousGetHandle());
}
internal class VkPerformanceCounterDescriptionFlagsKHRExterns
{
}

public struct VkPerformanceCounterDescriptionFlagsKHR
{
}
