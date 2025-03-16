namespace MentorLake.Vulkan;

public class VkPerformanceConfigurationAcquireInfoINTELHandle : BaseSafeHandle
{
}


public static class VkPerformanceConfigurationAcquireInfoINTELExtensions
{

	public static VkPerformanceConfigurationAcquireInfoINTEL Dereference(this VkPerformanceConfigurationAcquireInfoINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPerformanceConfigurationAcquireInfoINTEL>(x.DangerousGetHandle());
}
internal class VkPerformanceConfigurationAcquireInfoINTELExterns
{
}

public struct VkPerformanceConfigurationAcquireInfoINTEL
{
}
