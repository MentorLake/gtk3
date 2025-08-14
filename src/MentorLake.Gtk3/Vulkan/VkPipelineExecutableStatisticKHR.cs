namespace MentorLake.Vulkan;


public class VkPipelineExecutableStatisticKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineExecutableStatisticKHRExtensions
{

	public static VkPipelineExecutableStatisticKHR Dereference(this VkPipelineExecutableStatisticKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineExecutableStatisticKHR>(x.DangerousGetHandle());
}
internal class VkPipelineExecutableStatisticKHRExterns
{
}


public struct VkPipelineExecutableStatisticKHR
{
}
