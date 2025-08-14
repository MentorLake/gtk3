namespace MentorLake.Vulkan;


public class VkPipelineExecutableStatisticValueKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineExecutableStatisticValueKHRExtensions
{

	public static VkPipelineExecutableStatisticValueKHR Dereference(this VkPipelineExecutableStatisticValueKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineExecutableStatisticValueKHR>(x.DangerousGetHandle());
}
internal class VkPipelineExecutableStatisticValueKHRExterns
{
}


public struct VkPipelineExecutableStatisticValueKHR
{
}
