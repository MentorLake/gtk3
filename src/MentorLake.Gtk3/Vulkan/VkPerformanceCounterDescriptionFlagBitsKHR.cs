namespace MentorLake.Vulkan;

public class VkPerformanceCounterDescriptionFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkPerformanceCounterDescriptionFlagBitsKHRExtensions
{

	public static VkPerformanceCounterDescriptionFlagBitsKHR Dereference(this VkPerformanceCounterDescriptionFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceCounterDescriptionFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkPerformanceCounterDescriptionFlagBitsKHRExterns
{
}

public struct VkPerformanceCounterDescriptionFlagBitsKHR
{
}
