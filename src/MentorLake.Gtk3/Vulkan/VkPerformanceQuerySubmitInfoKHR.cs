namespace MentorLake.Vulkan;


public class VkPerformanceQuerySubmitInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPerformanceQuerySubmitInfoKHRExtensions
{

	public static VkPerformanceQuerySubmitInfoKHR Dereference(this VkPerformanceQuerySubmitInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceQuerySubmitInfoKHR>(x.DangerousGetHandle());
}
internal class VkPerformanceQuerySubmitInfoKHRExterns
{
}


public struct VkPerformanceQuerySubmitInfoKHR
{
}
