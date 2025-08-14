namespace MentorLake.Vulkan;


public class VkPipelineExecutableStatisticFormatKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineExecutableStatisticFormatKHRExtensions
{

	public static VkPipelineExecutableStatisticFormatKHR Dereference(this VkPipelineExecutableStatisticFormatKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineExecutableStatisticFormatKHR>(x.DangerousGetHandle());
}
internal class VkPipelineExecutableStatisticFormatKHRExterns
{
}


public struct VkPipelineExecutableStatisticFormatKHR
{
}
