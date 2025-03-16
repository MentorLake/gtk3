namespace MentorLake.Vulkan;

public class VkQueryPoolPerformanceQueryCreateInfoINTELHandle : BaseSafeHandle
{
}


public static class VkQueryPoolPerformanceQueryCreateInfoINTELExtensions
{

	public static VkQueryPoolPerformanceQueryCreateInfoINTEL Dereference(this VkQueryPoolPerformanceQueryCreateInfoINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryPoolPerformanceQueryCreateInfoINTEL>(x.DangerousGetHandle());
}
internal class VkQueryPoolPerformanceQueryCreateInfoINTELExterns
{
}

public struct VkQueryPoolPerformanceQueryCreateInfoINTEL
{
}
