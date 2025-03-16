namespace MentorLake.Vulkan;

public class VkPerformanceOverrideInfoINTELHandle : BaseSafeHandle
{
}


public static class VkPerformanceOverrideInfoINTELExtensions
{

	public static VkPerformanceOverrideInfoINTEL Dereference(this VkPerformanceOverrideInfoINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceOverrideInfoINTEL>(x.DangerousGetHandle());
}
internal class VkPerformanceOverrideInfoINTELExterns
{
}

public struct VkPerformanceOverrideInfoINTEL
{
}
