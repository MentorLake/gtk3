namespace MentorLake.Vulkan;


public class VkPerformanceCounterUnitKHRHandle : BaseSafeHandle
{
}


public static class VkPerformanceCounterUnitKHRExtensions
{

	public static VkPerformanceCounterUnitKHR Dereference(this VkPerformanceCounterUnitKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceCounterUnitKHR>(x.DangerousGetHandle());
}
internal class VkPerformanceCounterUnitKHRExterns
{
}


public struct VkPerformanceCounterUnitKHR
{
}
