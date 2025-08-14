namespace MentorLake.Vulkan;


public class VkPerformanceCounterStorageKHRHandle : BaseSafeHandle
{
}


public static class VkPerformanceCounterStorageKHRExtensions
{

	public static VkPerformanceCounterStorageKHR Dereference(this VkPerformanceCounterStorageKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceCounterStorageKHR>(x.DangerousGetHandle());
}
internal class VkPerformanceCounterStorageKHRExterns
{
}


public struct VkPerformanceCounterStorageKHR
{
}
