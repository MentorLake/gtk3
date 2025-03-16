namespace MentorLake.Vulkan;

public class VkPerformanceConfigurationTypeINTELHandle : BaseSafeHandle
{
}


public static class VkPerformanceConfigurationTypeINTELExtensions
{

	public static VkPerformanceConfigurationTypeINTEL Dereference(this VkPerformanceConfigurationTypeINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceConfigurationTypeINTEL>(x.DangerousGetHandle());
}
internal class VkPerformanceConfigurationTypeINTELExterns
{
}

public struct VkPerformanceConfigurationTypeINTEL
{
}
