namespace MentorLake.Vulkan;

public class VkPerformanceCounterScopeKHRHandle : BaseSafeHandle
{
}


public static class VkPerformanceCounterScopeKHRExtensions
{

	public static VkPerformanceCounterScopeKHR Dereference(this VkPerformanceCounterScopeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceCounterScopeKHR>(x.DangerousGetHandle());
}
internal class VkPerformanceCounterScopeKHRExterns
{
}

public struct VkPerformanceCounterScopeKHR
{
}
