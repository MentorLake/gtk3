namespace MentorLake.Vulkan;

public class VkPerformanceParameterTypeINTELHandle : BaseSafeHandle
{
}


public static class VkPerformanceParameterTypeINTELExtensions
{

	public static VkPerformanceParameterTypeINTEL Dereference(this VkPerformanceParameterTypeINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceParameterTypeINTEL>(x.DangerousGetHandle());
}
internal class VkPerformanceParameterTypeINTELExterns
{
}

public struct VkPerformanceParameterTypeINTEL
{
}
