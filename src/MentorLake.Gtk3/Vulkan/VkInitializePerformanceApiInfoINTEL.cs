namespace MentorLake.Vulkan;


public class VkInitializePerformanceApiInfoINTELHandle : BaseSafeHandle
{
}


public static class VkInitializePerformanceApiInfoINTELExtensions
{

	public static VkInitializePerformanceApiInfoINTEL Dereference(this VkInitializePerformanceApiInfoINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkInitializePerformanceApiInfoINTEL>(x.DangerousGetHandle());
}
internal class VkInitializePerformanceApiInfoINTELExterns
{
}


public struct VkInitializePerformanceApiInfoINTEL
{
}
