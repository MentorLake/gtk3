namespace MentorLake.Vulkan;


public class VkPerformanceValueINTELHandle : BaseSafeHandle
{
}


public static class VkPerformanceValueINTELExtensions
{

	public static VkPerformanceValueINTEL Dereference(this VkPerformanceValueINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceValueINTEL>(x.DangerousGetHandle());
}
internal class VkPerformanceValueINTELExterns
{
}


public struct VkPerformanceValueINTEL
{
}
