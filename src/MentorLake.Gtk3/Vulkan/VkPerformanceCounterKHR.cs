namespace MentorLake.Vulkan;


public class VkPerformanceCounterKHRHandle : BaseSafeHandle
{
}


public static class VkPerformanceCounterKHRExtensions
{

	public static VkPerformanceCounterKHR Dereference(this VkPerformanceCounterKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceCounterKHR>(x.DangerousGetHandle());
}
internal class VkPerformanceCounterKHRExterns
{
}


public struct VkPerformanceCounterKHR
{
}
