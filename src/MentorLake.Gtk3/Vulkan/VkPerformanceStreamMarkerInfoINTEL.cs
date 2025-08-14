namespace MentorLake.Vulkan;


public class VkPerformanceStreamMarkerInfoINTELHandle : BaseSafeHandle
{
}


public static class VkPerformanceStreamMarkerInfoINTELExtensions
{

	public static VkPerformanceStreamMarkerInfoINTEL Dereference(this VkPerformanceStreamMarkerInfoINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceStreamMarkerInfoINTEL>(x.DangerousGetHandle());
}
internal class VkPerformanceStreamMarkerInfoINTELExterns
{
}


public struct VkPerformanceStreamMarkerInfoINTEL
{
}
