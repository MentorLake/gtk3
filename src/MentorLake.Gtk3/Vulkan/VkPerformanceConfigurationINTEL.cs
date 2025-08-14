namespace MentorLake.Vulkan;


public class VkPerformanceConfigurationINTELHandle : BaseSafeHandle
{
}


public static class VkPerformanceConfigurationINTELExtensions
{

	public static VkPerformanceConfigurationINTEL Dereference(this VkPerformanceConfigurationINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceConfigurationINTEL>(x.DangerousGetHandle());
}
internal class VkPerformanceConfigurationINTELExterns
{
}


public struct VkPerformanceConfigurationINTEL
{
}
