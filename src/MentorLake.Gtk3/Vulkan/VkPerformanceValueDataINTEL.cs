namespace MentorLake.Vulkan;


public class VkPerformanceValueDataINTELHandle : BaseSafeHandle
{
}


public static class VkPerformanceValueDataINTELExtensions
{

	public static VkPerformanceValueDataINTEL Dereference(this VkPerformanceValueDataINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceValueDataINTEL>(x.DangerousGetHandle());
}
internal class VkPerformanceValueDataINTELExterns
{
}


public struct VkPerformanceValueDataINTEL
{
}
