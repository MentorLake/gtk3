namespace MentorLake.Vulkan;


public class VkPerformanceMarkerInfoINTELHandle : BaseSafeHandle
{
}


public static class VkPerformanceMarkerInfoINTELExtensions
{

	public static VkPerformanceMarkerInfoINTEL Dereference(this VkPerformanceMarkerInfoINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceMarkerInfoINTEL>(x.DangerousGetHandle());
}
internal class VkPerformanceMarkerInfoINTELExterns
{
}


public struct VkPerformanceMarkerInfoINTEL
{
}
