namespace MentorLake.Vulkan;

public class VkPerformanceCounterResultKHRHandle : BaseSafeHandle
{
}


public static class VkPerformanceCounterResultKHRExtensions
{

	public static VkPerformanceCounterResultKHR Dereference(this VkPerformanceCounterResultKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceCounterResultKHR>(x.DangerousGetHandle());
}
internal class VkPerformanceCounterResultKHRExterns
{
}

public struct VkPerformanceCounterResultKHR
{
}
