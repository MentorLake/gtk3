namespace MentorLake.Vulkan;

public class VkPerformanceOverrideTypeINTELHandle : BaseSafeHandle
{
}


public static class VkPerformanceOverrideTypeINTELExtensions
{

	public static VkPerformanceOverrideTypeINTEL Dereference(this VkPerformanceOverrideTypeINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceOverrideTypeINTEL>(x.DangerousGetHandle());
}
internal class VkPerformanceOverrideTypeINTELExterns
{
}

public struct VkPerformanceOverrideTypeINTEL
{
}
