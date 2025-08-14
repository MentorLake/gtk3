namespace MentorLake.Vulkan;


public class VkQueryPoolSamplingModeINTELHandle : BaseSafeHandle
{
}


public static class VkQueryPoolSamplingModeINTELExtensions
{

	public static VkQueryPoolSamplingModeINTEL Dereference(this VkQueryPoolSamplingModeINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryPoolSamplingModeINTEL>(x.DangerousGetHandle());
}
internal class VkQueryPoolSamplingModeINTELExterns
{
}


public struct VkQueryPoolSamplingModeINTEL
{
}
