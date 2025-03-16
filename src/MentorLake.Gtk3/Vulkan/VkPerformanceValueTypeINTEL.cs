namespace MentorLake.Vulkan;

public class VkPerformanceValueTypeINTELHandle : BaseSafeHandle
{
}


public static class VkPerformanceValueTypeINTELExtensions
{

	public static VkPerformanceValueTypeINTEL Dereference(this VkPerformanceValueTypeINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceValueTypeINTEL>(x.DangerousGetHandle());
}
internal class VkPerformanceValueTypeINTELExterns
{
}

public struct VkPerformanceValueTypeINTEL
{
}
