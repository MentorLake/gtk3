namespace MentorLake.Vulkan;

public class VkQueryPoolPerformanceCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkQueryPoolPerformanceCreateInfoKHRExtensions
{

	public static VkQueryPoolPerformanceCreateInfoKHR Dereference(this VkQueryPoolPerformanceCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryPoolPerformanceCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkQueryPoolPerformanceCreateInfoKHRExterns
{
}

public struct VkQueryPoolPerformanceCreateInfoKHR
{
}
